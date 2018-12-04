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
        private Settings settings = null;

        //Directories & Paths
        public string BasePath { get; set; } = null;
        public string ProjectPath { get; set; } = null;
        public string ProjectID { get; set; } = null;       // "SW209" "BW01" and such
        public string ProjectTitle { get; set; } = null;

        public string PathNext { get; set; } = "";
        public string PathPrevious { get; set; } = "";

        //List of things;
        public BindingList<ComparitronItem> itemList = new BindingList<ComparitronItem>();

        //Frame tracking
        private int currentFrame { get; set; } = 1;
        public int LastFrame { get; set; } = 1;

        //Things
        public int CurrentFrame {
            get { return currentFrame; }
            set { this.currentFrame = Math.Min(Math.Max(value,1), LastFrame); }
        }

        public ComparitronCore(Settings settings)
        {
            this.settings = settings;
        }

        // IO
        public void ScanForFiles(string Path)
        {
            LastFrame = 0;
            //Count frames
            if (Directory.Exists(Path))
            { 
                LastFrame = Directory.GetFiles(Path, "*.jpg", SearchOption.TopDirectoryOnly).Length;
                Console.WriteLine(LastFrame + " frames discovered");
            }

            if(LastFrame == 0)
            { 
                Console.WriteLine("No images!");
            }
        }
         
        public void LoadProject(string Path)
        {
            BasePath = Path;
            ProjectPath = BasePath + @"\project.xml";

            //Load item list
            if (File.Exists(ProjectPath))
            {

                ComparitronSaveFormat loadData = new ComparitronSaveFormat();
                XmlSerializer serializer = new XmlSerializer(typeof(ComparitronSaveFormat));
                using (var myFileStream = new FileStream(ProjectPath, FileMode.Open))
                {
                    loadData = (ComparitronSaveFormat)serializer.Deserialize(myFileStream);
                }

                itemList = loadData.itemList;
                ProjectID = loadData.projectID;
                ProjectTitle = loadData.projectTitle;
            }

            //Debug 
            Console.WriteLine("Loading " + ProjectPath);
            Console.WriteLine(itemList.Count.ToString() + " items found");

            ScanForFiles(BasePath + @"\"+ settings.MXFolder);
        }

        public void SaveProject()
        {
            if(BasePath != null)
                SaveProject(BasePath);
        }
        public void SaveProject(string Path)
        {
            //this just assumes the path is valid, because that's definately safe.
            //ProjectPath = BasePath + @"\Project.xml";
            ComparitronSaveFormat saveData = new ComparitronSaveFormat(itemList, ProjectID, ProjectTitle);

            XmlSerializer serializer = new XmlSerializer(typeof(ComparitronSaveFormat));
            using (TextWriter writer = new StreamWriter(ProjectPath))
            {
                serializer.Serialize(writer, saveData);
            }
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
