using System;
using System.Windows.Forms;

namespace AllShrink
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
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
    }
}
