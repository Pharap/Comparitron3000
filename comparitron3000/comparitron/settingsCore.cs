using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace comparitron
{
    public class Settings
    {
        const string SettingsFile = "settings.xml";

        //Settings
        public string TemplateHeader { get; set; } = "jfdifrd";
        public string TemplateFooter { get; set; } = "ifdfd";

        public string TVFolder { get; set; } = @"old\";
        public string BDFolder { get; set; } = @"new\";
        public string MXFolder { get; set; } = @"mix\";

        public string TVPrefix { get; set; } = @"tv-";
        public string BDPrefix { get; set; } = @"bd-";
        public string MXPrefix { get; set; } = @"mx-";

        public string ImageFormat { get; set; } = @".jpg";
        
        //Unsettings
        public static Settings Load(string path)
        {
            if (File.Exists(SettingsFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                using (FileStream fileStream = File.Open(SettingsFile, FileMode.Open))
                {
                    return (Settings)serializer.Deserialize(fileStream);
                }
            }
            return new Settings();
        }

        public static void Save(Settings settings, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            using (TextWriter writer = new StreamWriter(SettingsFile))
            {
                serializer.Serialize(writer, settings);
            }
        }

        public static void SaveDefault(Settings settings)
        {
            Save(settings, SettingsFile);
        }
        public static Settings LoadDefault()
        {
            return Load(SettingsFile);
        }
    }
}
