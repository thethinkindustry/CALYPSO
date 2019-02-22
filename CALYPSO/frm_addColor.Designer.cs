namespace CALYPSO
{
    partial class frm_addColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addColor));
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_color_add = new System.Windows.Forms.TextBox();
            this.cmb_color_delete = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pnl_add_color = new System.Windows.Forms.Panel();
            this.btn_esc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_color_removepnl = new System.Windows.Forms.Button();
            this.pnl_remove_color = new System.Windows.Forms.Panel();
            this.btn_esc_2 = new System.Windows.Forms.Button();
            this.btn_add_colorpnl = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new CALYPSO.DataQueryTableAdapters.TableAdapterManager();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_er = new System.Windows.Forms.Label();
            this.pnl_add_color.SuspendLayout();
            this.pnl_remove_color.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(278, 100);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 46);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "  ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_color_add
            // 
            this.txt_color_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_color_add.Location = new System.Drawing.Point(194, 74);
            this.txt_color_add.Name = "txt_color_add";
            this.txt_color_add.Size = new System.Drawing.Size(66, 15);
            this.txt_color_add.TabIndex = 5;
            // 
            // cmb_color_delete
            // 
            this.cmb_color_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_color_delete.FormattingEnabled = true;
            this.cmb_color_delete.Location = new System.Drawing.Point(278, 59);
            this.cmb_color_delete.Name = "cmb_color_delete";
            this.cmb_color_delete.Size = new System.Drawing.Size(65, 24);
            this.cmb_color_delete.TabIndex = 7;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(291, 109);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 37);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.TabStop = false;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pnl_add_color
            // 
            this.pnl_add_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_add_color.BackgroundImage")));
            this.pnl_add_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_add_color.Controls.Add(this.lbl_error);
            this.pnl_add_color.Controls.Add(this.btn_esc);
            this.pnl_add_color.Controls.Add(this.button1);
            this.pnl_add_color.Controls.Add(this.btn_color_removepnl);
            this.pnl_add_color.Controls.Add(this.btn_add);
            this.pnl_add_color.Controls.Add(this.txt_color_add);
            this.pnl_add_color.Location = new System.Drawing.Point(0, 0);
            this.pnl_add_color.Name = "pnl_add_color";
            this.pnl_add_color.Size = new System.Drawing.Size(377, 162);
            this.pnl_add_color.TabIndex = 8;
            // 
            // btn_esc
            // 
            this.btn_esc.BackColor = System.Drawing.Color.Transparent;
            this.btn_esc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_esc.FlatAppearance.BorderSize = 0;
            this.btn_esc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_esc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_esc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esc.Location = new System.Drawing.Point(339, 0);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(38, 32);
            this.btn_esc.TabIndex = 9;
            this.btn_esc.TabStop = false;
            this.btn_esc.UseVisualStyleBackColor = false;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(339, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 27);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // btn_color_removepnl
            // 
            this.btn_color_removepnl.BackColor = System.Drawing.Color.Transparent;
            this.btn_color_removepnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_color_removepnl.FlatAppearance.BorderSize = 0;
            this.btn_color_removepnl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_color_removepnl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_color_removepnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color_removepnl.Location = new System.Drawing.Point(157, 4);
            this.btn_color_removepnl.Name = "btn_color_removepnl";
            this.btn_color_removepnl.Size = new System.Drawing.Size(122, 29);
            this.btn_color_removepnl.TabIndex = 7;
            this.btn_color_removepnl.UseVisualStyleBackColor = false;
            this.btn_color_removepnl.Click += new System.EventHandler(this.btn_color_removepnl_Click);
            // 
            // pnl_remove_color
            // 
            this.pnl_remove_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_remove_color.BackgroundImage")));
            this.pnl_remove_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_remove_color.Controls.Add(this.lbl_er);
            this.pnl_remove_color.Controls.Add(this.btn_esc_2);
            this.pnl_remove_color.Controls.Add(this.btn_add_colorpnl);
            this.pnl_remove_color.Controls.Add(this.btn_delete);
            this.pnl_remove_color.Controls.Add(this.cmb_color_delete);
            this.pnl_remove_color.Location = new System.Drawing.Point(0, 0);
            this.pnl_remove_color.Name = "pnl_remove_color";
            this.pnl_remove_color.Size = new System.Drawing.Size(377, 162);
            this.pnl_remove_color.TabIndex = 9;
            // 
            // btn_esc_2
            // 
            this.btn_esc_2.BackColor = System.Drawing.Color.Transparent;
            this.btn_esc_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_esc_2.FlatAppearance.BorderSize = 0;
            this.btn_esc_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_esc_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_esc_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esc_2.Location = new System.Drawing.Point(339, 0);
            this.btn_esc_2.Name = "btn_esc_2";
            this.btn_esc_2.Size = new System.Drawing.Size(38, 32);
            this.btn_esc_2.TabIndex = 10;
            this.btn_esc_2.TabStop = false;
            this.btn_esc_2.UseVisualStyleBackColor = false;
            this.btn_esc_2.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // btn_add_colorpnl
            // 
            this.btn_add_colorpnl.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_colorpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_colorpnl.FlatAppearance.BorderSize = 0;
            this.btn_add_colorpnl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add_colorpnl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_add_colorpnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_colorpnl.Location = new System.Drawing.Point(0, 0);
            this.btn_add_colorpnl.Name = "btn_add_colorpnl";
            this.btn_add_colorpnl.Size = new System.Drawing.Size(142, 32);
            this.btn_add_colorpnl.TabIndex = 8;
            this.btn_add_colorpnl.TabStop = false;
            this.btn_add_colorpnl.UseVisualStyleBackColor = false;
            this.btn_add_colorpnl.Click += new System.EventHandler(this.btn_add_colorpnl_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbl_mainTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CALYPSO.DataQueryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_error.Location = new System.Drawing.Point(100, 115);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 11;
            // 
            // lbl_er
            // 
            this.lbl_er.AutoSize = true;
            this.lbl_er.BackColor = System.Drawing.Color.Transparent;
            this.lbl_er.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_er.Location = new System.Drawing.Point(69, 109);
            this.lbl_er.Name = "lbl_er";
            this.lbl_er.Size = new System.Drawing.Size(0, 17);
            this.lbl_er.TabIndex = 11;
            // 
            // frm_addColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 162);
            this.Controls.Add(this.pnl_add_color);
            this.Controls.Add(this.pnl_remove_color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_addColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addColor";
            this.Load += new System.EventHandler(this.frm_addColor_Load);
            this.pnl_add_color.ResumeLayout(false);
            this.pnl_add_color.PerformLayout();
            this.pnl_remove_color.ResumeLayout(false);
            this.pnl_remove_color.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_color_add;
        private System.Windows.Forms.ComboBox cmb_color_delete;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel pnl_add_color;
        private System.Windows.Forms.Button btn_color_removepnl;
        private System.Windows.Forms.Panel pnl_remove_color;
        private System.Windows.Forms.Button btn_add_colorpnl;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.Button button1;
        private DataQueryTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btn_esc_2;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_er;
    }
}