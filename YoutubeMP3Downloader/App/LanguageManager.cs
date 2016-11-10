using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using YoutubeMP3Downloader.Properties;

namespace YoutubeMP3Downloader
{
    class LanguageManager
    {
        public class LanguageInfo
        {
            public string Name;
            public string LocaleName;

            public override string ToString()
            {
                return Name;
            }
        }

        private static Dictionary<string, string> _languageDictionary = new Dictionary<string, string>();

        private static string _activeLanguage = null;

        public static LanguageInfo[] GetAllLanguages()
        {
            List<LanguageInfo> names = new List<LanguageInfo>();

            foreach(PropertyInfo pi in typeof(Resources).GetProperties(BindingFlags.Static | BindingFlags.NonPublic))
            {
                if(pi.Name.StartsWith("lang_"))
                {
                    string locName = pi.Name.Split('_').Last();

                    using (StringReader reader = new StringReader((string)pi.GetValue(null)))
                    {
                        string line;
                        while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                        {
                            string[] split = line.Split('=');
                            if (split.Length == 2 && split[0] == "langName")
                            {
                                names.Add(new LanguageInfo()
                                {
                                    Name = split[1],
                                    LocaleName = locName
                                });

                                break;
                            }
                        }
                    }
                }
            }

            return names.ToArray();
        }

        public static void LoadLanguage(string name)
        {
            if (_activeLanguage == name)
                return;

            _activeLanguage = name;

            name = "lang_" + name;

            _languageDictionary.Clear();

            using (StringReader reader = new StringReader(Resources.ResourceManager.GetString(name)))
            {
                string line;
                while(!string.IsNullOrEmpty(line = reader.ReadLine()))
                {
                    string[] split = line.Split('=');
                    if(split.Length == 2 && !_languageDictionary.ContainsKey(split[0]))
                    {
                        _languageDictionary.Add(split[0], split[1]);
                    }
                }
            }
        }

        public static string GetLocalization(string key)
        {
            if (_languageDictionary.ContainsKey(key))
                return _languageDictionary[key];

            return key;
        }

        public static void ApplyLanguage(Form form)
        {
            if(form.Tag is string)
            {
                string tag = (string)form.Tag;
                if (tag.StartsWith("[") && tag.EndsWith("]"))
                {
                    tag = tag.Substring(1, tag.Length - 2);
                    if (_languageDictionary.ContainsKey(tag))
                    {
                        form.Text = GetLocalization(tag);
                    }
                }
            }

            foreach(Control c in form.Controls)
            {
                ApplyForControl(c);
            }

            form.Refresh();
        }

        private static void ApplyForControl(Control c)
        {
            if(c.Tag is string)
            {
                string tag = (string)c.Tag;
                if(tag.StartsWith("[") && tag.EndsWith("]"))
                {
                    tag = tag.Substring(1, tag.Length - 2);
                    if(_languageDictionary.ContainsKey(tag))
                    {
                        c.Text = GetLocalization(tag);
                    }
                }
            }

            foreach(Control par in c.Controls)
            {
                ApplyForControl(par);
            }
        }
    }
}
