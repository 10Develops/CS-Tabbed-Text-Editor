using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
namespace CS_Tabbed_Text_Editor
{
    public class RichTextBoxCore : RichTextBox
    {
        /// <summary>
        /// The path to the file that is currently in use.
        /// </summary>
        public string fileName;

        public EventHandler<EventArgs> StatusTextChanged;

        /// <summary>
        /// A value indicating whether the text of the text box has been changed or not.
        /// </summary>
        public bool textChanged;

        public RichTextBoxCore()
        {
            fileName = "Untitled";
            textChanged = false;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            textChanged = true;
        }

        private string _StatusText;
        public string StatusText
        {
            get
            {
                _StatusText = string.Format("length: {0} \t lines: {1} \t Sel: {2}", Text.Length, Lines.Length, SelectionLength);
                OnStatusTextChanged();
                return _StatusText;
            }
        }

        protected virtual void OnStatusTextChanged()
        {
            if (StatusTextChanged != null) StatusTextChanged(this, EventArgs.Empty);
        }
    }
}
