using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YoutubeMP3Downloader
{
    class ConvertTask
    {
        private MetroLabel _statusLabel;
        private MetroProgressBar _progBar;
        private MetroButton _cancelButton;
        private VideoInfo _video;
        private string _outputMp3;

        private Task _task;
        private bool _cancelled = false;

        private Process _ffmpegProcess;

        public ConvertTask(MetroLabel statusLabel, MetroProgressBar progBar, MetroButton cancelButton, VideoInfo video, string outputMp3)
        {
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            _statusLabel = statusLabel;
            _progBar = progBar;
            _cancelButton = cancelButton;
            _video = video;
            _outputMp3 = outputMp3;
        }

        public void Start()
        {
            _task = Task.Factory.StartNew(DoTask);
        }

        private void SetStatus(string locName)
        {
            _statusLabel.Invoke(new Action(() =>
            {
                _statusLabel.Text = LanguageManager.GetLocalization(locName);
                _statusLabel.Tag = "[" + locName + "]";
            }));
        }

        private void SetProgressMax(int max)
        {
            _progBar.Invoke(new Action(() =>
            {
                _progBar.Value = 0;
                _progBar.Maximum = max;
            }));
        }

        private void SetProgress(int prog)
        {
            _progBar.Invoke(new Action(() =>
            {
                _progBar.Value = prog;
            }));
        }

        private void DisableCancelButton()
        {
            _cancelButton.Invoke(new Action(() =>
            {
                _cancelButton.Enabled = false;
            }));
        }

        private void RemoveProgressBar()
        {
            _progBar.Invoke(new Action(() =>
            {
                _progBar.Parent.Controls.Remove(_progBar);
            }));
        }

        public void Cancel()
        {
            _cancelled = true;
        }

        public void Kill()
        {
            if (_ffmpegProcess != null && !_ffmpegProcess.HasExited)
                _ffmpegProcess.Kill();
        }

        private void DoTask()
        {
            string mp4 = Path.Combine(Path.GetDirectoryName(_outputMp3), Utils.RemoveIllegalPathCharacters(_video.Title) + ".temp");

            try
            {
                SetProgressMax(100);

                VideoDownloader down = new VideoDownloader(_video, mp4);
                down.DownloadProgressChanged += Down_DownloadProgressChanged;
                down.Execute();

                if (_cancelled)
                {
                    if (File.Exists(mp4))
                        File.Delete(mp4);

                    SetStatus("cancelled");
                    DisableCancelButton();
                    RemoveProgressBar();

                    return;
                }

                SetStatus("statusEncoding");

                ProcessStartInfo ff = new ProcessStartInfo();
                ff.FileName = Path.Combine(Application.StartupPath, "ffmpeg.exe");
                ff.Arguments = "-y -i \"" + mp4 + "\" \"" + _outputMp3 + "\"";
                ff.UseShellExecute = false;
                ff.RedirectStandardError = true;
                ff.RedirectStandardOutput = true;
                ff.CreateNoWindow = true;

                Process ffmpeg = _ffmpegProcess = Process.Start(ff);

                bool? inputData = null;
                double mp4Length = 0;
                while (!ffmpeg.HasExited)
                {
                    string line = null;
                    if (!ffmpeg.StandardError.EndOfStream)
                        line = ffmpeg.StandardError.ReadLine();
                    else if (!ffmpeg.StandardOutput.EndOfStream)
                        line = ffmpeg.StandardOutput.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        continue;

                    if (line.StartsWith("Input #0"))
                    {
                        inputData = true;
                    }
                    else if (line.StartsWith("Output #0"))
                    {
                        inputData = false;
                    }
                    else if (line.ToLower().Contains("duration") && inputData.HasValue && inputData.Value)
                    {
                        int s = line.IndexOf(": ");
                        int e = line.IndexOf(",", s);

                        string sub = line.Substring(s + 2, e - s - 2);

                        mp4Length = TimeSpan.Parse(sub).TotalSeconds;
                    }

                    if (line.StartsWith("size="))
                    {
                        int s = line.IndexOf("time=");
                        int e = line.IndexOf(" bitrate", s + 5);

                        string sub = line.Substring(s + 5, e - s - 5);

                        double time = TimeSpan.Parse(sub).TotalSeconds;
                        double state = (time / mp4Length) * 100;
                        if (state > 100)
                            state = 100;

                        SetProgress((int)state);
                    }

                    if (_cancelled)
                    {
                        ffmpeg.Kill();

                        if (File.Exists(mp4))
                            File.Delete(mp4);
                        if (File.Exists(_outputMp3))
                            File.Delete(_outputMp3);

                        SetStatus("cancelled");
                        DisableCancelButton();
                        RemoveProgressBar();

                        return;
                    }
                }

                if (File.Exists(mp4))
                    File.Delete(mp4);

                SetStatus("done");
            }
            catch (Exception ex)
            {
                if (File.Exists(mp4))
                    File.Delete(mp4);
                if (File.Exists(_outputMp3))
                    File.Delete(_outputMp3);

                SetStatus("error");
            }

            DisableCancelButton();
            RemoveProgressBar();
        }

        private void Down_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            SetProgress((int)e.ProgressPercentage);

            e.Cancel = _cancelled;
        }
    }
}
