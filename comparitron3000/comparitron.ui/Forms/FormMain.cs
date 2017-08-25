using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            
            reloadUI();
        }

        private void reloadUI()
        {
            //Used for big changes (opening a new file, settings changes, startup, etc)
            comparisonViewer.BasePath = comparitron.BasePath;

            comboBoxViewMode.DataSource = Enum.GetValues(typeof(DisplayType));
            
            dataGridView.DataSource = comparitron.itemList;

            trackbarFrame.Minimum = 1;
            trackbarFrame.Maximum = comparitron.LastFrame;

            updateUI();
        }
        private void updateUI()
        {
            //For small changes (changing frame, viewmode)
            trackbarFrame.Value = comparitron.CurrentFrame;
            comparisonViewer.Frame = comparitron.CurrentFrame;

            statusLabel.Text = comparitron.BasePath;
            var digits = comparitron.LastFrame.ToString().Length;
            statusLabel.Text += " Frame " + comparitron.CurrentFrame.ToString("D"+digits) + " : " + comparitron.LastFrame;
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
            if(MessageBox.Show("Save current project?", "Save you fool!", MessageBoxButtons.YesNo) ==  DialogResult.Yes)
            {
                comparitron.SaveProject();
            }
            this.Close();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openProjectBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var Path = openProjectBrowserDialog.SelectedPath;
                if (Directory.Exists(Path))
                {
                    comparitron.LoadProject(Path);
                }
            }
            reloadUI();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comparitron.SaveProject();
            Console.WriteLine("Saveas : " + comparitron.ProjectPath);
        }

        //Inputty things
        private void clearText()
        {
            textBoxInput.Text = "";
        }

        private void btnAddCompare_Click(object sender, EventArgs e)
        {
            comparitron.AddFrame(comparitron.CurrentFrame, textBoxInput.Text);
        }
        private void btnAddText_Click(object sender, EventArgs e)
        {
            comparitron.AddItem(ItemType.Text, 0 , textBoxInput.Text, null, null);
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            comparitron.AddItem(ItemType.Image, 0, null, textBoxInput.Text, null);
        }
        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            comparitron.AddItem(ItemType.Video, 0, null, null, textBoxInput.Text);
        }
        private void btnAddDivide_Click(object sender, EventArgs e)
        {
            comparitron.AddItem(ItemType.Divider, 0, null, null, null);
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

        //Track
        private void btnTrackRight_Click(object sender, EventArgs e)
        {
            comparitron.CurrentFrame++;
            updateUI();
        }
        private void btnTrackLeft_Click(object sender, EventArgs e)
        {
            comparitron.CurrentFrame--;
            updateUI();
        }
        private void trackbarFrame_Scroll(object sender, EventArgs e)
        {
            comparitron.CurrentFrame = trackbarFrame.Value;
            updateUI();
        }


        //View settings;
        private void trackBarFade_Scroll(object sender, EventArgs e)
        {
            comparisonViewer.Transition = trackBarFade.Value;
        }

        private void comboBoxViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayType mode;
            Enum.TryParse<DisplayType>(comboBoxViewMode.SelectedValue.ToString(), out mode);
            comparisonViewer.Mode = mode;
        }
    }
}
