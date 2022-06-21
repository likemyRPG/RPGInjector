using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WeAreDevs_API;

namespace RPGInjector
{
    public partial class RPGInjector : Form
    {
        ExploitAPI module = new ExploitAPI();
        Point lastPoint;
        public RPGInjector()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RPGInjector_Load(object sender, EventArgs e)
        {
            lstBScripts.Items.Clear();
            Functions.PopulateListBox(lstBScripts, "./Scripts", "*.txt");
            Functions.PopulateListBox(lstBScripts, "./Scripts", "*.lua");
        }

        private void buttonInject_Click(object sender, EventArgs e)
        {
            module.LegacyLaunchExploit();
            if (module.isAPIAttached())
            {
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Successfully Injected!";
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Injection Failed!";
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            module.SendLuaScript(FCTBScript.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FCTBScript.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Title = "Open";
                FCTBScript.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                using (Stream s = File.Open(ofd.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(FCTBScript.Text);
                }
            }
        }

        private void btnScriptHub_Click(object sender, EventArgs e)
        {
            ScriptHub hub = new ScriptHub();
            hub.Show();
        }

        private void lstBScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FCTBScript.Text = File.ReadAllText($"./Scripts/{lstBScripts.SelectedItem}");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstBScripts.Items.Clear();
            Functions.PopulateListBox(lstBScripts, "./Scripts", "*.txt");
            Functions.PopulateListBox(lstBScripts, "./Scripts", "*.lua");
        }
    }
}
