namespace YoutubeMP3Downloader
{
    partial class NewDownloadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDownloadForm));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbLink = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbQuality = new MetroFramework.Controls.MetroComboBox();
            this.btnDownload = new MetroFramework.Controls.MetroButton();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.tbEncode = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(29, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Tag = "[link]";
            this.metroLabel1.Text = "Link:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLink
            // 
            this.tbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbLink.CustomButton.Image = null;
            this.tbLink.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.tbLink.CustomButton.Name = "";
            this.tbLink.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLink.CustomButton.TabIndex = 1;
            this.tbLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLink.CustomButton.UseSelectable = true;
            this.tbLink.CustomButton.Visible = false;
            this.tbLink.ForeColor = System.Drawing.Color.Black;
            this.tbLink.Lines = new string[0];
            this.tbLink.Location = new System.Drawing.Point(104, 73);
            this.tbLink.MaxLength = 32767;
            this.tbLink.Name = "tbLink";
            this.tbLink.PasswordChar = '\0';
            this.tbLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLink.SelectedText = "";
            this.tbLink.SelectionLength = 0;
            this.tbLink.SelectionStart = 0;
            this.tbLink.ShortcutsEnabled = true;
            this.tbLink.Size = new System.Drawing.Size(490, 23);
            this.tbLink.TabIndex = 1;
            this.tbLink.UseSelectable = true;
            this.tbLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbLink.TextChanged += new System.EventHandler(this.tbLink_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(29, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 23);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Tag = "[quality]";
            this.metroLabel2.Text = "Quality:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbQuality
            // 
            this.cbQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuality.Enabled = false;
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.ItemHeight = 23;
            this.cbQuality.Location = new System.Drawing.Point(104, 111);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(490, 29);
            this.cbQuality.TabIndex = 4;
            this.cbQuality.UseSelectable = true;
            this.cbQuality.SelectedIndexChanged += new System.EventHandler(this.cbQuality_SelectedIndexChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(491, 165);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(103, 39);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Tag = "[download]";
            this.btnDownload.Text = "Download";
            this.btnDownload.UseSelectable = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tip
            // 
            this.tip.IsBalloon = true;
            // 
            // tbEncode
            // 
            this.tbEncode.AutoSize = true;
            this.tbEncode.Checked = true;
            this.tbEncode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbEncode.Location = new System.Drawing.Point(324, 177);
            this.tbEncode.Name = "tbEncode";
            this.tbEncode.Size = new System.Drawing.Size(80, 17);
            this.tbEncode.TabIndex = 6;
            this.tbEncode.Text = "On";
            this.tbEncode.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(194, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 23);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Tag = "[encToMp3]";
            this.metroLabel3.Text = "Encode to mp3:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 240);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbEncode);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.cbQuality);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewDownloadForm";
            this.ShowInTaskbar = false;
            this.Tag = "[newDownloadTitle]";
            this.Text = "Download video";
            this.Load += new System.EventHandler(this.NewDownloadForm_Load);
            this.Enter += new System.EventHandler(this.NewDownloadForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox tbLink;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbQuality;
        private MetroFramework.Controls.MetroButton btnDownload;
        private System.Windows.Forms.ToolTip tip;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle tbEncode;
    }
}