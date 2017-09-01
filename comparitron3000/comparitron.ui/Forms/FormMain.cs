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
        Settings settings = null;
        FormViewer formViewer = null;

        public FormMain(ComparitronCore comparitron, Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            this.comparitron = comparitron;
            comparisonViewer.settings = settings;
            
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
            //trackbarFrame.Value = comparitron.CurrentFrame;
            comparisonViewer.Frame = comparitron.CurrentFrame;

            var digits = comparitron.LastFrame.ToString().Length;
            statusLabel1.Text = "Frame " + comparitron.CurrentFrame.ToString("D"+digits) + " : " + comparitron.LastFrame;
            statusLabel2.Text = comparitron.ProjectID;
            statusLabel3.Text = comparitron.ProjectTitle;
            statusLabel4.Text = comparitron.BasePath;

            updatePopout();
        }
        private void updatePopout()
        {
            //If the popout viewer exists, update it with current information.
            if ((formViewer != null) && (formViewer.IsDisposed == false))
            {
                formViewer.importImage(comparisonViewer.imageTV, comparisonViewer.imageBD, comparisonViewer.imageMX);
                formViewer.UpdateUI(comparisonViewer.Mode, comparisonViewer.Transition);
            }
        }

        ///Toolstrip.
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormSettings formSettings = new FormSettings(settings))
            {
                formSettings.ShowDialog();
            }
            updateUI();
        }
        private void engageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comparitron.ProjectID))
            {
                MessageBox.Show("Check project settings! \r\n Unusable ID!");
            }
            else if (string.IsNullOrEmpty(comparitron.BasePath) || (!Directory.Exists(comparitron.BasePath)))
            {
                MessageBox.Show("Bad Project Path!");
            }
            else
            {
                using (FormExport formExport = new FormExport(comparitron, settings))
                {
                    formExport.ShowDialog();
                }
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormProject formProject = new FormProject(comparitron))
            {
                formProject.ShowDialog();
            }
            updateUI();
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
            using (FormNewProject formNew = new FormNewProject())
            {
                formNew.ShowDialog();
            }
            reloadUI();
        }
        
        private void reloadFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comparitron.ScanForFiles(settings.MXFolder);
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
            Console.WriteLine("Save as : " + comparitron.ProjectPath);
        }

        //Viewer
        private void comparisonViewer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if((formViewer == null) || (formViewer.IsDisposed))
            {
                formViewer = new FormViewer(comparitron);
            }
            formViewer.Show();
            updatePopout();
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
            var index = dataGridView.CurrentRow.Index;
            if (index > 0)
            {
                //move item
                var item = comparitron.itemList[index];
                comparitron.itemList.RemoveAt(index);
                comparitron.itemList.Insert(index - 1, item);
                //Select it
                dataGridView.CurrentCell = dataGridView.Rows[index-1].Cells[0];
                dataGridView.Rows[index-1].Selected = true;
            }
        }
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentRow.Index;
            if (index < comparitron.itemList.Count - 1)
            {
                //move item
                var item = comparitron.itemList[index];
                comparitron.itemList.RemoveAt(index);
                comparitron.itemList.Insert(index + 1, item);
                //Select it
                dataGridView.CurrentCell = dataGridView.Rows[index + 1].Cells[0];
                dataGridView.Rows[index + 1].Selected = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentRow.Index;
            comparitron.itemList.RemoveAt(index);
        }
        private void btnGoto_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentRow.Index;
            var item = comparitron.itemList[index];

            if (item.Frame != 0)
            {
                comparitron.CurrentFrame = item.Frame;
            }
            updateUI();
        }
        private void btnSetFrame_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentRow.Index;
            var item = comparitron.itemList[index];

            if(item.Type == ItemType.Comparison)
            {
                item.Frame = comparitron.CurrentFrame;
                dataGridView.Update();
                dataGridView.Refresh();
            }
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
            updatePopout();
        }

        private void comboBoxViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayType mode;
            Enum.TryParse<DisplayType>(comboBoxViewMode.SelectedValue.ToString(), out mode);
            comparisonViewer.Mode = mode;
            updatePopout();
        }

        // Statusbar.
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            projectToolStripMenuItem_Click(this, new EventArgs());
        }
    }
}
