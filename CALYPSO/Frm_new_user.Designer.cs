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
            this.button2 = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_new_password2 = new System.Windows.Forms.TextBox();
            this.radio_quess = new System.Windows.Forms.RadioButton();
            this.radio_admin = new System.Windows.Forms.RadioButton();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.txt_new_username = new System.Windows.Forms.TextBox();
            this.txt_create = new System.Windows.Forms.Button();
            this.pnl_newUser = new System.Windows.Forms.Panel();
            this.pnl_adminInfo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_login_error = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pnl_newUser.SuspendLayout();
            this.pnl_adminInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.Name = "txt_password";
            // 
            // txt_user_name
            // 
            this.txt_user_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_user_name, "txt_user_name");
            this.txt_user_name.Name = "txt_user_name";
            // 
            // txt_new_password2
            // 
            this.txt_new_password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_new_password2, "txt_new_password2");
            this.txt_new_password2.Name = "txt_new_password2";
            // 
            // radio_quess
            // 
            resources.ApplyResources(this.radio_quess, "radio_quess");
            this.radio_quess.Name = "radio_quess";
            this.radio_quess.TabStop = true;
            this.radio_quess.UseVisualStyleBackColor = true;
            // 
            // radio_admin
            // 
            resources.ApplyResources(this.radio_admin, "radio_admin");
            this.radio_admin.Name = "radio_admin";
            this.radio_admin.TabStop = true;
            this.radio_admin.UseVisualStyleBackColor = true;
            // 
            // txt_new_password
            // 
            this.txt_new_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_new_password, "txt_new_password");
            this.txt_new_password.Name = "txt_new_password";
            // 
            // txt_new_username
            // 
            this.txt_new_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_new_username, "txt_new_username");
            this.txt_new_username.Name = "txt_new_username";
            // 
            // txt_create
            // 
            resources.ApplyResources(this.txt_create, "txt_create");
            this.txt_create.FlatAppearance.BorderSize = 0;
            this.txt_create.Name = "txt_create";
            this.txt_create.UseVisualStyleBackColor = true;
            this.txt_create.Click += new System.EventHandler(this.txt_create_Click);
            // 
            // pnl_newUser
            // 
            resources.ApplyResources(this.pnl_newUser, "pnl_newUser");
            this.pnl_newUser.Controls.Add(this.pnl_adminInfo);
            this.pnl_newUser.Controls.Add(this.lbl_Error);
            this.pnl_newUser.Controls.Add(this.txt_new_username);
            this.pnl_newUser.Controls.Add(this.txt_new_password);
            this.pnl_newUser.Controls.Add(this.txt_new_password2);
            this.pnl_newUser.Controls.Add(this.button2);
            this.pnl_newUser.Controls.Add(this.radio_admin);
            this.pnl_newUser.Controls.Add(this.radio_quess);
            this.pnl_newUser.Controls.Add(this.txt_create);
            this.pnl_newUser.Name = "pnl_newUser";
            // 
            // pnl_adminInfo
            // 
            resources.ApplyResources(this.pnl_adminInfo, "pnl_adminInfo");
            this.pnl_adminInfo.Controls.Add(this.button1);
            this.pnl_adminInfo.Controls.Add(this.lbl_login_error);
            this.pnl_adminInfo.Controls.Add(this.btn_next);
            this.pnl_adminInfo.Controls.Add(this.txt_password);
            this.pnl_adminInfo.Controls.Add(this.txt_user_name);
            this.pnl_adminInfo.Name = "pnl_adminInfo";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_login_error
            // 
            resources.ApplyResources(this.lbl_login_error, "lbl_login_error");
            this.lbl_login_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_login_error.Name = "lbl_login_error";
            // 
            // btn_next
            // 
            resources.ApplyResources(this.btn_next, "btn_next");
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.Name = "btn_next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_Error
            // 
            resources.ApplyResources(this.lbl_Error, "lbl_Error");
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Error.Name = "lbl_Error";
            // 
            // Frm_new_user
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_newUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Frm_new_user";
            this.ShowIcon = false;
            this.pnl_newUser.ResumeLayout(false);
            this.pnl_newUser.PerformLayout();
            this.pnl_adminInfo.ResumeLayout(false);
            this.pnl_adminInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_new_password2;
        private System.Windows.Forms.RadioButton radio_quess;
        private System.Windows.Forms.RadioButton radio_admin;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.TextBox txt_new_username;
        private System.Windows.Forms.Button txt_create;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnl_newUser;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_login_error;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel pnl_adminInfo;
    }
}