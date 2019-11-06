using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using hcwgenericclasses;
using editform;


namespace wexp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // BUILD INFO: TARGET = DEBUG, ANY CPU
        // VARIABLES
        #region

        // LOCAL VARIABLES & CLASSES
        //

        StringBuilder sb = new StringBuilder();
        List<xitem> XI = new List<xitem>();             // xml items list
        List<string> WsFiles = new List<string>();      // list of assessment files found in DatStore
        List<string> LockedFiles = new List<string>();  // unused but needed by ProcessDirectories Method
        List<string> AssessmentFileNames = new List<string>();
        LifoStack HeaderStack = new LifoStack();
        private BackgroundWorker bw = new BackgroundWorker();
        string CmdLine = "formal";               // Command Line Options for WinSAT, run all tests, no output window
        const int PAD = 6;
        bool CancelProcessDir = false;                  // used by ProcessDirectories Method
        bool EnabletscbSelectedIndexChangedHandler = true;
        private Int32 ProcessID;
        private IntPtr ProcessHandle;
        private Color SavedBackColor;
        private Color SavedTextColor;

        // WINSAT FILE LOCATIONS IN WINDOWS 10 64 BIT INSTALL (REMEMBER FOLDER REDIRECTION)
        // MAY HAVE TO MODIFIY FOR 32 BIT INSTALL OLDER OS VERSIONS

        private static string DataStorePath = "c:\\Windows\\Performance\\WinSAT\\DataStore";
        private static string WinSATFileName = globals.ExePathFor64BitApplication;                                  // BUILD OPTION = AnyCPU, should work in 32bit app under 64 bit OS OS of redirection is suspended

        private static bool is64BitProcess = (IntPtr.Size == 8);                                    // true if running as a 64bit process, unused
        private static bool is64BitOperatingSystem = is64BitProcess || InternalCheckIsWow64();      // true if current Windows OS is 64bit, used for redirection handling  

        // Detect 32 or 64 bit OS
        // Credits:
        // MICROSOFT: Raymond Chen
        // http://blogs.msdn.com/oldnewthing/archive/2005/02/01/364563.aspx

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
             [In] IntPtr hProcess,
             [Out] out bool wow64Process
         );
        private static bool InternalCheckIsWow64()
        {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6)
            {
                using (Process p = Process.GetCurrentProcess())
                {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal))
                    {
                        return false;
                    }
                    return retVal;
                }
            }
            else
            {
                return false;
            }
        }

        // HANDLE FOLDER REDIRECTION IN WINDOWS 64
        // CREDITS:
        // http://tcamilli.blogspot.com/2005/07/disabling-wow64-file-system.html
        // https://stackoverflow.com/questions/29149512/process-start-for-system32-applications-the-system-cannot-find-the-file-specif
        /// <summary>
        /// USE TO ENABLE AND DISABLE FILE REDIRECTION IN WIN 64
        /// </summary>
        public class Wow64Interop
        {
            [DllImport("Kernel32.Dll", EntryPoint = "Wow64EnableWow64FsRedirection")]
            public static extern bool EnableWow64FSRedirection(bool enable);
        }
        // HCWGENERICCLASSES.DLL
        //

        DragDropTools DDT = new DragDropTools();
        ExceptionHandlerTools EHT = new ExceptionHandlerTools();
        DialogTools DT = new DialogTools();
        FileTools FT = new FileTools();
        AboutBoxTools ABT = new AboutBoxTools();

        #endregion

        // FORM LOAD HANDLER
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataFileList();
            PopulateAssessmentFileNames();
            if (AssessmentFileNames.Count > 0)
            {
                ParseXml(AssessmentFileNames[AssessmentFileNames.Count - 1]);
            }

            //  FINISH BACKGROUND WORKER INITIALIZATION

            bw.DoWork += new DoWorkEventHandler(bwDoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwCompleted);
            SavedBackColor = this.lblSubScoreDisk.BackColor;
            SavedTextColor = this.lblSubScoreDisk.ForeColor;

        }
        // CLOSE BUTTON HANDLER
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // OPEN MENU ITEM
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = String.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = filename;
            ofd.Title = "Open WinSAT Assessment Source File";
            ofd.Filter = "XMLFiles (*.xml,*.XML)|*.xml;*.XML";
            DialogResult Dr = ofd.ShowDialog(this);
            if (Dr != DialogResult.OK)
            {
                return; // trap cancel
            }
            filename = ofd.FileName;
            GetXmlFromFile(filename);
            ParseXml(filename);
            


        }
        // GETXMLFROM FILE()
        // Fills in itemlist "XI" from specified file
        private void GetXmlFromFile(string filename)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create(filename, settings);
            XI.Clear();
            int count = 0;
            int x = 0;
            bool AddToXi = false;

            while (reader.Read())
            {
                xitem dataitem = new xitem();
                AddToXi = false;
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        dataitem.name = reader.Name.ToString();
                        if (!HeaderStack.IsEmpty())
                        {
                            dataitem.header = HeaderStack.GetLastItem();    // current header
                            HeaderStack.Push(dataitem.name);                // header for next subnode is this item's name
                        }
                        else
                        {
                            dataitem.header = "";
                            HeaderStack.Push(dataitem.name);                // header for next subnode is this item's name
                        }

                        dataitem.data = reader.Value;                       // prior code data="";
                        AddToXi = true;
                        break;
                    case XmlNodeType.Text:
                        XI[XI.Count - 1].data = reader.Value.ToString();
                        break;
                    case XmlNodeType.CDATA:
                        XI[XI.Count - 1].data = reader.Value.ToString();
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        dataitem.name = reader.Name;
                        dataitem.data = reader.Value;
                        dataitem.header = "PROCESSING INSTRUCTION";
                        AddToXi = true;
                        break;
                    case XmlNodeType.Comment:
                        dataitem.name = reader.Name;
                        dataitem.data = reader.Value;
                        dataitem.header = "COMMENT";
                        AddToXi = true;
                        break;
                    case XmlNodeType.XmlDeclaration:
                        dataitem.header = "XML DECLARATION";
                        dataitem.name = reader.Name;
                        dataitem.data = reader.Value;
                        AddToXi = true;

                        //sb.Append("<?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        dataitem.name = "<!DOCTYPE " + reader.Name + " " + reader.Value;
                        dataitem.header = "";
                        dataitem.data = reader.Value.ToString();
                        AddToXi = true;
                        break;
                    case XmlNodeType.EntityReference:
                        dataitem.name = "ENTITY REFERENCE";
                        dataitem.data = reader.Name.ToString();
                        dataitem.header = "";
                        AddToXi = true;
                        break;
                    case XmlNodeType.EndElement:
                        HeaderStack.Pop();
                        break;
                }
                if (reader.HasAttributes)
                {
                    for (x = 0; x < reader.AttributeCount; x++)
                    {
                        reader.MoveToAttribute(x);
                        xattribute xa = new xattribute();
                        xa.aname = reader.Name;
                        xa.avalue = reader.Value;
                        dataitem.attributes.Add(xa);
                    }
                }
                if (AddToXi)
                {
                    XI.Add(dataitem);
                    count++;
                }

            }
        }
        // ITEMCONTAINSDATA
        // Returns true if XI[itemnumber] .data field is not blank
        private bool ItemContainsData(int itemnumber)
        {
            if (itemnumber < 0 || itemnumber > XI.Count - 1)
            {
                return false;
            }
            if (XI[itemnumber].data.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // FORMAT DECODED XML DATA
        private string FormatXmlForDisplay()
        {

            sb.Clear();
            sb.Append("File Name: " + tscbAssessmentFiles.SelectedItem.ToString() + "\r\n\n");
            int itemcount = 1;
            int attributecount = 1;
            foreach (xitem i in XI)
            {

                sb.Append("Item     : " + itemcount.ToString() + "\r\n");
                sb.Append("Header   : " + i.header.PadRight(PAD) + "\r\n");
                sb.Append("Name     : " + i.name.PadRight(PAD) + "\r\n");
                attributecount = 1;
                foreach (xattribute s in i.attributes)
                {
                    sb.Append("Attr (" + attributecount.ToString() + ") : " + s.aname.PadRight(PAD) + " " + s.avalue.PadRight(PAD) + "\r\n");
                    attributecount++;
                }
                sb.Append("Data     : " + i.data.PadRight(PAD) + "\r\n\n");
                itemcount++;
            }
            return sb.ToString();

        }
        // VIEW PARSED XML IN EDIT WINDOW
        private void parsedXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor ed = new editor();
            ed.AllowDiscAccess = false;
            ed.WindowTitle = "View Parsed Xml Source Code";
            ed.StartingFont = new Font("Courier New", 12.0f, FontStyle.Regular);
            ed.AllowRtf = false;
            ed.UseSaveFileDialogWhenClosing = false;
            ed.Document = FormatXmlForDisplay();
            ed.DisplayEditForm(this);
        }
        // GET ATTRIBUTE FROM XML NODE IN LIST
        private string GetAttributeValue(string header, string name, int number)
        {
            string result = "";
            int x = 0;
            for (x = 0; x < XI.Count; x++)
            {
                if (XI[x].header == header && XI[x].name == name)
                {
                    if (XI[x].attributes.Count >= number)
                    {
                        result = XI[x].attributes[number - 1].avalue;
                        break;
                    }

                }
            }
            return result;
        }
        // GET DATA VALUE FROM XML NODE IN LIST
        private string GetDataValue(string header, string name)
        {
            string result = "";
            int x = 0;
            for (x = 0; x < XI.Count; x++)
            {
                if (XI[x].header == header && XI[x].name == name)
                {
                    result = XI[x].data;
                }
            }
            return result;
        }
        // WINSAT PROGRAM INFO DISPLAY
        private void winSATInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWinSATInfo WSI = new frmWinSATInfo();
            WSI.Version = " " + GetDataValue("ProgramInfo", "Version");
            WSI.Path = " " + GetDataValue("ProgramInfo", "ModulePath");
            WSI.Cmd = " " + GetDataValue("ProgramInfo", "CmdLine");
            WSI.OsName = " " + GetDataValue("OSVersion", "OSName");
            WSI.OsBuild = " " + GetDataValue("OSVersion", "BuildLab");
            WSI.ShowDialog(this);
            WSI.Dispose();
        }
        // POPULATE WINSAT DATAFILE LIST FROM DIR
        private void PopulateDataFileList()
        {
            if (!Directory.Exists(DataStorePath))
            {
                DT.NotifyDialog(this, "WEXEP.EXE \r\n No benchmark files found. \r\n Click the RunBenchmark Button.", 4000);
                btnGetBenchMark.Select();
                return;
            }
            WsFiles.Clear();
            LockedFiles.Clear();
            WsFiles.Add(DataStorePath);
            FT.ProcessDirectories(ref WsFiles, ref LockedFiles, false, ref CancelProcessDir);

        }
        // POPULATE ASSESSMENT FILE LIST
        private void PopulateAssessmentFileNames()
        {
            AssessmentFileNames.Clear();
            foreach (string s in WsFiles)
            {
                if (s.Contains("Formal.Assessment"))
                {
                    AssessmentFileNames.Add(s);
                }
            }
            AssessmentFileNames.Sort();             // DEFAULT COMPARER IS ASCENDING ALPHA ORDER
            tscbAssessmentFiles.Items.Clear();
            foreach (string s in AssessmentFileNames)
            {
                tscbAssessmentFiles.Items.Add(s);
            }
            EnabletscbSelectedIndexChangedHandler = false;  // Prevent triggering of SelectIndesChangedHandler
            tscbAssessmentFiles.SelectedIndex = tscbAssessmentFiles.Items.Count - 1;    //ensure most recent file is also selected in list as default
            EnabletscbSelectedIndexChangedHandler = true;   // Renenable handler
           
        }
        // PARSE XML FILE INTO DATABASE AND FILL IN THE FORM
        private void ParseXml(string filename)
        {
            
            
            GetXmlFromFile(filename);
            string systemscore = GetDataValue("WinSPR", "SystemScore");
            lblLastUpdate.Text = GetAttributeValue("SystemEnvironment", "ExecDateTOD", 1);
            lblSubScoreDisk.Text = GetDataValue("WinSPR", "DiskScore");
            if (lblSubScoreDisk.Text == systemscore)
            {
                lblSubScoreDisk.BackColor = tbBaseScore.BackColor;
                lblSubScoreDisk.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lblSubScoreDisk.BackColor = SavedBackColor;
                lblSubScoreDisk.ForeColor = SavedTextColor;
            }
            lblSubScoreGaming.Text = GetDataValue("WinSPR", "GamingScore");
            if (lblSubScoreGaming.Text == systemscore)
            {
                lblSubScoreGaming.BackColor = tbBaseScore.BackColor;
                lblSubScoreGaming.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lblSubScoreGaming.BackColor = SavedBackColor;
                lblSubScoreGaming.ForeColor = SavedTextColor;
            }
            lblSubScoreGraphics.Text = GetDataValue("WinSPR", "GraphicsScore");
            if (lblSubScoreGraphics.Text == systemscore)
            {
                lblSubScoreGraphics.BackColor = tbBaseScore.BackColor;
                lblSubScoreGraphics.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lblSubScoreGraphics.BackColor = SavedBackColor;
                lblSubScoreGraphics.ForeColor = SavedTextColor;
            }
            lblSubScoreMemory.Text = GetDataValue("WinSPR", "MemoryScore");
            if (lblSubScoreMemory.Text == systemscore)
            {
                lblSubScoreMemory.BackColor = tbBaseScore.BackColor;
                lblSubScoreMemory.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lblSubScoreMemory.BackColor = SavedBackColor;
                lblSubScoreMemory.ForeColor = SavedTextColor;
            }
            lblSubScoreProcessor.Text = GetDataValue("WinSPR", "CpuScore");
            if (lblSubScoreProcessor.Text == systemscore)
            {
                lblSubScoreProcessor.BackColor = tbBaseScore.BackColor;
                lblSubScoreProcessor.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lblSubScoreProcessor.BackColor = SavedBackColor;
                lblSubScoreProcessor.ForeColor = SavedTextColor;
            }
            tbBaseScore.Text = GetDataValue("WinSPR", "SystemScore");
            this.btnGetBenchMark.Select();          // USE SELECT METHOD NOT FOCUS

        }
        // ABOUT BOX
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = wexp.Properties.Resources.iconfinder_browser_os_02_542545;
            MemoryStream ms = new MemoryStream();
            myBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            ABT.AboutBoxImage = ms;
            ABT.Progam = "Windows Experience Viewer";
            ABT.Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ABT.Build = wexp.Properties.Resources.BuildDate;
            ABT.Copyright = "HC Williams MD";
            ABT.Compiler = "Visual C# 2019";
            ABT.DisplayAboutBox();
            if (ms != null)
            {
                ms.Dispose();
            }
        }
        // RERUN BENCHMARK BUTTON HANDLER
        private void btnGetBenchMark_Click(object sender, EventArgs e)
        {
            
            bool result = true;
            Process n = new Process();
            Int32 ID = 0;
            // NOTE CORRECT PATH To handle Windows 64/32 redirection issues concerning correct directory for WinSAT.exe
            // If only using 64 bit Installs, can use Platform Target = x64 and path c:\Windows\System32\Winsat.exe
            
            n.StartInfo.FileName = WinSATFileName;
            Exception BadPath = new Exception("(Application) - The executable: " + n.StartInfo.FileName + " is not found.\r\nThis may reflect " +
                "a Windows on Windows 64 bit redirection if this application has been built as a 32 bit exe and run in a 64 bit Install. " +
                "Try rebuilding the source code with the Platform Target set to x64.\r\n" +
                "Alternatively, the file may not exist - check the directory in Explorer. If the file is there, it's a redirection issue.");
            /*if (!File.Exists(n.StartInfo.FileName))
            {
                EHT.GeneralExceptionHandler("WinSAT executable not found!", "GetBenchMark()", false, BadPath);
                n.Dispose();
                return;
            }*/
            n.StartInfo.Arguments = CmdLine;
            n.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            Exception StartEx = new Exception("(Application) - Unable to Start WinSAT.exe, althought path is valid.");
            try
            {
                if (is64BitOperatingSystem)
                {
                    Wow64Interop.EnableWow64FSRedirection(false);
                    n.Start();
                    ID = n.Id;
                    Wow64Interop.EnableWow64FSRedirection(true);
                }
                else
                {
                    n.Start();
                    ID = n.Id;
                    ProcessHandle = n.Handle;
                }
                
            }
            catch (Exception ex)
            {
                EHT.GeneralExceptionHandler("Error Rerunning Benchmark", n.StartInfo.FileName, false, ex);
                result = false;
            }
            finally
            {
                if (result)
                {
                    DT.NotifyDialog(this, "Starting Benchmark...");
                    lblLastUpdate.Text = "";
                    lblLastUpdate.Text = "Update is Running";
                    ProcessID = n.Id;
                    this.btnClose.Select();     // CORRECT FOCUS POSITION
                }
            }
            
            btnGetBenchMark.Enabled = false;
            bw.RunWorkerAsync();
            return;
        }
        // BACKGROUNDWORKER DOWORK()
        private void bwDoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            FSWatcher FSW = new FSWatcher(DataStorePath, "*.*");        
            FSW.Start();
            while (!FSW.Completed)
            {
                // WAIT FOR COMPLETION
            }
           
            
        }
        // BACKGROUNDWORKER COMPLETED
        private void bwCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            Thread.Sleep(3000);             // Insure file creation is completed and file is unlocked
            PopulateDataFileList();
            PopulateAssessmentFileNames();
            if (AssessmentFileNames.Count > 0)
            {
                ParseXml(AssessmentFileNames[AssessmentFileNames.Count - 1]);
            }
            btnGetBenchMark.Enabled = true;
        }
        // HISTORY LIST COMBOBOX SELECTION CHANGED
        private void tscbAssessmentFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!EnabletscbSelectedIndexChangedHandler)
            {
                return;
            }
            int x = tscbAssessmentFiles.SelectedIndex;
            string s = tscbAssessmentFiles.SelectedItem.ToString();
            ParseXml(s);
        }
        // RELOAD ASSESSMENT FILES MENU ITEM
        private void reloadAssessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT.NotifyDialog(this, "Rescanning DataStore Folder");
            PopulateDataFileList();
            PopulateAssessmentFileNames();
            if (AssessmentFileNames.Count > 0)
            {
                ParseXml(AssessmentFileNames[AssessmentFileNames.Count - 1]);
            }
        }
    }
}
