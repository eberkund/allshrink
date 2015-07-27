using ImageMagick;
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
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            addCurrentDirectoryFiles(open.FileNames);
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

        void addCurrentDirectoryFiles(string path) 
        {
            // Is the path a directory?
            if (Directory.Exists(path))
            {
                foreach (string sub in Directory.GetFileSystemEntries(path))
                {
                    addCurrentDirectoryFiles(sub);
                }
            }
            // Otherwise it is a file
            else
            {
                FileInfo fi = new FileInfo(path);
                ListViewItem lvi = new ListViewItem(new string[] { fi.FullName, fi.Length / 1024 + " KB", "" });
                listViewMain.Items.Add(lvi);
            }
        }

        void addCurrentDirectoryFiles(string[] paths)
        {
            foreach (string path in paths)
            {
                addCurrentDirectoryFiles(path);
            }
        }

        void listViewMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string path in files)
            {
                Console.WriteLine(path);
                addCurrentDirectoryFiles(path);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().Show(); 
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSettings().Show();
        }
    }
}