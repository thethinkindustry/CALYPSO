namespace CALYPSO
{
    partial class frm_dr_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dr_add));
            this.grb_new_register = new System.Windows.Forms.GroupBox();
            this.txt_dr_number = new System.Windows.Forms.MaskedTextBox();
            this.btn_new_dr_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_doctor_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_dr_delete = new System.Windows.Forms.ComboBox();
            this.grb_new_register.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_new_register
            // 
            this.grb_new_register.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grb_new_register.Controls.Add(this.txt_dr_number);
            this.grb_new_register.Controls.Add(this.btn_new_dr_save);
            this.grb_new_register.Controls.Add(this.label5);
            this.grb_new_register.Controls.Add(this.txt_doctor_name);
            this.grb_new_register.Controls.Add(this.label3);
            this.grb_new_register.Cursor = System.Windows.Forms.Cursors.Default;
            this.grb_new_register.Location = new System.Drawing.Point(3, 3);
            this.grb_new_register.Name = "grb_new_register";
            this.grb_new_register.Size = new System.Drawing.Size(601, 200);
            this.grb_new_register.TabIndex = 74;
            this.grb_new_register.TabStop = false;
            this.grb_new_register.Text = "Doktor Ekle :";
            // 
            // txt_dr_number
            // 
            this.txt_dr_number.Location = new System.Drawing.Point(159, 76);
            this.txt_dr_number.Mask = "(999) 000-0000";
            this.txt_dr_number.Name = "txt_dr_number";
            this.txt_dr_number.Size = new System.Drawing.Size(415, 22);
            this.txt_dr_number.TabIndex = 9;
            // 
            // btn_new_dr_save
            // 
            this.btn_new_dr_save.BackColor = System.Drawing.Color.White;
            this.btn_new_dr_save.Location = new System.Drawing.Point(475, 104);
            this.btn_new_dr_save.Name = "btn_new_dr_save";
            this.btn_new_dr_save.Size = new System.Drawing.Size(99, 34);
            this.btn_new_dr_save.TabIndex = 8;
            this.btn_new_dr_save.Text = "Kaydet";
            this.btn_new_dr_save.UseVisualStyleBackColor = false;
            this.btn_new_dr_save.Click += new System.EventHandler(this.btn_new_dr_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefon No :";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(159, 37);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(415, 22);
            this.txt_doctor_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Diş Hekimi / Hastane :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cmb_dr_delete);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(3, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 128);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Kaldır:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(475, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kaldır";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diş Hekimi / Hastane :";
            // 
            // cmb_dr_delete
            // 
            this.cmb_dr_delete.FormattingEnabled = true;
            this.cmb_dr_delete.Location = new System.Drawing.Point(159, 34);
            this.cmb_dr_delete.Name = "cmb_dr_delete";
            this.cmb_dr_delete.Size = new System.Drawing.Size(415, 24);
            this.cmb_dr_delete.TabIndex = 9;
            // 
            // frm_dr_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_new_register);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_dr_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Ekleme";
            this.Load += new System.EventHandler(this.frm_dr_add_Load);
            this.grb_new_register.ResumeLayout(false);
            this.grb_new_register.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_new_register;
        private System.Windows.Forms.MaskedTextBox txt_dr_number;
        private System.Windows.Forms.Button btn_new_dr_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_doctor_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_dr_delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}