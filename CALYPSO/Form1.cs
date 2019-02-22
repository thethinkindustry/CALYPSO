using System;
using System.Collections;

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
using System.Globalization;

namespace CALYPSO
{
    public partial class Form1 : Form
    {
        public Frm_update_patient frm_update;
        public frm_print Frm_print;
        public frm_login Frm_login;
        public Frm_print_payment_historycs frm_print_payment_history;
        public frm_addColor Frm_addColor;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter adapter;
        DataView dv;
        int status;
        string sql = null;
        public  print_informations p_info = new print_informations();
        public int Totalprice = 0;
        DataTable table = new DataTable();
        public List<payment_history> lst2 = new List<payment_history>();
        public List<patient> lst = new List<patient>();
        
        public Form1(int _status)
        { 

            InitializeComponent();
            status = _status;
            Frm_print = new frm_print();
            frm_update = new Frm_update_patient();
            frm_print_payment_history = new Frm_print_payment_historycs();
            Frm_print.frm1 = this;
            frm_update.frm1 = this;
            frm_print_payment_history.frm1 = this;
            string connetionString = null;
            connetionString = "Data Source=DESKTOP-93568HR\\SQL_2014;Initial Catalog=db_calypso;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
          //  MessageBox.Show(""+status);
            if (status == 0)
            {
                pb_payment.Visible = false;
               
            }
            else {
                pb_payment.Visible = true;
               
            }
            try
            {
                cnn.Open();
               // MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Can not open connection ! ");
            }

            try
            {
                cnn.Open();
                sql = "SELECT d_name FROM tbl_dr";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb_doctor_name.Items.Add(dataReader["d_name"].ToString());
                }
                dataReader.Close();
                command.Dispose();

                sql = "SELECT process FROM tbl_process";
                command = new SqlCommand(sql,cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb_procces_bar.Items.Add(dataReader["process"].ToString());
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
                cnn.Open();
                sql = "SELECT Color_name FROM tbl_colors";
                command = new SqlCommand(sql,cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb_color.Items.Add(dataReader["Color_name"].ToString());
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
       
        private void btn_dr_add_Click(object sender, EventArgs e)
        {
            pnl_add_info.Visible = false;
           Form frmDRadd = new frm_dr_add();
            frmDRadd.ShowDialog();
            pnl_add_info.Visible = true;
            cb_doctor_name.Items.Clear();
            try
            {
                cnn.Open();
                sql = "select * From tbl_dr";
                command = new SqlCommand(sql, cnn);
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
                MessageBox.Show("ERROR" + ex);
                throw;
            }

        }
        private void btn_add_process_Click(object sender, EventArgs e)
        {
            //con.Close();
            pnl_add_info.Visible = false;
            Form frm_add_process = new Frm_add_process();
            frm_add_process.ShowDialog();
            pnl_add_info.Visible = true;
            cb_procces_bar.Items.Clear();
            try
            {
                cnn.Open();
                sql= "select * From tbl_process ";
                command = new SqlCommand(sql,cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb_procces_bar.Items.Add(dataReader["process"].ToString());
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }
        private void btn_addColor_Click(object sender, EventArgs e)
        {
            pnl_add_info.Visible = false;
            Form frm_add_Color = new frm_addColor();
            frm_add_Color.ShowDialog();
            pnl_add_info.Visible = true;
            cb_color.Items.Clear();
            try
            {
                cnn.Open();
                sql = "select * From tbl_colors ";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb_color.Items.Add(dataReader["Color_name"].ToString());
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pnl_add_patient.Visible = false;
            pnl_init.Visible = true;
        }
        private void btn_add_proc_Click(object sender, EventArgs e)
        {
            bool istrue=false;
            string step = "";
            bool bitis = false; ;
            var rbtn = pnl_add_info.Controls.OfType<RadioButton>();
            foreach (var rb in rbtn)
            {
                if (rb.Checked)
                {
                    
                    istrue = true;
                    step = rb.Text;
                    if (rb.Text == "Bitiş")
                    {
                        bitis = true;
                    }
                    break;
                }
            }
            if (bitis)
            {
                if ((txt_unit_price.Text == "0") || txt_unit_price.Text == "")
                {
                    MessageBox.Show("Bitiş aşamasında fiyat girilimelidir.");
                    return;
                }

            }
            if (txt_patient_name.Text == "" || string.IsNullOrEmpty(cb_doctor_name.Text) ||
                string.IsNullOrEmpty(cb_procces_bar.Text) || !istrue)
            {
               lbl_error.Text="Zorunlu Alnlar Doldurulmalıdır.";
                return;
            }
            else
            {
                lbl_error.Text = "";
            }
            if (string.IsNullOrEmpty(cb_color.Text))
            {
                cb_color.Text = "Yok";
            }
            var picture = grb_teeth.Controls.OfType<PictureBox>();
            int counter = 0;
            string teeth = "";
            foreach (PictureBox pb in picture)
            {
                if (pb.BackColor == Color.DarkSlateGray)
                {
                    counter++;
                    teeth += pb.Name.ToString() + "/";
                }
            }
            if (counter == 0)
            {
                counter = 1;
            }
            if (string.IsNullOrEmpty(txt_unit_price.Text))
            {
                txt_unit_price.Text = "0";
            }
            if (string.IsNullOrEmpty(teeth))
            {
                teeth = "X";
            }
            int i = dgv_procs.Rows.Add();
          
            dgv_procs.Rows[i].Cells[0].Value = cb_procces_bar.Text; 
            dgv_procs.Rows[i].Cells[1].Value = step;
            dgv_procs.Rows[i].Cells[2].Value = teeth;
            dgv_procs.Rows[i].Cells[3].Value = cb_color.Text;
            dgv_procs.Rows[i].Cells[4].Value = counter.ToString();
            dgv_procs.Rows[i].Cells[5].Value = txt_unit_price.Text;
            dgv_procs.Rows[i].Cells[6].Value = (int.Parse(txt_unit_price.Text)*counter).ToString();
            for (int j = 0; j < dgv_procs.Rows.Count; j+= 2)
            {

                dgv_procs.Rows[j].DefaultCellStyle.BackColor = Color.LightGray;

            }
            total_price();
        }
        private void dgv_procs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_procs.SelectedRows.Count > 0)
            {
                dgv_procs.Rows.RemoveAt(this.dgv_procs.SelectedRows[0].Index);
                total_price();
            }
            for (int j = 0; j < dgv_procs.Rows.Count; j += 2)
            {

                dgv_procs.Rows[j].DefaultCellStyle.BackColor = Color.LightGray;

            }
        }
        void total_price()
        {
            UInt32 prices = 0;
            for (int i = 0; i < dgv_procs.RowCount; i++)
            {
                prices += Convert.ToUInt32(dgv_procs.Rows[i].Cells[6].Value.ToString());
            }
            txt_all_prices.Text = prices.ToString();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dgv_procs.RowCount > 0)
            {
               
            if (string.IsNullOrEmpty(rtx_doctor_notes.Text))
            {
                rtx_doctor_notes.Text = "Yok";
            }
                string[] datas = new string[7];
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
                    sql = "insert into tbl_main(dr_name,patient_name,process_name,color,teeth,num ,unit_price,price,step, init_date,deadline,dr_note)values(@pname,@pat,@proc,@color,@teeth,@num,@price,@total_price,@step,@init_date,@deadline,@dr_note)";
                    command = new SqlCommand(sql, cnn);
                    command.Parameters.Add(new SqlParameter("@pname", cb_doctor_name.Text));
                    command.Parameters.Add(new SqlParameter("@pat", txt_patient_name.Text));
                    command.Parameters.Add(new SqlParameter("@proc", datas[0]));
                    command.Parameters.Add(new SqlParameter("@color", datas[3]));
                    command.Parameters.Add(new SqlParameter("@teeth", datas[2]));
                    command.Parameters.Add(new SqlParameter("@num", datas[4]));
                    command.Parameters.Add(new SqlParameter("@price", datas[5]));
                    command.Parameters.Add(new SqlParameter("@total_price", datas[6]));
                    command.Parameters.Add(new SqlParameter("@step", datas[1]));
                    command.Parameters.Add(new SqlParameter("@init_date", dtp_register_date.Value.ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new SqlParameter("@deadline", dtp_deadline.Value.ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new SqlParameter("@dr_note", rtx_doctor_notes.Text));
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    cnn.Open();
                    sql = "SELECT kimlik, payment FROM tbl_dr WHERE d_name='" + cb_doctor_name.Text + "' ";
                    command = new SqlCommand(sql, cnn);
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
                    payment += double.Parse(txt_all_prices.Text);
                    sql = "UPDATE tbl_dr SET payment = @pay WHERE kimlik = @id";
                    command = new SqlCommand(sql, cnn);
                    command.Parameters.AddWithValue("@pay", payment.ToString());
                    command.Parameters.AddWithValue("@id", kimlik);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    MessageBox.Show("Kayıt başarıyla tamamlandı");
                    pnl_add_patient.Visible = false;
                    pnl_init.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata" + ex);
                    throw;
                }
            }
            else
            {
              MessageBox.Show("Kayılı bir işlem Yok");
            }
        }

        private void txt_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void pB_add_pattient_Click(object sender, EventArgs e)
        {
            
           pB_add_pattient.Image = CALYPSO.Properties.Resources.Add_patient_white;
           pb_search.Image = CALYPSO.Properties.Resources.Search;
            pB_data_view.Image = CALYPSO.Properties.Resources.Print;
           pb_payment.Image = CALYPSO.Properties.Resources.Payment;
            pnl_add_patient.Visible = true;
            pnl_search.Visible = false;
            pnl_print.Visible = false;
            pnl_payment.Visible = false;
            pnl_init.Visible = false;
            dgv_procs.ColumnCount = 7;
            dgv_procs.Columns[0].Name = "Yapılacak işlem";
            dgv_procs.Columns[1].Name = "Aşama";
            dgv_procs.Columns[2].Name = "Dişler";
            dgv_procs.Columns[3].Name = "Renk";
            dgv_procs.Columns[4].Name = "Adet";
            dgv_procs.Columns[5].Name = "Birim fiyat";
            dgv_procs.Columns[6].Name = "Fiyat";
            clearText(pnl_add_patient);
            clearText(pnl_add_info);
            clearText(pnl_patient_save);
            try
            {
                cnn.Open();
                command = new SqlCommand("SELECT TOP(1) proc_id FROM tbl_main ORDER BY 1 DESC", cnn);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                string val = dataReader["proc_id"].ToString();
                if (val != "")
                {
                    txt_process_no.Text = (Convert.ToInt16(val) + 1).ToString();
                }
                dataReader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA" + ex);
                throw;
            }
           

        }
        public void clearText(Panel PanelID)
        {
           
            
                foreach (Control c in PanelID.Controls)
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
                    else if (c is GroupBox)
                    {
                    var pic = c.Controls.OfType<PictureBox>();
                    foreach (var item in pic)
                    {
                       // PictureBox questionTextBox = pic as PictureBox;
                        item.BackColor = Color.Transparent;
                    }
                    }
                    else if (c is RadioButton)
                    {
                        RadioButton questionTextBox = c as RadioButton;
                        if (questionTextBox.Checked)
                        {
                            questionTextBox.Checked = false;
                        }
                    }
                    else if (c is DataGridView)
                {
                    DataGridView questionDataGripView= c as DataGridView;
                    questionDataGripView.Rows.Clear();
                }
                }
        }
        private void lbl_ad_patient_Click(object sender, EventArgs e)
        {
            pB_add_pattient_Click(sender, e);
        }
     
        private void dgv_main_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_main.Rows.Count; i += 2)
            {
                dgv_main.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(96, 182, 167);
            }
        }
        private void pb_search_Click(object sender, EventArgs e)
        {
            pB_add_pattient.Image = CALYPSO.Properties.Resources.Add_patient;
            pb_search.Image = CALYPSO.Properties.Resources.Search_white;
            pB_data_view.Image = CALYPSO.Properties.Resources.Print;
            pb_payment.Image = CALYPSO.Properties.Resources.Payment;
            pnl_payment.Visible = false;
            pnl_search.Visible = true;
            pnl_add_patient.Visible = false;
            pnl_print.Visible = false;
            pnl_init.Visible = false;
            dtp_init_date_init.Enabled = false;
            dtb_deadline_init.Enabled = false;
            chk_deadline.Checked = false;
            chk_save_date.Checked= false;
            var txtbtn = pnl_search.Controls.OfType<TextBox>();
            foreach (TextBox txt in txtbtn)
            {
                txt.Clear();
            }
            try
            {
                cnn.Open();
                adapter = new SqlDataAdapter("Select * From tbl_main ORDER BY proc_id DESC ", cnn);
                table.Clear();
                adapter.Fill(table);
                dgv_main.DataSource = table;
                dgv_main.Columns[0].HeaderText = "ID";
                dgv_main.Columns[1].HeaderText = "Doktor Adı";
                dgv_main.Columns[2].HeaderText = "Hasta Adı";
                dgv_main.Columns[3].HeaderText = "Yapılan İşlem";
                dgv_main.Columns[4].HeaderText = "Aşama";
                dgv_main.Columns[5].HeaderText = "Kayıt T.";
                dgv_main.Columns[6].HeaderText = "İstenilen T.";
                dgv_main.Columns[7].HeaderText = "Renk";
                dgv_main.Columns[8].HeaderText = "Diş";
                dgv_main.Columns[9].HeaderText = "Adet";
                dgv_main.Columns[10].HeaderText = "Fiyat";
                dgv_main.Columns[11].HeaderText = "Toplam Fiyat";
                dgv_main.Columns[12].HeaderText = "Doktor Notu";
                dgv_main.Columns[13].HeaderText = "Yazdırıldı"; 
                dgv_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                adapter.Dispose();
                table.Dispose();
                   
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);throw;
            }
            var text = pnl_search.Controls.OfType<TextBox>();
            foreach (TextBox rb in text)
            {
                rb.Clear();
            }
        }
        public void tableSeach(object sender, EventArgs e)
        {
            dv = new DataView(table);
            if (chk_deadline.Checked && chk_save_date.Checked)
            {
                dv.RowFilter = string.Format(CultureInfo.InvariantCulture.NumberFormat, "dr_name LIKE '%{0}%' And patient_name LIKE '%{1}%' And process_name LIKE '%{2}%' And deadline >=#{3}# And deadline <=#{4}#And init_date>= #{5}# And init_date <= #{6}# And step LIKE '%{7}%'", txt_search_dr.Text, txt_search_patient.Text, txt_search_procces.Text, dtb_deadline_init.Value.ToString("yyyy-MM-dd"),dtp_deadline_upperlimit.Value.ToString("yyyy-MM-dd"), dtp_init_date_init.Value.ToString("yyyy-MM-dd"),dtp_init_date_upperlimit.Value.ToString("yyyy-MM-dd"),txt_step.Text);
            }
            else if (chk_save_date.Checked)
            {
                dv.RowFilter = string.Format(CultureInfo.InvariantCulture.NumberFormat, "dr_name LIKE '%{0}%' And patient_name LIKE '%{1}%' And process_name LIKE '%{2}%' And init_date >=#{3}#And init_date <=#{4}#  And step LIKE '%{5}%'", txt_search_dr.Text, txt_search_patient.Text, txt_search_procces.Text, dtp_init_date_init.Value.ToString("yyyy-MM-dd"),dtp_init_date_upperlimit.Value.ToString("yyyy-MM-dd"),txt_step.Text);
            }
            else if (chk_deadline.Checked) 
            {
                dv.RowFilter = string.Format(CultureInfo.InvariantCulture.NumberFormat, "dr_name LIKE '%{0}%' And patient_name LIKE '%{1}%' And process_name LIKE '%{2}%' And deadline >=#{3}# And deadline <=#{4}# And step LIKE '%{5}%'", txt_search_dr.Text, txt_search_patient.Text, txt_search_procces.Text, dtb_deadline_init.Value.ToString("yyyy-MM-dd"),dtp_deadline_upperlimit.Value.ToString("yyyy-MM-dd"),txt_step.Text);
            }
            else
            {
                dv.RowFilter = string.Format(CultureInfo.InvariantCulture.NumberFormat, "dr_name LIKE '%{0}%' And patient_name LIKE '%{1}%' And process_name LIKE '%{2}%' And step LIKE '%{3}%'", txt_search_dr.Text, txt_search_patient.Text, txt_search_procces.Text,txt_step.Text);
            }
          
            
            dgv_main.DataSource = dv;
           
            int totalTeeth = 0; ;
             for (int i = 0; i < dgv_main.Rows.Count; i++)
            {
                
                string value = dgv_main.Rows[i].Cells[9].Value.ToString();
                string[] values = value.Split('-');
                for (int j = 0; j < values.Length-1; j++)
                {
                    if (values[j]!="")
                    {
                        totalTeeth += int.Parse(values[j]);
                    }
                   
                }
                // totalTeeth += int.Parse(dgv_main.Rows[i].Cells[9].Value.ToString());
              
            }
            txt_result.Text = totalTeeth.ToString();
        }
        private void lbl_search_Click(object sender, EventArgs e)
        {
            pb_search_Click(sender, e);
        }
       
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                dv = new DataView(table);
                dv.RowFilter = string.Format(CultureInfo.InvariantCulture.NumberFormat, "proc_id={0}", int.Parse(txt_id.Text));
                dgv_main.DataSource = dv;
                int totalTeeth = 0; 
                for (int i = 0; i < dgv_main.Rows.Count; i++)
                {
                    string value = dgv_main.Rows[i].Cells[9].Value.ToString();
                    string[] values = value.Split('-');
                    for (int j = 0; j < values.Length - 1; j++)
                    {
                        if (values[j] != "")
                        {
                            totalTeeth += int.Parse(values[j]);
                        }

                    }
                }
            }
            else
            {
                tableSeach(sender, e);
            }
           
        }
        private void dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_update.ShowDialog();
            cnn.Open();
            adapter = new SqlDataAdapter("Select * From tbl_main ORDER BY proc_id DESC ", cnn);
            table.Dispose();
            table.Clear();
            adapter.Fill(table);
            dgv_main.DataSource = table;
            dgv_main.Columns[0].HeaderText = "ID";
            dgv_main.Columns[1].HeaderText = "Doktor Adı";
            dgv_main.Columns[2].HeaderText = "Hasta Adı";
            dgv_main.Columns[3].HeaderText = "Yapılan İşlem";
            dgv_main.Columns[4].HeaderText = "Aşama";
            dgv_main.Columns[5].HeaderText = "Kayıt T.";
            dgv_main.Columns[6].HeaderText = "İstenilen T.";
            dgv_main.Columns[7].HeaderText = "Renk";
            dgv_main.Columns[8].HeaderText = "Diş";
            dgv_main.Columns[9].HeaderText = "Adet";
            dgv_main.Columns[10].HeaderText = "Fiyat";
            dgv_main.Columns[11].HeaderText = "Toplam Fiyat";
            dgv_main.Columns[12].HeaderText = "Doktor Notu";
            dgv_main.Columns[13].HeaderText = "Yazdırıldı";
            dgv_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adapter.Dispose();
            table.Dispose();
            cnn.Close();

        }
        private void pB_data_view_Click(object sender, EventArgs e)
        {
            pB_add_pattient.Image = CALYPSO.Properties.Resources.Add_patient;
            pb_search.Image = CALYPSO.Properties.Resources.Search;
            pB_data_view.Image = CALYPSO.Properties.Resources.Print_white;
            pb_payment.Image = CALYPSO.Properties.Resources.Payment;
            cmb_select_dr.Items.Clear();
            pnl_payment.Visible = false;
            pnl_print.Visible = true;
            pnl_add_patient.Visible = false;
            pnl_search.Visible = false;
            pnl_init.Visible = false;
            try
            {
                cnn.Open();
                sql = "select * From tbl_dr";
                command = new SqlCommand(sql,cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cmb_select_dr.Items.Add(dataReader["d_name"].ToString());
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex); throw;
            }
        }
        private void cmb_select_dr_SelectedIndexChanged(object sender, EventArgs e)
        {
         
             try
            {
                cnn.Open();
                sql= "SELECT proc_id,patient_name , process_name,deadline ,num ,unit_price, price,step,printed FROM tbl_main  WHERE dr_name='" + cmb_select_dr.Text + "' AND step Like '%" +"Bitiş" + "%' AND (( deadline >= '" + dt_fromdate.Value.ToString("yyyy-MM-dd") + "' AND deadline <='" + dt_todate.Value.ToString("yyyy-MM-dd") + "')) ";
                adapter = new SqlDataAdapter(sql, cnn);
                DataTable ptable = new DataTable();
                adapter.Fill(ptable);
                dgv_patients.DataSource = ptable;
                dgv_patients.Columns[0].HeaderText = "ID";
                dgv_patients.Columns[1].HeaderText = "Hasta Adı";
                dgv_patients.Columns[2].HeaderText = "Yapılan İşlem";
                dgv_patients.Columns[3].HeaderText = "Tarih";
                dgv_patients.Columns[4].HeaderText = "Adet";
                dgv_patients.Columns[5].HeaderText = "Birim Fiyat";
                dgv_patients.Columns[6].HeaderText = "Fiyat";
                dgv_patients.Columns[7].HeaderText = "Toplam Ücret";
                dgv_patients.Columns[8].HeaderText = "Yazdırıldı";
                dgv_patients.Columns[4].Visible = false;
                dgv_patients.Columns[5].Visible = false;
                dgv_patients.Columns[6].Visible = false;
                string[] datas = new string[5];
                  for (int i = 0; i < dgv_patients.Rows.Count-1; i++)
                  {
                      datas[0] = dgv_patients.Rows[i].Cells[2].Value.ToString();//işlem
                      datas[1] = dgv_patients.Rows[i].Cells[7].Value.ToString();//aşama
                      datas[2] = dgv_patients.Rows[i].Cells[4].Value.ToString();//adet
                      datas[3] = dgv_patients.Rows[i].Cells[5].Value.ToString();//birimfiyat
                      datas[4] = dgv_patients.Rows[i].Cells[6].Value.ToString();//toplam fiyat
                    string[] processList = datas[0].Split('-');
                    string[] stepList = datas[1].Split('-');
                    string[] numberList = datas[2].Split('-');
                    string[] upriceList = datas[3].Split('-');
                    string[] priceList = datas[4].Split('-');
                    dgv_patients.Rows[i].Cells[2].Value = DBNull.Value;
                    dgv_patients.Rows[i].Cells[4].Value = DBNull.Value;
                    dgv_patients.Rows[i].Cells[5].Value = DBNull.Value;
                    dgv_patients.Rows[i].Cells[6].Value=DBNull.Value;
                    UInt16 total = 0;
                    for (int j = 0; j < stepList.Length-1; j++)
                    {
                        if (stepList[j] =="Bitiş")
                        {
                            ArrayList myAL = new ArrayList();
                            dgv_patients.Rows[i].Cells[2].Value +=processList[j]+"\n" ;
                            dgv_patients.Rows[i].Cells[4].Value+=  numberList[j] + "\n";
                            dgv_patients.Rows[i].Cells[5].Value += upriceList[j] + "\n";
                            dgv_patients.Rows[i].Cells[6].Value += priceList[j] + "\n";
                            total += UInt16.Parse(priceList[j]);
                        } 
                    }
                    dgv_patients.Rows[i].Cells[8].Value = total;
                }
                dgv_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                adapter.Dispose();
                cnn.Close();
               /* cnn.Open();
                sql = "SELECT payment_price FROM tbl_payment  WHERE doctor_name='" + cmb_select_dr.Text + "'  AND (( payment_date >= '" + dt_fromdate.Value.ToString("yyyy-MM-dd") + "' AND payment_date <= '" + dt_todate.Value.ToString("yyyy-MM-dd") + "')) ";
                adapter= new SqlDataAdapter(sql,cnn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                int dr_last_payment = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dr_last_payment += int.Parse(table.Rows[i][0].ToString());
                }
                p_info.dr_last_payment = dr_last_payment;
                adapter.Dispose();
                cnn.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);throw;
            }
        }
        private void dgv_patients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex = dgv_patients.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dgv_patients.Rows.RemoveAt(selectedIndex);
                dgv_patients.Refresh();
            }
        }
        private void pb_payment_Click(object sender, EventArgs e)
        {
            pB_add_pattient.Image = CALYPSO.Properties.Resources.Add_patient;
            pb_search.Image = CALYPSO.Properties.Resources.Search;
            pB_data_view.Image = CALYPSO.Properties.Resources.Print;
            pb_payment.Image = CALYPSO.Properties.Resources.Payment_white;
            pnl_print.Visible = false;
            pnl_add_patient.Visible = false;
            pnl_search.Visible = false;
            pnl_payment.Visible = true;
            pnl_init.Visible = false;
            try
            {
                cnn.Open();
                sql = "select d_name,d_number,payment From tbl_dr ";
                adapter = new SqlDataAdapter(sql, cnn);
                DataTable paytable = new DataTable();
                adapter.Fill(paytable);
                dgv_dr_payment.DataSource = paytable;
                int total_payment = 0;
                for (int i = 0; i < dgv_dr_payment.Rows.Count - 1; i++)
                {
                    total_payment += int.Parse(dgv_dr_payment.Rows[i].Cells[2].Value.ToString());
                }
                txt_total_payment.Text = total_payment.ToString();
                dgv_dr_payment.Columns[0].HeaderText = "Doktor Adı";
                dgv_dr_payment.Columns[1].HeaderText = "Tel. No";
                dgv_dr_payment.Columns[2].HeaderText = "Borç Miktarı";
                dgv_dr_payment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;adapter.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }
        private void label15_Click(object sender, EventArgs e)
        {
             pB_data_view_Click(sender, e);
        }
        private void label51_Click(object sender, EventArgs e)
        {
            pb_payment_Click( sender,  e);
        }
        private void dgv_dr_payment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_payment.Enabled = true;
            int selectedIndex = dgv_dr_payment.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                txt_pdr_name.Text = dgv_dr_payment.CurrentRow.Cells[0].Value.ToString();
               txt_remainingpayment.Text = dgv_dr_payment.CurrentRow.Cells[2].Value.ToString();
                cnn.Open();
                sql = "select doctor_name,payment_date ,payment_price From tbl_payment where doctor_name='" + txt_pdr_name.Text + "'";
                adapter = new SqlDataAdapter(sql,cnn);
                DataTable oldpaytable = new DataTable();
                adapter.Fill(oldpaytable);
                cnn.Close();
                dgv_old_payment.DataSource = oldpaytable;
                dgv_old_payment.Columns[0].HeaderText = "Doktor Adı";
                dgv_old_payment.Columns[1].HeaderText = "Ödeme Tarihi";
                dgv_old_payment.Columns[2].HeaderText = "Miktar";
            }
        }
        private void txt_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&& e.KeyChar != '-';
        }
        private void pb_printp_Click(object sender, EventArgs e)
        {
            if (cmb_select_dr.SelectedIndex > -1)
            {
                cnn.Open();
                var totaldebt = new SqlCommand("SELECT payment FROM tbl_dr where d_name='" + cmb_select_dr.Text + "'", cnn).ExecuteScalar().ToString();
                string debt = totaldebt.ToString();
                p_info.Totaldebt = Convert.ToInt16(debt);
                cnn.Close();
                Totalprice = 0;
                try
                {
                    lst.Clear();
                    for (int i = 0; i < dgv_patients.Rows.Count - 1; i++)
                    {
                        cnn.Open();
                        sql = "UPDATE  tbl_main SET printed=@pat WHERE proc_id=@id";
                        command = new SqlCommand(sql, cnn);
                        command.Parameters.AddWithValue("@pat", "Evet");
                        command.Parameters.AddWithValue("@id", dgv_patients.Rows[i].Cells[0].Value);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        cnn.Close();
                        if ("Evet" == dgv_patients.Rows[i].Cells[7].Value.ToString())
                        {
                            DialogResult dialogResult = MessageBox.Show(dgv_patients.Rows[i].Cells[1].Value.ToString() + " Adlı Kullanıcı daha once yazdırılmış Yazdırmak istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialogResult == DialogResult.No)
                            {
                                int selectedIndex = dgv_patients.Rows[i].Cells[7].RowIndex;
                                if (selectedIndex > -1)
                                {
                                    dgv_patients.Rows.RemoveAt(selectedIndex);
                                    dgv_patients.Refresh();
                                    if (i > -1) i--;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < dgv_patients.Rows.Count - 1; i++)
                    {
                        lst.Add(new patient
                        {
                            patient_name = dgv_patients.Rows[i].Cells[1].Value.ToString(),
                            proc_name = dgv_patients.Rows[i].Cells[2].Value.ToString(),
                            date = dgv_patients.Rows[i].Cells[3].Value.ToString(),
                            num = dgv_patients.Rows[i].Cells[4].Value.ToString(),
                            price = dgv_patients.Rows[i].Cells[5].Value.ToString(),
                            total_price = dgv_patients.Rows[i].Cells[6].Value.ToString()

                        });
                       Totalprice += int.Parse(dgv_patients.Rows[i].Cells[8].Value.ToString());
                    }
                    p_info.SelectedDoctorName = cmb_select_dr.Text;
                    p_info.fromDate = dt_fromdate.Value.ToString("yyyy-MM-dd");
                    p_info.toDate = dt_todate.Value.ToString("yyyy-MM-dd");
                    p_info.Totalprice = Totalprice;
                    Frm_print.frm1.Frm_print.ShowDialog();
                    cmb_select_dr_SelectedIndexChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata" + ex);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Herhangi Bir Doktor Seçilmelidir.");
            }
        }
        private void btn_complate_payment_Click(object sender, EventArgs e)
        {
            if (txt_payment.Text == "")
            {
                MessageBox.Show("HATA : Herhangi bir tutar girilmedi");
            }
            else
            {
                double payment = Convert.ToInt32(txt_remainingpayment.Text) - Convert.ToInt32(txt_payment.Text);
                DialogResult result = MessageBox.Show(txt_pdr_name.Text + " adlı doktordan " + txt_payment.Text + "₺ ödeme alınacaktır.\n Kalan borç=" + payment + "\n işlemi onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        sql = "SELECT kimlik FROM tbl_dr WHERE d_name='" + txt_pdr_name.Text + "' ";
                        command = new SqlCommand(sql, cnn);
                        dataReader = command.ExecuteReader();
                        int kimlik = 0;
                        dataReader.Read();
                        kimlik = Convert.ToInt16(dataReader["kimlik"].ToString());
                       // MessageBox.Show(kimlik.ToString());
                        dataReader.Close();
                        command.Dispose();
                        cnn.Close();
                        cnn.Open();
                        sql = "UPDATE tbl_dr SET payment = @pay WHERE kimlik = @id";
                        command = new SqlCommand(sql, cnn);
                        command.Parameters.AddWithValue("@pay", payment.ToString());
                        command.Parameters.AddWithValue("@id", kimlik);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        cnn.Close();
                        cnn.Open();
                        sql = "select d_name,d_number,payment From tbl_dr ";
                        adapter = new SqlDataAdapter(sql, cnn);
                        DataTable paytable = new DataTable();
                        adapter.Fill(paytable);
                        dgv_dr_payment.DataSource = paytable;
                        sql = "insert into tbl_payment(doctor_name,payment_date,payment_price)values(@name,@date,@price)";
                        command = new SqlCommand(sql, cnn);
                        command.Parameters.AddWithValue("@name", txt_pdr_name.Text);
                        command.Parameters.AddWithValue("@date", dtp_old_payment.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@price", txt_payment.Text);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        cnn.Close();
                      
                    }
                    catch (Exception ex )
                    {
                        MessageBox.Show("hata"+ex);
                        throw;
                    }
                }
                txt_pdr_name.Clear();
                txt_remainingpayment.Clear();
                txt_payment.Clear();
                txt_pdr_name.Text = dgv_dr_payment.CurrentRow.Cells[0].Value.ToString();
                txt_remainingpayment.Text = dgv_dr_payment.CurrentRow.Cells[2].Value.ToString();
                cnn.Open();
                sql = "select doctor_name,payment_date ,payment_price From tbl_payment where doctor_name='" + txt_pdr_name.Text + "'";
                adapter = new SqlDataAdapter(sql,cnn);
                DataTable oldpaytable = new DataTable();
                adapter.Fill(oldpaytable);
                dgv_old_payment.DataSource = oldpaytable;
                dgv_old_payment.Columns[0].HeaderText = "Doktor Adı";
                dgv_old_payment.Columns[1].HeaderText = "Ödeme Tarihi";
                dgv_old_payment.Columns[2].HeaderText = "Miktar";
                cnn.Close();
            }
        }
        private void txt_total_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

   
        private void chk_deadline_CheckedChanged(object sender, EventArgs e)
        {
            if (dtb_deadline_init.Enabled)
            {
                dtb_deadline_init.Enabled = false;
                dtp_deadline_upperlimit.Enabled = false;
            }
            else
            {
                dtb_deadline_init.Enabled = true;
                dtp_deadline_upperlimit.Enabled = true;
            }
            tableSeach(sender, e);

        }

        private void chk_save_date_CheckedChanged(object sender, EventArgs e)
        {
            if (dtp_init_date_init.Enabled)
            {
                dtp_init_date_init.Enabled = false;
                dtp_init_date_upperlimit.Enabled = false;

            }
            else
            {
                dtp_init_date_init.Enabled = true;
                dtp_init_date_upperlimit.Enabled = true;
            }
            tableSeach(sender, e);
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex )
            {
                MessageBox.Show("Hata :"+ex);

                throw;
            }
        }

        private void btn_print_payment_Click(object sender, EventArgs e)
        {
            Totalprice = 0;
            lst2.Clear();
            for (int i = 0; i < dgv_old_payment.Rows.Count - 1; i++)
            {
                lst2.Add(new payment_history
                {
                    doctor_name = dgv_old_payment.Rows[i].Cells[0].Value.ToString(),
                    payment_date = dgv_old_payment.Rows[i].Cells[1].Value.ToString(),
                    payment_price = dgv_old_payment.Rows[i].Cells[2].Value.ToString()
                });
                Totalprice += int.Parse(dgv_old_payment.Rows[i].Cells[2].Value.ToString());
            }
          frm_print_payment_history.frm1.frm_print_payment_history.ShowDialog();
       }
      }
    }


