namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.SelectAllBtn = new System.Windows.Forms.ToolStripButton();
            this.UnSelect = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.ElipseBtn = new System.Windows.Forms.ToolStripButton();
            this.TriangleBtn = new System.Windows.Forms.ToolStripButton();
            this.ColorBtn = new System.Windows.Forms.ToolStripButton();
            this.BackgroundColorBtn = new System.Windows.Forms.ToolStripButton();
            this.SizeBox = new System.Windows.Forms.ToolStripTextBox();
            this.SizeBtn = new System.Windows.Forms.ToolStripButton();
            this.PenSizeBox = new System.Windows.Forms.ToolStripTextBox();
            this.ChangePenSize = new System.Windows.Forms.ToolStripButton();
            this.penColor = new System.Windows.Forms.ToolStripButton();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.UndoBtn = new System.Windows.Forms.ToolStripButton();
            this.Help = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.penBackColor = new System.Windows.Forms.PictureBox();
            this.backGroundColor = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundColor)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1362, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAsToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAsToolStripMenuItem
            // 
            this.openAsToolStripMenuItem.Name = "openAsToolStripMenuItem";
            this.openAsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openAsToolStripMenuItem.Text = "Open File";
            this.openAsToolStripMenuItem.Click += new System.EventHandler(this.openAsToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveAsToolStripMenuItem.Text = "Save File";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 711);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1362, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.SelectAllBtn,
            this.UnSelect,
            this.drawRectangleSpeedButton,
            this.ElipseBtn,
            this.TriangleBtn,
            this.ColorBtn,
            this.BackgroundColorBtn,
            this.SizeBox,
            this.SizeBtn,
            this.PenSizeBox,
            this.ChangePenSize,
            this.penColor,
            this.DeleteBtn,
            this.UndoBtn,
            this.Help,
            this.toolStripButton1});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(1362, 25);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // SelectAllBtn
            // 
            this.SelectAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("SelectAllBtn.Image")));
            this.SelectAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAllBtn.Name = "SelectAllBtn";
            this.SelectAllBtn.Size = new System.Drawing.Size(23, 22);
            this.SelectAllBtn.Text = "Select All";
            this.SelectAllBtn.Click += new System.EventHandler(this.SelectAllBtn_Click);
            // 
            // UnSelect
            // 
            this.UnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnSelect.Image = ((System.Drawing.Image)(resources.GetObject("UnSelect.Image")));
            this.UnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnSelect.Name = "UnSelect";
            this.UnSelect.Size = new System.Drawing.Size(23, 22);
            this.UnSelect.Text = "UnSelect";
            this.UnSelect.Click += new System.EventHandler(this.UnSelect_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // ElipseBtn
            // 
            this.ElipseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ElipseBtn.Image = ((System.Drawing.Image)(resources.GetObject("ElipseBtn.Image")));
            this.ElipseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ElipseBtn.Name = "ElipseBtn";
            this.ElipseBtn.Size = new System.Drawing.Size(23, 22);
            this.ElipseBtn.Text = "Elipse";
            this.ElipseBtn.Click += new System.EventHandler(this.ElipseBtn_Click);
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TriangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("TriangleBtn.Image")));
            this.TriangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(23, 22);
            this.TriangleBtn.Text = "Triangle";
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // ColorBtn
            // 
            this.ColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("ColorBtn.Image")));
            this.ColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(23, 22);
            this.ColorBtn.Text = "Colors";
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // BackgroundColorBtn
            // 
            this.BackgroundColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackgroundColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundColorBtn.Image")));
            this.BackgroundColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackgroundColorBtn.Name = "BackgroundColorBtn";
            this.BackgroundColorBtn.Size = new System.Drawing.Size(23, 22);
            this.BackgroundColorBtn.Text = "BackgroundColorBtn";
            this.BackgroundColorBtn.Click += new System.EventHandler(this.BackgroundColorBtn_Click);
            // 
            // SizeBox
            // 
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(30, 25);
            // 
            // SizeBtn
            // 
            this.SizeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("SizeBtn.Image")));
            this.SizeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SizeBtn.Name = "SizeBtn";
            this.SizeBtn.Size = new System.Drawing.Size(23, 22);
            this.SizeBtn.Text = "SizeBtn";
            this.SizeBtn.Click += new System.EventHandler(this.SizeBtn_Click);
            // 
            // PenSizeBox
            // 
            this.PenSizeBox.Name = "PenSizeBox";
            this.PenSizeBox.Size = new System.Drawing.Size(30, 25);
            // 
            // ChangePenSize
            // 
            this.ChangePenSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChangePenSize.Image = ((System.Drawing.Image)(resources.GetObject("ChangePenSize.Image")));
            this.ChangePenSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangePenSize.Name = "ChangePenSize";
            this.ChangePenSize.Size = new System.Drawing.Size(23, 22);
            this.ChangePenSize.Text = "ChangePenSize";
            this.ChangePenSize.Click += new System.EventHandler(this.ChangePenSize_Click);
            // 
            // penColor
            // 
            this.penColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penColor.Image = ((System.Drawing.Image)(resources.GetObject("penColor.Image")));
            this.penColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penColor.Name = "penColor";
            this.penColor.Size = new System.Drawing.Size(23, 22);
            this.penColor.Text = "penColor";
            this.penColor.Click += new System.EventHandler(this.penColor_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(23, 22);
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoBtn.Image = ((System.Drawing.Image)(resources.GetObject("UndoBtn.Image")));
            this.UndoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(23, 22);
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // Help
            // 
            this.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(23, 22);
            this.Help.Text = "Help";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // penBackColor
            // 
            this.penBackColor.Location = new System.Drawing.Point(1276, 12);
            this.penBackColor.Name = "penBackColor";
            this.penBackColor.Size = new System.Drawing.Size(33, 23);
            this.penBackColor.TabIndex = 6;
            this.penBackColor.TabStop = false;
            // 
            // backGroundColor
            // 
            this.backGroundColor.Location = new System.Drawing.Point(1315, 12);
            this.backGroundColor.Name = "backGroundColor";
            this.backGroundColor.Size = new System.Drawing.Size(35, 23);
            this.backGroundColor.TabIndex = 7;
            this.backGroundColor.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.importImageToolStripMenuItem,
            this.exportImageToolStripMenuItem,
            this.openImageToFileToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 114);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elipseToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addToolStripMenuItem.Text = "New";
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.elipseToolStripMenuItem.Text = "Elipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // importImageToolStripMenuItem
            // 
            this.importImageToolStripMenuItem.Name = "importImageToolStripMenuItem";
            this.importImageToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.importImageToolStripMenuItem.Text = "Import Image";
            this.importImageToolStripMenuItem.Click += new System.EventHandler(this.importImageToolStripMenuItem_Click);
            // 
            // exportImageToolStripMenuItem
            // 
            this.exportImageToolStripMenuItem.Name = "exportImageToolStripMenuItem";
            this.exportImageToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exportImageToolStripMenuItem.Text = "Export Image";
            this.exportImageToolStripMenuItem.Click += new System.EventHandler(this.exportImageToolStripMenuItem_Click);
            // 
            // openImageToFileToolStripMenuItem
            // 
            this.openImageToFileToolStripMenuItem.Name = "openImageToFileToolStripMenuItem";
            this.openImageToFileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openImageToFileToolStripMenuItem.Text = "Open Image As File";
            this.openImageToFileToolStripMenuItem.Click += new System.EventHandler(this.openImageToFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 26);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // viewPort
            // 
            this.viewPort.ContextMenuStrip = this.contextMenuStrip1;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 49);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1362, 662);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 733);
            this.Controls.Add(this.backGroundColor);
            this.Controls.Add(this.penBackColor);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundColor)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton ElipseBtn;
        private System.Windows.Forms.ToolStripButton TriangleBtn;
        private System.Windows.Forms.ToolStripButton ColorBtn;
        private System.Windows.Forms.ToolStripButton SelectAllBtn;
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.Windows.Forms.ToolStripButton UndoBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton BackgroundColorBtn;
        private System.Windows.Forms.ToolStripTextBox SizeBox;
        private System.Windows.Forms.ToolStripButton SizeBtn;
        private System.Windows.Forms.ToolStripTextBox PenSizeBox;
        private System.Windows.Forms.ToolStripButton ChangePenSize;
        private System.Windows.Forms.ToolStripMenuItem openAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton UnSelect;
        private System.Windows.Forms.ToolStripButton Help;
        private System.Windows.Forms.PictureBox penBackColor;
        private System.Windows.Forms.PictureBox backGroundColor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton penColor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
