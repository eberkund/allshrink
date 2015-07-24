using ImageMagick;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //string[] files = System.IO.Directory.GetFiles("C:/test");
            DirectoryInfo di = new DirectoryInfo("C:/test");
            FileInfo[] fi = di.GetFiles();

           
            for (int x = 0; x < fi.Length; x++)
            {
                ListViewItem item = new ListViewItem(new string[] { fi[x].Name, fi[x].Length / 1024 + " KB", "" });
                listViewMain.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewMain.Items.Clear();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(listViewMain.Items[0].ToString());
            //MagickImage img = new MagickImage();

            foreach (ListViewItem file in listViewMain.Items)
            {
                Console.WriteLine(file.ToString());
                file.SubItems[2].Text = "12%";
            }
           
            
        }

        void listViewMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        void listViewMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                ListViewItem item = new ListViewItem(new string[] { fi.Name, fi.Length / 1024 + " KB", "" });
                listViewMain.Items.Add(item);
            }
        }
    }
}
