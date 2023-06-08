namespace abracadabra
{
    partial class ReportTovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTovar));
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSet = new abracadabra.warehouseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tovarTableAdapter = new abracadabra.warehouseDataSetTableAdapters.tovarTableAdapter();
            this.warehouseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.warehouseDataSetBindingSource1;
            // 
            // warehouseDataSetBindingSource1
            // 
            this.warehouseDataSetBindingSource1.DataSource = this.warehouseDataSet;
            this.warehouseDataSetBindingSource1.Position = 0;
            // 
            // warehouseDataSet
            // 
            this.warehouseDataSet.DataSetName = "warehouseDataSet";
            this.warehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tovarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "abracadabra.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1710, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseDataSetBindingSource
            // 
            this.warehouseDataSetBindingSource.DataSource = this.warehouseDataSet;
            this.warehouseDataSetBindingSource.Position = 0;
            // 
            // ReportTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1710, 451);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о товарах";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportPostavshik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private warehouseDataSet warehouseDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private warehouseDataSetTableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.BindingSource warehouseDataSetBindingSource1;
        private System.Windows.Forms.BindingSource warehouseDataSetBindingSource;
    }
}