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
    public partial class FormViewer : Form
    {
        ComparitronCore comparitron = null;
        public FormViewer(ComparitronCore comparitron)
        {
            InitializeComponent();
            this.comparitron = comparitron;

            comparisonViewer.Slave = true;
        }

        public void UpdateUI(DisplayType mode, float transition)
        {
            comparisonViewer.Mode = mode;
            comparisonViewer.Transition = transition;
            /*
            comparisonViewer.BasePath = comparitron.BasePath;
            comparisonViewer.Frame = comparitron.CurrentFrame;*/
        }

        public void importImage(Image imageTV, Image imageBD, Image imageMX)
        {
            comparisonViewer.imageTV = imageTV;
            comparisonViewer.imageBD = imageBD;
            comparisonViewer.imageMX = imageMX;
        }

        private void FormViewer_Load(object sender, EventArgs e)
        {

        }

        private void comparisonViewer_MouseDoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.FromControl(this).Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
    }
}
