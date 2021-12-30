namespace CS_Tabbed_Text_Editor
{
    partial class OptionsDialogue
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
            System.Windows.Forms.Button cancelOperationButton;
            System.Windows.Forms.Button okButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialogue));
            this.tc = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.gbDynamic = new System.Windows.Forms.GroupBox();
            this.dynamicStatusBarToggle = new System.Windows.Forms.CheckBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbSearchEngine = new System.Windows.Forms.ComboBox();
            this.lblDefaultSearchEngine = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            cancelOperationButton = new System.Windows.Forms.Button();
            okButton = new System.Windows.Forms.Button();
            this.tc.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.gbDynamic.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelOperationButton
            // 
            cancelOperationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelOperationButton.Location = new System.Drawing.Point(313, 5);
            cancelOperationButton.Name = "cancelOperationButton";
            cancelOperationButton.Size = new System.Drawing.Size(75, 23);
            cancelOperationButton.TabIndex = 14;
            cancelOperationButton.Text = "Cancel";
            cancelOperationButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Location = new System.Drawing.Point(236, 5);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 13;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpGeneral);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(393, 334);
            this.tc.TabIndex = 15;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.gbDynamic);
            this.tpGeneral.Controls.Add(this.gbSearch);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(385, 308);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // gbDynamic
            // 
            this.gbDynamic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDynamic.Controls.Add(this.dynamicStatusBarToggle);
            this.gbDynamic.Location = new System.Drawing.Point(3, 63);
            this.gbDynamic.Name = "gbDynamic";
            this.gbDynamic.Size = new System.Drawing.Size(379, 44);
            this.gbDynamic.TabIndex = 20;
            this.gbDynamic.TabStop = false;
            this.gbDynamic.Text = "Dynamic Elements";
            // 
            // dynamicStatusBarToggle
            // 
            this.dynamicStatusBarToggle.AutoSize = true;
            this.dynamicStatusBarToggle.Location = new System.Drawing.Point(6, 19);
            this.dynamicStatusBarToggle.Name = "dynamicStatusBarToggle";
            this.dynamicStatusBarToggle.Size = new System.Drawing.Size(155, 17);
            this.dynamicStatusBarToggle.TabIndex = 19;
            this.dynamicStatusBarToggle.Text = "&Enable Dynamic Status Bar";
            this.dynamicStatusBarToggle.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.cbSearchEngine);
            this.gbSearch.Controls.Add(this.lblDefaultSearchEngine);
            this.gbSearch.Location = new System.Drawing.Point(3, 3);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(379, 61);
            this.gbSearch.TabIndex = 19;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Engine";
            // 
            // cbSearchEngine
            // 
            this.cbSearchEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchEngine.FormattingEnabled = true;
            this.cbSearchEngine.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "Yahoo"});
            this.cbSearchEngine.Location = new System.Drawing.Point(126, 23);
            this.cbSearchEngine.Name = "cbSearchEngine";
            this.cbSearchEngine.Size = new System.Drawing.Size(248, 21);
            this.cbSearchEngine.TabIndex = 1;
            // 
            // lblDefaultSearchEngine
            // 
            this.lblDefaultSearchEngine.AutoSize = true;
            this.lblDefaultSearchEngine.Location = new System.Drawing.Point(3, 26);
            this.lblDefaultSearchEngine.Name = "lblDefaultSearchEngine";
            this.lblDefaultSearchEngine.Size = new System.Drawing.Size(117, 13);
            this.lblDefaultSearchEngine.TabIndex = 0;
            this.lblDefaultSearchEngine.Text = "&Default Search Engine:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(cancelOperationButton);
            this.panel1.Controls.Add(okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 34);
            this.panel1.TabIndex = 16;
            // 
            // OptionsDialogue
            // 
            this.AcceptButton = okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelOperationButton;
            this.ClientSize = new System.Drawing.Size(393, 368);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialogue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDialogue_Load);
            this.tc.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.gbDynamic.ResumeLayout(false);
            this.gbDynamic.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ComboBox cbSearchEngine;
        private System.Windows.Forms.Label lblDefaultSearchEngine;
        private System.Windows.Forms.GroupBox gbDynamic;
        private System.Windows.Forms.CheckBox dynamicStatusBarToggle;
    }
}