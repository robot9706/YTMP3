using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace YoutubeMP3Downloader
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void SettingsForm_Load(object sender, System.EventArgs e)
        {
            LanguageManager.ApplyLanguage(this);

            StyleHelper.SetFormStyle(this, metroStyleManager, Settings.AppColorStyle, Settings.AppThemeStyle);

            SettingsFile set = Settings.AppSettings;

            MetroColorStyle selectedColorStlye = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), set.AppColorStyle);
            foreach (MetroColorStyle s in (MetroColorStyle[])Enum.GetValues(typeof(MetroColorStyle)))
            {
                if (s == MetroColorStyle.Default)
                    continue;

                cbColor.Items.Add(s);

                if(selectedColorStlye == s)
                {
                    cbColor.SelectedIndex = cbColor.Items.Count - 1;
                }
            }
            if(cbColor.SelectedItem == null)
            {
                cbColor.SelectedIndex = 0;
            }

            MetroThemeStyle selectedTheme = (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle), set.AppStyle);
            foreach (MetroThemeStyle t in (MetroThemeStyle[])Enum.GetValues(typeof(MetroThemeStyle)))
            {
                if (t == MetroThemeStyle.Default)
                    continue;

                cbStyle.Items.Add(t);

                if(t == selectedTheme)
                {
                    cbStyle.SelectedIndex = cbStyle.Items.Count - 1;
                }
            }
            if (cbStyle.SelectedItem == null)
            {
                cbStyle.SelectedIndex = 0;
            }

            foreach (LanguageManager.LanguageInfo info in LanguageManager.GetAllLanguages())
            {
                cbLanguage.Items.Add(info);

                if(info.LocaleName == set.Language)
                {
                    cbLanguage.SelectedIndex = cbLanguage.Items.Count - 1;
                }
            }
            if (cbLanguage.SelectedItem == null)
            {
                cbLanguage.SelectedIndex = 0;
            }

            tbDownload.Text = set.DownloadFolder;
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor.SelectedItem == null || cbStyle.SelectedItem == null)
                return;

            MetroColorStyle color = (MetroColorStyle)cbColor.SelectedItem;
            MetroThemeStyle theme = (MetroThemeStyle)cbStyle.SelectedItem;

            SettingsFile set = Settings.AppSettings;
            set.AppColorStyle = color.ToString();
            set.AppStyle = theme.ToString();

            StyleHelper.SetFormStyle(this, metroStyleManager, color, theme);
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedItem == null)
                return;

            LanguageManager.LanguageInfo lang = (LanguageManager.LanguageInfo)cbLanguage.SelectedItem;

            LanguageManager.LoadLanguage(lang.LocaleName);
            LanguageManager.ApplyLanguage(this);

            Settings.AppSettings.Language = lang.LocaleName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.SaveSettings();

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnBrowseDownloads_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                fd.SelectedPath = Settings.AppSettings.DownloadFolder;

                if(fd.ShowDialog(this) == DialogResult.OK)
                {
                    Settings.AppSettings.DownloadFolder = fd.SelectedPath;
                    tbDownload.Text = fd.SelectedPath;

                    Refresh();
                }
            }
        }

        private void lnkDev_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/robot9706");
        }

        private void lnkMetroUI_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dennismagno/metroframework-modern-ui");
        }

        private void lnkYtEx_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/flagbug/YoutubeExtractor");
        }

        private void lnkFF_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ffmpeg.org/");
        }
    }
}
