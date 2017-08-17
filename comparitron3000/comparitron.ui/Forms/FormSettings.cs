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
    public partial class FormSettings : Form
    {
        SettingsCore settings = null;

        public FormSettings(SettingsCore settings)
        {
            InitializeComponent();
            this.settings = settings;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }


        private void btnOkay_Click(object sender, EventArgs e)
        {
            //Save goes here
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
