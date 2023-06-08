using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abracadabra
{
    public partial class Administration : Form
    {
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        public Administration()
        {
            InitializeComponent();
        }

        private void buttonCreateBackup_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = folderBrowserDialog1.SelectedPath;
                    string query = "BACKUP DATABASE warehouse\r\nTO DISK = '" + path + "\\backup_warehouse.bak' \r\nWITH NOFORMAT, NOINIT,\r\nNAME = 'BACKUP-WAREHOUSE', SKIP, NOREWIND, NOUNLOAD, STATS = 10;";
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = connectionStringClass.ConnectionString;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Резервная копия успешно создана!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRestoreDataBase_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    if (!path.Contains(".bak"))
                    {
                        MessageBox.Show("Неверный тип файла!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string query = "USE master ALTER DATABASE warehouse\r\nSET SINGLE_USER\r\nWITH ROLLBACK IMMEDIATE RESTORE DATABASE warehouse " +
                                    "FROM DISK = N'" + path + "' WITH FILE = 1, NOUNLOAD, STATS = 5; ";
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = connectionStringClass.ConnectionString;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("База данных успешно восстановлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEditUsers_Click(object sender, EventArgs e)
        {
            EditUsers editUsers = new EditUsers();
            editUsers.ShowDialog();
        }
    }
}
