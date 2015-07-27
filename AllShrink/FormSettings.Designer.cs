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
            this.checkBoxStripMeta = new System.Windows.Forms.CheckBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.groupBoxResizing = new System.Windows.Forms.GroupBox();
            this.radioButtonPercent = new System.Windows.Forms.RadioButton();
            this.radioButtonPixels = new System.Windows.Forms.RadioButton();
            this.checkBoxResize = new System.Windows.Forms.CheckBox();
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.labelQuality = new System.Windows.Forms.Label();
            this.groupBoxResizing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxStripMeta
            // 
            this.checkBoxStripMeta.AutoSize = true;
            this.checkBoxStripMeta.Location = new System.Drawing.Point(15, 159);
            this.checkBoxStripMeta.Name = "checkBoxStripMeta";
            this.checkBoxStripMeta.Size = new System.Drawing.Size(186, 24);
            this.checkBoxStripMeta.TabIndex = 0;
            this.checkBoxStripMeta.Text = "Strip JPEG metadata";
            this.checkBoxStripMeta.UseVisualStyleBackColor = true;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Enabled = false;
            this.textBoxWidth.Location = new System.Drawing.Point(39, 76);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 26);
            this.textBoxWidth.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Enabled = false;
            this.textBoxHeight.Location = new System.Drawing.Point(172, 76);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 26);
            this.textBoxHeight.TabIndex = 3;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Enabled = false;
            this.labelWidth.Location = new System.Drawing.Point(9, 79);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(24, 20);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "W";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Enabled = false;
            this.labelHeight.Location = new System.Drawing.Point(145, 79);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(21, 20);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "H";
            this.labelHeight.Click += new System.EventHandler(this.labelHeight_Click);
            // 
            // groupBoxResizing
            // 
            this.groupBoxResizing.AutoSize = true;
            this.groupBoxResizing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxResizing.Controls.Add(this.radioButtonPercent);
            this.groupBoxResizing.Controls.Add(this.checkBoxResize);
            this.groupBoxResizing.Controls.Add(this.labelWidth);
            this.groupBoxResizing.Controls.Add(this.radioButtonPixels);
            this.groupBoxResizing.Controls.Add(this.textBoxWidth);
            this.groupBoxResizing.Controls.Add(this.labelHeight);
            this.groupBoxResizing.Controls.Add(this.textBoxHeight);
            this.groupBoxResizing.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxResizing.Location = new System.Drawing.Point(15, 15);
            this.groupBoxResizing.Name = "groupBoxResizing";
            this.groupBoxResizing.Padding = new System.Windows.Forms.Padding(20, 10, 10, 0);
            this.groupBoxResizing.Size = new System.Drawing.Size(570, 124);
            this.groupBoxResizing.TabIndex = 6;
            this.groupBoxResizing.TabStop = false;
            this.groupBoxResizing.Text = "Resizing";
            this.groupBoxResizing.Enter += new System.EventHandler(this.groupBoxResizing_Enter);
            // 
            // radioButtonPercent
            // 
            this.radioButtonPercent.AutoSize = true;
            this.radioButtonPercent.Enabled = false;
            this.radioButtonPercent.Location = new System.Drawing.Point(334, 77);
            this.radioButtonPercent.Name = "radioButtonPercent";
            this.radioButtonPercent.Size = new System.Drawing.Size(48, 24);
            this.radioButtonPercent.TabIndex = 7;
            this.radioButtonPercent.TabStop = true;
            this.radioButtonPercent.Text = "%";
            this.radioButtonPercent.UseVisualStyleBackColor = true;
            // 
            // radioButtonPixels
            // 
            this.radioButtonPixels.AutoSize = true;
            this.radioButtonPixels.Enabled = false;
            this.radioButtonPixels.Location = new System.Drawing.Point(278, 77);
            this.radioButtonPixels.Name = "radioButtonPixels";
            this.radioButtonPixels.Size = new System.Drawing.Size(50, 24);
            this.radioButtonPixels.TabIndex = 6;
            this.radioButtonPixels.TabStop = true;
            this.radioButtonPixels.Text = "px";
            this.radioButtonPixels.UseVisualStyleBackColor = true;
            // 
            // checkBoxResize
            // 
            this.checkBoxResize.AutoSize = true;
            this.checkBoxResize.Location = new System.Drawing.Point(13, 32);
            this.checkBoxResize.Name = "checkBoxResize";
            this.checkBoxResize.Size = new System.Drawing.Size(139, 24);
            this.checkBoxResize.TabIndex = 7;
            this.checkBoxResize.Text = "Resize images";
            this.checkBoxResize.UseVisualStyleBackColor = true;
            this.checkBoxResize.CheckedChanged += new System.EventHandler(this.checkBoxResize_CheckedChanged);
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.Location = new System.Drawing.Point(74, 219);
            this.trackBarQuality.Maximum = 11;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(266, 69);
            this.trackBarQuality.TabIndex = 7;
            this.trackBarQuality.Value = 11;
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(11, 219);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(57, 20);
            this.labelQuality.TabIndex = 8;
            this.labelQuality.Text = "Quality";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 319);
            this.Controls.Add(this.labelQuality);
            this.Controls.Add(this.trackBarQuality);
            this.Controls.Add(this.groupBoxResizing);
            this.Controls.Add(this.checkBoxStripMeta);
            this.Name = "FormSettings";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxResizing.ResumeLayout(false);
            this.groupBoxResizing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxStripMeta;
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
    }
}