using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparitron.ui
{
    public partial class FormExport : Form
    {
        ComparitronCore comparitron = null;
        SettingsCore settings = null;

        public FormExport(ComparitronCore comparitron, SettingsCore settings)
        {
            InitializeComponent();

            this.settings = settings;
            this.comparitron = comparitron;
        }

        private void FormExport_Load(object sender, EventArgs e)
        {

        }
    }
}
