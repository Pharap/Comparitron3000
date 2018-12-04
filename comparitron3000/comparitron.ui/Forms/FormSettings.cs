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
        Settings settings = null;

        public FormSettings(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            textHeaderPath.Text = settings.PathHeader;
            textFooterPath.Text = settings.PathFooter;
            textAuthorName.Text = settings.AuthorName;

            textTVFolder.Text = settings.TVFolder;
            textTVPrefix.Text = settings.TVPrefix;
            textBDFolder.Text = settings.BDFolder;
            textBDPrefix.Text = settings.BDPrefix;
            textMXFolder.Text = settings.MXFolder;
            textMXPrefix.Text = settings.MXPrefix;
            checkDebug.Checked = settings.DebugShow;

            comboImageFormat.Text = settings.ImageFormat;
        }


        private void btnOkay_Click(object sender, EventArgs e)
        {
            settings.PathHeader = textHeaderPath.Text;
            settings.PathFooter = textFooterPath.Text;
            settings.AuthorName = textAuthorName.Text;

            settings.TVFolder = textTVFolder.Text;
            settings.TVPrefix = textTVPrefix.Text;
            settings.BDFolder = textBDFolder.Text;
            settings.BDPrefix = textBDPrefix.Text;
            settings.MXFolder = textMXFolder.Text;
            settings.MXPrefix = textMXPrefix.Text;
            settings.DebugShow = checkDebug.Checked;

            settings.ImageFormat = comboImageFormat.Text;

            Settings.SaveDefault(settings);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboImageFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHeaderBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textHeaderPath.Text = openFileDialog.FileName;
            }
        }

        private void btnFooterBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textFooterPath.Text = openFileDialog.FileName;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
