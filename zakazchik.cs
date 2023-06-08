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
    public partial class zakazchik : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-3MC65OQ\SQLEXPRESS;Initial Catalog=warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public zakazchik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!textBox4.Text.StartsWith("+373"))
            {
                MessageBox.Show("Введите номер, начиная с '+373'");
                return;
            }

            try
            {
                string query = "insert into zacazchik values(@cod_firma_z,@name_firma_z,@adres_z,@telfax_z)";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cod_firma_z", textBox1.Text);
                    command.Parameters.AddWithValue("@name_firma_z", textBox2.Text);
                    command.Parameters.AddWithValue("@adres_z", textBox3.Text);
                    command.Parameters.AddWithValue("@telfax_z", textBox4.Text);

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
