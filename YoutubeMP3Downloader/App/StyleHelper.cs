using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace YoutubeMP3Downloader
{
    class StyleHelper
    {
        public static void SetFormStyle(MetroForm form, MetroStyleManager styleMgr, MetroColorStyle color, MetroThemeStyle theme)
        {
            form.Theme = theme;
            styleMgr.Theme = theme;

            form.Style = color;
            styleMgr.Style = color;

            styleMgr.Update();
            form.Refresh();
        }
    }
}
