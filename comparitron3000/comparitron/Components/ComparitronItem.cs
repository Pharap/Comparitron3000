﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparitron
{
    public class ComparitronItem
    {
        public ItemType Type { get; set;  }
        public int Frame { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
    }
}
