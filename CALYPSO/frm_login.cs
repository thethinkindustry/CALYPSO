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
using System.Security.Cryptography;
using System.Threading;

namespace CALYPSO
{
    public partial class frm_login : Form
    {
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        Frm_new_user frm_new_user;
        Thread th;
        Form1 frm1;
        string sql = null;
        public frm_login()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.Opacity =.99;
            this.TopMost = true;
            this.BringToFront();
            frm_new_user = new Frm_new_user();
            frm_new_user.Frm_login = this;
            txt_password.PasswordChar = '*';
            string connetionString = "Data Source=DESKTOP-93568HR\\SQL_2014;Initial Catalog=db_calypso;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            //btn_eye.BackColor = Color.Transparent;
            
        }

        private void btn_eye_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '\0';
        }

        private void btn_eye_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        int status = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text != "" && txt_password.Text != "")
            {
                cnn.Open();
                string md5password = MD5eDonustur(txt_password.Text);
                sql = "SELECT * FROM tbl_users WHERE password='" + md5password + "'and user_name='" + txt_user_name.Text + "'";
                command = new SqlCommand(sql, cnn);
                int count = 0;

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    status = int.Parse(dataReader["admin"].ToString());
                    count++;
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
                if (count == 1)
                {
                    this.Close();
                    th = new Thread(openNewForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    lbl_error.Text = "*Kullanıcı adı ya da şifre hatalı";
                }
            }
            else
            {
                lbl_error.Text = "*Kullanıcı adı ya da şifre hatalı";
            }
            
        }
        public static string MD5eDonustur(string metin)
        {
            MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
            return encryption(metin, pwd);
        }
        private static string encryption(string metin, HashAlgorithm alg)
        {
            byte[] byteDegeri = System.Text.Encoding.UTF8.GetBytes(metin);
            byte[] sifreliByte = alg.ComputeHash(byteDegeri);
            return Convert.ToBase64String(sifreliByte);
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void openNewForm(object obj)
        {
            Application.Run(new Form1(status));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_new_user.ShowDialog();
            this.Visible = true;
        }
    }
}
