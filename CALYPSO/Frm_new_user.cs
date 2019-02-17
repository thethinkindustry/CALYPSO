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

namespace CALYPSO
{
    public partial class Frm_new_user : Form
    {
        public frm_login Frm_login;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        string sql = null;
        public Frm_new_user()
        {
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();
            string connetionString = "Data Source=DESKTOP-93568HR\\SQL_2014;Initial Catalog=db_calypso;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            var texts = groupBox1.Controls.OfType<TextBox>();
            foreach (TextBox txt in texts)
            {
                txt.Clear();
            }
            texts = groupBox2.Controls.OfType<TextBox>();
            foreach (TextBox txt in texts)
            {
                txt.Clear();
            }
        }

        private void txt_create_Click(object sender, EventArgs e)
        {
            bool control = false;
            var texts = groupBox1.Controls.OfType<TextBox>();
            foreach (TextBox txt in texts)
            {
                if (txt.Text=="")
                {
                    control = true;
                    break;
                }
            }
            texts = groupBox2.Controls.OfType<TextBox>();
            foreach (TextBox txt in texts)
            {
                if (txt.Text == "")
                {
                    control = true;
                    break;
                }
            }
            if (!control)
            {
                try
                {
                    cnn.Open();
                    string md5password = MD5eDonustur(txt_password.Text);
                    sql = "SELECT * FROM tbl_users WHERE password='"+md5password+"'and user_name='"+txt_user_name.Text+ "'and admin=1";
                    command = new SqlCommand(sql,cnn);
                    int count = 0;
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        count++;
                    }
                    if (count==1)
                    {
                        dataReader.Close();
                        command.Dispose();
                        if (txt_new_password.Text==txt_new_password2.Text)
                        {
                            md5password = MD5eDonustur(txt_new_password2.Text);
                            int status = 0;
                            if (radio_admin.Checked)
                            {
                                status = 1;
                            }
                            sql = "INSERT INTO tbl_users(password,user_name,admin)values(@pass,@name,@admin)";
                            command = new SqlCommand(sql, cnn);
                            command.Parameters.AddWithValue("@pass", md5password);
                            command.Parameters.AddWithValue("@name",txt_new_username.Text);                            command.Parameters.AddWithValue("@admin", status);
                            command.ExecuteNonQuery();
                            command.Dispose();
                            cnn.Close();
                            MessageBox.Show("Yeni Kullanıcı Oluşturuldu.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Şifreler birbiri ile uyuşmuyor.");
                        }
                   
                    }
                    else
                    {
                        MessageBox.Show("Hatalı ya da birden fazla eşleşme");
                        dataReader.Close();
                        command.Dispose();
                        cnn.Close();
                    }
                 //   int status = int.Parse(dataReader["admin"].ToString());
                   // MessageBox.Show(""+status);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA" + ex);
                    throw;
                }
            }
            else
            {
                lbl_login_error.Text = "*Boş alan bırakılamaz";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
