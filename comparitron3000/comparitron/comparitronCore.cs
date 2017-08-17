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
        public SettingsCore settings { get; } = null;

        public ComparitronCore(SettingsCore settings)
        {
            this.settings = settings;
        }
    }
}
