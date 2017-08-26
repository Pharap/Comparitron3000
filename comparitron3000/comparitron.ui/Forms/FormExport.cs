using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparitron.ui
{
    public partial class FormExport : Form
    {
        ComparitronCore comparitron = null;
        SettingsCore settings = null;
        ComparitronExporter exporter = null;

        public FormExport(ComparitronCore comparitron, SettingsCore settings)
        {
            InitializeComponent();

            this.settings = settings;
            this.comparitron = comparitron;
            exporter = new ComparitronExporter(comparitron, settings);
        }

        private void FormExport_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                exporter.Run();
            }).Start();

            btnRun.Enabled = false;
            btnBack.Enabled = false;

            timerUpdate.Enabled = true;
            timerUpdate.Start();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (exporter.Running)
            {
                timerUpdate.Start();
            }
            else
            {
                btnRun.Enabled = true;
                btnBack.Enabled = true;
            }
            textboxLog.Text = exporter.log;
        }
    }
}
