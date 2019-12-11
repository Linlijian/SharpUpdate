namespace SharpUpdate
{
    partial class SharpUpdateAcceptForm
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
            this.lblUpdateAvali = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdateAvali
            // 
            this.lblUpdateAvali.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblUpdateAvali.Location = new System.Drawing.Point(106, 8);
            this.lblUpdateAvali.Name = "lblUpdateAvali";
            this.lblUpdateAvali.Size = new System.Drawing.Size(228, 65);
            this.lblUpdateAvali.TabIndex = 2;
            this.lblUpdateAvali.Text = "An update is available! Would you like to update?";
            this.lblUpdateAvali.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SharpUpdate.Properties.Resources.cloud_upload_1;
            this.pictureBox.Location = new System.Drawing.Point(12, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(80, 80);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(143, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(97, 108);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(178, 108);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(259, 108);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // SharpUpdateAcceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 143);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUpdateAvali);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharpUpdateAcceptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblUpdateAvali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnDetail;
    }
}