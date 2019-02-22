using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALYPSO
{
    public partial class Frm_print_payment_historycs : Form
    {
        public Form1 frm1;
        public Frm_print_payment_historycs()
        {
            InitializeComponent();
            this.BringToFront();
        }
        Microsoft.Reporting.WinForms.ReportDataSource rs = new Microsoft.Reporting.WinForms.ReportDataSource();
        private void Frm_print_payment_historycs_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DataQuery.tbl_main' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
            rs.Name = "DataSet2";
            rs.Value = frm1.lst2;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs);
           reportViewer1.LocalReport.ReportEmbeddedResource = "CALYPSO.ReportPage.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
    {
              new Microsoft.Reporting.WinForms.ReportParameter("ReportParametertotalPayment",frm1.Totalprice.ToString() )
        // new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter_lastpayment",frm1.p_info.dr_last_payment.ToString()+"₺")
    };
            this.reportViewer1.LocalReport.SetParameters(rParams);

            this.reportViewer1.RefreshReport();
        }
    }
}
