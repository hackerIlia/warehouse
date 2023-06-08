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
    public partial class jurnal : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-3MC65OQ\SQLEXPRESS;Initial Catalog=warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public jurnal()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "insert into jurnal values(@cod_tovara,@data_p,@ostatok)";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cod_tovara", textBox1.Text);
                    command.Parameters.AddWithValue("@data_p", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@ostatok", textBox2.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Информация успешно добавлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
