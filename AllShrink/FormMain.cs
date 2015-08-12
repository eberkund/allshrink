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

		}

        private void buttonRun_Click(object sender, EventArgs e)
        {
            double savings;
            string outputName;
			FileInfo before;
			FileInfo after;
			MagickImage mi;

			foreach (ListViewItem listedImage in listViewMain.Items)
            {
				// File size before shrinking
                before = new FileInfo(listedImage.Text);
				mi = new MagickImage(listedImage.Text);

				// Get the output file path
				if (Properties.Settings.Default.overwrite)
				{
					outputName = listedImage.Text;
				}
				else
				{
					outputName = Properties.Settings.Default.path + "\\" + before.Name;
				}

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
					mi.Write(outputName);
				}
				catch (MagickBlobErrorException ex)
				{
					MessageBox.Show("Unable to write file to specified path.", "Error");
				}

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
			// Clear the list if the savings have already been calculated
			if (listViewMain.Items.Count > 0)
			{
				if (!listViewMain.Items[0].SubItems[columnSavings.Index].Text.Equals(""))
				{
					listViewMain.Items.Clear();
				}
			}

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