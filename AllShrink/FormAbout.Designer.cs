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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelProgram = new System.Windows.Forms.Label();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.panelLinks = new System.Windows.Forms.Panel();
			this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
			this.linkLabelWebsite = new System.Windows.Forms.LinkLabel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelLinks.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Controls.Add(this.labelProgram, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelAuthor, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.panelLinks, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 90);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// labelProgram
			// 
			this.labelProgram.AutoSize = true;
			this.labelProgram.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProgram.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProgram.Location = new System.Drawing.Point(127, 0);
			this.labelProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelProgram.Name = "labelProgram";
			this.labelProgram.Size = new System.Drawing.Size(288, 30);
			this.labelProgram.TabIndex = 0;
			this.labelProgram.Text = "AllShrink v1.0.0";
			this.labelProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelAuthor
			// 
			this.labelAuthor.AutoSize = true;
			this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAuthor.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAuthor.Location = new System.Drawing.Point(127, 30);
			this.labelAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(288, 30);
			this.labelAuthor.TabIndex = 1;
			this.labelAuthor.Text = "(C) 2015 Erik Berkun-Drevnig";
			this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelLinks
			// 
			this.panelLinks.AutoSize = true;
			this.panelLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelLinks.Controls.Add(this.linkLabelGitHub);
			this.panelLinks.Controls.Add(this.linkLabelWebsite);
			this.panelLinks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLinks.Location = new System.Drawing.Point(125, 60);
			this.panelLinks.Margin = new System.Windows.Forms.Padding(0);
			this.panelLinks.Name = "panelLinks";
			this.panelLinks.Size = new System.Drawing.Size(292, 30);
			this.panelLinks.TabIndex = 2;
			// 
			// linkLabelGitHub
			// 
			this.linkLabelGitHub.Dock = System.Windows.Forms.DockStyle.Left;
			this.linkLabelGitHub.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelGitHub.Location = new System.Drawing.Point(69, 0);
			this.linkLabelGitHub.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabelGitHub.Name = "linkLabelGitHub";
			this.linkLabelGitHub.Size = new System.Drawing.Size(52, 30);
			this.linkLabelGitHub.TabIndex = 2;
			this.linkLabelGitHub.TabStop = true;
			this.linkLabelGitHub.Text = "GitHub";
			this.linkLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
			// 
			// linkLabelWebsite
			// 
			this.linkLabelWebsite.Dock = System.Windows.Forms.DockStyle.Left;
			this.linkLabelWebsite.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelWebsite.Location = new System.Drawing.Point(0, 0);
			this.linkLabelWebsite.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabelWebsite.Name = "linkLabelWebsite";
			this.linkLabelWebsite.Size = new System.Drawing.Size(69, 30);
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
			this.buttonOk.Location = new System.Drawing.Point(369, 101);
			this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
			this.buttonOk.Size = new System.Drawing.Size(57, 23);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// FormAbout
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(435, 154);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panelLinks.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelProgram;
		private System.Windows.Forms.Label labelAuthor;
		private System.Windows.Forms.LinkLabel linkLabelWebsite;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Panel panelLinks;
		private System.Windows.Forms.LinkLabel linkLabelGitHub;
	}
}
