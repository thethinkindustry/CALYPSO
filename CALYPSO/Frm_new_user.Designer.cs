namespace CALYPSO
{
    partial class Frm_new_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_new_user));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_new_password2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radio_quess = new System.Windows.Forms.RadioButton();
            this.radio_admin = new System.Windows.Forms.RadioButton();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.txt_new_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_create = new System.Windows.Forms.Button();
            this.lbl_login_error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_login_error);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_user_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Bilgileri ";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(302, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 20);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(112, 60);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(181, 22);
            this.txt_password.TabIndex = 2;
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(112, 34);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(181, 22);
            this.txt_user_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_new_password2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radio_quess);
            this.groupBox2.Controls.Add(this.radio_admin);
            this.groupBox2.Controls.Add(this.txt_new_password);
            this.groupBox2.Controls.Add(this.txt_new_username);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kullanıcı";
            // 
            // txt_new_password2
            // 
            this.txt_new_password2.Location = new System.Drawing.Point(112, 88);
            this.txt_new_password2.Name = "txt_new_password2";
            this.txt_new_password2.PasswordChar = '*';
            this.txt_new_password2.Size = new System.Drawing.Size(106, 22);
            this.txt_new_password2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifre Doğrula:";
            // 
            // radio_quess
            // 
            this.radio_quess.AutoSize = true;
            this.radio_quess.Location = new System.Drawing.Point(224, 59);
            this.radio_quess.Name = "radio_quess";
            this.radio_quess.Size = new System.Drawing.Size(70, 21);
            this.radio_quess.TabIndex = 5;
            this.radio_quess.TabStop = true;
            this.radio_quess.Text = "Misafir";
            this.radio_quess.UseVisualStyleBackColor = true;
            // 
            // radio_admin
            // 
            this.radio_admin.AutoSize = true;
            this.radio_admin.Location = new System.Drawing.Point(224, 33);
            this.radio_admin.Name = "radio_admin";
            this.radio_admin.Size = new System.Drawing.Size(68, 21);
            this.radio_admin.TabIndex = 4;
            this.radio_admin.TabStop = true;
            this.radio_admin.Text = "Admin";
            this.radio_admin.UseVisualStyleBackColor = true;
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(112, 60);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.PasswordChar = '*';
            this.txt_new_password.Size = new System.Drawing.Size(106, 22);
            this.txt_new_password.TabIndex = 2;
            // 
            // txt_new_username
            // 
            this.txt_new_username.Location = new System.Drawing.Point(112, 34);
            this.txt_new_username.Name = "txt_new_username";
            this.txt_new_username.Size = new System.Drawing.Size(106, 22);
            this.txt_new_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // txt_create
            // 
            this.txt_create.Location = new System.Drawing.Point(257, 248);
            this.txt_create.Name = "txt_create";
            this.txt_create.Size = new System.Drawing.Size(77, 35);
            this.txt_create.TabIndex = 3;
            this.txt_create.Text = "Oluştur";
            this.txt_create.UseVisualStyleBackColor = true;
            this.txt_create.Click += new System.EventHandler(this.txt_create_Click);
            // 
            // lbl_login_error
            // 
            this.lbl_login_error.AutoSize = true;
            this.lbl_login_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_login_error.Location = new System.Drawing.Point(109, 14);
            this.lbl_login_error.Name = "lbl_login_error";
            this.lbl_login_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_login_error.TabIndex = 4;
            // 
            // Frm_new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 299);
            this.Controls.Add(this.txt_create);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Frm_new_user";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_new_user";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_new_password2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio_quess;
        private System.Windows.Forms.RadioButton radio_admin;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.TextBox txt_new_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txt_create;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_login_error;
    }
}