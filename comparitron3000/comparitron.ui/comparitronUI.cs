using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparitron.ui
{
    static class comparitronUI
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            //gunk
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //fun
            Settings settings = Settings.LoadDefault();
            ComparitronCore comparitron = new ComparitronCore(settings);
            Application.Run(new FormMain(comparitron,settings));
        }
    }
}
