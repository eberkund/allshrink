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
            // Resize settings
            textBoxWidth.Text = Properties.Settings.Default.maxWidth.ToString();
            textBoxHeight.Text = Properties.Settings.Default.maxHeight.ToString();
            checkBoxResize.Checked = Properties.Settings.Default.resize;
            if (Properties.Settings.Default.units == 0)
            {
                radioButtonPixels.Checked = true;
                radioButtonPercent.Checked = false;
            }
            else if (Properties.Settings.Default.units == 1)
            {
                radioButtonPixels.Checked = false;
                radioButtonPercent.Checked = true;
            }

            // Output settings
            checkBoxOverwrite.Checked = Properties.Settings.Default.overwrite;
            labelOutputPath.Text = Properties.Settings.Default.path;

            // Compression settings
            trackBarQuality.Value = Properties.Settings.Default.quality;
            checkBoxStrip.Checked = Properties.Settings.Default.strip;
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
            // Get the path from the user
            FolderBrowserDialog open = new FolderBrowserDialog();
            DialogResult result = open.ShowDialog();
            
            // Update the label
            labelOutputPath.Text = open.SelectedPath;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Resize settings
            Properties.Settings.Default.maxWidth = Int16.Parse(textBoxWidth.Text);
            Properties.Settings.Default.maxHeight = Int16.Parse(textBoxHeight.Text);
            Properties.Settings.Default.resize = checkBoxResize.Checked;
            if (radioButtonPixels.Checked)
            {
                Properties.Settings.Default.units = 0;
            }
            else if (radioButtonPixels.Checked)
            {
                Properties.Settings.Default.units = 1;
            }

            // Output settings
            Properties.Settings.Default.overwrite = checkBoxOverwrite.Checked;
            Properties.Settings.Default.path = labelOutputPath.Text;

            // Compression settings
            Properties.Settings.Default.quality = trackBarQuality.Value;
            Properties.Settings.Default.strip = checkBoxStrip.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
