using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;
namespace CS_Tabbed_Text_Editor
{
    /// <summary>
    /// A <b>TabControl</b> designed to display <see cref="RichTextBoxTabPage" /> objects.
    /// </summary>
    public class RichTextBoxTabControl : TabControl
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        #region Properties

        public RichTextBoxTabControl()
        {
            DrawMode = TabDrawMode.Normal;
        }

        /// <summary>
        /// Gets the currently selected tab page.
        /// </summary>
        /// <value>
        /// The <see cref="RichTextBoxTabPage" /> that is currently selected.
        /// </value>
        public RichTextBoxTabPage SelectedRichTextBoxTabPage
        {
            get
            {
                return (RichTextBoxTabPage)this.SelectedTab;
            }
        }

        /// <summary>
        /// Gets the currently selected web browser.
        /// </summary>
        /// <value>
        /// The <b>RichTextBox</b> control on the currently selected tab page.
        /// </value>
        public RichTextBoxCore SelectedRichTextBox
        {
            get
            {
                return this.SelectedRichTextBoxTabPage.TextBox;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a new, empty page to the tab control.
        /// </summary>
        /// <returns> 
        /// The <see cref="RichTextBoxTabPage" /> that was added.
        /// </returns>
        public RichTextBoxTabPage AddTab()
        {
            RichTextBoxTabPage tab = new RichTextBoxTabPage();
            if (TabCount == 0)
            {
                TabPages.Insert(TabCount, tab);
            }
            else
            {
                TabPages.Insert(TabCount - 1, tab);
            }
            this.SelectedTab = tab;
            return tab;
        }

        /// <summary>
        /// Removes the currently selected tab from the tab control.
        /// </summary>
        /// <returns>
        /// <b>True</b> if the current tab was removed; otherwise, <b>False</b>.
        /// </returns>
        /// <remarks>
        /// There must always be at least one tab so the last tab cannot be removed.
        /// </remarks>
        public bool RemoveCurrentTab()
        {
            bool canRemove = this.TabCount > 2;

            if (canRemove)
            {
                RichTextBoxTabPage tab = this.SelectedRichTextBoxTabPage;
                this.TabPages.Remove(tab);
                tab.Dispose();
            }

            return canRemove;
        }

        #endregion

        protected override void OnHandleCreated(EventArgs e)
        {
            SendMessage(Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)30);
            base.OnHandleCreated(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 10, e.Bounds.Top + 6);
            e.Graphics.DrawString(this.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top + 6);
            e.DrawFocusRectangle();

        }
    }
}