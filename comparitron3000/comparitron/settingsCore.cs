using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace comparitron
{
    public class SettingsCore
    {
        //Settings!
        public string TemplateHeader { get; set; } = "jfdifrd";
        public string TemplateFooter { get; set; } = "ifdfd";

        public string TVFolder { get; set; } = @"old\";
        public string BDFolder { get; set; } = @"new\";
        public string MXFolder { get; set; } = @"mix\";

        public string TVPrefix { get; set; } = @"tv-";
        public string BDPrefix { get; set; } = @"bd-";
        public string MXPrefix { get; set; } = @"mx-";

        public string ImageFormat { get; set; } = @".jpg";

        //Unsettings!
        public void LoadSettings()
        {
            XmlReader reader = XmlReader.Create("settings.xml");

            reader.ReadStartElement();

            reader.ReadElementContentAsString();    //Template
            TemplateHeader = reader.ReadElementContentAsString();    //Header
            reader.ReadEndElement();
            reader.ReadStartElement();
            TemplateFooter = reader.ReadElementContentAsString();   //Footer
            reader.ReadEndElement();

            reader.Close();
        }

        public void SaveSettings()
        {
            XmlWriter writer = XmlWriter.Create("settings.xml");

            writer.WriteStartDocument();
            writer.WriteStartElement("Template");

            writer.WriteStartElement("Header");
            writer.WriteAttributeString("path", TemplateHeader);
            writer.WriteEndElement();

            writer.WriteStartElement("Footer");
            writer.WriteAttributeString("path", TemplateFooter);
            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
