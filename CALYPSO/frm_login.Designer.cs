namespace CALYPSO
{
    partial class frm_login
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
            System.Windows.Forms.Button btn_eye;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_login_error = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            btn_eye = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_eye
            // 
            btn_eye.BackColor = System.Drawing.Color.Transparent;
            btn_eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_eye.Cursor = System.Windows.Forms.Cursors.Default;
            btn_eye.FlatAppearance.BorderSize = 0;
            btn_eye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btn_eye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn_eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_eye.ForeColor = System.Drawing.Color.Transparent;
            btn_eye.Location = new System.Drawing.Point(434, 275);
            btn_eye.Name = "btn_eye";
            btn_eye.Size = new System.Drawing.Size(33, 26);
            btn_eye.TabIndex = 6;
            btn_eye.UseVisualStyleBackColor = false;
            btn_eye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_eye_MouseDown);
            btn_eye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_eye_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(44, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 17);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.Location = new System.Drawing.Point(88, 277);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(350, 20);
            this.txt_password.TabIndex = 2;
            // 
            // lbl_login_error
            // 
            this.lbl_login_error.AutoSize = true;
            this.lbl_login_error.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_login_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_login_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_login_error.Location = new System.Drawing.Point(569, 508);
            this.lbl_login_error.Name = "lbl_login_error";
            this.lbl_login_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_login_error.TabIndex = 8;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(378, 326);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(104, 47);
            this.btn_login.TabIndex = 3;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(487, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 28);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_user_name
            // 
            this.txt_user_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_user_name.Location = new System.Drawing.Point(88, 204);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(354, 20);
            this.txt_user_name.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_error);
            this.panel1.Controls.Add(this.txt_user_name);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(btn_eye);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 402);
            this.panel1.TabIndex = 9;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_error.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_error.Location = new System.Drawing.Point(85, 310);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 127;
            // 
            // frm_login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(531, 402);
            this.Controls.Add(this.lbl_login_error);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı :";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_login_error;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_error;
    }
}