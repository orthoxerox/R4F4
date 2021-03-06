﻿namespace R4F4
{
    partial class frmMain
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
            if (disposing && (components != null)) {
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.olvBindings = new BrightIdeasSoftware.ObjectListView();
            this.colGroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colKeyboard = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colMouse = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvBindings)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(912, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.miExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(155, 22);
            this.miOpen.Text = "&Open...";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Enabled = false;
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(155, 22);
            this.miSave.Text = "&Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Enabled = false;
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.miSaveAs.Size = new System.Drawing.Size(155, 22);
            this.miSaveAs.Text = "Save &As...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(155, 22);
            this.miExit.Text = "E&xit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAbout.Size = new System.Drawing.Size(135, 22);
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "CustomControlMap.txt";
            // 
            // dlgFolder
            // 
            this.dlgFolder.SelectedPath = "C:\\Program Files";
            this.dlgFolder.ShowNewFolderButton = false;
            // 
            // olvBindings
            // 
            this.olvBindings.AllColumns.Add(this.colGroup);
            this.olvBindings.AllColumns.Add(this.colAction);
            this.olvBindings.AllColumns.Add(this.colKeyboard);
            this.olvBindings.AllColumns.Add(this.colMouse);
            this.olvBindings.CellEditUseWholeCell = false;
            this.olvBindings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGroup,
            this.colAction,
            this.colKeyboard,
            this.colMouse});
            this.olvBindings.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvBindings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvBindings.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.olvBindings.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.olvBindings.Location = new System.Drawing.Point(0, 24);
            this.olvBindings.Name = "olvBindings";
            this.olvBindings.RowHeight = 32;
            this.olvBindings.Size = new System.Drawing.Size(912, 631);
            this.olvBindings.TabIndex = 1;
            this.olvBindings.UseCompatibleStateImageBehavior = false;
            this.olvBindings.View = System.Windows.Forms.View.Details;
            // 
            // colGroup
            // 
            this.colGroup.AspectName = "Group";
            this.colGroup.IsEditable = false;
            this.colGroup.IsVisible = false;
            this.colGroup.Text = "Group";
            // 
            // colAction
            // 
            this.colAction.AspectName = "Action";
            this.colAction.Groupable = false;
            this.colAction.Sortable = false;
            this.colAction.Text = "Action";
            this.colAction.Width = 120;
            // 
            // colKeyboard
            // 
            this.colKeyboard.AspectName = "";
            this.colKeyboard.Groupable = false;
            this.colKeyboard.IsButton = true;
            this.colKeyboard.Sortable = false;
            this.colKeyboard.Text = "Keyboard";
            this.colKeyboard.Width = 120;
            // 
            // colMouse
            // 
            this.colMouse.Sortable = false;
            this.colMouse.Text = "Mouse";
            this.colMouse.Width = 120;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 655);
            this.Controls.Add(this.olvBindings);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "R4F4";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvBindings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private BrightIdeasSoftware.ObjectListView olvBindings;
        private BrightIdeasSoftware.OLVColumn colGroup;
        private BrightIdeasSoftware.OLVColumn colAction;
        private BrightIdeasSoftware.OLVColumn colKeyboard;
        private BrightIdeasSoftware.OLVColumn colMouse;
    }
}

