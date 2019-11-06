using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wexp
{
    public partial class frmWinSATInfo : Form
    {
        public frmWinSATInfo()
        {
            InitializeComponent();
        }
        private string version = String.Empty;
        private string path = String.Empty;
        private string cmd = String.Empty;
        private string osname = String.Empty;
        private string osbuild = String.Empty;
        // ACCESSORS
        public string Version
        {
            get
            {
                return version;
            } set
            {
                version = value;
            }
        }
        public string Path
        {
            get
            {
                return path;
            } set
            {
                path = value;
            }
        }
        public string Cmd
        {
            get
            {
                return cmd;
            }
            set
            {
                cmd = value;
            }
        }
        public string OsName
        {
            get
            {
                return osname;
            } set
            {
                osname = value;
            }
        }
        public string OsBuild
        {
            get
            {
                return osbuild;
            }
            set
            {
                osbuild = value;
            }
        }
        // FORM LOAD EVENT HANDLER
        private void Form2_Load(object sender, EventArgs e)
        {
            lblWinSATCmdLine.Text += cmd;
            lblWinSATModulePath.Text += path;
            lblWinSatVersion.Text += version;
            lblOSName.Text += osname;
            lblOsBuild.Text += osbuild;
        }
        // CLOSE BUTTON HANDLER
        private void btnfrmWinSATInfoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
