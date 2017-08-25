﻿using System;
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
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            comparitron.ProjectID = inputProjectID.Text;
        }
    }
}
