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
        //SqlDataAdapter adapter;
        DataTable table = new DataTable();
        string sql = null;
        UInt32 last_payment;
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
            dgv_procs.Rows.Clear();
            dgv_procs.ColumnCount = 7;
            dgv_procs.Columns[0].Name = "Yapılacak işlem";
            dgv_procs.Columns[1].Name = "Aşama";
            dgv_procs.Columns[2].Name = "Dişler";
            dgv_procs.Columns[3].Name = "Renk";
            dgv_procs.Columns[4].Name = "Adet";
            dgv_procs.Columns[5].Name = "Birim fiyat";
            dgv_procs.Columns[6].Name = "Fiyat";

            txt_ID.Text= frm1.dgv_main.CurrentRow.Cells[0].Value.ToString();
            cb_doctor_name.Text = frm1.dgv_main.CurrentRow.Cells[1].Value.ToString();
            txt_patient_name.Text = frm1.dgv_main.CurrentRow.Cells[2].Value.ToString();
            dtp_deadline.Text = frm1.dgv_main.CurrentRow.Cells[6].Value.ToString();
            rtx_doctor_notes.Text = frm1.dgv_main.CurrentRow.Cells[12].Value.ToString();
            string[] datas = new string[7];
            datas[0]= frm1.dgv_main.CurrentRow.Cells[3].Value.ToString();//işlem
            datas[1] = frm1.dgv_main.CurrentRow.Cells[4].Value.ToString();//aşama
            datas[2] = frm1.dgv_main.CurrentRow.Cells[8].Value.ToString();//diş
            datas[3]= frm1.dgv_main.CurrentRow.Cells[7].Value.ToString();//renk
            datas[4]= frm1.dgv_main.CurrentRow.Cells[9].Value.ToString();//adet
            datas[5] = frm1.dgv_main.CurrentRow.Cells[10].Value.ToString();//birim fiyat
            datas[6] = frm1.dgv_main.CurrentRow.Cells[11].Value.ToString();//toplam fiyat
            string[] processList = datas[0].Split('-');
            string[] stepList = datas[1].Split('-');
            string[] teethList = datas[2].Split('-');
            string[] colorList = datas[3].Split('-');
            string[] numberList = datas[4].Split('-');
            string[] upriceList = datas[5].Split('-');
            string[] priceList = datas[6].Split('-');
            for (int i = 0; i < processList.Length-1; i++)
            {
               dgv_procs.Rows.Add();
                dgv_procs.Rows[i].Cells[0].Value = processList[i];
                dgv_procs.Rows[i].Cells[1].Value = stepList[i];
                dgv_procs.Rows[i].Cells[2].Value = teethList[i];
                dgv_procs.Rows[i].Cells[3].Value = colorList[i];
                dgv_procs.Rows[i].Cells[4].Value = numberList[i];
                dgv_procs.Rows[i].Cells[5].Value = upriceList[i];
                dgv_procs.Rows[i].Cells[6].Value = priceList[i];
                total_price();
            }
            last_payment = UInt32.Parse(txt_all_prices.Text);
           
            // cb_procces_bar.Text = frm1.dgv_main.CurrentRow.Cells[3].Value.ToString();
            /* var radioButtons = grb_steps.Controls.OfType<RadioButton>();
              foreach (var rb in radioButtons)
              {
                  if (rb.Text == frm1.dgv_main.CurrentRow.Cells[4].Value.ToString())
                  {
                      rb.Checked = true;
                  }
              }*/

            //cb_color.Text = frm1.dgv_main.CurrentRow.Cells[7].Value.ToString();
            //string teeth= frm1.dgv_main.CurrentRow.Cells[8].Value.ToString();
            //string[] teethList = teeth.Split('/');
            /* var radioButton = grb_teeth.Controls.OfType<PictureBox>();
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
               
            }*/
            //txt_u_price.Text= frm1.dgv_main.CurrentRow.Cells[10].Value.ToString();

            // last_payment =Convert.ToInt32(frm1.dgv_main.CurrentRow.Cells[9].Value.ToString())* Convert.ToInt32(frm1.dgv_main.CurrentRow.Cells[10].Value.ToString());
        }
         void total_price()
        {
            UInt32 prices = 0;
            for (int i = 0; i < dgv_procs.RowCount; i++)
            {
                if (dgv_procs.Rows[i].Cells[6].Value.ToString()!="")
                {
                    prices += Convert.ToUInt32(dgv_procs.Rows[i].Cells[6].Value.ToString());
                }
                
            }
            txt_all_prices.Text = prices.ToString();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string[] datas = new string[7];
            if (string.IsNullOrEmpty(rtx_doctor_notes.Text))
            {
                rtx_doctor_notes.Text = "Yok";
            }
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < dgv_procs.RowCount; i++)
                {
                    datas[j] += dgv_procs.Rows[i].Cells[j].Value.ToString() + "-";
                }
            }
            try
            {

                cnn.Open();
                sql = "UPDATE  tbl_main SET dr_name =@dr_name,patient_name=@pat,process_name=@proc,color=@color,teeth=@teeth,num=@num ,unit_price=@price,price=@total_price,step=@step,deadline=@deadline,dr_note=@dr_note WHERE proc_id=@ID";
                command = new SqlCommand(sql, cnn);
                command.Parameters.Add(new SqlParameter("@dr_name", cb_doctor_name.Text));
                command.Parameters.Add(new SqlParameter("@pat", txt_patient_name.Text));
                command.Parameters.Add(new SqlParameter("@proc", datas[0]));
                command.Parameters.Add(new SqlParameter("@color", datas[3]));
                command.Parameters.Add(new SqlParameter("@teeth", datas[2]));
                command.Parameters.Add(new SqlParameter("@num", datas[4]));
                command.Parameters.Add(new SqlParameter("@price", datas[5]));
                command.Parameters.Add(new SqlParameter("@total_price", datas[6]));
                command.Parameters.Add(new SqlParameter("@step", datas[1]));
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
                payment += double.Parse(txt_all_prices.Text);
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
        private void dgv_procs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_procces_bar.Text = dgv_procs.CurrentRow.Cells[0].Value.ToString();
            cb_color.Text = dgv_procs.CurrentRow.Cells[3].Value.ToString();
            txt_u_price.Text= dgv_procs.CurrentRow.Cells[5].Value.ToString();
            string teeth = dgv_procs.CurrentRow.Cells[2].Value.ToString();
            string[] teethList = teeth.Split('/');
            var radioButton = grb_teeth.Controls.OfType<PictureBox>();
            foreach (PictureBox rb in radioButton)
            {
                for (int i = 0; i < teethList.Length; i++)
                {
                    if (rb.Name == teethList[i].ToString())
                    {
                        i = teethList.Length + 1;
                        rb.BackColor = Color.DarkSlateGray;
                        // MessageBox.Show(rb.Name);
                    }
                    else
                    {
                        rb.BackColor = Color.Transparent;
                    }
                }
            }
            var radioButtons = pnl_patient_info.Controls.OfType<RadioButton>();
            foreach (var rb in radioButtons)
            {
                if (rb.Text == dgv_procs.CurrentRow.Cells[1].Value.ToString())
                {
                    rb.Checked = true;
                }

            }
        }
        private void btn_onedelete_Click(object sender, EventArgs e)
        {
            if (this.dgv_procs.SelectedRows.Count > 0)
            {
                dgv_procs.Rows.RemoveAt(this.dgv_procs.SelectedRows[0].Index);
                cb_procces_bar.Text = "";
                cb_color.Text = "";
                txt_u_price.Text= "";
                var radioButtons = pnl_patient_info.Controls.OfType<RadioButton>();
                foreach (var rb in radioButtons)
                {
                     rb.Checked = false;
                }
                var radioButton = grb_teeth.Controls.OfType<PictureBox>();
                foreach (PictureBox rb in radioButton)
                {
                     rb.BackColor = Color.Transparent;
                }
            }
        }
        private void btn_one_update_Click(object sender, EventArgs e)
        {
            bool istrue = true;
            var check = pnl_patient_info.Controls.OfType<RadioButton>();
            foreach (var ck in check)
            {
                if (ck.Checked==true)
                {
                    istrue = false;
                }
            }
            if (txt_patient_name.Text==""||cb_color.Text==""||cb_doctor_name.Text==""||cb_procces_bar.Text==""||istrue)
            {
                lbl_error.Text = "*Zorunlu alanlar boş bırakılamaz.";
                return;
            }
            string selectedTeeth = "";
            int counter = 0;
            if (this.dgv_procs.SelectedRows.Count > -1)
            {
                int rowindex = dgv_procs.CurrentCell.RowIndex;
                dgv_procs.Rows[rowindex].Cells[0].Value=cb_procces_bar.Text;
                var _radioButtons = pnl_patient_info.Controls.OfType<RadioButton>();
                foreach (var rb in _radioButtons)
                {
                    if (rb.Checked==true)
                    {
                        dgv_procs.Rows[rowindex].Cells[1].Value = rb.Text;
                    }
                }
                var teeth = grb_teeth.Controls.OfType<PictureBox>();
                foreach (PictureBox pic in teeth)
                {
                    if (pic.BackColor == Color.DarkSlateGray)
                    {
                        counter++;
                        selectedTeeth += pic.Name + "/";
                    } 
                }
                if (counter==0)
                {
                    counter = 1;
                }
                dgv_procs.Rows[rowindex].Cells[2].Value = selectedTeeth;
                dgv_procs.Rows[rowindex].Cells[3].Value = cb_color.Text;
                dgv_procs.Rows[rowindex].Cells[4].Value = counter.ToString();
                dgv_procs.Rows[rowindex].Cells[5].Value =txt_u_price.Text;
                dgv_procs.Rows[rowindex].Cells[6].Value =(UInt16.Parse( txt_u_price.Text)*counter).ToString();
                total_price();
                cb_procces_bar.Text = "";
                cb_color.Text = "";
                txt_u_price.Text = "";
                var radioButtons = pnl_patient_info.Controls.OfType<RadioButton>();
                foreach (var rb in radioButtons)
                {
                    rb.Checked = false;
                }
                var radioButton = grb_teeth.Controls.OfType<PictureBox>();
                foreach (PictureBox rb in radioButton)
                {
                    rb.BackColor = Color.Transparent;
                }
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