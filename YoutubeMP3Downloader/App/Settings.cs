using MetroFramework;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace YoutubeMP3Downloader
{
    class Settings
    {
        private static string _settingsPath = Path.Combine(Application.StartupPath, "settings.bin");

        private static SettingsFile _settings;
        public static SettingsFile AppSettings
        {
            get
            {
                if(_settings == null)
                {
                    _settings = new SettingsFile();
                    if (File.Exists(_settingsPath))
                    {
                        _settings.Read(_settingsPath);
                    }
                    else
                    {
                        _settings.AppStyle = MetroThemeStyle.Light.ToString();
                        _settings.AppColorStyle = MetroColorStyle.Blue.ToString();
                        _settings.DownloadFolder = GetDownloadsFolderPath();
                        _settings.Language = "en";

                        _settings.Write(_settingsPath);
                    }
                }

                return _settings;
            }
        }

        public static MetroColorStyle AppColorStyle
        {
            get
            {
                return (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), AppSettings.AppColorStyle);
            }
        }

        public static MetroThemeStyle AppThemeStyle
        {
            get
            {
                return (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle), AppSettings.AppStyle);
            }
        }

        public static void SaveSettings()
        {
            _settings.Write(_settingsPath);
        }

        private static string GetDownloadsFolderPath()
        {
            IntPtr outPath;
            int result = SHGetKnownFolderPath(new Guid("{374DE290-123F-4565-9164-39C4925E467B}"), (uint)0x00004000, new IntPtr(0), out outPath); //0x00004000=Don't verify
            if (result >= 0)
            {
                return Marshal.PtrToStringUni(outPath);
            }

            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        [DllImport("Shell32.dll")]
        private static extern int SHGetKnownFolderPath(
        [MarshalAs(UnmanagedType.LPStruct)]Guid rfid, uint dwFlags, IntPtr hToken,
        out IntPtr ppszPath);
    }
}
