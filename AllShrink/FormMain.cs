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
            Properties.Settings.Default.Reset();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
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

            // Get settings
            int maxHeight = Properties.Settings.Default.maxHeight;
            int maxWidth = Properties.Settings.Default.maxWidth;
            int units = Properties.Settings.Default.units;
            bool strip = Properties.Settings.Default.strip;
            bool resize = Properties.Settings.Default.resize;
            bool overwrite = Properties.Settings.Default.overwrite;
            string path = Properties.Settings.Default.path;
            int quality = Properties.Settings.Default.quality;

            foreach (ListViewItem listedImage in listViewMain.Items)
            {
                fi = new FileInfo(listedImage.Text);
                mi = new MagickImage(listedImage.Text);
                beforeLength = fi.Length;

                // Generate the new image
                outputName = overwrite ? listedImage.Text : (path + "\\" + fi.Name);
                if (strip)
                {
                    mi.Strip();
                }
                if (resize)
                {
                    if (units == 0)
                    {
                        mi.Resize(maxWidth, maxHeight);
                    }
                    else if (units == 1)
                    {
                        mi.Resize(new Percentage(maxWidth), new Percentage(maxHeight));
                    }
                }
                mi.Quality = quality * (100 / 13);
                mi.Interlace = Interlace.Jpeg;
                
                try {
                    // Save the new file
                    mi.Write(outputName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                    break;
                }

                // Lossless optimization
                optimizer = new ImageOptimizer();
                optimizer.LosslessCompress(outputName);

                // Get the size of the file after shrinking;
                fi = new FileInfo(outputName);
                afterLength = fi.Length;

                // Calculate and display the savings
                savings = (1 - (float)afterLength / beforeLength) * 100;
                listedImage.SubItems[columnSavings.Index].Text = savings.ToString("p1");
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
            // Directory or file?
            if (Directory.Exists(path))
            {
                foreach (string sub in Directory.GetFileSystemEntries(path))
                {
                    addCurrentDirectoryFiles(sub);
                }
            }
            else
            {
                FileInfo fi = new FileInfo(path);
                string[] data = { fi.FullName, fi.Length / 1024 + " KB", "" };
                ListViewItem lvi = new ListViewItem(data);
                listViewMain.Items.Add(lvi);
            }
        }

        void addCurrentDirectoryFiles(string[] paths)
        {
            // Given an array of paths, so add each one
            foreach (string path in paths)
            {
                addCurrentDirectoryFiles(path);
            }
        }

        void listViewMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            addCurrentDirectoryFiles(paths);
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