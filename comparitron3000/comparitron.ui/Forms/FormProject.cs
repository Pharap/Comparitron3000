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
    public partial class FormProject : Form
    {
        ComparitronCore comparitron = null;

        public FormProject(ComparitronCore comparitron)
        {
            InitializeComponent();
            this.comparitron = comparitron;

            inputProjectID.Text = comparitron.ProjectID;
            inputProjectTitle.Text = comparitron.ProjectTitle;

            textPreviousURL.Text = comparitron.PathPrevious;
            textNextURL.Text = comparitron.PathNext;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            comparitron.ProjectID = inputProjectID.Text;
            comparitron.ProjectTitle = inputProjectTitle.Text;
            comparitron.PathPrevious = textPreviousURL.Text;
            comparitron.PathNext = textNextURL.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
