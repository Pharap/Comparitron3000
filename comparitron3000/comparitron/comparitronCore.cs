﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace comparitron
{
    public class ComparitronCore
    {
        private SettingsCore settings = null;
        public BindingList<ComparitronItem> itemList = new BindingList<ComparitronItem>();

        public ComparitronCore(SettingsCore settings)
        {
            this.settings = settings;

            /// Testing;
            itemList.Add(new ComparitronItem { Type = ItemType.Image, Frame = 4143 });
        }

        public int currentFrame { get; set; }

        public void AddItem(ItemType type, int frame, string text, string image, string video)
        {
            itemList.Add(new ComparitronItem { Type = type, Frame = frame, Text = text, Image = image, Video = video });
        }
        public void AddFrame(int frame, string text)
        {
            AddItem(ItemType.Comparison, frame, text, null, null);
        }
        

    }
}
