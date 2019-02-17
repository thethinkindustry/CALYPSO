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
            this.grb_registered = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_process_name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_procces_delete = new System.Windows.Forms.ComboBox();
            this.grb_registered.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_registered
            // 
            this.grb_registered.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grb_registered.Controls.Add(this.btn_save);
            this.grb_registered.Controls.Add(this.txt_process_name);
            this.grb_registered.Controls.Add(this.label19);
            this.grb_registered.Location = new System.Drawing.Point(12, 12);
            this.grb_registered.Name = "grb_registered";
            this.grb_registered.Size = new System.Drawing.Size(382, 120);
            this.grb_registered.TabIndex = 75;
            this.grb_registered.TabStop = false;
            this.grb_registered.Text = "İşlem Ekleme :";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(275, 68);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 33);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_process_name
            // 
            this.txt_process_name.Location = new System.Drawing.Point(111, 40);
            this.txt_process_name.Name = "txt_process_name";
            this.txt_process_name.Size = new System.Drawing.Size(239, 22);
            this.txt_process_name.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "İslem Ekle :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cmb_procces_delete);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 120);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Kaldırma :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(275, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaldır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Kaldır :";
            // 
            // cmb_procces_delete
            // 
            this.cmb_procces_delete.FormattingEnabled = true;
            this.cmb_procces_delete.Location = new System.Drawing.Point(111, 40);
            this.cmb_procces_delete.Name = "cmb_procces_delete";
            this.cmb_procces_delete.Size = new System.Drawing.Size(239, 24);
            this.cmb_procces_delete.TabIndex = 77;
            // 
            // Frm_add_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_registered);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_add_process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Ekleme";
            this.Load += new System.EventHandler(this.Frm_add_process_Load);
            this.grb_registered.ResumeLayout(false);
            this.grb_registered.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_registered;
        private System.Windows.Forms.TextBox txt_process_name;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_procces_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}