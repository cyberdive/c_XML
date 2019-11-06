using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;


namespace wexp
{
    /// <summary>
    /// WEXP.EXE - Open Source Tool for reading and generating WinSAT Benchmarks in Windows 10+
    /// Author: HC Williams MD
    /// Copyright: GNU Public License V3 (Freeware) 2019
    /// </summary>
    /// 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Must run in Program Class (where exception occurs
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.Run(new Form1());
        }
        // EMBEDDED DLL LOADER 
        // VERSION 2.0 01-15-2014 derives resourcename from args and application namespace
        // assumes resource is a DLL
        // this should load any missing DLL that is properly embedded
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string appname = Application.ProductName + "."; // gets Application Namespace
            string[] dll = args.Name.ToString().Split(','); // separates args.Name string
            string resourcename = appname + dll[0] + ".dll"; // element [0] contains the missing resource name
            Assembly MyAssembly = Assembly.GetExecutingAssembly();
            Stream AssemblyStream = MyAssembly.GetManifestResourceStream(resourcename);
            byte[] raw = new byte[AssemblyStream.Length];
            AssemblyStream.Read(raw, 0, raw.Length);
            return Assembly.Load(raw);

        }
    }

    /// <summary>
    /// XATTRIBUTE CLASS
    /// Stores an xml attribute
    /// </summary>
    [Serializable]
    public class xattribute
    {
        public string aname;
        public string avalue;
    }
    /// <summary>
    /// XITEM CLASS
    /// Stores xml node
    /// </summary>
    [Serializable]
    public class xitem
    {
        public string header;
        public string name;
        public List<xattribute> attributes = new List<xattribute>();
        public string data;

    }
    /// <summary>
    /// LIFOSTACK CLASS
    /// Implements a LIFO string stack
    /// </summary>
    public class LifoStack
    {
        private List<string> StackItems;

        // CONSTRUCTOR
        public LifoStack()
        {
            StackItems = new List<string>();
        }
        //DESTRUCTOR
        ~LifoStack()
        {
            StackItems = null;
        }
        // ADDS ELEMENT TO THE END OF THE STACK
        /// <summary>
        /// adds string to the stack (always returns true)
        /// </summary>
        /// <param name="s"></param>
        /// <returns>true</returns>
        public bool Push(string s)
        {
            StackItems.Add(s);
            return true;
        }
        /// <summary>
        /// Pop Last Element pushed on Stack
        /// </summary>
        /// <returns>Most recently pushed element and removes it from stack</returns>
        public string Pop()
        {
            string s = "";
            if (StackItems.Count() > 0)
            {
                s = StackItems[StackItems.Count - 1].ToString();
                StackItems.RemoveAt(StackItems.Count - 1);

            }
            return s;
        }
        /// <summary>
        /// returns # of items on stack
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return StackItems.Count();
        }
        /// <summary>
        /// RETURNS STATE OF STACK
        /// </summary>
        /// <returns> True if Stack is empty</returns>
        public bool IsEmpty()
        {
            if (StackItems.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Get Last Item Placed On Stack
        /// </summary>
        /// <returns>Most recently pushed item, blank if stack is empty (not null)</returns>
        public string GetLastItem()
        {
            string s = "";
            if (StackItems.Count > 0)
            {
                s = StackItems[StackItems.Count - 1];
            }
            return s;
        }
        

    }
    /// <summary>
    /// FSWATCHER - A Wrapper For FileSystemWatcher
    /// Call from a Backround Worker DoWork() instance with Path and File extension filter.
    /// Watches for File Create
    /// </summary>
    /// <param name="Path">Used for Folder to watch.</param>
    /// <param name="Filter">Used for file extension to watch for as in *.xml.</param>
    /// <returns>Nothing, DoWork uses() Completed property to terminate</returns>
    public class FSWatcher
    {
        // CONSTRUCTOR
        public FSWatcher(string Path,string Filter)
        {
            watcher = new FileSystemWatcher(Path,Filter);
            watcher.Created += watcher_changed;
            watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

        }
        // DESTRUCTOR
        ~FSWatcher()
            {
                watcher.Dispose();
            }
        //PUBLIC STATUS ACCESSOR
        public bool Completed
        {
            get
            {
                return completed;
            }
        }
        // PUBLIC START METHOD
        public void Start()
        {
            completed = false;
            watcher_start();
        }
        
        private FileSystemWatcher watcher;
        private void watcher_changed(object sendwer, FileSystemEventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            completed = true;
        }
        private void watcher_start()
        {
            watcher.EnableRaisingEvents = true;
        }
        private bool completed = false;
       

    }
    public class globals
    {
        // DIFFERENT APP PATHS DEPENDING ON REDRIECTION STATE

        public static string ExePathFor64BitApplication = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), @"system32\winsat.exe");
        public static string ExePathFor32BitApplicationRunningIn32BitOS = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), @"system32\winsat.exe");
        public static string ExePathFor32BitApplicationRunningIn64BitOS = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), @"Sysnative\winsat.exe");
    }
    
    
}
