namespace CALYPSO
{
    partial class Frm_print_payment_historycs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataQuery = new CALYPSO.DataQuery();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payment_historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_mainTableAdapter = new CALYPSO.DataQueryTableAdapters.tbl_mainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_historyBindingSource)).BeginInit();
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
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(CALYPSO.patient);
            // 
            // payment_historyBindingSource
            // 
            this.payment_historyBindingSource.DataSource = typeof(CALYPSO.payment_history);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Man";
            reportDataSource1.Value = this.tbl_mainBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.patientBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.payment_historyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CALYPSO.ReportPage.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1028, 703);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_mainTableAdapter
            // 
            this.tbl_mainTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_print_payment_historycs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 703);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_print_payment_historycs";
            this.Text = "Frm_print_payment_historycs";
            this.Load += new System.EventHandler(this.Frm_print_payment_historycs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_historyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_mainBindingSource;
        private DataQuery DataQuery;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource payment_historyBindingSource;
        private DataQueryTableAdapters.tbl_mainTableAdapter tbl_mainTableAdapter;
    }
}