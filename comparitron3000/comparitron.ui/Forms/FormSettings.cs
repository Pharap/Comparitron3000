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
            this.settings = settings;
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            textHeaderFile.Text = settings.TemplateHeader;
            textFooterFile.Text = settings.TemplateFooter;

            textTVFolder.Text = settings.TVFolder;
            textTVPrefix.Text = settings.TVPrefix;
            textBDFolder.Text = settings.BDFolder;
            textBDPrefix.Text = settings.BDPrefix;
            textMXFolder.Text = settings.MXFolder;
            textMXPrefix.Text = settings.MXPrefix;

            comboImageFormat.Text = settings.ImageFormat;
        }


        private void btnOkay_Click(object sender, EventArgs e)
        {
            //Swap these!
            textHeaderFile.Text = settings.TemplateHeader;
            textFooterFile.Text = settings.TemplateFooter;

            textTVFolder.Text = settings.TVFolder;
            textTVPrefix.Text = settings.TVPrefix;
            textBDFolder.Text = settings.BDFolder;
            textBDPrefix.Text = settings.BDPrefix;
            textMXFolder.Text = settings.MXFolder;
            textMXPrefix.Text = settings.MXPrefix;

            comboImageFormat.Text = settings.ImageFormat;
            //Swap these!

            settings.SaveSettings();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
