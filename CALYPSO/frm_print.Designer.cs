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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataQuery = new CALYPSO.DataQuery();
            this.tbl_mainTableAdapter = new CALYPSO.DataQueryTableAdapters.tbl_mainTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQuery)).BeginInit();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Man";
            reportDataSource1.Value = this.tbl_mainBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CALYPSO.ReportPage.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(976, 702);
            this.reportViewer1.TabIndex = 0;
            // 
            // frm_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 702);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_print";
            this.Text = "frm_print";
            this.Load += new System.EventHandler(this.frm_print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.BindingSource tbl_mainBindingSource;
        private DataQuery DataQuery;
        private DataQueryTableAdapters.tbl_mainTableAdapter tbl_mainTableAdapter;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}