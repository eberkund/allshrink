using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllShrink
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string[] files = System.IO.Directory.GetFiles("C:/test");
            DirectoryInfo di = new DirectoryInfo("C:/test");
            FileInfo[] fi = di.GetFiles();

            // FileInfo[] files = System.IO.DirectoryInfo("C:/test").getFiles();

           
            for (int x = 0; x < fi.Length; x++)
            {
                ListViewItem item = new ListViewItem(new string[] { fi[x].Name, fi[x].Length / 1024 + " KB", "12%" });
                listViewMain.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewMain.Items.Clear();
        }
    }
}
