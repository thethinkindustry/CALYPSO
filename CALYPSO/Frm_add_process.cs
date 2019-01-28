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
    public partial class Frm_add_process : Form
    {
        SqlConnection cnn;
        SqlCommand command;
    
        string sql = null;
        public Frm_add_process()
        {
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();
            string connetionString = null;
            connetionString = "Data Source=DESKTOP-93568HR\\SQL_2014;Initial Catalog=db_calypso;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
        
        }
         private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                sql = "insert into tbl_process (process) values(@pprocess)";
                command = new SqlCommand(sql, cnn);
                command.Parameters.Add(new SqlParameter("@pprocess", txt_process_name.Text));
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);
                throw;
            }
        
        }
    }
}
