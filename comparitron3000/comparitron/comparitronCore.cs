using System;
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
            itemList.Add(new ComparitronItem { type = ItemType.Image, frame = 4143 });
        }


    }
}
