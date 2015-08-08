namespace AllShrink
{
    partial class FormMain
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
			this.components = new System.ComponentModel.Container();
			this.listViewMain = new System.Windows.Forms.ListView();
			this.columnFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSavings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageListMain = new System.Windows.Forms.ImageList(this.components);
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonRun = new System.Windows.Forms.Button();
			this.labelDragImages = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItemSettings = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItemAbout = new System.Windows.Forms.MenuItem();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewMain
			// 
			this.listViewMain.AllowDrop = true;
			this.listViewMain.BackgroundImageTiled = true;
			this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFilename,
            this.columnSize,
            this.columnSavings});
			this.listViewMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.listViewMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewMain.Location = new System.Drawing.Point(0, 0);
			this.listViewMain.Margin = new System.Windows.Forms.Padding(0);
			this.listViewMain.Name = "listViewMain";
			this.listViewMain.Size = new System.Drawing.Size(1202, 613);
			this.listViewMain.TabIndex = 1;
			this.listViewMain.UseCompatibleStateImageBehavior = false;
			this.listViewMain.View = System.Windows.Forms.View.Details;
			this.listViewMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewMain_DragDrop);
			this.listViewMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewMain_DragEnter);
			// 
			// columnFilename
			// 
			this.columnFilename.Text = "Filename";
			this.columnFilename.Width = 323;
			// 
			// columnSize
			// 
			this.columnSize.Text = "Size";
			this.columnSize.Width = 134;
			// 
			// columnSavings
			// 
			this.columnSavings.Text = "Savings";
			this.columnSavings.Width = 116;
			// 
			// imageListMain
			// 
			this.imageListMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListMain.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClear.AutoSize = true;
			this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonClear.Location = new System.Drawing.Point(11, 19);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(56, 30);
			this.buttonClear.TabIndex = 2;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAdd.AutoSize = true;
			this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonAdd.Location = new System.Drawing.Point(73, 19);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(48, 30);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonRun
			// 
			this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRun.AutoSize = true;
			this.buttonRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonRun.Location = new System.Drawing.Point(1142, 19);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(49, 30);
			this.buttonRun.TabIndex = 4;
			this.buttonRun.Text = "Run";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
			// 
			// labelDragImages
			// 
			this.labelDragImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDragImages.AutoSize = true;
			this.labelDragImages.Location = new System.Drawing.Point(127, 24);
			this.labelDragImages.Name = "labelDragImages";
			this.labelDragImages.Size = new System.Drawing.Size(239, 20);
			this.labelDragImages.TabIndex = 5;
			this.labelDragImages.Text = "Drag images into the area above";
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.buttonRun);
			this.panel1.Controls.Add(this.labelDragImages);
			this.panel1.Controls.Add(this.buttonClear);
			this.panel1.Controls.Add(this.buttonAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 613);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1202, 60);
			this.panel1.TabIndex = 6;
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItem2});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSettings,
            this.menuItemExit});
			this.menuItemFile.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAbout});
			this.menuItem2.Text = "Help";
			// 
			// menuItemSettings
			// 
			this.menuItemSettings.Index = 0;
			this.menuItemSettings.Text = "Settings";
			this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Index = 1;
			this.menuItemExit.Text = "Exit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItemAbout
			// 
			this.menuItemAbout.Index = 0;
			this.menuItemAbout.Text = "About";
			this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 673);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listViewMain);
			this.Menu = this.mainMenu;
			this.MinimumSize = new System.Drawing.Size(600, 600);
			this.Name = "FormMain";
			this.Text = "AllShrink";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnFilename;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ColumnHeader columnSavings;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelDragImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItemSettings;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItemAbout;
	}
}

