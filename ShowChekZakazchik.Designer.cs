﻿namespace abracadabra
{
    partial class ShowChekZakazchik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowChekZakazchik));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEditChek = new System.Windows.Forms.Button();
            this.buttonAddChek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(877, 789);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonEditChek
            // 
            this.buttonEditChek.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEditChek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditChek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditChek.Location = new System.Drawing.Point(919, 127);
            this.buttonEditChek.Name = "buttonEditChek";
            this.buttonEditChek.Size = new System.Drawing.Size(365, 82);
            this.buttonEditChek.TabIndex = 22;
            this.buttonEditChek.Text = "Редактировать";
            this.buttonEditChek.UseVisualStyleBackColor = false;
            this.buttonEditChek.Click += new System.EventHandler(this.buttonEditChek_Click);
            // 
            // buttonAddChek
            // 
            this.buttonAddChek.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddChek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddChek.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddChek.Location = new System.Drawing.Point(919, 12);
            this.buttonAddChek.Name = "buttonAddChek";
            this.buttonAddChek.Size = new System.Drawing.Size(365, 82);
            this.buttonAddChek.TabIndex = 21;
            this.buttonAddChek.Text = "Добавить";
            this.buttonAddChek.UseVisualStyleBackColor = false;
            this.buttonAddChek.Click += new System.EventHandler(this.buttonAddChek_Click);
            // 
            // ShowChekZakazchik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 895);
            this.Controls.Add(this.buttonEditChek);
            this.Controls.Add(this.buttonAddChek);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowChekZakazchik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чек-заказчик";
            this.Load += new System.EventHandler(this.ShowChekZakazchik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEditChek;
        private System.Windows.Forms.Button buttonAddChek;
    }
}