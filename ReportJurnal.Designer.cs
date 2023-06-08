namespace abracadabra
{
    partial class ReportJurnal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportJurnal));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.warehouseDataSetPostavshik = new abracadabra.warehouseDataSetPostavshik();
            this.warehouseDataSetPostavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSetPostavshikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSet1 = new abracadabra.warehouseDataSet1();
            this.jurnalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jurnalTableAdapter = new abracadabra.warehouseDataSet1TableAdapters.jurnalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetJurnal";
            reportDataSource1.Value = this.jurnalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "abracadabra.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1553, 841);
            this.reportViewer1.TabIndex = 0;
            // 
            // warehouseDataSetPostavshik
            // 
            this.warehouseDataSetPostavshik.DataSetName = "warehouseDataSetPostavshik";
            this.warehouseDataSetPostavshik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseDataSetPostavshikBindingSource
            // 
            this.warehouseDataSetPostavshikBindingSource.DataSource = this.warehouseDataSetPostavshik;
            this.warehouseDataSetPostavshikBindingSource.Position = 0;
            // 
            // warehouseDataSetPostavshikBindingSource1
            // 
            this.warehouseDataSetPostavshikBindingSource1.DataSource = this.warehouseDataSetPostavshik;
            this.warehouseDataSetPostavshikBindingSource1.Position = 0;
            // 
            // warehouseDataSet1
            // 
            this.warehouseDataSet1.DataSetName = "warehouseDataSet1";
            this.warehouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jurnalBindingSource
            // 
            this.jurnalBindingSource.DataMember = "jurnal";
            this.jurnalBindingSource.DataSource = this.warehouseDataSet1;
            // 
            // jurnalTableAdapter
            // 
            this.jurnalTableAdapter.ClearBeforeFill = true;
            // 
            // ReportJurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 841);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportJurnal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о журнале";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportJurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource warehouseDataSetPostavshikBindingSource1;
        private warehouseDataSetPostavshik warehouseDataSetPostavshik;
        private System.Windows.Forms.BindingSource warehouseDataSetPostavshikBindingSource;
        private warehouseDataSet1 warehouseDataSet1;
        private System.Windows.Forms.BindingSource jurnalBindingSource;
        private warehouseDataSet1TableAdapters.jurnalTableAdapter jurnalTableAdapter;
    }
}