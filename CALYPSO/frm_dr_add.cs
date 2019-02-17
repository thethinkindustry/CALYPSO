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
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        string sql = null;

        public frm_dr_add()
        {
           
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();
            string connetionString = "Data Source=DESKTOP-93568HR\\SQL_2014;Initial Catalog=db_calypso;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

        }
         private void frm_dr_add_Load(object sender, EventArgs e)
        {
            cnn.Open();
            sql = "SELECT d_name FROM tbl_dr";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_dr_delete.Items.Add(dataReader["d_name"].ToString());
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
        private void btn_new_dr_save_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmb_dr_delete.SelectedItem.ToString()!="")
            {
                cnn.Open();
                sql = "DELETE FROM tbl_dr  WHERE d_name = @name";
                command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@name", cmb_dr_delete.SelectedItem.ToString());
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                this.Close();
            }
           
        }
    }
}
