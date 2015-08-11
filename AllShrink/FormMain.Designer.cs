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
			this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemSettings = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItemHelp = new System.Windows.Forms.MenuItem();
			this.menuItemAbout = new System.Windows.Forms.MenuItem();
			this.listViewMain = new System.Windows.Forms.ListView();
			this.columnFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSavings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.labelDragImages = new System.Windows.Forms.Label();
			this.buttonRun = new System.Windows.Forms.Button();
			this.panelControls = new System.Windows.Forms.Panel();
			this.panelControls.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemHelp});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSettings,
            this.menuItemExit});
			this.menuItemFile.Text = "File";
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
			// menuItemHelp
			// 
			this.menuItemHelp.Index = 1;
			this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAbout});
			this.menuItemHelp.Text = "Help";
			// 
			// menuItemAbout
			// 
			this.menuItemAbout.Index = 0;
			this.menuItemAbout.Text = "About";
			this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
			// 
			// listViewMain
			// 
			this.listViewMain.AllowDrop = true;
			this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFilename,
            this.columnSize,
            this.columnSavings});
			this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewMain.Location = new System.Drawing.Point(0, 0);
			this.listViewMain.Margin = new System.Windows.Forms.Padding(0);
			this.listViewMain.Name = "listViewMain";
			this.listViewMain.Size = new System.Drawing.Size(384, 219);
			this.listViewMain.TabIndex = 1;
			this.listViewMain.UseCompatibleStateImageBehavior = false;
			this.listViewMain.View = System.Windows.Forms.View.Details;
			this.listViewMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewMain_DragDrop);
			this.listViewMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewMain_DragEnter);
			// 
			// columnFilename
			// 
			this.columnFilename.Text = "Filename";
			this.columnFilename.Width = 200;
			// 
			// columnSize
			// 
			this.columnSize.Text = "Size";
			this.columnSize.Width = 80;
			// 
			// columnSavings
			// 
			this.columnSavings.Text = "Savings";
			this.columnSavings.Width = 80;
			// 
			// buttonAdd
			// 
			this.buttonAdd.AutoSize = true;
			this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonAdd.Location = new System.Drawing.Point(58, 10);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(36, 23);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.AutoSize = true;
			this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonClear.Location = new System.Drawing.Point(10, 10);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(42, 23);
			this.buttonClear.TabIndex = 2;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// labelDragImages
			// 
			this.labelDragImages.AutoSize = true;
			this.labelDragImages.Location = new System.Drawing.Point(100, 15);
			this.labelDragImages.Name = "labelDragImages";
			this.labelDragImages.Size = new System.Drawing.Size(164, 13);
			this.labelDragImages.TabIndex = 5;
			this.labelDragImages.Text = "Drag images into the area above";
			// 
			// buttonRun
			// 
			this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRun.AutoSize = true;
			this.buttonRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonRun.Location = new System.Drawing.Point(336, 10);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(36, 23);
			this.buttonRun.TabIndex = 4;
			this.buttonRun.Text = "Run";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
			// 
			// panelControls
			// 
			this.panelControls.Controls.Add(this.buttonClear);
			this.panelControls.Controls.Add(this.buttonAdd);
			this.panelControls.Controls.Add(this.buttonRun);
			this.panelControls.Controls.Add(this.labelDragImages);
			this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControls.Location = new System.Drawing.Point(0, 219);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new System.Drawing.Size(384, 43);
			this.panelControls.TabIndex = 6;
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(384, 262);
			this.Controls.Add(this.listViewMain);
			this.Controls.Add(this.panelControls);
			this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Menu = this.mainMenu;
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "FormMain";
			this.Text = "AllShrink";
			this.panelControls.ResumeLayout(false);
			this.panelControls.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItemSettings;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItemAbout;
		private System.Windows.Forms.ListView listViewMain;
		private System.Windows.Forms.ColumnHeader columnFilename;
		private System.Windows.Forms.ColumnHeader columnSize;
		private System.Windows.Forms.ColumnHeader columnSavings;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Label labelDragImages;
		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.Panel panelControls;
	}
}

