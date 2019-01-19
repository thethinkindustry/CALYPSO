namespace CALYPSO
{
    partial class frm_print
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_print));
            this.tbl_mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataQuery = new CALYPSO.DataQuery();
            this.tbl_mainTableAdapter = new CALYPSO.DataQueryTableAdapters.tbl_mainTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_mainBindingSource
            // 
            this.tbl_mainBindingSource.DataMember = "tbl_main";
            this.tbl_mainBindingSource.DataSource = this.DataQuery;
            // 
            // DataQuery
            // 
            this.DataQuery.DataSetName = "DataQuery";
            this.DataQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_mainTableAdapter
            // 
            this.tbl_mainTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(CALYPSO.patient);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(990, 702);
            this.reportViewer.TabIndex = 0;
            // 
            // frm_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 702);
            this.Controls.Add(this.reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazdırma Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.BindingSource tbl_mainBindingSource;
        private DataQuery DataQuery;
        private DataQueryTableAdapters.tbl_mainTableAdapter tbl_mainTableAdapter;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}