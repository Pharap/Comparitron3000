using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparitron
{
    public class ComparitronItem
    {
        public ItemType type { get; set;  }
        public int frame { get; set; }
        public string text { get; set; }
        public string image { get; set; }
        public string video { get; set; }
    }
}
