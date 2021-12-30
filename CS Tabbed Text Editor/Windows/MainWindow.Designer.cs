//-----------------------------------------------------------------------
// <copyright file="MainWindow.Designer.cs" company="Company">
// Copyright (c) 2018 Julian and Patrick Gamauf. All rights reserved.
// </copyright>
// <summary>Represents the main window designer class.</summary>
// <author>Julian and Patrick Gamauf</author>
//-----------------------------------------------------------------------
namespace CS_Tabbed_Text_Editor
{
    /// <summary>
    /// Represents the main window designer class.
    /// </summary>
    public partial class MainWindow
    {

        /// <summary>
        /// The open a file dialog.
        /// </summary>
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        /// <summary>
        /// The save a file as dialog.
        /// </summary>
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        /// <summary>
        /// The change font dialog.
        /// </summary>
        private System.Windows.Forms.FontDialog fontDialog;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator toolbarSeparator1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showStatusBarTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.redoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.newTabButton = new System.Windows.Forms.ToolStripButton();
            this.closeTabButton = new System.Windows.Forms.ToolStripButton();
            this.hamburgerMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.datentimeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fontTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.updatesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printButton = new System.Windows.Forms.ToolStripButton();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.tabs = new CS_Tabbed_Text_Editor.RichTextBoxTabControl();
            this.addTabButton = new System.Windows.Forms.TabPage();
            toolbarSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlStatus.SuspendLayout();
            this.cms.SuspendLayout();
            this.cmsTabs.SuspendLayout();
            this.cmsGeneral.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarSeparator1
            // 
            toolbarSeparator1.Name = "toolbarSeparator1";
            toolbarSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt|Rich text format (*.rtf)|*.rtf|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt|Rich text format (*.rtf)|*.rtf|All files (*.*)|*.*";
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 475);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(685, 20);
            this.pnlStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(4, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStatusBarTSMI});
            this.cms.Name = "cms";
            this.cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cms.Size = new System.Drawing.Size(159, 26);
            // 
            // showStatusBarTSMI
            // 
            this.showStatusBarTSMI.Checked = true;
            this.showStatusBarTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStatusBarTSMI.Name = "showStatusBarTSMI";
            this.showStatusBarTSMI.Size = new System.Drawing.Size(158, 22);
            this.showStatusBarTSMI.Text = "Show Status Bar";
            this.showStatusBarTSMI.Click += new System.EventHandler(this.showStatusBarTSMI_Click);
            // 
            // cmsTabs
            // 
            this.cmsTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabTSMI,
            this.closeTabTSMI});
            this.cmsTabs.Name = "cmsTabs";
            this.cmsTabs.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsTabs.Size = new System.Drawing.Size(168, 48);
            // 
            // newTabTSMI
            // 
            this.newTabTSMI.Name = "newTabTSMI";
            this.newTabTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabTSMI.Size = new System.Drawing.Size(167, 22);
            this.newTabTSMI.Text = "New Tab";
            this.newTabTSMI.Click += new System.EventHandler(this.newTabTSMI_Click);
            // 
            // closeTabTSMI
            // 
            this.closeTabTSMI.Enabled = false;
            this.closeTabTSMI.Name = "closeTabTSMI";
            this.closeTabTSMI.Size = new System.Drawing.Size(167, 22);
            this.closeTabTSMI.Text = "Close Current Tab";
            this.closeTabTSMI.Click += new System.EventHandler(this.closeTabTSMI_Click);
            // 
            // cmsGeneral
            // 
            this.cmsGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoTSMI,
            this.redoTSMI,
            this.toolStripSeparator1,
            this.CutTSMI,
            this.CopyTSMI,
            this.PasteTSMI,
            this.DeleteTSMI,
            this.toolStripMenuItem6,
            this.selectAllTSMI,
            this.toolStripMenuItem1,
            this.SearchTSMI});
            this.cmsGeneral.Name = "cmsProperties";
            this.cmsGeneral.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsGeneral.Size = new System.Drawing.Size(123, 198);
            // 
            // undoTSMI
            // 
            this.undoTSMI.Enabled = false;
            this.undoTSMI.Name = "undoTSMI";
            this.undoTSMI.Size = new System.Drawing.Size(122, 22);
            this.undoTSMI.Text = "Undo";
            this.undoTSMI.Click += new System.EventHandler(this.undoTSMI_Click);
            // 
            // redoTSMI
            // 
            this.redoTSMI.Enabled = false;
            this.redoTSMI.Name = "redoTSMI";
            this.redoTSMI.Size = new System.Drawing.Size(122, 22);
            this.redoTSMI.Text = "Redo";
            this.redoTSMI.Click += new System.EventHandler(this.redoTSMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // CutTSMI
            // 
            this.CutTSMI.Enabled = false;
            this.CutTSMI.Name = "CutTSMI";
            this.CutTSMI.Size = new System.Drawing.Size(122, 22);
            this.CutTSMI.Text = "Cut";
            this.CutTSMI.Click += new System.EventHandler(this.CutTSMI_Click);
            // 
            // CopyTSMI
            // 
            this.CopyTSMI.Enabled = false;
            this.CopyTSMI.Name = "CopyTSMI";
            this.CopyTSMI.Size = new System.Drawing.Size(122, 22);
            this.CopyTSMI.Text = "Copy";
            this.CopyTSMI.Click += new System.EventHandler(this.CopyTSMI_Click);
            // 
            // PasteTSMI
            // 
            this.PasteTSMI.Enabled = false;
            this.PasteTSMI.Name = "PasteTSMI";
            this.PasteTSMI.Size = new System.Drawing.Size(122, 22);
            this.PasteTSMI.Text = "Paste";
            this.PasteTSMI.Click += new System.EventHandler(this.PasteTSMI_Click);
            // 
            // DeleteTSMI
            // 
            this.DeleteTSMI.Enabled = false;
            this.DeleteTSMI.Name = "DeleteTSMI";
            this.DeleteTSMI.Size = new System.Drawing.Size(122, 22);
            this.DeleteTSMI.Text = "Delete";
            this.DeleteTSMI.Click += new System.EventHandler(this.DeleteTSMI_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllTSMI
            // 
            this.selectAllTSMI.Name = "selectAllTSMI";
            this.selectAllTSMI.Size = new System.Drawing.Size(122, 22);
            this.selectAllTSMI.Text = "Select All";
            this.selectAllTSMI.Click += new System.EventHandler(this.selectAllTSMI_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // SearchTSMI
            // 
            this.SearchTSMI.Enabled = false;
            this.SearchTSMI.Name = "SearchTSMI";
            this.SearchTSMI.Size = new System.Drawing.Size(122, 22);
            this.SearchTSMI.Text = "Search";
            this.SearchTSMI.Click += new System.EventHandler(this.SearchTSMI_Click);
            // 
            // toolbar
            // 
            this.toolbar.ContextMenuStrip = this.cms;
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            toolbarSeparator1,
            this.newTabButton,
            this.closeTabButton,
            this.hamburgerMenuButton,
            this.toolStripSeparator2,
            this.printButton});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbar.Size = new System.Drawing.Size(685, 25);
            this.toolbar.TabIndex = 6;
            this.toolbar.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(23, 22);
            this.openButton.Text = "Open";
            this.openButton.ToolTipText = "Open (Ctrl+O)";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Enabled = false;
            this.saveButton.Image = global::CS_Tabbed_Text_Editor.Properties.Resources.saveFileMenuItem_Image;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.Text = "Save";
            this.saveButton.ToolTipText = "Save (Ctrl+S)";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newTabButton
            // 
            this.newTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTabButton.Image = global::CS_Tabbed_Text_Editor.Properties.Resources.newTabMenuItem_Image;
            this.newTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(23, 22);
            this.newTabButton.Text = "New Tab";
            this.newTabButton.ToolTipText = "New Tab (Ctrl+T)";
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // closeTabButton
            // 
            this.closeTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTabButton.Enabled = false;
            this.closeTabButton.Image = global::CS_Tabbed_Text_Editor.Properties.Resources.closeTabMenuItem_Image;
            this.closeTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(23, 22);
            this.closeTabButton.Text = "Close Tab";
            this.closeTabButton.ToolTipText = "Close Tab";
            this.closeTabButton.Click += new System.EventHandler(this.closeTabButton_Click);
            // 
            // hamburgerMenuButton
            // 
            this.hamburgerMenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.hamburgerMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hamburgerMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsTSMI,
            this.insertTSMI,
            this.fontTSMI,
            this.toolStripMenuItem3,
            this.updatesTSMI,
            this.tsmiOptions,
            this.aboutTSMI});
            this.hamburgerMenuButton.Image = global::CS_Tabbed_Text_Editor.Properties.Resources.hamburgerMenuItem_Image;
            this.hamburgerMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hamburgerMenuButton.Name = "hamburgerMenuButton";
            this.hamburgerMenuButton.Size = new System.Drawing.Size(29, 22);
            this.hamburgerMenuButton.Text = "More";
            // 
            // saveAsTSMI
            // 
            this.saveAsTSMI.Name = "saveAsTSMI";
            this.saveAsTSMI.Size = new System.Drawing.Size(180, 22);
            this.saveAsTSMI.Text = "Save As...";
            this.saveAsTSMI.Click += new System.EventHandler(this.saveAsTSMI_Click);
            // 
            // insertTSMI
            // 
            this.insertTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datentimeTSMI,
            this.filePathTSMI,
            this.fileNameTSMI});
            this.insertTSMI.Name = "insertTSMI";
            this.insertTSMI.Size = new System.Drawing.Size(180, 22);
            this.insertTSMI.Text = "Insert";
            // 
            // datentimeTSMI
            // 
            this.datentimeTSMI.Name = "datentimeTSMI";
            this.datentimeTSMI.Size = new System.Drawing.Size(150, 22);
            this.datentimeTSMI.Text = "Date and Time";
            this.datentimeTSMI.Click += new System.EventHandler(this.datentimeTSMI_Click);
            // 
            // filePathTSMI
            // 
            this.filePathTSMI.Enabled = false;
            this.filePathTSMI.Name = "filePathTSMI";
            this.filePathTSMI.Size = new System.Drawing.Size(150, 22);
            this.filePathTSMI.Text = "File path";
            this.filePathTSMI.Click += new System.EventHandler(this.filePathTSMI_Click);
            // 
            // fileNameTSMI
            // 
            this.fileNameTSMI.Enabled = false;
            this.fileNameTSMI.Name = "fileNameTSMI";
            this.fileNameTSMI.Size = new System.Drawing.Size(150, 22);
            this.fileNameTSMI.Text = "File name";
            this.fileNameTSMI.Click += new System.EventHandler(this.fileNameTSMI_Click);
            // 
            // fontTSMI
            // 
            this.fontTSMI.Name = "fontTSMI";
            this.fontTSMI.Size = new System.Drawing.Size(180, 22);
            this.fontTSMI.Text = "Font";
            this.fontTSMI.Click += new System.EventHandler(this.fontTSMI_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // updatesTSMI
            // 
            this.updatesTSMI.Name = "updatesTSMI";
            this.updatesTSMI.Size = new System.Drawing.Size(180, 22);
            this.updatesTSMI.Text = "Updates";
            this.updatesTSMI.Click += new System.EventHandler(this.updatesTSMI_Click);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(180, 22);
            this.tsmiOptions.Text = "Options";
            this.tsmiOptions.Click += new System.EventHandler(this.tsmiOptions_Click);
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(180, 22);
            this.aboutTSMI.Text = "About";
            this.aboutTSMI.Click += new System.EventHandler(this.aboutTSMI_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printButton
            // 
            this.printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printButton.Image = global::CS_Tabbed_Text_Editor.Properties.Resources.printMenuItem_Image;
            this.printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(23, 22);
            this.printButton.Text = "Print";
            this.printButton.ToolTipText = "Print (Ctrl+P)";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // tabs
            // 
            this.tabs.ContextMenuStrip = this.cmsTabs;
            this.tabs.Controls.Add(this.addTabButton);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ItemSize = new System.Drawing.Size(0, 24);
            this.tabs.Location = new System.Drawing.Point(0, 25);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(685, 450);
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            this.tabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabs_Selecting);
            this.tabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabs_MouseDown);
            // 
            // addTabButton
            // 
            this.addTabButton.Location = new System.Drawing.Point(4, 28);
            this.addTabButton.Name = "addTabButton";
            this.addTabButton.Padding = new System.Windows.Forms.Padding(3);
            this.addTabButton.Size = new System.Drawing.Size(677, 418);
            this.addTabButton.TabIndex = 0;
            this.addTabButton.Text = "  +";
            this.addTabButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 495);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.pnlStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Tabbed Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.cms.ResumeLayout(false);
            this.cmsTabs.ResumeLayout(false);
            this.cmsGeneral.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private RichTextBoxTabControl tabs;
        private System.Windows.Forms.TabPage addTabButton;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip cmsTabs;
        private System.Windows.Forms.ToolStripMenuItem newTabTSMI;
        private System.Windows.Forms.ToolStripMenuItem closeTabTSMI;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem showStatusBarTSMI;
        private System.Windows.Forms.ContextMenuStrip cmsGeneral;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem selectAllTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CutTSMI;
        private System.Windows.Forms.ToolStripMenuItem CopyTSMI;
        private System.Windows.Forms.ToolStripMenuItem PasteTSMI;
        private System.Windows.Forms.ToolStripMenuItem DeleteTSMI;
        private System.Windows.Forms.ToolStripMenuItem SearchTSMI;
        private System.Windows.Forms.ToolStripMenuItem undoTSMI;
        private System.Windows.Forms.ToolStripMenuItem redoTSMI;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton newTabButton;
        private System.Windows.Forms.ToolStripButton closeTabButton;
        private System.Windows.Forms.ToolStripDropDownButton hamburgerMenuButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsTSMI;
        private System.Windows.Forms.ToolStripMenuItem insertTSMI;
        private System.Windows.Forms.ToolStripMenuItem datentimeTSMI;
        private System.Windows.Forms.ToolStripMenuItem filePathTSMI;
        private System.Windows.Forms.ToolStripMenuItem fileNameTSMI;
        private System.Windows.Forms.ToolStripMenuItem fontTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updatesTSMI;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton printButton;
    }
}