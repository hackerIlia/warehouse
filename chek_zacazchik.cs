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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace abracadabra
{
    public partial class chek_zacazchik : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-3MC65OQ\SQLEXPRESS;Initial Catalog=warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public chek_zacazchik()
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
                string query = "insert into chek_zakazchik values(@number_chek,@data_z,@cod_firma_z)";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@number_chek", textBox1.Text);
                    command.Parameters.AddWithValue("@data_z", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@cod_firma_z", textBox2.Text);

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
