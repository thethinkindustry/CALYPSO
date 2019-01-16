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
    public partial class Frm_add_process : Form
    {
        public Frm_add_process()
        {
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_calypso.mdb");
            con.Open();
            string query = "insert into tbl_process (process) values(@pprocess)";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@pprocess", txt_process_name.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
