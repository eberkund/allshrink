using System;
using System.IO;
using System.Windows.Forms;

namespace AllShrink
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            // Resize settings
            numericUpDownWidth.Value = Properties.Settings.Default.maxWidth;
            numericUpDownHeight.Value = Properties.Settings.Default.maxHeight;
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
                numericUpDownWidth.Enabled = true;
                labelWidth.Enabled = true;
                numericUpDownHeight.Enabled = true;
                labelHeight.Enabled = true;
                radioButtonPixels.Enabled = true;
                radioButtonPercent.Enabled = true;
            }
            else
            {
                numericUpDownWidth.Enabled = false;
                labelWidth.Enabled = false;
                numericUpDownHeight.Enabled = false;
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
			// Output settings
			Properties.Settings.Default.overwrite = checkBoxOverwrite.Checked;
			if (!Directory.Exists(labelOutputPath.Text))
			{
				MessageBox.Show("Invalid output path.", "Error");
			}
			else
			{
				Properties.Settings.Default.path = labelOutputPath.Text;
			}

			// Resize settings
			Properties.Settings.Default.maxWidth = (int)numericUpDownWidth.Value;
            Properties.Settings.Default.maxHeight = (int)numericUpDownHeight.Value;
            Properties.Settings.Default.resize = checkBoxResize.Checked;
            if (radioButtonPixels.Checked)
            {
                Properties.Settings.Default.units = 0;
            }
            else if (radioButtonPixels.Checked)
            {
                Properties.Settings.Default.units = 1;
            }

            // Compression settings
            Properties.Settings.Default.quality = trackBarQuality.Value;
            Properties.Settings.Default.strip = checkBoxStrip.Checked;

            Properties.Settings.Default.Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}
