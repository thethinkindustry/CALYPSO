using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CALYPSO
{
    public partial class frm_dr_add : Form
    {
        
        public frm_dr_add()
        {
           
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();

        }

        private void grb_new_register_Enter(object sender, EventArgs e)
        {

        }

        private void btn_new_dr_save_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_calypso.mdb");
            con.Open();
            string query = "insert into tbl_dr (d_name,d_number) values(@pname,@pnumber)";
            OleDbCommand cmd= new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@pname", txt_doctor_name.Text);
            cmd.Parameters.AddWithValue("@number", txt_dr_number.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
           
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
