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
    public partial class Form1 : Form
    {
        public Frm_update_patient frm_update;
        public frm_print Frm_print;
        OleDbConnection con;
        OleDbCommand cmd;
        string query;
        OleDbDataReader reader;


        public String SelectedDoctorName="";
        public String fromDate, toDate;
        public int Totalprice = 0;
        DataTable table = new DataTable();
        public Form1()
        {

            InitializeComponent();

            Frm_print = new frm_print();
            Frm_print.frm1 = this;

            frm_update = new Frm_update_patient();
            frm_update.frm1 = this;
            
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_calypso.mdb");
            cmd = new OleDbCommand();

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
                    cb_doctor_name.Items.Add(reader["dr_name"].ToString());
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

            pnl_add_patient.Visible = false;

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
        private void ManageCheckGroupBox(CheckBox chk, GroupBox grp)
        {
            // Make sure the CheckBox isn't in the GroupBox.
            // This will only happen the first time.
            if (chk.Parent == grp)
            {
                // Reparent the CheckBox so it's not in the GroupBox.
                grp.Parent.Controls.Add(chk);

                // Adjust the CheckBox's location.
                chk.Location = new Point(
                    chk.Left + grp.Left,
                    chk.Top + grp.Top);

                // Move the CheckBox to the top of the stacking order.
                chk.BringToFront();
            }

            // Enable or disable the GroupBox.
            grp.Enabled = chk.Checked;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Close();
            var newForm = new teeth();
            newForm.ShowDialog();

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
                    cb_doctor_name.Items.Add(reader["dr_name"].ToString());
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }

        }

        private void cb_doctor_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cb_doctor_name.Items.Clear();

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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pnl_add_patient.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
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
            if (counter==0)
            {
                counter = 1;
            }
            if (string.IsNullOrEmpty(txt_unit_price.Text))
            {
                txt_unit_price.Text = "0";
            }
            if (string.IsNullOrEmpty(rtx_doctor_notes.Text))
            {
                rtx_doctor_notes.Text = "Yok";
            }
            if (string.IsNullOrEmpty(teeth))
            {
                teeth = "-";
            }
            try
            {
                string query = "insert into tbl_main(dr_name,patient_name,process_name,color,teeth,num ,unit_price,price,step,deadline,dr_note)values(@dr,@pat,@proc,@color,@teeth,@num,@price,@total_price,@step,@deadline,@dr_note)";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
               cmd.Parameters.AddWithValue("@pname", cb_doctor_name.Text);
                cmd.Parameters.AddWithValue("@pat", txt_patient_name.Text);
                 cmd.Parameters.AddWithValue("@proc", cb_procces_bar.Text);
                 cmd.Parameters.AddWithValue("@color", cb_color.Text);
                  cmd.Parameters.AddWithValue("@teeth", teeth);
                  cmd.Parameters.AddWithValue("@num", counter.ToString());
                 cmd.Parameters.AddWithValue("@price", txt_unit_price.Text);
                cmd.Parameters.AddWithValue("@price",Convert.ToInt16(txt_unit_price.Text)*counter );

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
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarıyla tamamlandı");

                pnl_add_patient.Visible = false;

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

        private void pB_add_pattient_Click(object sender, EventArgs e)
        {
            pnl_add_patient.Visible = true;
            pnl_search.Visible = false;
            pnl_print.Visible = false;
        }

        private void lbl_ad_patient_Click(object sender, EventArgs e)
        {
            pB_add_pattient_Click(sender, e);
        }
        void view_data(OleDbDataAdapter adtr)
        {
            table.Clear();
            adtr.Fill(table);
            dgv_main.DataSource = table;
            dgv_main.Columns[0].HeaderText = "ID";
            dgv_main.Columns[1].HeaderText = "Doktor Adı";
            dgv_main.Columns[2].HeaderText = "Hasta Adı";
            dgv_main.Columns[3].HeaderText = "Yapılan İşlem";
            dgv_main.Columns[4].HeaderText = "Aşama";
            dgv_main.Columns[5].HeaderText = "Tarih";
            dgv_main.Columns[6].HeaderText = "Renk";
            dgv_main.Columns[7].HeaderText = "Diş";
            dgv_main.Columns[8].HeaderText = "Adet";
            dgv_main.Columns[9].HeaderText = "Fiyat";
            dgv_main.Columns[10].HeaderText = "Doktor Notu";
            dgv_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void pb_search_Click(object sender, EventArgs e)
        {

            pnl_search.Visible = true;
            pnl_add_patient.Visible = false;
            pnl_print.Visible = false;
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From tbl_main", con);
            view_data(adtr);
        }
       
        private void lbl_search_Click(object sender, EventArgs e)
        {
            pb_search_Click(sender, e);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search_dr.Text.Trim()=="")
            {
              
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From tbl_main", con);
                view_data(adtr);
            }
            else
            {
              
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From tbl_main where dr_name Like '%" + txt_search_dr.Text+"%'", con);
                view_data(adtr);
            }
        }

        private void txt_search_patient_TextChanged(object sender, EventArgs e)
        {
            if (txt_search_patient.Text.Trim() == "")
            {
               
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From tbl_main", con);
                view_data(adtr);
            }
            else
            {
            
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From tbl_main where patient_name Like '%" + txt_search_patient.Text + "%'", con);
                view_data(adtr);
            }
        }

        private void txt_search_deadline_TextChanged(object sender, EventArgs e)
        {
            if (txt_search_deadline.Text.Trim() == "")
            {
               
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From tbl_main", con);
                view_data(adtr);
            }
            else
            {
               
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From tbl_main where deadline Like '%" + txt_search_deadline.Text + "%'", con);
                view_data(adtr);
            }
           
        }

        private void dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Close();
            frm_update.frm1.frm_update.ShowDialog();
            con.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From tbl_main", con);
            view_data(adtr);

        }

      
        private void pB_data_view_Click(object sender, EventArgs e)
        {
            pnl_print.Visible = true;
            pnl_add_patient.Visible = false;
            pnl_search.Visible = false;
            try
            {
               
               // con.Open();
                query = "select * From tbl_dr";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_select_dr.Items.Add(reader["dr_name"].ToString());
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }

        private void cmb_select_dr_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            try
            {
                String query = "SELECT proc_id,patient_name , process_name,deadline ,num ,unit_price, price FROM tbl_main  WHERE dr_name='" + cmb_select_dr.Text + "' AND (( deadline between #" + dt_fromdate.Value.ToString("yyyy-MM-dd") + "# AND #" + dt_todate.Value.ToString("yyyy-MM-dd") + "#)) ";
                OleDbDataAdapter _adtr = new OleDbDataAdapter(query, con);
                DataTable ptable = new DataTable();
                _adtr.Fill(ptable);
                dgv_patients.DataSource = ptable;
                dgv_patients.Columns[0].HeaderText = "ID";
                dgv_patients.Columns[1].HeaderText = "Hasta Adı";
                dgv_patients.Columns[2].HeaderText = "Yapılan İşlem";
                dgv_patients.Columns[3].HeaderText = "Tarih";
                dgv_patients.Columns[4].HeaderText = "Adet";
                dgv_patients.Columns[5].HeaderText = "Birim Fiyat";
                dgv_patients.Columns[6].HeaderText = "Fiyat";
                dgv_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);

                throw;
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

        private void pb_printp_Click(object sender, EventArgs e)
        {
            Totalprice = 0;
            //int paid = 1;
            string query;
            OleDbCommand cmd = new OleDbCommand();
            DataTable _table = new DataTable();
            try
            {
                for (int i = 0; i < dgv_patients.Rows.Count-1; i++)
                {
                    Totalprice +=int.Parse(dgv_patients.Rows[i].Cells[6].Value.ToString());
                    #region Insert print              
                    query = "UPDATE  tbl_main SET printed=@pat WHERE proc_id=@id";
                    OleDbCommand cmdd = new OleDbCommand();
                    cmdd.Connection = con;
                    cmdd.CommandText = query;
                    cmdd.Parameters.AddWithValue("@pat", "Evet");
                    cmdd.Parameters.AddWithValue("@id", dgv_patients.Rows[i].Cells[0].Value);
                    cmdd.ExecuteNonQuery();
                    #endregion
                }
                
                SelectedDoctorName = cmb_select_dr.Text;
                fromDate = dt_fromdate.Value.ToString("yyyy-MM-dd");
                toDate = dt_todate.Value.ToString("yyyy-MM-dd");

                MessageBox.Show("OK:");
                //con.Close();
                Frm_print.frm1.Frm_print.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);
                 throw;
            }
        }
    }
}

