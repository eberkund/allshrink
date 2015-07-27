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

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxResizing_Enter(object sender, EventArgs e)
        {

        }

        private void labelHeight_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
