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
        comparitronCore comparitron = null;
        FormSettings formSettings = null;
        public FormMain(comparitronCore comparitron)
        {
            InitializeComponent();
            this.comparitron = comparitron;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSettings == null || formSettings.IsDisposed)
            {
                formSettings = new FormSettings(comparitron);
            }
            formSettings.ShowDialog();
        }
    }
}
