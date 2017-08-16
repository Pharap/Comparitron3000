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
        comparitronCore comparitron = null;
        public FormSettings(comparitronCore comparitron)
        {
            InitializeComponent();
            this.comparitron = comparitron;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
