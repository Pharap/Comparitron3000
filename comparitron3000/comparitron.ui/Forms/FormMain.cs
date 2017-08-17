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
    public partial class FormMain : Form
    {
        ComparitronCore comparitron = null;
        SettingsCore settings = null;

        public FormMain(ComparitronCore comparitron, SettingsCore settings)
        {
            InitializeComponent();
            this.settings = settings;
            this.comparitron = comparitron;

            /// Configure UI gizmos.
            comboBoxViewMode.DataSource = Enum.GetValues(typeof(DisplayType));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormSettings formSettings = new FormSettings(settings))
            {
                formSettings.ShowDialog();
            }
        }
    }
}
