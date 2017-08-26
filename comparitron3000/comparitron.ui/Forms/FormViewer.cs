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
        }

        public void UpdateUI(DisplayType mode, float transition)
        {
            comparisonViewer.Mode = mode;
            comparisonViewer.BasePath = comparitron.BasePath;
            comparisonViewer.Frame = comparitron.CurrentFrame;
            comparisonViewer.Transition = transition;
        }

        private void FormViewer_Load(object sender, EventArgs e)
        {

        }

        private void comparisonViewer1_MouseDoubleClick(object sender, MouseEventArgs e)
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
