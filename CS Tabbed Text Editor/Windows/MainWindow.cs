//-----------------------------------------------------------------------
// <copyright file="MainWindow.cs" company="Company">
// Copyright (c) 2018 Julian and Patrick Gamauf. All rights reserved.
// </copyright>
// <summary>Represents the main window class.</summary>
// <author>Julian and Patrick Gamauf</author>
//-----------------------------------------------------------------------
namespace CS_Tabbed_Text_Editor
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// Represents the main window class.
    /// </summary>
    public partial class MainWindow : Form
    {
        #region Variables

        public RichTextBoxCore currentTextBox;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            this.KeyPreview = true;
        }

        #endregion

        #region Event Handlers

        private void MainWindow_Load(object sender, EventArgs e)
        {
            NewTab();

            if (Properties.Settings.Default.Width != 0)
            {
                Width = Properties.Settings.Default.Width;
            }

            if (Properties.Settings.Default.Height != 0)
            {
                Height = Properties.Settings.Default.Height;
            }

            if (Properties.Settings.Default.WindowState == 0)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (Properties.Settings.Default.WindowState == 2)
            {
                WindowState = FormWindowState.Maximized;
            }

            currentTextBox.Font = fontDialog.Font = Properties.Settings.Default.Font;


            showStatusBarTSMI.Checked = Properties.Settings.Default.ShowStatusBar;
            pnlStatus.Visible = Properties.Settings.Default.ShowStatusBar;

            this.OpenFileAtStartUp();
        }

        /// <summary>
        /// Checks if a keyboard shortcut is used.
        /// When a known keyboard shortcut is entered, the corresponding command is executed.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="k">The event arguments.</param>
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                this.OpenFile();
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                this.SaveFile(false);
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                this.SaveFile(true);
            }

            if (e.Control && e.KeyCode == Keys.F)
            {
                if (this.fontDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (TabPage tab in tabs.TabPages)
                    {
                        if (tab != addTabButton)
                        {
                            RichTextBoxCore rtb = ((RichTextBoxTabPage)tab).TextBox;

                            if (Path.GetExtension(rtb.fileName) != ".rtf")
                                rtb.Font = this.fontDialog.Font;
                        }
                    }
                }
            }

            if (e.Control && e.KeyCode == Keys.P)
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TabPage tabPage in tabs.TabPages)
            {
                if (tabPage != addTabButton && ((RichTextBoxTabPage)tabPage).TextBox.textChanged == true)
                {
                    DialogResult askIfSave = MessageBox.Show("There are some unsaved files. Do you want to close the program without saving them?", 
                        "CS Tabbed Text Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (askIfSave == DialogResult.No)
                    {
                        e.Cancel = true;
                    }

                    break;
                }
            }

            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;

            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.WindowState = 0;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                Properties.Settings.Default.WindowState = 0;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.WindowState = 2;
            }

            Properties.Settings.Default.Font = fontDialog.Font;

            Properties.Settings.Default.Save();
        }

        private void showStatusBarTSMI_Click(object sender, EventArgs e)
        {
            showStatusBarTSMI.Checked = !showStatusBarTSMI.Checked;
            pnlStatus.Visible = showStatusBarTSMI.Checked;
            Properties.Settings.Default.ShowStatusBar = showStatusBarTSMI.Checked;
        }

        private void newTabTSMI_Click(object sender, EventArgs e)
        {
            newTabButton.PerformClick();
        }

        private void closeTabTSMI_Click(object sender, EventArgs e)
        {
            closeTabButton.PerformClick();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.currentTextBox.Text, this.currentTextBox.Font, Brushes.Black, 10, 25);
        }

        #endregion

        #region Toolbar Event Handlers

        /// <summary>
        /// Adds a tab that allows the user to create a new file.
        /// Is called by the corresponding menu item or by a keyboard shortcut.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void newTabButton_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            DialogResult askIfSave = DialogResult.None;

            if (currentTextBox.textChanged == true)
            {
                askIfSave = MessageBox.Show("Do you want to save the changes?", "CS Tabbed Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }

            if (askIfSave == DialogResult.Yes)
            {
                this.SaveFile(false);
            }

            if (askIfSave != DialogResult.Cancel)
            {
                tabs.RemoveCurrentTab();
            }
        }

        /// <summary>
        /// Starts a dialog that allows the user to open a file.
        /// Is called by the corresponding menu item or by a keyboard shortcut.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void openButton_Click(object sender, EventArgs e)
        {
            this.OpenFile();
        }

        /// <summary>
        /// Calls the save file method.
        /// Is called by the corresponding menu item or by a keyboard shortcut.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            this.SaveFile(false);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        #endregion

        #region Drop Down Manu Event Handlers

        /// <summary>
        /// Calls the save file method.
        /// Is called by the corresponding menu item or by a keyboard shortcut.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void saveAsTSMI_Click(object sender, EventArgs e)
        {
            this.SaveFile(true);
        }

        private void datentimeTSMI_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            currentTextBox.SelectedText = string.Format("{0} {1}", dateTime.ToShortTimeString(), dateTime.ToShortDateString());
        }

        private void filePathTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.SelectedText = Path.GetDirectoryName(currentTextBox.fileName);
        }

        private void fileNameTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.SelectedText = Path.GetFileName(currentTextBox.fileName);
        }

        /// <summary>
        /// Starts a dialog that allows the user to change the font, font style and font size of the text box.
        /// Is called by the corresponding menu item or by a keyboard shortcut.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void fontTSMI_Click(object sender, EventArgs e)
        {
            if (this.fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(TabPage tab in tabs.TabPages)
                {
                    if (tab != addTabButton)
                    {
                        RichTextBoxCore rtb = ((RichTextBoxTabPage)tab).TextBox;

                        if(Path.GetExtension(rtb.fileName) != ".rtf")
                        rtb.Font = this.fontDialog.Font;
                    }
                }
            }
        }

        private void updatesTSMI_Click(object sender, EventArgs e)
        {
            UpdatesForm updatesForm = new UpdatesForm();
            updatesForm.Show();
        }

        private void tsmiOptions_Click(object sender, EventArgs e)
        {
            using (OptionsDialogue dialogue = new OptionsDialogue())
            {
                dialogue.ShowDialog();
            }
        }

        /// <summary>
        /// Opens a window with information about the project.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void aboutTSMI_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        #endregion

        #region Context Manu Event Handlers

        private void undoTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.Undo();
        }

        private void redoTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.Redo();
        }

        private void CutTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.Cut();
        }

        private void CopyTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.Copy();
        }

        private void PasteTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.Paste();
        }

        private void DeleteTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.SelectedText = string.Empty;
        }

        private void selectAllTSMI_Click(object sender, EventArgs e)
        {
            currentTextBox.SelectAll();
            currentTextBox.Focus();
        }

        private void SearchTSMI_Click(object sender, EventArgs e)
        {
            SearchInTheWeb(currentTextBox.SelectedText);
        }

        #endregion

        #region Tab Control Event Handlers

        private void tabs_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabs.TabCount - 1;
            if (this.tabs.GetTabRect(lastIndex).Contains(e.Location))
            {
                NewTab();
            }
        }

        private void tabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabs.TabCount - 1)
                e.Cancel = true;
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentTextBox = tabs.SelectedRichTextBox;
            this.DisplayFileTitle();

            currentTextBox.Focus();

            // Enable the Close Tab command if and only if there is more than one tab.
            if (this.tabs.TabCount == 2)
            {
                this.closeTabButton.Enabled = false;
                closeTabTSMI.Enabled = false;
            }
            else
            {
                this.closeTabButton.Enabled = true;
                closeTabTSMI.Enabled = true;
            }

            saveButton.Enabled = currentTextBox.textChanged;

            filePathTSMI.Enabled = fileNameTSMI.Enabled = Path.GetDirectoryName(currentTextBox.fileName) != "";
            Debug.WriteLine(Path.GetExtension(currentTextBox.fileName));
            if (Path.GetExtension(currentTextBox.fileName) != ".rtf")
            {
                this.currentTextBox.Font = this.fontDialog.Font;
            }

            undoTSMI.Enabled = currentTextBox.CanUndo;
            redoTSMI.Enabled = currentTextBox.CanRedo;
            CutTSMI.Enabled = CopyTSMI.Enabled = DeleteTSMI.Enabled = SearchTSMI.Enabled = currentTextBox.SelectedText.Length > 0;
            PasteTSMI.Enabled = currentTextBox.CanPaste(DataFormats.GetFormat(DataFormats.Text));

            lblStatus.Text = currentTextBox.StatusText;
        }

        #endregion

        #region Text Box Event Handlers

        private void currentTextBox_SelectionChanged(object sender, EventArgs e)
        {
            lblStatus.Text = currentTextBox.StatusText;
            pnlStatus.Visible = Properties.Settings.Default.ShowStatusBar;

            CutTSMI.Enabled = CopyTSMI.Enabled = DeleteTSMI.Enabled = SearchTSMI.Enabled = currentTextBox.SelectedText.Length > 0;
            PasteTSMI.Enabled = currentTextBox.CanPaste(DataFormats.GetFormat(DataFormats.Text));
        }

        private void currentTextBox_TextChanged(object sender, EventArgs e)
        {
            currentTextBox.textChanged = true;
            saveButton.Enabled = currentTextBox.textChanged;

            lblStatus.Text = currentTextBox.StatusText;
            pnlStatus.Visible = Properties.Settings.Default.ShowStatusBar;

            undoTSMI.Enabled = currentTextBox.CanUndo;
            redoTSMI.Enabled = currentTextBox.CanRedo;

            DisplayFileTitle();
        }

        private void currentTextBox_LostFocus(object sender, EventArgs e)
        {
            // Display the current page's status text in the status bar.
            if (Properties.Settings.Default.EnableDynamicStatusBar == true)
            {
                pnlStatus.Visible = Properties.Settings.Default.ShowStatusBar;
            }
        }

        private void currentTextBox_GotFocus(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EnableDynamicStatusBar == true)
            {
                pnlStatus.Visible = false;
            }
        }

        private void currentTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EnableDynamicStatusBar == true)
            {
                pnlStatus.Visible = Properties.Settings.Default.ShowStatusBar;
            }
        }

        private void currentTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EnableDynamicStatusBar == true)
            {
                pnlStatus.Visible = false;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Displays the current page title in the title bar.
        /// </summary>
        /// <remarks>
        /// Only the application name is displayed if no document is loaded.
        /// </remarks>
        private void DisplayFileTitle()
        {
            string documentTitle = Path.GetFileName(this.currentTextBox.fileName);

            if (documentTitle == "Untitled")
            {
                this.Text = Application.ProductName;
            }
            else
            {
                // Display the current page title in the window's title bar.
                if (!currentTextBox.textChanged)
                {
                    this.Text = String.Format("{0} - {1}", documentTitle, Application.ProductName);
                }
                else
                {
                    this.Text = String.Format("{0}* - {1}", documentTitle, Application.ProductName);
                }
            }
        }

        private void NewTab()
        {
            tabs.AddTab();
            this.currentTextBox = this.tabs.SelectedRichTextBox;
            currentTextBox.TextChanged += currentTextBox_TextChanged;
            currentTextBox.SelectionChanged += currentTextBox_SelectionChanged;
            currentTextBox.MouseEnter += currentTextBox_MouseEnter;
            currentTextBox.MouseLeave += currentTextBox_MouseLeave;
            currentTextBox.GotFocus += currentTextBox_GotFocus;
            currentTextBox.LostFocus += currentTextBox_LostFocus;
            currentTextBox.ContextMenuStrip = cmsGeneral;
            lblStatus.Text = currentTextBox.StatusText;
        }

        /// <summary>
        /// Opens a file and loads its contents in the text box.
        /// </summary>
        private void OpenFile()
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(this.openFileDialog.FileName);
                this.openFileDialog.FileName = string.Empty;
            }
        }

        private void OpenFile(string file)
        {
            try
            {
                if (currentTextBox.textChanged == true)
                {
                    NewTab();
                }

                if (this.CheckIfFileIsRtf(file) == true)
                {
                    this.currentTextBox.LoadFile(file, RichTextBoxStreamType.RichText);

                    // Sets the font of the richtextbox to the font of the .rtf file.
                    this.currentTextBox.HideSelection = true;
                    this.currentTextBox.SelectAll();
                    this.currentTextBox.Font = this.currentTextBox.SelectionFont;
                    this.currentTextBox.Select(this.currentTextBox.Text.Length, this.currentTextBox.Text.Length);
                    this.currentTextBox.HideSelection = false;
                }
                else
                {
                    this.currentTextBox.LoadFile(file, RichTextBoxStreamType.PlainText);
                }

                currentTextBox.textChanged = false;
                currentTextBox.fileName = file;

                DisplayFileTitle();
                saveButton.Enabled = currentTextBox.textChanged;

                tabs.SelectedRichTextBoxTabPage.Text = this.GetFileName(file);

                lblStatus.Text = currentTextBox.StatusText;

                filePathTSMI.Enabled = fileNameTSMI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("An error occured! The file couldn't be opened!", "CS Tabbed Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Check if there is a file that need to be opened when the program starts. 
        /// If yes, the file will be opened.
        /// </summary>
        private void OpenFileAtStartUp()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args != null && args.Length == 2)
            {
                this.OpenFile(args[1]);
            }
        }

        /// <summary>
        /// Saves the content of the text box to a file.
        /// </summary>
        /// <param name="saveAs">A value indicating if it is sure that the user wants to use the save as function.</param>
        private void SaveFile(bool saveAs)
        {
            DialogResult askIfSave = DialogResult.None;

            if (currentTextBox.fileName == "Untitled" || saveAs == true)
            {
                saveFileDialog.FileName = "File " + (tabs.SelectedIndex + 1);
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentTextBox.fileName = this.saveFileDialog.FileName;
                    tabs.SelectedRichTextBoxTabPage.Text = this.GetFileName(currentTextBox.fileName);

                    filePathTSMI.Enabled = fileNameTSMI.Enabled = true;
                }
                else
                {
                    askIfSave = DialogResult.Cancel;
                }
            }

            if (askIfSave != DialogResult.Cancel)
            {
                try
                {
                    if (this.CheckIfFileIsRtf(currentTextBox.fileName) == true)
                    {
                        this.currentTextBox.SaveFile(currentTextBox.fileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        this.currentTextBox.SaveFile(currentTextBox.fileName, RichTextBoxStreamType.PlainText);
                    }

                    currentTextBox.textChanged = false;
                    saveButton.Enabled = currentTextBox.textChanged;
                }
                catch
                {
                    MessageBox.Show("An error occured! The changes couldn't be saved!", "CS Tabbed Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

            DisplayFileTitle();

            this.saveFileDialog.FileName = string.Empty;
        }

        /// <summary>
        /// Gets the file name of a file path.
        /// </summary>
        /// <param name="path">The path of a file.</param>
        /// <returns>The name of the file.</returns>
        private string GetFileName(string path)
        {
            string[] pathArray = path.Split('\\');
            return pathArray[pathArray.Length - 1];
        }

        /// <summary>
        /// Checks if a file uses the rich text format.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        /// <returns>A value indicating whether file uses the rich text format or not.</returns>
        private bool CheckIfFileIsRtf(string path)
        {
            string[] pathArray = path.Split('.');

            if (pathArray[pathArray.Length - 1] == "rtf")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SearchInTheWeb(string text)
        {
            var SearchEngine = Properties.Settings.Default.DefaultSearchEngine;
            if (SearchEngine == 0)
            {
                Process.Start("https://www.google.com/search?q=" + text);
            }
            else if (SearchEngine == 1)
            {
                Process.Start("https://www.bing.com/search?q=" + text);

            }
            else if (SearchEngine == 2)
            {
                Process.Start("https://search.yahoo.com/search?p=" + text);
            }
        }

        #endregion
    }
}
