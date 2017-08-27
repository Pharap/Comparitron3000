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
        public string templateHeader { get; set; } = null;
        public string templateFooter { get; set; } = null;

        public void LoadSettings()
        {
            XmlReader reader = XmlReader.Create("settings.xml");

            reader.ReadStartElement();

            reader.ReadElementContentAsString();    //Template
            templateHeader = reader.ReadElementContentAsString();    //Header
            reader.ReadEndElement();
            reader.ReadStartElement();
            templateFooter = reader.ReadElementContentAsString();   //Footer
            reader.ReadEndElement();

            reader.Close();
        }

        public void SaveSettings()
        {
            XmlWriter writer = XmlWriter.Create("settings.xml");

            writer.WriteStartDocument();
            writer.WriteStartElement("Template");

            writer.WriteStartElement("Header");
            writer.WriteAttributeString("path",templateHeader);
            writer.WriteEndElement();

            writer.WriteStartElement("Footer");
            writer.WriteAttributeString("path", templateFooter);
            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
