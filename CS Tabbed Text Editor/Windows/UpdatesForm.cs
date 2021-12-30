using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
namespace CS_Tabbed_Text_Editor
{
    public partial class UpdatesForm : Form
    {
        public UpdatesForm()
        {
            InitializeComponent();
        }

        string currentVersion;
        string newVersion;

        string currentFileName;
        string newFileName;

        Uri versionUrl = new Uri("https://www.dropbox.com/s/i8vacmyllvxgcai/New-Version.txt?dl=1");        
        Uri fileUrl = new Uri("https://www.dropbox.com/s/g4o7zvnesnmvb3z/Editor.exe?dl=1");

        WebClient webClient;

        private void UpdatesForm_Load(object sender, EventArgs e)
        {
            getCurrentVersion();
        }

        private void getCurrentVersion()
        {
            currentVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
            lblCurrentVersion.Text = string.Format("Current Version: {0}", currentVersion);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            getNewVersion();

            if (currentVersion.CompareTo(newVersion) < 0)
            {
                if (MessageBox.Show("New version is available. Do you want to download it?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    downloadUpdates();
                }
                else
                {
                    lblPercent.Visible = true;
                    lblPercent.Text = "Update is cancelled";
                }
            }
            else
            {
                lblPercent.Visible = true;
                lblPercent.Text = "Program is up to date";
            }
        }

        private void getNewVersion()
        {
            webClient = new WebClient();
            newVersion = webClient.DownloadString(versionUrl).Trim();
            lblNewVersion.Text = string.Format("New Version: {0}", newVersion);
        }

        private void downloadUpdates()
        {
            currentFileName = getFileName();
            newFileName = "new." + currentFileName;

            webClient = new WebClient();
            webClient.DownloadFileAsync(fileUrl, newFileName);
            webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            lblPercent.Visible = true;
        }

        private string getFileName()
        {
            string fullname = Application.ExecutablePath;
            string[] split = { "\\" };
            string[] parts = fullname.Split(split, StringSplitOptions.None);

            if (parts.Length > 0)
                return parts[parts.Length - 1]; 
            return "";
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblPercent.Text = "Update Cancelled";
            }
            else
            {
                replaceFile();
                lblPercent.Text = "Update Completed";
                if (MessageBox.Show("Update is completed. Do you want to restart program for apply update?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(Application.ExecutablePath); // to start new instance of application
                    Application.Exit(); //to turn off current app
                }
            }
        }

        private void replaceFile()
        {
            int loop = 10; // Количество попыток 
            while (--loop > 0 && File.Exists(newFileName))
                try
                {
                    File.Replace(newFileName, currentFileName, currentFileName + ".bac");
                }
                catch
                {
                    Thread.Sleep(200);
                }
        }

        private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblPercent.Text = string.Format("{0} %", e.ProgressPercentage);
            pbUpdate.Value = e.ProgressPercentage;

            lblSize.Visible = true;
            lblSize.Text = BytesToString(e.TotalBytesToReceive);

            lblReceived.Visible = true;
            lblReceived.Text = BytesToString(e.BytesReceived);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }
}