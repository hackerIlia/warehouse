namespace abracadabra
{
    partial class ReportNakladnaia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportNakladnaia));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.warehouseDataSet4 = new abracadabra.warehouseDataSet4();
            this.nakladnaiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nakladnaiaTableAdapter = new abracadabra.warehouseDataSet4TableAdapters.nakladnaiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnaiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nakladnaiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "abracadabra.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1332, 941);
            this.reportViewer1.TabIndex = 0;
            // 
            // warehouseDataSet4
            // 
            this.warehouseDataSet4.DataSetName = "warehouseDataSet4";
            this.warehouseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nakladnaiaBindingSource
            // 
            this.nakladnaiaBindingSource.DataMember = "nakladnaia";
            this.nakladnaiaBindingSource.DataSource = this.warehouseDataSet4;
            // 
            // nakladnaiaTableAdapter
            // 
            this.nakladnaiaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportNakladnaia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 941);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportNakladnaia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладная";
            this.Load += new System.EventHandler(this.ReportNakladnaia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnaiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private warehouseDataSet4 warehouseDataSet4;
        private System.Windows.Forms.BindingSource nakladnaiaBindingSource;
        private warehouseDataSet4TableAdapters.nakladnaiaTableAdapter nakladnaiaTableAdapter;
    }
}