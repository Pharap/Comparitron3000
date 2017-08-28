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
        
        public SettingsCore()
        {
            Load();
        }

        //Unsettings!
        public static void Load()
        {
            if(!File.Exists("settings.xml"))
            {
                Save(); //If it doesn't exist, create it with default values.
                return;
            }
            else
            {

            }
        }

        public static void Save()
        {

        }
    }
}
