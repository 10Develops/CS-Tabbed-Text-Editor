using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using CS_Tabbed_Text_Editor.Properties;
namespace CS_Tabbed_Text_Editor
{
    public partial class OptionsDialogue : Form
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="OptionsDialogue" /> class.
        /// </summary>
        public OptionsDialogue()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
        }

        #endregion

        #region Event Handlers
        private void OptionsDialogue_Load(object sender, EventArgs e)
        {
            // Load the current options
            dynamicStatusBarToggle.Checked = Settings.Default.ShowStatusBar;
            cbSearchEngine.SelectedIndex = Settings.Default.DefaultSearchEngine;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Save the new settings
            Settings.Default.EnableDynamicStatusBar = dynamicStatusBarToggle.Checked;
            Settings.Default.DefaultSearchEngine = cbSearchEngine.SelectedIndex;

            Settings.Default.Save();
            Close();
        }

        #endregion
    }
}
