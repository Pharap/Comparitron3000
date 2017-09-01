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
        Settings settings = null;
        ComparitronExporter exporter = null;

        public FormExport(ComparitronCore comparitron, Settings settings)
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
                timerUpdate.Enabled = false;
            }
            textboxLog.Text = exporter.log;
            textboxLog.Select(textboxLog.Text.Length - 1, 0);
            textboxLog.ScrollToCaret();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textboxLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
