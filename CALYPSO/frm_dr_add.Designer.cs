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
            this.txt_dr_number = new System.Windows.Forms.MaskedTextBox();
            this.btn_new_dr_save = new System.Windows.Forms.Button();
            this.txt_doctor_name = new System.Windows.Forms.TextBox();
            this.cmb_dr_delete = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_dr_add = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_dr_remove_btn = new System.Windows.Forms.Button();
            this.btn_esc = new System.Windows.Forms.Button();
            this.pnl_dr_remove = new System.Windows.Forms.Panel();
            this.btn_dr_add_btn = new System.Windows.Forms.Button();
            this.btn_esc2 = new System.Windows.Forms.Button();
            this.lbl_er = new System.Windows.Forms.Label();
            this.pnl_dr_add.SuspendLayout();
            this.pnl_dr_remove.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_dr_number
            // 
            this.txt_dr_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dr_number.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_dr_number.Location = new System.Drawing.Point(238, 124);
            this.txt_dr_number.Mask = "(999) 000-0000";
            this.txt_dr_number.Name = "txt_dr_number";
            this.txt_dr_number.Size = new System.Drawing.Size(244, 15);
            this.txt_dr_number.TabIndex = 9;
            // 
            // btn_new_dr_save
            // 
            this.btn_new_dr_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_new_dr_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new_dr_save.FlatAppearance.BorderSize = 0;
            this.btn_new_dr_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_new_dr_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_new_dr_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_dr_save.Location = new System.Drawing.Point(407, 166);
            this.btn_new_dr_save.Name = "btn_new_dr_save";
            this.btn_new_dr_save.Size = new System.Drawing.Size(92, 42);
            this.btn_new_dr_save.TabIndex = 8;
            this.btn_new_dr_save.UseVisualStyleBackColor = false;
            this.btn_new_dr_save.Click += new System.EventHandler(this.btn_new_dr_save_Click);
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_doctor_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_doctor_name.Location = new System.Drawing.Point(238, 76);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(244, 15);
            this.txt_doctor_name.TabIndex = 2;
            // 
            // cmb_dr_delete
            // 
            this.cmb_dr_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_dr_delete.FormattingEnabled = true;
            this.cmb_dr_delete.Location = new System.Drawing.Point(238, 94);
            this.cmb_dr_delete.Name = "cmb_dr_delete";
            this.cmb_dr_delete.Size = new System.Drawing.Size(244, 24);
            this.cmb_dr_delete.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(402, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 43);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnl_dr_add
            // 
            this.pnl_dr_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_dr_add.BackgroundImage")));
            this.pnl_dr_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_dr_add.Controls.Add(this.lbl_error);
            this.pnl_dr_add.Controls.Add(this.btn_dr_remove_btn);
            this.pnl_dr_add.Controls.Add(this.btn_esc);
            this.pnl_dr_add.Controls.Add(this.btn_new_dr_save);
            this.pnl_dr_add.Controls.Add(this.txt_dr_number);
            this.pnl_dr_add.Controls.Add(this.txt_doctor_name);
            this.pnl_dr_add.Location = new System.Drawing.Point(0, 0);
            this.pnl_dr_add.Name = "pnl_dr_add";
            this.pnl_dr_add.Size = new System.Drawing.Size(513, 220);
            this.pnl_dr_add.TabIndex = 76;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_error.Location = new System.Drawing.Point(237, 154);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 12;
            // 
            // btn_dr_remove_btn
            // 
            this.btn_dr_remove_btn.BackColor = System.Drawing.Color.Transparent;
            this.btn_dr_remove_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dr_remove_btn.FlatAppearance.BorderSize = 0;
            this.btn_dr_remove_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_dr_remove_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_dr_remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dr_remove_btn.Location = new System.Drawing.Point(148, 3);
            this.btn_dr_remove_btn.Name = "btn_dr_remove_btn";
            this.btn_dr_remove_btn.Size = new System.Drawing.Size(134, 27);
            this.btn_dr_remove_btn.TabIndex = 11;
            this.btn_dr_remove_btn.UseVisualStyleBackColor = false;
            this.btn_dr_remove_btn.Click += new System.EventHandler(this.btn_dr_remove_btn_Click);
            // 
            // btn_esc
            // 
            this.btn_esc.BackColor = System.Drawing.Color.Transparent;
            this.btn_esc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_esc.FlatAppearance.BorderSize = 0;
            this.btn_esc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_esc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_esc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esc.Location = new System.Drawing.Point(477, 0);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(36, 31);
            this.btn_esc.TabIndex = 10;
            this.btn_esc.TabStop = false;
            this.btn_esc.UseVisualStyleBackColor = false;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // pnl_dr_remove
            // 
            this.pnl_dr_remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_dr_remove.BackgroundImage")));
            this.pnl_dr_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_dr_remove.Controls.Add(this.lbl_er);
            this.pnl_dr_remove.Controls.Add(this.cmb_dr_delete);
            this.pnl_dr_remove.Controls.Add(this.btn_dr_add_btn);
            this.pnl_dr_remove.Controls.Add(this.btn_esc2);
            this.pnl_dr_remove.Controls.Add(this.button2);
            this.pnl_dr_remove.Location = new System.Drawing.Point(0, 0);
            this.pnl_dr_remove.Name = "pnl_dr_remove";
            this.pnl_dr_remove.Size = new System.Drawing.Size(513, 220);
            this.pnl_dr_remove.TabIndex = 77;
            // 
            // btn_dr_add_btn
            // 
            this.btn_dr_add_btn.BackColor = System.Drawing.Color.Transparent;
            this.btn_dr_add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dr_add_btn.FlatAppearance.BorderSize = 0;
            this.btn_dr_add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_dr_add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_dr_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dr_add_btn.Location = new System.Drawing.Point(0, 0);
            this.btn_dr_add_btn.Name = "btn_dr_add_btn";
            this.btn_dr_add_btn.Size = new System.Drawing.Size(137, 30);
            this.btn_dr_add_btn.TabIndex = 12;
            this.btn_dr_add_btn.UseVisualStyleBackColor = false;
            this.btn_dr_add_btn.Click += new System.EventHandler(this.btn_dr_add_btn_Click);
            // 
            // btn_esc2
            // 
            this.btn_esc2.BackColor = System.Drawing.Color.Transparent;
            this.btn_esc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_esc2.FlatAppearance.BorderSize = 0;
            this.btn_esc2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_esc2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_esc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esc2.Location = new System.Drawing.Point(477, 0);
            this.btn_esc2.Name = "btn_esc2";
            this.btn_esc2.Size = new System.Drawing.Size(36, 31);
            this.btn_esc2.TabIndex = 11;
            this.btn_esc2.TabStop = false;
            this.btn_esc2.UseVisualStyleBackColor = false;
            this.btn_esc2.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // lbl_er
            // 
            this.lbl_er.AutoSize = true;
            this.lbl_er.BackColor = System.Drawing.Color.Transparent;
            this.lbl_er.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_er.Location = new System.Drawing.Point(253, 142);
            this.lbl_er.Name = "lbl_er";
            this.lbl_er.Size = new System.Drawing.Size(0, 17);
            this.lbl_er.TabIndex = 13;
            // 
            // frm_dr_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(513, 220);
            this.Controls.Add(this.pnl_dr_add);
            this.Controls.Add(this.pnl_dr_remove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_dr_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Ekleme";
            this.Load += new System.EventHandler(this.frm_dr_add_Load);
            this.pnl_dr_add.ResumeLayout(false);
            this.pnl_dr_add.PerformLayout();
            this.pnl_dr_remove.ResumeLayout(false);
            this.pnl_dr_remove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txt_dr_number;
        private System.Windows.Forms.Button btn_new_dr_save;
        private System.Windows.Forms.TextBox txt_doctor_name;
        private System.Windows.Forms.ComboBox cmb_dr_delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnl_dr_add;
        private System.Windows.Forms.Panel pnl_dr_remove;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.Button btn_esc2;
        private System.Windows.Forms.Button btn_dr_remove_btn;
        private System.Windows.Forms.Button btn_dr_add_btn;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_er;
    }
}