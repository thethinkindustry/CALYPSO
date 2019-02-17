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
        SqlDataReader dataReader;
    
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

        private void Frm_add_process_Load(object sender, EventArgs e)
        {
            cnn.Open();
            sql = "SELECT process FROM tbl_process";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_procces_delete.Items.Add(dataReader["process"].ToString());
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_process_name.Text!="")
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);
                throw;
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_procces_delete.SelectedItem.ToString() != "")
            {
                cnn.Open();
                sql = "DELETE FROM tbl_process  WHERE process = @proc";
                command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@proc", cmb_procces_delete.SelectedItem.ToString());
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                this.Close();
            }
        }
    }
}
