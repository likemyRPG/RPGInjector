using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace RPGInjector
{
    public partial class ScriptHub : Form
    {
        ExploitAPI module = new ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMadCityScript_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string script = wb.DownloadString("https://raw.githubusercontent.com/Deni210/madcity/main/Ruby%20Hub%20v1.3");
            module.SendLuaScript(script);
        }
    }
}
