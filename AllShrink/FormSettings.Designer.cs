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
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.groupBoxResizing = new System.Windows.Forms.GroupBox();
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxCompression = new System.Windows.Forms.GroupBox();
            this.checkBoxStrip = new System.Windows.Forms.CheckBox();
            this.groupBoxResizing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.panelResizing.SuspendLayout();
            this.groupBoxCompression.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Enabled = false;
            this.textBoxWidth.Location = new System.Drawing.Point(46, 56);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 26);
            this.textBoxWidth.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Enabled = false;
            this.textBoxHeight.Location = new System.Drawing.Point(179, 56);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 26);
            this.textBoxHeight.TabIndex = 3;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Enabled = false;
            this.labelWidth.Location = new System.Drawing.Point(16, 59);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(3);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(24, 20);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "W";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Enabled = false;
            this.labelHeight.Location = new System.Drawing.Point(152, 59);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(21, 20);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "H";
            // 
            // groupBoxResizing
            // 
            this.groupBoxResizing.AutoSize = true;
            this.groupBoxResizing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxResizing.Controls.Add(this.radioButtonPercent);
            this.groupBoxResizing.Controls.Add(this.checkBoxResize);
            this.groupBoxResizing.Controls.Add(this.labelHeight);
            this.groupBoxResizing.Controls.Add(this.radioButtonPixels);
            this.groupBoxResizing.Controls.Add(this.textBoxHeight);
            this.groupBoxResizing.Controls.Add(this.labelWidth);
            this.groupBoxResizing.Controls.Add(this.textBoxWidth);
            this.groupBoxResizing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResizing.Location = new System.Drawing.Point(0, 10);
            this.groupBoxResizing.Name = "groupBoxResizing";
            this.groupBoxResizing.Padding = new System.Windows.Forms.Padding(20, 10, 10, 0);
            this.groupBoxResizing.Size = new System.Drawing.Size(764, 104);
            this.groupBoxResizing.TabIndex = 6;
            this.groupBoxResizing.TabStop = false;
            this.groupBoxResizing.Text = "Resizing";
            // 
            // radioButtonPercent
            // 
            this.radioButtonPercent.AutoSize = true;
            this.radioButtonPercent.Enabled = false;
            this.radioButtonPercent.Location = new System.Drawing.Point(285, 57);
            this.radioButtonPercent.Name = "radioButtonPercent";
            this.radioButtonPercent.Size = new System.Drawing.Size(48, 24);
            this.radioButtonPercent.TabIndex = 7;
            this.radioButtonPercent.Text = "%";
            this.radioButtonPercent.UseVisualStyleBackColor = true;
            // 
            // checkBoxResize
            // 
            this.checkBoxResize.AutoSize = true;
            this.checkBoxResize.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxResize.Location = new System.Drawing.Point(20, 29);
            this.checkBoxResize.Name = "checkBoxResize";
            this.checkBoxResize.Size = new System.Drawing.Size(734, 24);
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
            this.radioButtonPixels.Location = new System.Drawing.Point(339, 57);
            this.radioButtonPixels.Name = "radioButtonPixels";
            this.radioButtonPixels.Size = new System.Drawing.Size(50, 24);
            this.radioButtonPixels.TabIndex = 6;
            this.radioButtonPixels.TabStop = true;
            this.radioButtonPixels.Text = "px";
            this.radioButtonPixels.UseVisualStyleBackColor = true;
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.Location = new System.Drawing.Point(76, 56);
            this.trackBarQuality.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarQuality.Maximum = 11;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(254, 69);
            this.trackBarQuality.TabIndex = 7;
            this.trackBarQuality.Value = 11;
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(16, 56);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(57, 20);
            this.labelQuality.TabIndex = 8;
            this.labelQuality.Text = "Quality";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Location = new System.Drawing.Point(643, 410);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(55, 30);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.AutoSize = true;
            this.groupBoxOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxOutput.Controls.Add(this.labelOutputPath);
            this.groupBoxOutput.Controls.Add(this.buttonBrowse);
            this.groupBoxOutput.Controls.Add(this.checkBoxOverwrite);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(20, 10, 10, 0);
            this.groupBoxOutput.Size = new System.Drawing.Size(764, 111);
            this.groupBoxOutput.TabIndex = 10;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // labelOutputPath
            // 
            this.labelOutputPath.AutoSize = true;
            this.labelOutputPath.Enabled = false;
            this.labelOutputPath.Location = new System.Drawing.Point(96, 64);
            this.labelOutputPath.Name = "labelOutputPath";
            this.labelOutputPath.Size = new System.Drawing.Size(74, 20);
            this.labelOutputPath.TabIndex = 3;
            this.labelOutputPath.Text = "C:\\output";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.AutoSize = true;
            this.buttonBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBrowse.Enabled = false;
            this.buttonBrowse.Location = new System.Drawing.Point(20, 59);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(72, 30);
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
            this.checkBoxOverwrite.Location = new System.Drawing.Point(20, 29);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(734, 24);
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
            this.panelOutput.Location = new System.Drawing.Point(15, 15);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelOutput.Size = new System.Drawing.Size(764, 121);
            this.panelOutput.TabIndex = 14;
            // 
            // panelResizing
            // 
            this.panelResizing.AutoSize = true;
            this.panelResizing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelResizing.Controls.Add(this.groupBoxResizing);
            this.panelResizing.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResizing.Location = new System.Drawing.Point(15, 136);
            this.panelResizing.Name = "panelResizing";
            this.panelResizing.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelResizing.Size = new System.Drawing.Size(764, 124);
            this.panelResizing.TabIndex = 15;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(704, 410);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxCompression
            // 
            this.groupBoxCompression.AutoSize = true;
            this.groupBoxCompression.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCompression.Controls.Add(this.checkBoxStrip);
            this.groupBoxCompression.Controls.Add(this.trackBarQuality);
            this.groupBoxCompression.Controls.Add(this.labelQuality);
            this.groupBoxCompression.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCompression.Location = new System.Drawing.Point(15, 260);
            this.groupBoxCompression.Name = "groupBoxCompression";
            this.groupBoxCompression.Padding = new System.Windows.Forms.Padding(20, 10, 10, 0);
            this.groupBoxCompression.Size = new System.Drawing.Size(764, 144);
            this.groupBoxCompression.TabIndex = 17;
            this.groupBoxCompression.TabStop = false;
            this.groupBoxCompression.Text = "Compression";
            // 
            // checkBoxStrip
            // 
            this.checkBoxStrip.AutoSize = true;
            this.checkBoxStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxStrip.Location = new System.Drawing.Point(20, 29);
            this.checkBoxStrip.Name = "checkBoxStrip";
            this.checkBoxStrip.Size = new System.Drawing.Size(734, 24);
            this.checkBoxStrip.TabIndex = 9;
            this.checkBoxStrip.Text = "Strip JPEG metadata";
            this.checkBoxStrip.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(794, 567);
            this.Controls.Add(this.groupBoxCompression);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelResizing);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.buttonSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.groupBoxResizing.ResumeLayout(false);
            this.groupBoxResizing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.panelResizing.ResumeLayout(false);
            this.panelResizing.PerformLayout();
            this.groupBoxCompression.ResumeLayout(false);
            this.groupBoxCompression.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
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
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxCompression;
        private System.Windows.Forms.CheckBox checkBoxStrip;
    }
}