using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllShrink
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles("C:/test");

            for (int x = 0; x < files.Length; x++)
            {
                ListViewItem item = new ListViewItem(new string[] { files[x], "test" });
                listView1.Items.Add(item);
            }

        }
    }
}
