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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_process_name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.grb_registered.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_registered
            // 
            this.grb_registered.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grb_registered.Controls.Add(this.btn_cancel);
            this.grb_registered.Controls.Add(this.btn_save);
            this.grb_registered.Controls.Add(this.txt_process_name);
            this.grb_registered.Controls.Add(this.label19);
            this.grb_registered.Location = new System.Drawing.Point(12, 12);
            this.grb_registered.Name = "grb_registered";
            this.grb_registered.Size = new System.Drawing.Size(650, 120);
            this.grb_registered.TabIndex = 75;
            this.grb_registered.TabStop = false;
            this.grb_registered.Text = "İşlem Ekleme :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Location = new System.Drawing.Point(385, 81);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Iptal";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(466, 81);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 33);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_process_name
            // 
            this.txt_process_name.Location = new System.Drawing.Point(164, 37);
            this.txt_process_name.Name = "txt_process_name";
            this.txt_process_name.Size = new System.Drawing.Size(377, 22);
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
            // Frm_add_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 143);
            this.Controls.Add(this.grb_registered);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_add_process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Ekleme";
            this.grb_registered.ResumeLayout(false);
            this.grb_registered.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_registered;
        private System.Windows.Forms.TextBox txt_process_name;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}