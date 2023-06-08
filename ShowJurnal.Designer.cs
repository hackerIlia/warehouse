namespace abracadabra
{
    partial class ShowJurnal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowJurnal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonReportJurnal = new System.Windows.Forms.Button();
            this.buttonEditJurnal = new System.Windows.Forms.Button();
            this.buttonAddJurnal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 655);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonReportJurnal
            // 
            this.buttonReportJurnal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonReportJurnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReportJurnal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReportJurnal.Location = new System.Drawing.Point(760, 249);
            this.buttonReportJurnal.Name = "buttonReportJurnal";
            this.buttonReportJurnal.Size = new System.Drawing.Size(365, 82);
            this.buttonReportJurnal.TabIndex = 26;
            this.buttonReportJurnal.Text = "Отчет";
            this.buttonReportJurnal.UseVisualStyleBackColor = false;
            this.buttonReportJurnal.Click += new System.EventHandler(this.buttonReportChek_Click);
            // 
            // buttonEditJurnal
            // 
            this.buttonEditJurnal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEditJurnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditJurnal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditJurnal.Location = new System.Drawing.Point(760, 127);
            this.buttonEditJurnal.Name = "buttonEditJurnal";
            this.buttonEditJurnal.Size = new System.Drawing.Size(365, 82);
            this.buttonEditJurnal.TabIndex = 25;
            this.buttonEditJurnal.Text = "Редактировать";
            this.buttonEditJurnal.UseVisualStyleBackColor = false;
            this.buttonEditJurnal.Click += new System.EventHandler(this.buttonEditChek_Click);
            // 
            // buttonAddJurnal
            // 
            this.buttonAddJurnal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddJurnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddJurnal.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddJurnal.Location = new System.Drawing.Point(760, 12);
            this.buttonAddJurnal.Name = "buttonAddJurnal";
            this.buttonAddJurnal.Size = new System.Drawing.Size(365, 82);
            this.buttonAddJurnal.TabIndex = 24;
            this.buttonAddJurnal.Text = "Добавить";
            this.buttonAddJurnal.UseVisualStyleBackColor = false;
            this.buttonAddJurnal.Click += new System.EventHandler(this.buttonAddChek_Click);
            // 
            // ShowJurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 701);
            this.Controls.Add(this.buttonReportJurnal);
            this.Controls.Add(this.buttonEditJurnal);
            this.Controls.Add(this.buttonAddJurnal);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowJurnal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.ShowJurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReportJurnal;
        private System.Windows.Forms.Button buttonEditJurnal;
        private System.Windows.Forms.Button buttonAddJurnal;
    }
}