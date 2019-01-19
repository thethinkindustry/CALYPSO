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
            this.btn_iptal = new System.Windows.Forms.Button();
            this.txt_dr_number = new System.Windows.Forms.MaskedTextBox();
            this.btn_new_dr_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_doctor_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_new_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_new_register
            // 
            this.grb_new_register.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grb_new_register.Controls.Add(this.btn_iptal);
            this.grb_new_register.Controls.Add(this.txt_dr_number);
            this.grb_new_register.Controls.Add(this.btn_new_dr_save);
            this.grb_new_register.Controls.Add(this.label5);
            this.grb_new_register.Controls.Add(this.txt_doctor_name);
            this.grb_new_register.Controls.Add(this.label3);
            this.grb_new_register.Cursor = System.Windows.Forms.Cursors.Default;
            this.grb_new_register.Location = new System.Drawing.Point(3, 3);
            this.grb_new_register.Name = "grb_new_register";
            this.grb_new_register.Size = new System.Drawing.Size(650, 200);
            this.grb_new_register.TabIndex = 74;
            this.grb_new_register.TabStop = false;
            this.grb_new_register.Text = "Doktor Ekle :";
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.White;
            this.btn_iptal.Location = new System.Drawing.Point(420, 115);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(99, 34);
            this.btn_iptal.TabIndex = 10;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // txt_dr_number
            // 
            this.txt_dr_number.Location = new System.Drawing.Point(209, 76);
            this.txt_dr_number.Mask = "(999) 000-0000";
            this.txt_dr_number.Name = "txt_dr_number";
            this.txt_dr_number.Size = new System.Drawing.Size(411, 22);
            this.txt_dr_number.TabIndex = 9;
            // 
            // btn_new_dr_save
            // 
            this.btn_new_dr_save.BackColor = System.Drawing.Color.White;
            this.btn_new_dr_save.Location = new System.Drawing.Point(525, 115);
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
            this.label5.Location = new System.Drawing.Point(83, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefon No :";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(209, 36);
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
            // frm_dr_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 207);
            this.Controls.Add(this.grb_new_register);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_dr_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Ekleme";
            this.grb_new_register.ResumeLayout(false);
            this.grb_new_register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_new_register;
        private System.Windows.Forms.MaskedTextBox txt_dr_number;
        private System.Windows.Forms.Button btn_new_dr_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_doctor_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_iptal;
    }
}