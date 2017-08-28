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
    public class SettingsHolder
    {
        public string TemplateHeader { get; set; } = "jfdifrd";
        public string TemplateFooter { get; set; } = "ifdfd";

        public string TVFolder { get; set; } = @"old\";
        public string BDFolder { get; set; } = @"new\";
        public string MXFolder { get; set; } = @"mix\";

        public string TVPrefix { get; set; } = @"tv-";
        public string BDPrefix { get; set; } = @"bd-";
        public string MXPrefix { get; set; } = @"mx-";

        public string ImageFormat { get; set; } = @".jpg";
    }

    public class SettingsCore
    {
        //Settings!
        SettingsHolder holder = new SettingsHolder();

        public string TemplateHeader { get { return holder.TemplateHeader; } set { holder.TemplateHeader = value; } }
        public string TemplateFooter { get { return holder.TemplateFooter; } set { holder.TemplateFooter = value; } }

        public string TVFolder { get { return holder.TVFolder; } set { holder.TVFolder = value; } }
        public string BDFolder { get { return holder.BDFolder; } set { holder.BDFolder = value; } }
        public string MXFolder { get { return holder.MXFolder; } set { holder.MXFolder = value; } }

        public string TVPrefix { get { return holder.TVPrefix; } set { holder.TVPrefix = value; } }
        public string BDPrefix { get { return holder.BDPrefix; } set { holder.BDPrefix = value; } }
        public string MXPrefix { get { return holder.MXPrefix; } set { holder.MXPrefix = value; } }

        public string ImageFormat { get { return holder.ImageFormat; } set { holder.ImageFormat = value; } }


        public SettingsCore()
        {
            Load();
        }

        //Unsettings!
        public void Load()
        {
            if(!File.Exists("settings.xml"))
            {
                Save(); //If it doesn't exist, create it with default values.
                return;
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SettingsHolder));
                using (FileStream fileStream = new FileStream("settings.xml", FileMode.Open))
                {
                    holder = (SettingsHolder)serializer.Deserialize(fileStream);
                }
            }
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SettingsHolder));
            using (TextWriter writer = new StreamWriter("settings.xml"))
            {
                serializer.Serialize(writer, holder);
            }
        }
    }
}
