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

		private void processImage(string input, string output)
		{
			MagickImage	mi = new MagickImage(input);

			if (Properties.Settings.Default.strip)
			{
				mi.Strip();
			}

			if (Properties.Settings.Default.resize)
			{
				if (Properties.Settings.Default.units == 0)
				{
					mi.Resize(
						Properties.Settings.Default.maxWidth,
						Properties.Settings.Default.maxHeight
					);
				}
				else if (Properties.Settings.Default.units == 1)
				{
					mi.Resize(
						new Percentage(Properties.Settings.Default.maxWidth),
						new Percentage(Properties.Settings.Default.maxHeight)
					);
				}
			}

			mi.Quality = Properties.Settings.Default.quality * (100 / 13);
			mi.Interlace = Interlace.Jpeg;

			try
			{
				mi.Write(output);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error");
			}
		}

        private void buttonRun_Click(object sender, EventArgs e)
        {
            double savings;
            string outputName;
			string path = Properties.Settings.Default.path;
			bool overwrite = Properties.Settings.Default.overwrite;
			FileInfo before;
			FileInfo after;

			foreach (ListViewItem listedImage in listViewMain.Items)
            {
				// File size before shrinking
                before = new FileInfo(listedImage.Text);
                
                // Generate the new image
                outputName = overwrite ? listedImage.Text : (path + "\\" + before.Name);
				processImage(listedImage.Text, outputName);

                // File size after shrinking;
                after = new FileInfo(outputName);

				// Calculate and display the savings
				savings = 1 - (double)after.Length / before.Length;
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

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            new FormAbout().Show(); 
        }

		private void menuItemSettings_Click(object sender, EventArgs e)
		{
			new FormSettings().Show();
		}

		private void menuItemExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}