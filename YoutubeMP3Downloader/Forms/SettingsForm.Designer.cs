namespace YoutubeMP3Downloader
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbStyle = new MetroFramework.Controls.MetroComboBox();
            this.cbColor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLanguage = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnBrowseDownloads = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tbDownload = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lnkDev = new MetroFramework.Controls.MetroLink();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lnkMetroUI = new MetroFramework.Controls.MetroLink();
            this.lnkYtEx = new MetroFramework.Controls.MetroLink();
            this.lnkFF = new MetroFramework.Controls.MetroLink();
            this.lblVer = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.Location = new System.Drawing.Point(44, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Tag = "[style]";
            this.metroLabel1.Text = "Style:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.Location = new System.Drawing.Point(44, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Tag = "[color]";
            this.metroLabel2.Text = "Color:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbStyle
            // 
            this.cbStyle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.ItemHeight = 23;
            this.cbStyle.Location = new System.Drawing.Point(169, 67);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(138, 29);
            this.cbStyle.TabIndex = 2;
            this.cbStyle.UseSelectable = true;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // cbColor
            // 
            this.cbColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.ItemHeight = 23;
            this.cbColor.Location = new System.Drawing.Point(169, 109);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(138, 29);
            this.cbColor.TabIndex = 3;
            this.cbColor.UseSelectable = true;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.Location = new System.Drawing.Point(23, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(419, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Tag = "[defaultDownloadFolder]";
            this.metroLabel3.Text = "Default download folder:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(23, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(23, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 1);
            this.panel2.TabIndex = 9;
            // 
            // cbLanguage
            // 
            this.cbLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.ItemHeight = 23;
            this.cbLanguage.Location = new System.Drawing.Point(169, 267);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(138, 29);
            this.cbLanguage.TabIndex = 11;
            this.cbLanguage.UseSelectable = true;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.Location = new System.Drawing.Point(44, 272);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Tag = "[language]";
            this.metroLabel4.Text = "Language:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(330, 408);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 31);
            this.btnSave.TabIndex = 12;
            this.btnSave.Tag = "[OK]";
            this.btnSave.Text = "OK";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowseDownloads
            // 
            this.btnBrowseDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloads.Location = new System.Drawing.Point(354, 205);
            this.btnBrowseDownloads.Name = "btnBrowseDownloads";
            this.btnBrowseDownloads.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDownloads.TabIndex = 7;
            this.btnBrowseDownloads.Text = "Browse";
            this.btnBrowseDownloads.UseSelectable = true;
            this.btnBrowseDownloads.Click += new System.EventHandler(this.btnBrowseDownloads_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // tbDownload
            // 
            this.tbDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbDownload.CustomButton.Image = null;
            this.tbDownload.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.tbDownload.CustomButton.Name = "";
            this.tbDownload.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDownload.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDownload.CustomButton.TabIndex = 1;
            this.tbDownload.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDownload.CustomButton.UseSelectable = true;
            this.tbDownload.CustomButton.Visible = false;
            this.tbDownload.Lines = new string[] {
        "metroTextBox1"};
            this.tbDownload.Location = new System.Drawing.Point(41, 205);
            this.tbDownload.MaxLength = 32767;
            this.tbDownload.Name = "tbDownload";
            this.tbDownload.PasswordChar = '\0';
            this.tbDownload.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDownload.SelectedText = "";
            this.tbDownload.SelectionLength = 0;
            this.tbDownload.SelectionStart = 0;
            this.tbDownload.ShortcutsEnabled = true;
            this.tbDownload.Size = new System.Drawing.Size(320, 23);
            this.tbDownload.TabIndex = 13;
            this.tbDownload.Text = "metroTextBox1";
            this.tbDownload.UseSelectable = true;
            this.tbDownload.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDownload.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(23, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 1);
            this.panel3.TabIndex = 14;
            // 
            // lnkDev
            // 
            this.lnkDev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDev.Location = new System.Drawing.Point(41, 327);
            this.lnkDev.Name = "lnkDev";
            this.lnkDev.Size = new System.Drawing.Size(401, 23);
            this.lnkDev.TabIndex = 15;
            this.lnkDev.Tag = "[devBy]";
            this.lnkDev.Text = "devby";
            this.lnkDev.UseSelectable = true;
            this.lnkDev.Click += new System.EventHandler(this.lnkDev_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lnkFF, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lnkYtEx, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnkMetroUI, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 356);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 46);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.metroLabel5, 3);
            this.metroLabel5.Location = new System.Drawing.Point(3, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(395, 23);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Tag = "[uses]";
            this.metroLabel5.Text = "Uses:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkMetroUI
            // 
            this.lnkMetroUI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkMetroUI.Location = new System.Drawing.Point(3, 26);
            this.lnkMetroUI.Name = "lnkMetroUI";
            this.lnkMetroUI.Size = new System.Drawing.Size(127, 17);
            this.lnkMetroUI.TabIndex = 1;
            this.lnkMetroUI.Text = "Metro UI";
            this.lnkMetroUI.UseSelectable = true;
            this.lnkMetroUI.Click += new System.EventHandler(this.lnkMetroUI_Click);
            // 
            // lnkYtEx
            // 
            this.lnkYtEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkYtEx.Location = new System.Drawing.Point(136, 26);
            this.lnkYtEx.Name = "lnkYtEx";
            this.lnkYtEx.Size = new System.Drawing.Size(127, 17);
            this.lnkYtEx.TabIndex = 2;
            this.lnkYtEx.Text = "YoutubeExtractor";
            this.lnkYtEx.UseSelectable = true;
            this.lnkYtEx.Click += new System.EventHandler(this.lnkYtEx_Click);
            // 
            // lnkFF
            // 
            this.lnkFF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkFF.Location = new System.Drawing.Point(269, 26);
            this.lnkFF.Name = "lnkFF";
            this.lnkFF.Size = new System.Drawing.Size(129, 17);
            this.lnkFF.TabIndex = 3;
            this.lnkFF.Text = "FFmpeg";
            this.lnkFF.UseSelectable = true;
            this.lnkFF.Click += new System.EventHandler(this.lnkFF_Click);
            // 
            // lblVer
            // 
            this.lblVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(44, 423);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(30, 19);
            this.lblVer.TabIndex = 17;
            this.lblVer.Text = "v1.0";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 462);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lnkDev);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbDownload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBrowseDownloads);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(465, 462);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "[settings]";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbColor;
        private MetroFramework.Controls.MetroComboBox cbStyle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cbLanguage;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnBrowseDownloads;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox tbDownload;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLink lnkDev;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLink lnkMetroUI;
        private MetroFramework.Controls.MetroLink lnkFF;
        private MetroFramework.Controls.MetroLink lnkYtEx;
        private MetroFramework.Controls.MetroLabel lblVer;
    }
}