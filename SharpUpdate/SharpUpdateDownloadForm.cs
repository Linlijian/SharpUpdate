using System;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using SharpUpdate;

namespace SharpUpdate
{
    public partial class SharpUpdateDownloadForm : Form
    {
        private WebClient webClient;
        private BackgroundWorker bgWorker;
        private string tempfile;
        private string md5;
        internal string TempFilePath
        {
            get { return this.tempfile; }
        }

        public SharpUpdateDownloadForm(Uri location, string md5, Icon programTcon)
        {
            InitializeComponent();

            if (programTcon != null)
                this.Icon = programTcon;

            tempfile = Path.GetTempFileName();

            this.md5 = md5;

            webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChecnged);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);

            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);

            try { webClient.DownloadFileAsync(location, this.tempfile); }
            catch { this.DialogResult = DialogResult.No; this.Close(); }
        }

        private void webClient_DownloadProgressChecnged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
            this.lblProgress.Text = string.Format("Download {0} of {1}", e.BytesReceived, e.TotalBytesToReceive);
        }

        private string FormatByte(long bytes, int decimalPlaces, bool showByteType)
        {
            double newByte = bytes;
            string FormatString = "{0";
            string byteType = "B";

            if (newByte > 1024 && newByte < 1048576)
            {
                newByte /= 1024;
                byteType = "KB";
            }
            else if (newByte > 1048576 && newByte < 1073741824)
            {
                newByte /= 1048576;
                byteType = "MB";
            }
            else
            {
                newByte /= 1073741824;
                byteType = "GB";
            }

            if (decimalPlaces > 0)
                FormatString += ":0.";

            for (int i = 0; i < decimalPlaces; i++)
                FormatString += "0";

            FormatString += "}";

            if (showByteType)
                FormatString += byteType;

            return string.Format(FormatString, newByte);
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            else if (e.Cancelled)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            else
            {
                lblProgress.Text = "Verifying Download...";
                progressBar.Style = ProgressBarStyle.Marquee;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = (DialogResult)e.Result;
            this.Close();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string file = ((string[])e.Argument)[0];
            string updateMd5 = ((string[])e.Argument)[1];

            if (Hasher.Hashfile(file, HashType.MD5) != updateMd5)
                e.Result = DialogResult.No;
            else
                e.Result = DialogResult.OK;
        }

        private void SharpUpdateDownloadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (webClient.IsBusy)
            {
                webClient.CancelAsync();
                this.DialogResult = DialogResult.Abort;
            }

            if (bgWorker.IsBusy)
            {
                bgWorker.CancelAsync();
                this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
