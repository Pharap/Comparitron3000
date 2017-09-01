using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparitron
{
    [Serializable]
    public class ComparitronSaveFormat
    {
        public BindingList<ComparitronItem> itemList = new BindingList<ComparitronItem>();
        public string projectID;
        public string projectTitle;

        public ComparitronSaveFormat(BindingList<ComparitronItem> itemList, string projectID, string projectTitle)
        {
            this.itemList = itemList;
            this.projectID = projectID;
            this.projectTitle = projectTitle;
        }
        public ComparitronSaveFormat() { }

    }
}
