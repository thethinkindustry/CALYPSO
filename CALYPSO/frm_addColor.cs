using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CALYPSO
{
    public partial class frm_addColor : Form
    {
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        string sql = null;
        public frm_addColor()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.TopMost = true;
            this.BringToFront();
            this.StartPosition = FormStartPosition.CenterScreen;
            string connetionString = null;
            connetionString = "Data Source=DESKTOP-93568HR\\SQL_2014;Initial Catalog=db_calypso;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
        }
        private void frm_addColor_Load(object sender, EventArgs e)
        {
            cnn.Open();
            sql = "SELECT Color_name FROM tbl_colors";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_color_delete.Items.Add(dataReader["Color_name"].ToString());
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_color_add.Text!="")
            {
                cnn.Open();
                sql = "insert into tbl_colors (Color_name) values(@color)";
                command = new SqlCommand(sql, cnn);
                command.Parameters.Add(new SqlParameter("@color", txt_color_add.Text));
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                this.Close();
            }
            else
            {
                lbl_error.Text = "Alan boş bırakılamaz.";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmb_color_delete.SelectedIndex>-1)
            {
                cnn.Open();
                sql = "DELETE FROM tbl_colors  WHERE Color_name = @color";
                command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@color", cmb_color_delete.SelectedItem.ToString());
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                this.Close();
            }
            else
            {
                lbl_er.Text = "*Kaldırılacak rengi seçiniz.";
            }
           
        }

        private void btn_add_colorpnl_Click(object sender, EventArgs e)
        {
            pnl_add_color.Visible = true;
        }

        private void btn_color_removepnl_Click(object sender, EventArgs e)
        {
            pnl_add_color.Visible = false;
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
