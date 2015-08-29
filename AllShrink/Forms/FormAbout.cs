using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllShrink
{
    partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

		private void linkLabelWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabelWebsite.LinkVisited = true;
			System.Diagnostics.Process.Start("http://allshrink.com");
		}

		private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabelGitHub.LinkVisited = true;
			System.Diagnostics.Process.Start("http://github.com/eberkund/allshrink");
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
