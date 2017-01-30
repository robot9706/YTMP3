using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YoutubeMP3Downloader
{
    public partial class MainForm : MetroForm
    {
        private List<ConvertTask> _downloads = new List<ConvertTask>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LanguageManager.LoadLanguage(Settings.AppSettings.Language);
            LanguageManager.ApplyLanguage(this);

            StyleHelper.SetFormStyle(this, metroStyleManager, Settings.AppColorStyle, Settings.AppThemeStyle);
        }

        private void pbSettings_Click(object sender, System.EventArgs e)
        {
            using(SettingsForm set = new SettingsForm())
            {
                if(set.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    LanguageManager.ApplyLanguage(this);

                    StyleHelper.SetFormStyle(this, metroStyleManager, Settings.AppColorStyle, Settings.AppThemeStyle);
                }
            }
        }

        private void btnDownload_Click(object sender, System.EventArgs e)
        {
            using (NewDownloadForm nd = new NewDownloadForm())
            {
                if(nd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    VideoInfo yt = nd.SelectedVideo;

                    SaveFileDialog svf = new SaveFileDialog();
                    svf.InitialDirectory = Settings.AppSettings.DownloadFolder;

                    if (nd.EncodeToMp3)
                    {
                        svf.Filter = "MP3 (*.mp3)|*.mp3|" + LanguageManager.GetLocalization("allFiles") + " (*.*)|*.*";
                        svf.FileName = Utils.RemoveIllegalPathCharacters(yt.Title) + ".mp3";
                    }
                    else
                    {
                        svf.Filter = "MP3 (*.mp4)|*.mp4|" + LanguageManager.GetLocalization("allFiles") + " (*.*)|*.*";
                        svf.FileName = Utils.RemoveIllegalPathCharacters(yt.Title) + ".mp4";
                    }

                    if (svf.ShowDialog() == DialogResult.OK)
                    {
                        if (_downloads.Count > 0)
                            listTasks.RowCount++;

                        MetroLabel title = CreateColumnLabel(0);
                        title.Text = yt.Title;

                        MetroLabel status = CreateColumnLabel(1);
                        status.Text = LanguageManager.GetLocalization("statusFileDownload");

                        MetroProgressBar progBar = new MetroProgressBar();
                        progBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                        progBar.Width = listTasks.GetColumnWidths()[2];

                        MetroLabel file = CreateColumnLabel(3);
                        file.Text = svf.FileName;

                        MetroButton cancelButton = new MetroButton();
                        cancelButton.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                        cancelButton.Text = LanguageManager.GetLocalization("cancel");
                        cancelButton.Width = listTasks.GetColumnWidths()[4];
                        cancelButton.Tag = "[cancel]";

                        listTasks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        listTasks.Controls.Add(title, 0, listTasks.RowCount - 1);
                        listTasks.Controls.Add(status, 1, listTasks.RowCount - 1);
                        listTasks.Controls.Add(progBar, 2, listTasks.RowCount - 1);
                        listTasks.Controls.Add(file, 3, listTasks.RowCount - 1);
                        listTasks.Controls.Add(cancelButton, 4, listTasks.RowCount - 1);

                        ConvertTask task = new ConvertTask(status, progBar, cancelButton, yt, svf.FileName, nd.EncodeToMp3);
                        cancelButton.Click += delegate (object s, System.EventArgs se)
                        {
                            task.Cancel();
                        };

                        _downloads.Add(task);

                        metroStyleManager.Update();
                        Refresh();

                        task.Start();
                    }
                }
            }
        }

        private MetroLabel CreateColumnLabel(int column)
        {
            MetroLabel label = new MetroLabel();
            label.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            label.AutoSize = false;
            label.Width = listTasks.GetColumnWidths()[column];

            return label;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (ConvertTask tt in _downloads)
            {
                tt.Cancel();
                tt.Kill();
            }
        }
    }
}
