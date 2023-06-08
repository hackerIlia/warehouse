namespace abracadabra
{
    partial class ReportChek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportChek));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.warehouseDataSet2 = new abracadabra.warehouseDataSet2();
            this.chekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chekTableAdapter = new abracadabra.warehouseDataSet2TableAdapters.chekTableAdapter();
            this.chekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chekBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "abracadabra.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1280, 908);
            this.reportViewer1.TabIndex = 0;
            // 
            // warehouseDataSet2
            // 
            this.warehouseDataSet2.DataSetName = "warehouseDataSet2";
            this.warehouseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chekBindingSource
            // 
            this.chekBindingSource.DataMember = "chek";
            this.chekBindingSource.DataSource = this.warehouseDataSet2;
            // 
            // chekTableAdapter
            // 
            this.chekTableAdapter.ClearBeforeFill = true;
            // 
            // chekBindingSource1
            // 
            this.chekBindingSource1.DataMember = "chek";
            this.chekBindingSource1.DataSource = this.warehouseDataSet2;
            // 
            // ReportChek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 908);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportChek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать чека";
            this.Load += new System.EventHandler(this.ReportChek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private warehouseDataSet2 warehouseDataSet2;
        private System.Windows.Forms.BindingSource chekBindingSource;
        private warehouseDataSet2TableAdapters.chekTableAdapter chekTableAdapter;
        private System.Windows.Forms.BindingSource chekBindingSource1;
    }
}