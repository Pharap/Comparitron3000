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

        }

        public void SaveSettings()
        {
            XmlWriter xmlWriter = XmlWriter.Create("settings.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Template");

            xmlWriter.WriteStartElement("Header");
            xmlWriter.WriteAttributeString("path",templateHeader);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("Footer");
            xmlWriter.WriteAttributeString("path", templateFooter);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
