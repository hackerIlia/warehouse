namespace abracadabra
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.buttonEditUsers = new System.Windows.Forms.Button();
            this.buttonCreateBackup = new System.Windows.Forms.Button();
            this.buttonRestoreDataBase = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonEditUsers
            // 
            this.buttonEditUsers.BackColor = System.Drawing.Color.Azure;
            this.buttonEditUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditUsers.Location = new System.Drawing.Point(110, 45);
            this.buttonEditUsers.Name = "buttonEditUsers";
            this.buttonEditUsers.Size = new System.Drawing.Size(567, 99);
            this.buttonEditUsers.TabIndex = 0;
            this.buttonEditUsers.Text = "Управление пользователями";
            this.buttonEditUsers.UseVisualStyleBackColor = false;
            this.buttonEditUsers.Click += new System.EventHandler(this.buttonEditUsers_Click);
            // 
            // buttonCreateBackup
            // 
            this.buttonCreateBackup.BackColor = System.Drawing.Color.Azure;
            this.buttonCreateBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateBackup.Location = new System.Drawing.Point(110, 183);
            this.buttonCreateBackup.Name = "buttonCreateBackup";
            this.buttonCreateBackup.Size = new System.Drawing.Size(567, 99);
            this.buttonCreateBackup.TabIndex = 1;
            this.buttonCreateBackup.Text = "Создать резервную копию БД";
            this.buttonCreateBackup.UseVisualStyleBackColor = false;
            this.buttonCreateBackup.Click += new System.EventHandler(this.buttonCreateBackup_Click);
            // 
            // buttonRestoreDataBase
            // 
            this.buttonRestoreDataBase.BackColor = System.Drawing.Color.Azure;
            this.buttonRestoreDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestoreDataBase.Location = new System.Drawing.Point(110, 326);
            this.buttonRestoreDataBase.Name = "buttonRestoreDataBase";
            this.buttonRestoreDataBase.Size = new System.Drawing.Size(567, 99);
            this.buttonRestoreDataBase.TabIndex = 2;
            this.buttonRestoreDataBase.Text = "Восстановить БД";
            this.buttonRestoreDataBase.UseVisualStyleBackColor = false;
            this.buttonRestoreDataBase.Click += new System.EventHandler(this.buttonRestoreDataBase_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(760, 502);
            this.Controls.Add(this.buttonRestoreDataBase);
            this.Controls.Add(this.buttonCreateBackup);
            this.Controls.Add(this.buttonEditUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование базой данных";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditUsers;
        private System.Windows.Forms.Button buttonCreateBackup;
        private System.Windows.Forms.Button buttonRestoreDataBase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}