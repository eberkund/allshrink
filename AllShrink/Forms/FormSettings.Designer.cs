namespace AllShrink
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.labelWidth = new System.Windows.Forms.Label();
			this.labelHeight = new System.Windows.Forms.Label();
			this.groupBoxResizing = new System.Windows.Forms.GroupBox();
			this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
			this.radioButtonPercent = new System.Windows.Forms.RadioButton();
			this.checkBoxResize = new System.Windows.Forms.CheckBox();
			this.radioButtonPixels = new System.Windows.Forms.RadioButton();
			this.trackBarQuality = new System.Windows.Forms.TrackBar();
			this.labelQuality = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.groupBoxOutput = new System.Windows.Forms.GroupBox();
			this.labelOutputPath = new System.Windows.Forms.Label();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
			this.panelOutput = new System.Windows.Forms.Panel();
			this.panelResizing = new System.Windows.Forms.Panel();
			this.groupBoxCompression = new System.Windows.Forms.GroupBox();
			this.checkBoxStrip = new System.Windows.Forms.CheckBox();
			this.panelCompression = new System.Windows.Forms.Panel();
			this.groupBoxResizing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
			this.groupBoxOutput.SuspendLayout();
			this.panelOutput.SuspendLayout();
			this.panelResizing.SuspendLayout();
			this.groupBoxCompression.SuspendLayout();
			this.panelCompression.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelWidth
			// 
			this.labelWidth.AutoSize = true;
			this.labelWidth.Enabled = false;
			this.labelWidth.Location = new System.Drawing.Point(7, 48);
			this.labelWidth.Name = "labelWidth";
			this.labelWidth.Size = new System.Drawing.Size(17, 13);
			this.labelWidth.TabIndex = 4;
			this.labelWidth.Text = "W";
			this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelHeight
			// 
			this.labelHeight.AutoSize = true;
			this.labelHeight.Enabled = false;
			this.labelHeight.Location = new System.Drawing.Point(116, 48);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new System.Drawing.Size(14, 13);
			this.labelHeight.TabIndex = 5;
			this.labelHeight.Text = "H";
			// 
			// groupBoxResizing
			// 
			this.groupBoxResizing.AutoSize = true;
			this.groupBoxResizing.Controls.Add(this.numericUpDownWidth);
			this.groupBoxResizing.Controls.Add(this.numericUpDownHeight);
			this.groupBoxResizing.Controls.Add(this.radioButtonPercent);
			this.groupBoxResizing.Controls.Add(this.checkBoxResize);
			this.groupBoxResizing.Controls.Add(this.labelHeight);
			this.groupBoxResizing.Controls.Add(this.radioButtonPixels);
			this.groupBoxResizing.Controls.Add(this.labelWidth);
			this.groupBoxResizing.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxResizing.Location = new System.Drawing.Point(0, 0);
			this.groupBoxResizing.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxResizing.Name = "groupBoxResizing";
			this.groupBoxResizing.Padding = new System.Windows.Forms.Padding(10);
			this.groupBoxResizing.Size = new System.Drawing.Size(354, 92);
			this.groupBoxResizing.TabIndex = 6;
			this.groupBoxResizing.TabStop = false;
			this.groupBoxResizing.Text = "Resizing";
			// 
			// numericUpDownWidth
			// 
			this.numericUpDownWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownWidth.Location = new System.Drawing.Point(30, 44);
			this.numericUpDownWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownWidth.Name = "numericUpDownWidth";
			this.numericUpDownWidth.Size = new System.Drawing.Size(80, 22);
			this.numericUpDownWidth.TabIndex = 9;
			this.numericUpDownWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
			// 
			// numericUpDownHeight
			// 
			this.numericUpDownHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownHeight.Location = new System.Drawing.Point(136, 44);
			this.numericUpDownHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownHeight.Name = "numericUpDownHeight";
			this.numericUpDownHeight.Size = new System.Drawing.Size(80, 22);
			this.numericUpDownHeight.TabIndex = 8;
			this.numericUpDownHeight.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
			// 
			// radioButtonPercent
			// 
			this.radioButtonPercent.AutoSize = true;
			this.radioButtonPercent.Enabled = false;
			this.radioButtonPercent.Location = new System.Drawing.Point(262, 46);
			this.radioButtonPercent.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonPercent.Name = "radioButtonPercent";
			this.radioButtonPercent.Size = new System.Drawing.Size(36, 17);
			this.radioButtonPercent.TabIndex = 7;
			this.radioButtonPercent.Text = "%";
			this.radioButtonPercent.UseVisualStyleBackColor = true;
			// 
			// checkBoxResize
			// 
			this.checkBoxResize.AutoSize = true;
			this.checkBoxResize.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBoxResize.Location = new System.Drawing.Point(10, 23);
			this.checkBoxResize.Name = "checkBoxResize";
			this.checkBoxResize.Size = new System.Drawing.Size(334, 17);
			this.checkBoxResize.TabIndex = 7;
			this.checkBoxResize.Text = "Resize images";
			this.checkBoxResize.UseVisualStyleBackColor = true;
			this.checkBoxResize.CheckedChanged += new System.EventHandler(this.checkBoxResize_CheckedChanged);
			// 
			// radioButtonPixels
			// 
			this.radioButtonPixels.AutoSize = true;
			this.radioButtonPixels.Checked = true;
			this.radioButtonPixels.Enabled = false;
			this.radioButtonPixels.Location = new System.Drawing.Point(221, 46);
			this.radioButtonPixels.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonPixels.Name = "radioButtonPixels";
			this.radioButtonPixels.Size = new System.Drawing.Size(37, 17);
			this.radioButtonPixels.TabIndex = 6;
			this.radioButtonPixels.TabStop = true;
			this.radioButtonPixels.Text = "px";
			this.radioButtonPixels.UseVisualStyleBackColor = true;
			// 
			// trackBarQuality
			// 
			this.trackBarQuality.Location = new System.Drawing.Point(50, 45);
			this.trackBarQuality.Margin = new System.Windows.Forms.Padding(0);
			this.trackBarQuality.Maximum = 11;
			this.trackBarQuality.Name = "trackBarQuality";
			this.trackBarQuality.Size = new System.Drawing.Size(169, 45);
			this.trackBarQuality.TabIndex = 7;
			this.trackBarQuality.Value = 11;
			// 
			// labelQuality
			// 
			this.labelQuality.AutoSize = true;
			this.labelQuality.Location = new System.Drawing.Point(7, 47);
			this.labelQuality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelQuality.Name = "labelQuality";
			this.labelQuality.Size = new System.Drawing.Size(41, 13);
			this.labelQuality.TabIndex = 8;
			this.labelQuality.Text = "Quality";
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.AutoSize = true;
			this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonSave.Location = new System.Drawing.Point(315, 332);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.buttonSave.Size = new System.Drawing.Size(49, 27);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// groupBoxOutput
			// 
			this.groupBoxOutput.AutoSize = true;
			this.groupBoxOutput.Controls.Add(this.labelOutputPath);
			this.groupBoxOutput.Controls.Add(this.buttonBrowse);
			this.groupBoxOutput.Controls.Add(this.checkBoxOverwrite);
			this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
			this.groupBoxOutput.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxOutput.Name = "groupBoxOutput";
			this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(10);
			this.groupBoxOutput.Size = new System.Drawing.Size(354, 95);
			this.groupBoxOutput.TabIndex = 10;
			this.groupBoxOutput.TabStop = false;
			this.groupBoxOutput.Text = "Output";
			// 
			// labelOutputPath
			// 
			this.labelOutputPath.AutoSize = true;
			this.labelOutputPath.Enabled = false;
			this.labelOutputPath.Location = new System.Drawing.Point(61, 51);
			this.labelOutputPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelOutputPath.Name = "labelOutputPath";
			this.labelOutputPath.Size = new System.Drawing.Size(54, 13);
			this.labelOutputPath.TabIndex = 3;
			this.labelOutputPath.Text = "C:\\output";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.AutoSize = true;
			this.buttonBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonBrowse.Enabled = false;
			this.buttonBrowse.Location = new System.Drawing.Point(10, 47);
			this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(52, 23);
			this.buttonBrowse.TabIndex = 2;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// checkBoxOverwrite
			// 
			this.checkBoxOverwrite.AutoSize = true;
			this.checkBoxOverwrite.Checked = true;
			this.checkBoxOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxOverwrite.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBoxOverwrite.Location = new System.Drawing.Point(10, 23);
			this.checkBoxOverwrite.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxOverwrite.Name = "checkBoxOverwrite";
			this.checkBoxOverwrite.Size = new System.Drawing.Size(334, 17);
			this.checkBoxOverwrite.TabIndex = 0;
			this.checkBoxOverwrite.Text = "Overwrite input files";
			this.checkBoxOverwrite.UseVisualStyleBackColor = true;
			this.checkBoxOverwrite.CheckedChanged += new System.EventHandler(this.checkBoxOverwrite_CheckedChanged);
			// 
			// panelOutput
			// 
			this.panelOutput.AutoSize = true;
			this.panelOutput.Controls.Add(this.groupBoxOutput);
			this.panelOutput.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelOutput.Location = new System.Drawing.Point(10, 10);
			this.panelOutput.Margin = new System.Windows.Forms.Padding(2);
			this.panelOutput.Name = "panelOutput";
			this.panelOutput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panelOutput.Size = new System.Drawing.Size(354, 105);
			this.panelOutput.TabIndex = 14;
			// 
			// panelResizing
			// 
			this.panelResizing.AutoSize = true;
			this.panelResizing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelResizing.Controls.Add(this.groupBoxResizing);
			this.panelResizing.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelResizing.Location = new System.Drawing.Point(10, 115);
			this.panelResizing.Margin = new System.Windows.Forms.Padding(2);
			this.panelResizing.Name = "panelResizing";
			this.panelResizing.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panelResizing.Size = new System.Drawing.Size(354, 102);
			this.panelResizing.TabIndex = 15;
			// 
			// groupBoxCompression
			// 
			this.groupBoxCompression.AutoSize = true;
			this.groupBoxCompression.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBoxCompression.Controls.Add(this.checkBoxStrip);
			this.groupBoxCompression.Controls.Add(this.trackBarQuality);
			this.groupBoxCompression.Controls.Add(this.labelQuality);
			this.groupBoxCompression.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxCompression.Location = new System.Drawing.Point(0, 0);
			this.groupBoxCompression.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxCompression.Name = "groupBoxCompression";
			this.groupBoxCompression.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.groupBoxCompression.Size = new System.Drawing.Size(354, 103);
			this.groupBoxCompression.TabIndex = 17;
			this.groupBoxCompression.TabStop = false;
			this.groupBoxCompression.Text = "Compression";
			// 
			// checkBoxStrip
			// 
			this.checkBoxStrip.AutoSize = true;
			this.checkBoxStrip.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBoxStrip.Location = new System.Drawing.Point(10, 23);
			this.checkBoxStrip.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxStrip.Name = "checkBoxStrip";
			this.checkBoxStrip.Size = new System.Drawing.Size(334, 17);
			this.checkBoxStrip.TabIndex = 9;
			this.checkBoxStrip.Text = "Strip JPEG metadata";
			this.checkBoxStrip.UseVisualStyleBackColor = true;
			// 
			// panelCompression
			// 
			this.panelCompression.AutoSize = true;
			this.panelCompression.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelCompression.Controls.Add(this.groupBoxCompression);
			this.panelCompression.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCompression.Location = new System.Drawing.Point(10, 217);
			this.panelCompression.Name = "panelCompression";
			this.panelCompression.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panelCompression.Size = new System.Drawing.Size(354, 113);
			this.panelCompression.TabIndex = 18;
			// 
			// FormSettings
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(374, 372);
			this.Controls.Add(this.panelCompression);
			this.Controls.Add(this.panelResizing);
			this.Controls.Add(this.panelOutput);
			this.Controls.Add(this.buttonSave);
			this.Font = new System.Drawing.Font("Tahoma", 8F);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSettings";
			this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Settings";
			this.TopMost = true;
			this.groupBoxResizing.ResumeLayout(false);
			this.groupBoxResizing.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
			this.groupBoxOutput.ResumeLayout(false);
			this.groupBoxOutput.PerformLayout();
			this.panelOutput.ResumeLayout(false);
			this.panelOutput.PerformLayout();
			this.panelResizing.ResumeLayout(false);
			this.panelResizing.PerformLayout();
			this.groupBoxCompression.ResumeLayout(false);
			this.groupBoxCompression.PerformLayout();
			this.panelCompression.ResumeLayout(false);
			this.panelCompression.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.GroupBox groupBoxResizing;
        private System.Windows.Forms.RadioButton radioButtonPercent;
        private System.Windows.Forms.RadioButton radioButtonPixels;
        private System.Windows.Forms.CheckBox checkBoxResize;
        private System.Windows.Forms.TrackBar trackBarQuality;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.Label labelOutputPath;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelResizing;
        private System.Windows.Forms.GroupBox groupBoxCompression;
        private System.Windows.Forms.CheckBox checkBoxStrip;
		private System.Windows.Forms.NumericUpDown numericUpDownHeight;
		private System.Windows.Forms.NumericUpDown numericUpDownWidth;
		private System.Windows.Forms.Panel panelCompression;
	}
}