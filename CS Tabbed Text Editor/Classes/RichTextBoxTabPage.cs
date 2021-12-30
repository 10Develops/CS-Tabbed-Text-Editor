using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_Tabbed_Text_Editor
{
    /// <summary>
    /// A <b>TagPage</b> that displays a <b>WebBrowser</b> control.
    /// </summary>
    public class RichTextBoxTabPage : TabPage
    {
        #region Constants

        private const string BLANK_PAGE_TITLE = "(Blank)";

        #endregion

        #region Variables

        /// <summary>
        /// The <b>RichTextBox</b> control displayed on the page.
        /// </summary>
        private RichTextBoxCore _richTextBox;

        #endregion

        #region Properties

        /// <summary>
        /// Get the <b>RichTextBox</b> control displayed on the page.
        /// </summary>
        /// <value>
        /// A <b>WebBrowser</b> object.
        /// </value>
        public RichTextBoxCore TextBox
        {
            get
            {
                return this._richTextBox;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="RichTextBoxTabPage" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor creates and displays a new <b>RichTextBox</b> control.
        /// </remarks>
        public RichTextBoxTabPage() :
            this(new RichTextBoxCore())
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="WebBrowserTabPage" /> class and displays the specified <b>WebBrowser</b> control.
        /// </summary>
        /// <param name="browser">
        /// The <b>WebBrowser</b> control to display on the page.
        /// </param>
        public RichTextBoxTabPage(RichTextBoxCore richTextBox)
        {
            richTextBox.Dock = DockStyle.Fill;
            this.Controls.Add(richTextBox);
            this._richTextBox = richTextBox;
            Text = richTextBox.fileName;
        }

        #endregion

        #region Event Handlers

        #endregion

        #region Methods

        #endregion
    }
}