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
            dataGridView.DataSource = comparitron.itemList;
        }

        ///Toolstrip.
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormSettings formSettings = new FormSettings(settings))
            {
                formSettings.ShowDialog();
            }
        }
        private void engageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormExport formExport = new FormExport(comparitron,settings))
            {
                formExport.ShowDialog();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save
            this.Close();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Inputty things
        private void btnAddCompare_Click(object sender, EventArgs e)
        {
            comparitron.AddFrame(comparitron.currentFrame, textBoxInput.Text);
        }
        private void btnAddText_Click(object sender, EventArgs e)
        {
            comparitron.AddItem(ItemType.Text, 0 , textBoxInput.Text, null, null);
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            comparitron.AddItem(ItemType.Text, 0, null, textBoxInput.Text, null);
        }
        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            comparitron.AddItem(ItemType.Text, 0, null, null, textBoxInput.Text);
        }
        private void btnAddDivide_Click(object sender, EventArgs e)
        {
            comparitron.AddItem(ItemType.Text, 0, "<hr/>", null, null);
        }
        
        //Interaction buttons.
        private void btnMoveUp_Click(object sender, EventArgs e)
        {

        }
        private void btnMoveDown_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnGoto_Click(object sender, EventArgs e)
        {

        }
        private void btnSetFrame_Click(object sender, EventArgs e)
        {

        }
    }
}
