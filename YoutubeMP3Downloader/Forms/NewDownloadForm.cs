using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YoutubeMP3Downloader
{
    public partial class NewDownloadForm : MetroForm
    {
        struct QualityElement
        {
            public VideoInfo YTInfo;

            public override string ToString()
            {
                return YTInfo.Resolution.ToString() + "p " + YTInfo.AudioType.ToString() + "(" + YTInfo.AudioBitrate.ToString() + "b/s)";
            }
        }

        public VideoInfo SelectedVideo
        {
            get;
            private set;
        }

        public NewDownloadForm()
        {
            InitializeComponent();

            DialogResult = DialogResult.Cancel;
        }

        private void NewDownloadForm_Load(object sender, System.EventArgs e)
        {
            LanguageManager.ApplyLanguage(this);
            StyleHelper.SetFormStyle(this, metroStyleManager, Settings.AppColorStyle, Settings.AppThemeStyle);
        }

        private void tbLink_TextChanged(object sender, System.EventArgs e)
        {
            if(tbLink.Text.Length > 0 && tbLink.Text.Contains("watch?v"))
            {
                Cursor = System.Windows.Forms.Cursors.WaitCursor;
                btnDownload.Enabled = cbQuality.Enabled = false;

                Uri url;
                if(Uri.TryCreate(tbLink.Text, UriKind.Absolute, out url))
                {
                    string yt;
                    if (DownloadUrlResolver.TryNormalizeYoutubeUrl(tbLink.Text, out yt))
                    {
                        try
                        {
                            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(yt, false).OrderBy(x => x.Resolution);

                            cbQuality.Items.Clear();
                            foreach (VideoInfo vi in videoInfos)
                            {
                                if (!string.IsNullOrEmpty(vi.Title) && vi.VideoType == VideoType.Mp4 && vi.Resolution > 0 && vi.AudioBitrate > 0)
                                {
                                    cbQuality.Items.Add(new QualityElement()
                                    {
                                        YTInfo = vi
                                    });
                                    if (cbQuality.Items.Count > 0)
                                        cbQuality.SelectedIndex = 0;
                                }
                            }
                            cbQuality.Refresh();
                            cbQuality.Enabled = true;
                            Application.DoEvents();

                            tbLink.ForeColor = Color.Black;
                        }
                        catch
                        {
                            btnDownload.Enabled = cbQuality.Enabled = false;
                            tip.Show(LanguageManager.GetLocalization("invalidYTLink"), tbLink, tbLink.Width, 0, 1000);
                        }
                    }
                    else
                    {
                        tip.Show(LanguageManager.GetLocalization("invalidYTLink"), tbLink, tbLink.Width, 0, 1000);
                    }
                }
            }
            cbQuality.Refresh();
            Application.DoEvents();
            Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void cbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDownload.Enabled = (cbQuality.SelectedIndex > -1);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            SelectedVideo = ((QualityElement)cbQuality.SelectedItem).YTInfo;
        }

        private void NewDownloadForm_Enter(object sender, EventArgs e)
        {
            tbLink.Focus();
        }
    }
}
