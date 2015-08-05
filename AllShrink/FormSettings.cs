using System;
using System.Windows.Forms;

namespace AllShrink
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            loadSettings();
        }

        private void loadSettings()
        {
            textBoxWidth.Text = Properties.Settings.Default.maxWidth.ToString();
            textBoxHeight.Text = Properties.Settings.Default.maxHeight.ToString();
            checkBoxResize.Checked = Properties.Settings.Default.resizeImages;
            checkBoxOverwrite.Checked = Properties.Settings.Default.overwriteFiles;
            trackBarQuality.Value = Properties.Settings.Default.quality;
        }

        private void checkBoxResize_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxResize.Checked)
            {
                textBoxWidth.Enabled = true;
                labelWidth.Enabled = true;
                textBoxHeight.Enabled = true;
                labelHeight.Enabled = true;
                radioButtonPixels.Enabled = true;
                radioButtonPercent.Enabled = true;
            }
            else
            {
                textBoxWidth.Enabled = false;
                labelWidth.Enabled = false;
                textBoxHeight.Enabled = false;
                labelHeight.Enabled = false;
                radioButtonPixels.Enabled = false;
                radioButtonPercent.Enabled = false;
            }
        }

        private void checkBoxOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOverwrite.Checked)
            {
                labelOutputPath.Enabled = false;
                buttonBrowse.Enabled = false;
            }
            else
            {
                labelOutputPath.Enabled = true;
                buttonBrowse.Enabled = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            DialogResult result = open.ShowDialog();
            labelOutputPath.Text = open.SelectedPath;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.maxWidth = Int16.Parse(textBoxWidth.Text);
            Properties.Settings.Default.maxHeight = Int16.Parse(textBoxHeight.Text);
            Properties.Settings.Default.resizeImages = checkBoxResize.Checked;
            Properties.Settings.Default.overwriteFiles = checkBoxResize.Checked;
            Properties.Settings.Default.quality = trackBarQuality.Value;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
