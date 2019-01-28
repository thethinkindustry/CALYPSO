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
using System.Data.SqlClient;
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

        private void btn_new_dr_save_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = "Data Source=DESKTOP-93568HR\\SQL_2014;Initial Catalog=db_calypso;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "insert into tbl_dr (d_name ,d_number,payment) values(@pname,@number,@payment)";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.Add(new SqlParameter("@pname", txt_doctor_name.Text));
                command.Parameters.Add(new SqlParameter("@number", txt_dr_number.Text));
                command.Parameters.Add(new SqlParameter("@payment", "0"));
                command.ExecuteNonQuery();
               cnn.Close();
                this.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
        }
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
