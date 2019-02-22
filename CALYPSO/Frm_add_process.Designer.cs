namespace CALYPSO
{
    partial class Frm_add_process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_add_process));
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_process_name = new System.Windows.Forms.TextBox();
            this.cmb_procces_delete = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_process_add = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_process_removepnl = new System.Windows.Forms.Button();
            this.btn_esc = new System.Windows.Forms.Button();
            this.pnl_process_remove = new System.Windows.Forms.Panel();
            this.btn_process_addpnl = new System.Windows.Forms.Button();
            this.btn_esc2 = new System.Windows.Forms.Button();
            this.lbl_er = new System.Windows.Forms.Label();
            this.pnl_process_add.SuspendLayout();
            this.pnl_process_remove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(302, 118);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(73, 37);
            this.btn_save.TabIndex = 5;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_process_name
            // 
            this.txt_process_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_process_name.Location = new System.Drawing.Point(135, 81);
            this.txt_process_name.Name = "txt_process_name";
            this.txt_process_name.Size = new System.Drawing.Size(213, 15);
            this.txt_process_name.TabIndex = 4;
            // 
            // cmb_procces_delete
            // 
            this.cmb_procces_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmb_procces_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_procces_delete.Location = new System.Drawing.Point(144, 76);
            this.cmb_procces_delete.Name = "cmb_procces_delete";
            this.cmb_procces_delete.Size = new System.Drawing.Size(210, 24);
            this.cmb_procces_delete.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(300, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_process_add
            // 
            this.pnl_process_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_process_add.BackgroundImage")));
            this.pnl_process_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_process_add.Controls.Add(this.lbl_error);
            this.pnl_process_add.Controls.Add(this.btn_process_removepnl);
            this.pnl_process_add.Controls.Add(this.btn_esc);
            this.pnl_process_add.Controls.Add(this.btn_save);
            this.pnl_process_add.Controls.Add(this.txt_process_name);
            this.pnl_process_add.Location = new System.Drawing.Point(0, 0);
            this.pnl_process_add.Name = "pnl_process_add";
            this.pnl_process_add.Size = new System.Drawing.Size(390, 170);
            this.pnl_process_add.TabIndex = 77;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_error.Location = new System.Drawing.Point(100, 118);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 81;
            // 
            // btn_process_removepnl
            // 
            this.btn_process_removepnl.BackColor = System.Drawing.Color.Transparent;
            this.btn_process_removepnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_process_removepnl.FlatAppearance.BorderSize = 0;
            this.btn_process_removepnl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_process_removepnl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_process_removepnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_process_removepnl.Location = new System.Drawing.Point(144, 3);
            this.btn_process_removepnl.Name = "btn_process_removepnl";
            this.btn_process_removepnl.Size = new System.Drawing.Size(110, 27);
            this.btn_process_removepnl.TabIndex = 80;
            this.btn_process_removepnl.TabStop = false;
            this.btn_process_removepnl.UseVisualStyleBackColor = false;
            this.btn_process_removepnl.Click += new System.EventHandler(this.btn_process_removepnl_Click);
            // 
            // btn_esc
            // 
            this.btn_esc.BackColor = System.Drawing.Color.Transparent;
            this.btn_esc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_esc.FlatAppearance.BorderSize = 0;
            this.btn_esc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_esc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_esc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esc.Location = new System.Drawing.Point(356, 3);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(34, 27);
            this.btn_esc.TabIndex = 79;
            this.btn_esc.TabStop = false;
            this.btn_esc.UseVisualStyleBackColor = false;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // pnl_process_remove
            // 
            this.pnl_process_remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_process_remove.BackgroundImage")));
            this.pnl_process_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_process_remove.Controls.Add(this.lbl_er);
            this.pnl_process_remove.Controls.Add(this.btn_esc2);
            this.pnl_process_remove.Controls.Add(this.button1);
            this.pnl_process_remove.Controls.Add(this.cmb_procces_delete);
            this.pnl_process_remove.Controls.Add(this.btn_process_addpnl);
            this.pnl_process_remove.Location = new System.Drawing.Point(0, 0);
            this.pnl_process_remove.Name = "pnl_process_remove";
            this.pnl_process_remove.Size = new System.Drawing.Size(390, 170);
            this.pnl_process_remove.TabIndex = 78;
            // 
            // btn_process_addpnl
            // 
            this.btn_process_addpnl.BackColor = System.Drawing.Color.Transparent;
            this.btn_process_addpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_process_addpnl.FlatAppearance.BorderSize = 0;
            this.btn_process_addpnl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_process_addpnl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_process_addpnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_process_addpnl.Location = new System.Drawing.Point(3, 3);
            this.btn_process_addpnl.Name = "btn_process_addpnl";
            this.btn_process_addpnl.Size = new System.Drawing.Size(127, 27);
            this.btn_process_addpnl.TabIndex = 81;
            this.btn_process_addpnl.TabStop = false;
            this.btn_process_addpnl.UseVisualStyleBackColor = false;
            this.btn_process_addpnl.Click += new System.EventHandler(this.btn_process_addpnl_Click);
            // 
            // btn_esc2
            // 
            this.btn_esc2.BackColor = System.Drawing.Color.Transparent;
            this.btn_esc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_esc2.FlatAppearance.BorderSize = 0;
            this.btn_esc2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_esc2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_esc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esc2.Location = new System.Drawing.Point(356, 3);
            this.btn_esc2.Name = "btn_esc2";
            this.btn_esc2.Size = new System.Drawing.Size(34, 27);
            this.btn_esc2.TabIndex = 80;
            this.btn_esc2.TabStop = false;
            this.btn_esc2.UseVisualStyleBackColor = false;
            this.btn_esc2.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // lbl_er
            // 
            this.lbl_er.AutoSize = true;
            this.lbl_er.BackColor = System.Drawing.Color.Transparent;
            this.lbl_er.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_er.Location = new System.Drawing.Point(116, 117);
            this.lbl_er.Name = "lbl_er";
            this.lbl_er.Size = new System.Drawing.Size(0, 17);
            this.lbl_er.TabIndex = 82;
            // 
            // Frm_add_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 169);
            this.Controls.Add(this.pnl_process_add);
            this.Controls.Add(this.pnl_process_remove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_add_process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Ekleme";
            this.Load += new System.EventHandler(this.Frm_add_process_Load);
            this.pnl_process_add.ResumeLayout(false);
            this.pnl_process_add.PerformLayout();
            this.pnl_process_remove.ResumeLayout(false);
            this.pnl_process_remove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_process_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmb_procces_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_process_add;
        private System.Windows.Forms.Panel pnl_process_remove;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.Button btn_esc2;
        private System.Windows.Forms.Button btn_process_removepnl;
        private System.Windows.Forms.Button btn_process_addpnl;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_er;
    }
}