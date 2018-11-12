using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace RetailConnectPOS
    {
    public partial class Pay : Form
        {
        public Pay()
            {
            InitializeComponent();
            }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
            {
            ReportDocument cryRpt = new ReportDocument();

            cryRpt.Load(@"C:\Users\user\Desktop\RetailConnectPOS\RetailConnectPOS\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            }
        }
    }
