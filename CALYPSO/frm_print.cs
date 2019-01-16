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
    public partial class frm_print : Form
    {
        public Form1 frm1;
        public frm_print()
        {
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();
        }

        private void frm_print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataQuery.tbl_main' table. You can move, or remove it, as needed.
            this.tbl_mainTableAdapter.Fill(this.DataQuery.tbl_main, frm1.SelectedDoctorName, "Evet", DateTime.Parse(frm1.fromDate), DateTime.Parse(frm1.toDate));
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
       {
              new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter_totalprice","Toplam Ücret : "+frm1.Totalprice.ToString()+"₺")
        };
      
            this.reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }
      
        
   
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
