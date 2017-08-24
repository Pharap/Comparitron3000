﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace comparitron
{
    public class ComparitronCore
    {
        private SettingsCore settings = null;

        //Directories
        public string BasePath { get; set; } = null;

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

            //EXPAND ON THIS-
            if(!File.Exists(BasePath+"Project.xml"))
            {
                File.Create(BasePath + "Project.xml");
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
