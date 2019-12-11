using System;
using System.Windows.Forms;

namespace SharpUpdate
{
    internal partial class SharpUpdateAcceptForm : Form
    {
        private ISharpUpdatable applicationInfo;
        private SharpUpdateXml updateInfo;
        private SharpUpdateFornInfo updateInfoForm;

        internal SharpUpdateAcceptForm()
        {
            InitializeComponent();

            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;

            this.Text = this.applicationInfo.ApplicationName+ " - Update Available";

            if (this.applicationInfo.ApplicationIcon != null)
                this.Icon = this.applicationInfo.ApplicationIcon;

            this.lblUpdateAvali.Text = string.Format("New Version: {0}", this.updateInfo.Version.ToString());
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (updateInfoForm == null)
                this.updateInfoForm = new SharpUpdateFornInfo(this.applicationInfo, this.updateInfo);

            this.updateInfoForm.ShowDialog(this);
        }
    }
}
