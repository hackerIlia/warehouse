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
    public partial class EditInfoUsers : Form
    {
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        string info_user = "";
        public EditInfoUsers(string info)
        {
            InitializeComponent();
            info_user= info;
        }

        private void EditInfoUsers_Load(object sender, EventArgs e)
        {
            string path_photo = "";
            string[] infoSplit=info_user.Split(';');
            textBoxLogin.Text = infoSplit[0];
            string role = infoSplit[1];
            if(role=="admin") { comboBoxRole.SelectedIndex = 0; }
            else { comboBoxRole.SelectedIndex = 1;}

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionStringUsers;
                connection.Open();
                string query = "select path_photo from login_password WHERE login_user='"+textBoxLogin.Text+"'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    path_photo=cmd.ExecuteScalar().ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pictureBox1.ImageLocation = @""+path_photo;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string role_us = "";
            if (comboBoxRole.SelectedIndex == 0)
            {
                role_us = "admin";
            }
            else
            {
                role_us= "user";
            }

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionStringUsers;
                connection.Open();
                string query = "update login_password " +
                    "set role_user='"+role_us+
                    "' where login_user='" + textBoxLogin.Text+"'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешное редактирование!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = connectionStringClass.ConnectionStringUsers;
                    connection.Open();

                    string query = "DELETE FROM login_password WHERE login_user='" + textBoxLogin.Text+"'";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Успешное удаление!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    connection.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("The DELETE statement conflicted"))
                    {
                        MessageBox.Show("Удалите сначала записи об этом поставщике в других таблицах!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string path=openFileDialog1.FileName;
                try
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = connectionStringClass.ConnectionStringUsers;
                    string query = "update login_password "+
                                    "set path_photo='"+path+
                                    "' where login_user='"+textBoxLogin.Text+"'";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                    connection.Close();
                    EditInfoUsers_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}