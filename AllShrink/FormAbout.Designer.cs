namespace AllShrink
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelProgram = new System.Windows.Forms.Label();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.panelLinks = new System.Windows.Forms.Panel();
			this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
			this.labelSeparator1 = new System.Windows.Forms.Label();
			this.linkLabelWebsite = new System.Windows.Forms.LinkLabel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.panelLinks.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel.Controls.Add(this.labelProgram, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelAuthor, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.panelLinks, 1, 2);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 3;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(396, 120);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// labelProgram
			// 
			this.labelProgram.AutoSize = true;
			this.labelProgram.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProgram.Location = new System.Drawing.Point(121, 0);
			this.labelProgram.Name = "labelProgram";
			this.labelProgram.Size = new System.Drawing.Size(272, 40);
			this.labelProgram.TabIndex = 0;
			this.labelProgram.Text = "AllShrink v1.0.0";
			this.labelProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelAuthor
			// 
			this.labelAuthor.AutoSize = true;
			this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAuthor.Location = new System.Drawing.Point(121, 40);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(272, 40);
			this.labelAuthor.TabIndex = 1;
			this.labelAuthor.Text = "(C) 2015 Erik Berkun-Drevnig";
			this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelLinks
			// 
			this.panelLinks.AutoSize = true;
			this.panelLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelLinks.Controls.Add(this.linkLabelGitHub);
			this.panelLinks.Controls.Add(this.labelSeparator1);
			this.panelLinks.Controls.Add(this.linkLabelWebsite);
			this.panelLinks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLinks.Location = new System.Drawing.Point(118, 80);
			this.panelLinks.Margin = new System.Windows.Forms.Padding(0);
			this.panelLinks.Name = "panelLinks";
			this.panelLinks.Size = new System.Drawing.Size(278, 40);
			this.panelLinks.TabIndex = 2;
			// 
			// linkLabelGitHub
			// 
			this.linkLabelGitHub.AutoSize = true;
			this.linkLabelGitHub.Dock = System.Windows.Forms.DockStyle.Left;
			this.linkLabelGitHub.Location = new System.Drawing.Point(74, 0);
			this.linkLabelGitHub.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabelGitHub.MinimumSize = new System.Drawing.Size(0, 40);
			this.linkLabelGitHub.Name = "linkLabelGitHub";
			this.linkLabelGitHub.Size = new System.Drawing.Size(51, 40);
			this.linkLabelGitHub.TabIndex = 2;
			this.linkLabelGitHub.TabStop = true;
			this.linkLabelGitHub.Text = "GitHub";
			this.linkLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
			// 
			// labelSeparator1
			// 
			this.labelSeparator1.AutoSize = true;
			this.labelSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelSeparator1.Location = new System.Drawing.Point(60, 0);
			this.labelSeparator1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelSeparator1.MinimumSize = new System.Drawing.Size(0, 40);
			this.labelSeparator1.Name = "labelSeparator1";
			this.labelSeparator1.Size = new System.Drawing.Size(14, 40);
			this.labelSeparator1.TabIndex = 3;
			this.labelSeparator1.Text = "|";
			this.labelSeparator1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabelWebsite
			// 
			this.linkLabelWebsite.AutoSize = true;
			this.linkLabelWebsite.Dock = System.Windows.Forms.DockStyle.Left;
			this.linkLabelWebsite.Location = new System.Drawing.Point(0, 0);
			this.linkLabelWebsite.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabelWebsite.MinimumSize = new System.Drawing.Size(0, 40);
			this.linkLabelWebsite.Name = "linkLabelWebsite";
			this.linkLabelWebsite.Size = new System.Drawing.Size(60, 40);
			this.linkLabelWebsite.TabIndex = 1;
			this.linkLabelWebsite.TabStop = true;
			this.linkLabelWebsite.Text = "Website";
			this.linkLabelWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebsite_LinkClicked);
			// 
			// buttonOk
			// 
			this.buttonOk.AutoSize = true;
			this.buttonOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOk.Location = new System.Drawing.Point(343, 135);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
			this.buttonOk.Size = new System.Drawing.Size(65, 23);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// FormAbout
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(420, 200);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.tableLayoutPanel);
			this.Font = new System.Drawing.Font("Tahoma", 11F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.TopMost = true;
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.panelLinks.ResumeLayout(false);
			this.panelLinks.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelProgram;
		private System.Windows.Forms.Label labelAuthor;
		private System.Windows.Forms.LinkLabel linkLabelWebsite;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Panel panelLinks;
		private System.Windows.Forms.LinkLabel linkLabelGitHub;
		private System.Windows.Forms.Label labelSeparator1;
	}
}
