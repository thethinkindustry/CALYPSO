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
    public partial class Frm_update_patient : Form
    {
        public Form1 frm1;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        string sql = null;
        int last_payment;
        int counter = 0;
        public Frm_update_patient()
        {
            InitializeComponent();
            // clearText(pnl_update_patient);
            this.TopMost = true;
            this.BringToFront();
            string connetionString = null;
            connetionString = "Data Source=DESKTOP-93568HR\\SQL_2014;Initial Catalog=db_calypso;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                sql = "select * From tbl_process ";
                command = new SqlCommand(sql,cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb_procces_bar.Items.Add(dataReader["process"].ToString());
                }
                dataReader.Close();
                command.Dispose();
                sql = "select * From tbl_dr";
                command = new SqlCommand(sql,cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb_doctor_name.Items.Add(dataReader["d_name"].ToString());
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                throw;
            }
            foreach (Control c in grb_teeth.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox questionTextBox = c as PictureBox;
                    questionTextBox.BackColor = Color.Transparent;
                  
                }
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

                rb.BackColor = Color.Transparent;
            }
            else
            {
                rb.BackColor = Color.DarkSlateGray;
            }

        }
        public void clearText(Panel PanelID)
        {
            var grb = PanelID.Controls.OfType<GroupBox>();
            foreach (GroupBox rb in grb)
            {
                foreach (Control c in rb.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox questionTextBox = c as TextBox;
                        if (questionTextBox != null)
                        {
                            questionTextBox.Text = "";
                        }
                    }
                    else if (c is ComboBox)
                    {
                        ComboBox questionTextBox = c as ComboBox;
                        if (questionTextBox != null)
                        {
                            questionTextBox.Text = "";
                        }
                    }
                    else if (c is RichTextBox)
                    {
                        RichTextBox questionTextBox = c as RichTextBox;
                        if (questionTextBox != null)
                        {
                            questionTextBox.Text = "";
                        }
                    }
                    else if (c is PictureBox)
                    {
                        PictureBox questionTextBox = c as PictureBox;
                        questionTextBox.BackColor = Color.Transparent;
                    }
                    else if (c is RadioButton)
                    {
                        RadioButton questionTextBox = c as RadioButton;
                        if (questionTextBox.Checked)
                        {
                            questionTextBox.Checked = false;
                        }
                    }
                }

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
                        i = teethList.Length+1;
                        rb.BackColor = Color.DarkSlateGray;
                       // MessageBox.Show(rb.Name);
                    }
                    else
                    {
                        rb.BackColor = Color.Transparent;
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
            counter = 0;
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
                cnn.Open();
                sql = "UPDATE  tbl_main SET dr_name =@dr_name,patient_name=@pat,process_name=@proc,color=@color,teeth=@teeth,num=@num ,unit_price=@price,price=@total_price,step=@step,deadline=@deadline,dr_note=@dr_note WHERE proc_id=@ID";
                command = new SqlCommand(sql, cnn);
                command.Parameters.Add(new SqlParameter("@dr_name", cb_doctor_name.Text));
                command.Parameters.Add(new SqlParameter("@pat", txt_patient_name.Text));
                command.Parameters.Add(new SqlParameter("@proc", cb_procces_bar.Text));
                command.Parameters.Add(new SqlParameter("@color", cb_color.Text));
                command.Parameters.Add(new SqlParameter("@teeth", teeth));
                command.Parameters.Add(new SqlParameter("@num", counter.ToString()));
                command.Parameters.Add(new SqlParameter("@price", txt_u_price.Text));
                command.Parameters.Add(new SqlParameter("@total_price", Convert.ToInt16(txt_u_price.Text) * counter));
                var radioButtons = grb_steps.Controls.OfType<RadioButton>();
                foreach (var rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        command.Parameters.Add(new SqlParameter("@step", rb.Text));
                    }
                }
                command.Parameters.Add(new SqlParameter("@deadline", dtp_deadline.Value.ToString("yyyy-MM-dd")));
                command.Parameters.Add(new SqlParameter("@dr_note", rtx_doctor_notes.Text));
                command.Parameters.Add(new SqlParameter("@ID", txt_ID.Text));
                command.ExecuteNonQuery();
                command.Dispose();
                 sql = "SELECT kimlik, payment FROM tbl_dr WHERE d_name='" + cb_doctor_name.Text + "' ";
                command = new SqlCommand(sql,cnn);
                dataReader= command.ExecuteReader();
                double payment = 0;
                int kimlik = 0;
                while (dataReader.Read())
                {
                    payment = Convert.ToDouble(dataReader["payment"].ToString());
                    kimlik = Convert.ToInt16(dataReader["kimlik"].ToString());
                }
                dataReader.Close();
                command.Dispose();
                payment += counter * Convert.ToInt64(txt_u_price.Text);
                payment -= last_payment;
                sql = "UPDATE tbl_dr SET payment = @pay WHERE kimlik = @id";
                command =new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@pay", payment.ToString());
                command.Parameters.AddWithValue("@id", kimlik);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Kayıt başarıyla tamamlandı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);
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
                    cnn.Open();
                    sql = "DELETE FROM tbl_main  WHERE proc_id = @id";
                    command =new SqlCommand(sql,cnn);
                    command.Parameters.AddWithValue("@id", txt_ID.Text);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata" + ex);
                    throw;
                }
                cnn.Open();
                sql = "SELECT kimlik, payment FROM tbl_dr WHERE d_name='" + cb_doctor_name.Text + "' ";
                command= new SqlCommand(sql,cnn);
                dataReader = command.ExecuteReader();
                double payment = 0;
                int kimlik = 0;
                while (dataReader.Read())
                {
                    payment = Convert.ToDouble(dataReader["payment"].ToString());
                    kimlik = Convert.ToInt16(dataReader["kimlik"].ToString());
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
                cnn.Open();
                payment -= last_payment;
                sql = "UPDATE tbl_dr SET payment = @pay WHERE kimlik = @id";
                command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@pay", payment.ToString());
                command.Parameters.AddWithValue("@id", kimlik);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Kayıt başarıyla silindi");
                this.Close();
            }

        }

    }

}