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
    public partial class chek : Form
    {
        private string ConnectionString = @"Data Source=DESKTOP-3MC65OQ\SQLEXPRESS;Initial Catalog=warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public chek()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(Convert.ToInt32(textBox3.Text)<1)
            {
                MessageBox.Show("Количество единиц должно быть больше 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "insert into chek values(@number_chek,@cod_tovara,@kol_ed)";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@number_chek", textBox1.Text);
                    command.Parameters.AddWithValue("@cod_tovara",textBox2.Text);
                    command.Parameters.AddWithValue("@kol_ed",Convert.ToInt32(textBox3.Text));

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
