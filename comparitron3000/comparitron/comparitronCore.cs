using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace comparitron
{
    public class ComparitronCore
    {
        private SettingsCore settings = null;

        //Directories & Paths
        public string BasePath { get; set; } = null;
        public string ProjectPath { get; set; } = null;
        public string ProjectID { get; set; } = null;       // "SW209" "BW01" and such

        //List of things;
        public BindingList<ComparitronItem> itemList = new BindingList<ComparitronItem>();

        //Frame tracking
        private int currentFrame { get; set; } = 1;
        public int LastFrame { get; set; } = 34000;

        //Things
        public int CurrentFrame {
            get { return currentFrame; }
            set { this.currentFrame = Math.Min(Math.Max(value,1), LastFrame); }
        }

        public ComparitronCore(SettingsCore settings)
        {
            this.settings = settings;
        }
        
        // IO
        public void LoadProject(string Path)
        {
            BasePath = Path;
            ProjectPath = BasePath + @"\project.xml";

            //Load item list
            if (File.Exists(ProjectPath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<ComparitronItem>));
                using (var myFileStream = new FileStream(ProjectPath, FileMode.Open))
                {
                    itemList = (BindingList<ComparitronItem>)serializer.Deserialize(myFileStream);
                }
            }

            //Debug 
            Console.WriteLine(ProjectPath);
            Console.WriteLine(itemList == null);
            Console.WriteLine(itemList.Count);

            //Count frames
            string mixDir = BasePath + @"\mix";
            LastFrame = Directory.GetFiles(mixDir, "*.jpg", SearchOption.TopDirectoryOnly).Length;
        }

        public void SaveProject()
        {
            SaveProject(BasePath);
        }
        public void SaveProject(string Path)
        { 
            //this just assumes the path is valid, because that's definately safe.
            //ProjectPath = BasePath + @"\Project.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<ComparitronItem>));
            TextWriter writer = new StreamWriter(ProjectPath);
            //Header stuff
            serializer.Serialize(writer, itemList);
        }

        //Thing list
        public void AddItem(ItemType type, int frame, string text, string image, string video)
        {
            itemList.Add(new ComparitronItem { Type = type, Frame = frame, Text = text, Image = image, Video = video });
        }
        public void AddFrame(int frame, string text)    //Simplified for the lazy
        {
            AddItem(ItemType.Comparison, frame, text, null, null);
        }
        

    }
}
