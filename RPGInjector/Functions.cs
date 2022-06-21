using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGInjector
{
    internal class Functions
    {
        public static void PopulateListBox(ListBox lsb, string folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(folder);
            FileInfo[] files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in files)
            {
                lsb.Items.Add(file.Name);
            }
        }
    }
}
