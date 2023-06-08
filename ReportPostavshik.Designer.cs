namespace abracadabra
{
    partial class ReportPostavshik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPostavshik));
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSetPostavshikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSetPostavshik = new abracadabra.warehouseDataSetPostavshik();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.warehouseDataSetPostavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new abracadabra.warehouseDataSetPostavshikTableAdapters.postavshikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "postavshik";
            this.postavshikBindingSource.DataSource = this.warehouseDataSetPostavshikBindingSource1;
            // 
            // warehouseDataSetPostavshikBindingSource1
            // 
            this.warehouseDataSetPostavshikBindingSource1.DataSource = this.warehouseDataSetPostavshik;
            this.warehouseDataSetPostavshikBindingSource1.Position = 0;
            // 
            // warehouseDataSetPostavshik
            // 
            this.warehouseDataSetPostavshik.DataSetName = "warehouseDataSetPostavshik";
            this.warehouseDataSetPostavshik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPostavshik";
            reportDataSource1.Value = this.postavshikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "abracadabra.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1736, 982);
            this.reportViewer1.TabIndex = 0;
            // 
            // warehouseDataSetPostavshikBindingSource
            // 
            this.warehouseDataSetPostavshikBindingSource.DataSource = this.warehouseDataSetPostavshik;
            this.warehouseDataSetPostavshikBindingSource.Position = 0;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPostavshik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 982);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportPostavshik";
            this.Text = "Отчет о поставщиках";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportPostavshik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetPostavshikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource warehouseDataSetPostavshikBindingSource;
        private warehouseDataSetPostavshik warehouseDataSetPostavshik;
        private System.Windows.Forms.BindingSource warehouseDataSetPostavshikBindingSource1;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private warehouseDataSetPostavshikTableAdapters.postavshikTableAdapter postavshikTableAdapter;
    }
}