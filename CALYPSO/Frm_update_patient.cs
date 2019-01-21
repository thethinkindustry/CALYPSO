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
    public partial class Frm_update_patient : Form
    {
        public Form1 frm1;
        OleDbConnection con;
        OleDbCommand cmd;
        string query;
        OleDbDataReader reader;
        int last_payment;
        int counter = 0;
        public Frm_update_patient()
        {
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_calypso.mdb"); cmd = new OleDbCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                query = "select * From tbl_process ";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb_procces_bar.Items.Add(reader["process"].ToString());
                }
                reader.Close();

                query = "select * From tbl_dr";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb_doctor_name.Items.Add(reader["d_name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                throw;
            }
            var radioButtons = grb_teeth.Controls.OfType<PictureBox>();
            foreach (PictureBox rb in radioButtons)
            {
                rb.MouseClick += new MouseEventHandler((o, a) => onClickList(rb));
            }
        }
        public void onClickList(PictureBox rb)
        {
            if (rb.BackColor == Color.DarkSlateGray)
            {

                rb.BackColor = Color.White;
            }
            else
            {
                rb.BackColor = Color.DarkSlateGray;
            }

        }
        private void Frm_update_patient_Load(object sender, EventArgs e)
        {
            txt_ID.Text= frm1.dgv_main.CurrentRow.Cells[0].Value.ToString();
            cb_doctor_name.Text = frm1.dgv_main.CurrentRow.Cells[1].Value.ToString();
            txt_patient_name.Text = frm1.dgv_main.CurrentRow.Cells[2].Value.ToString();
            cb_procces_bar.Text = frm1.dgv_main.CurrentRow.Cells[3].Value.ToString();

            var radioButtons = grb_steps.Controls.OfType<RadioButton>();
            foreach (var rb in radioButtons)
            {
                if (rb.Text == frm1.dgv_main.CurrentRow.Cells[4].Value.ToString())
                {
                    rb.Checked = true;
                }
            }
            dtp_deadline.Text = frm1.dgv_main.CurrentRow.Cells[6].Value.ToString();
            cb_color.Text = frm1.dgv_main.CurrentRow.Cells[7].Value.ToString();
             string teeth= frm1.dgv_main.CurrentRow.Cells[8].Value.ToString();
            string[] teethList = teeth.Split('/');
            var radioButton = grb_teeth.Controls.OfType<PictureBox>();
            foreach (PictureBox rb in radioButton)
            {
                for (int i = 0; i < teethList.Length; i++)
                {
                    if (rb.Name == teethList[i].ToString())
                    {
                        rb.BackColor = Color.DarkSlateGray;
                    }
                }
               
            }
            txt_u_price.Text= frm1.dgv_main.CurrentRow.Cells[10].Value.ToString();
           
            rtx_doctor_notes.Text= frm1.dgv_main.CurrentRow.Cells[12].Value.ToString();
            last_payment =Convert.ToInt32(frm1.dgv_main.CurrentRow.Cells[9].Value.ToString())* Convert.ToInt32(frm1.dgv_main.CurrentRow.Cells[10].Value.ToString());
        }
        


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool istrue = false;
            var rbtn = grb_steps.Controls.OfType<RadioButton>();
            foreach (var rb in rbtn)
            {
                if (rb.Checked)
                {
                    istrue = true;
                }
            }
            if (txt_patient_name.Text == "" || string.IsNullOrEmpty(cb_doctor_name.Text) ||
                string.IsNullOrEmpty(cb_procces_bar.Text) || !istrue)
            {
                MessageBox.Show("Zorunlu Alnlar Doldurulmalıdır.");

                return;
            }
            if (string.IsNullOrEmpty(cb_color.Text))
            {
                cb_color.Text = "Yok";
            }
            var picture = grb_teeth.Controls.OfType<PictureBox>();
          
            string teeth = "";
            foreach (PictureBox pb in picture)
            {
                if (pb.BackColor == Color.DarkSlateGray)
                {
                    counter++;
                    teeth += pb.Name.ToString() + "/";
                }
            }
            if (counter==0)
            {
                counter = 1;
            }
            if (string.IsNullOrEmpty(txt_u_price.Text))
            {
                txt_u_price.Text = "0";
            }
            if (string.IsNullOrEmpty(rtx_doctor_notes.Text))
            {
                rtx_doctor_notes.Text = "Yok";
            }
            try
            {
               
                OleDbCommand cmd = new OleDbCommand("UPDATE  tbl_main SET dr_name =@dr_name,patient_name=@pat,process_name=@proc,color=@color,teeth=@teeth,num=@num ,unit_price=@price,price=@total_price,step=@step,deadline=@dealine,dr_note=@dr_note WHERE proc_id=@ID", con);

                cmd.Parameters.AddWithValue("@dr_name", cb_doctor_name.Text);
                cmd.Parameters.AddWithValue("@pat", txt_patient_name.Text);
                cmd.Parameters.AddWithValue("@proc", cb_procces_bar.Text);
                cmd.Parameters.AddWithValue("@color", cb_color.Text);
                cmd.Parameters.AddWithValue("@teeth", teeth);
                cmd.Parameters.AddWithValue("@num", counter.ToString());
                cmd.Parameters.AddWithValue("@price", txt_u_price.Text);
                cmd.Parameters.AddWithValue("@total_price", Convert.ToInt16(txt_u_price.Text) * counter);
                var radioButtons = grb_steps.Controls.OfType<RadioButton>();
                foreach (var rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        cmd.Parameters.AddWithValue("@step", rb.Text);
                    }
                }
                cmd.Parameters.AddWithValue("@deadline", dtp_deadline.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@dr_note", rtx_doctor_notes.Text);
                cmd.Parameters.AddWithValue("@ID", txt_ID.Text);
                cmd.ExecuteNonQuery();
                string query_ = "SELECT kimlik, payment FROM tbl_dr WHERE d_name='" + cb_doctor_name.Text + "' ";
                OleDbCommand cmdw = new OleDbCommand();
                cmdw.Connection = con;
                cmdw.CommandText = query_;
                OleDbDataReader read = cmdw.ExecuteReader();
                double payment = 0;
                int kimlik = 0;

                while (read.Read())
                {
                    payment = Convert.ToDouble(read["payment"].ToString());
                    kimlik = Convert.ToInt16(read["kimlik"].ToString());
                }
                read.Close();
                payment += counter * Convert.ToInt64(txt_u_price.Text);
                payment -= last_payment;
                OleDbCommand cmdk = new OleDbCommand("UPDATE tbl_dr SET payment = @pay WHERE kimlik = @id", con);
                cmdk.Parameters.AddWithValue("@pay", payment.ToString());
                cmdk.Parameters.AddWithValue("@id", kimlik);
                cmdk.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla tamamlandı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);
                throw;
            }

        }

        private void btn_dr_add_Click(object sender, EventArgs e)
        {
            con.Close();
            reader.Close();
            Form frmDRadd = new frm_dr_add();
            frmDRadd.ShowDialog();
            cb_doctor_name.Items.Clear();
            try
            {
                con.Open();
                query = "select * From tbl_dr";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb_doctor_name.Items.Add(reader["d_name"].ToString());
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }

        }

        private void btn_add_process_Click(object sender, EventArgs e)
        {
            con.Close();
            Form frm_add_process = new Frm_add_process();
            frm_add_process.ShowDialog();
            cb_procces_bar.Items.Clear();
            try
            {

                con.Open();
                cmd.Connection = con;
                query = "select * From tbl_process ";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb_procces_bar.Items.Add(reader["process"].ToString());
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }

        private void txt_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
          DialogResult result=  MessageBox.Show(txt_ID.Text+" Numaralı işlemi silmek istediğinizden emin misiniz?","Veriler Silinecek",MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM tbl_main  WHERE proc_id = @id", con);
                    cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata" + ex);
                    throw;
                }
                string query_ = "SELECT kimlik, payment FROM tbl_dr WHERE d_name='" + cb_doctor_name.Text + "' ";
                OleDbCommand cmdw = new OleDbCommand();
                cmdw.Connection = con;
                cmdw.CommandText = query_;
                OleDbDataReader read = cmdw.ExecuteReader();
                double payment = 0;
                int kimlik = 0;

                while (read.Read())
                {
                    payment = Convert.ToDouble(read["payment"].ToString());
                    kimlik = Convert.ToInt16(read["kimlik"].ToString());
                }
                read.Close();
                payment -= last_payment;
                OleDbCommand cmdk = new OleDbCommand("UPDATE tbl_dr SET payment = @pay WHERE kimlik = @id", con);
                cmdk.Parameters.AddWithValue("@pay", payment.ToString());
                cmdk.Parameters.AddWithValue("@id", kimlik);
                cmdk.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla silindi");
                this.Close();
            }

        }
    }

}