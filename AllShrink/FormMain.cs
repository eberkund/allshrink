﻿using ImageMagick;
using System;
using System.IO;
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
            DirectoryInfo di = new DirectoryInfo("C:/test");
            FileInfo[] fi = di.GetFiles();

            for (int x = 0; x < fi.Length; x++)
            {
                ListViewItem item = new ListViewItem(new string[] { fi[x].FullName, fi[x].Length / 1024 + " KB", "" });
                listViewMain.Items.Add(item);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listViewMain.Items.Clear();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            long beforeLength;
            long afterLength;
            float savings;
            string outputName;
            ImageOptimizer optimizer;
            MagickImage mi;
            FileInfo fi;

            foreach (ListViewItem file in listViewMain.Items)
            {
                // Get the size of the file before shrinking
                fi = new FileInfo(file.Text);
                beforeLength = fi.Length;

                // Resize and optimize the image
                outputName = file.Text.Insert(file.Text.LastIndexOf('.'), "_resized");
                mi = new MagickImage(file.Text);
                mi.Resize(200, 200);
                mi.Interlace = Interlace.Jpeg;
                mi.Strip();
                mi.Write(outputName);
                optimizer = new ImageOptimizer();
                optimizer.LosslessCompress(outputName);


                // Get the size of the file after shrinking;
                fi = new FileInfo(outputName);
                afterLength = fi.Length;

                // Calculate and display the savings
                savings = (1 - (float)afterLength / beforeLength) * 100;
                file.SubItems[2].Text = savings.ToString("p1");
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

            foreach (string s in files)
            {
                if (Directory.Exists(s))
                {
                    // If it is a directory, add each file it contains
                    foreach (string sub in Directory.GetFiles(s))
                    {
                        FileInfo fi = new FileInfo(sub);
                        ListViewItem item = new ListViewItem(new string[] { fi.FullName, fi.Length / 1024 + " KB", "" });
                        listViewMain.Items.Add(item);
                    }
                }
                else
                {
                    FileInfo fi = new FileInfo(s);
                    ListViewItem item = new ListViewItem(new string[] { fi.FullName, fi.Length / 1024 + " KB", "" });
                    listViewMain.Items.Add(item);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().Show(); 
        }
    }
}