using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace abracadabra
{
    public partial class Authorization : Form
    {
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        int attempt = 0;
        string login="",email="";
        public Authorization()
        {
            InitializeComponent();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private bool SendMessage(string email)
        {
            try
            {
                MailAddress from = new MailAddress("zabilpr@gmail.com", "Служба безопасности БД");
                MailAddress to = new MailAddress(email);
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Попытка входа в аккаунт";


                message.Body = "В Ваш аккаунт "+login+ " пытались войти 3 раза\nДата попытки входа в Ваш аккаунт: " +
                                DateTime.Now.ToString("dddd, dd MMMM yyyy HH: mm:ss") +
                                "\nIP адрес устройства, с которого была попытка входа: " +
                                GetLocalIPAddress();
                message.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("zabilpr@gmail.com", "xfexluamjrystnbz");
                smtp.EnableSsl = true;
                smtp.Send(message);
                connectionStringClass.login_forgot_password = textBoxLogin.Text;
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool SendMessageOK(string email)
        {
            try
            {
                MailAddress from = new MailAddress("zabilpr@gmail.com", "Служба безопасности БД");
                MailAddress to = new MailAddress(email);
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Вход в аккаунт";


                message.Body = "В Ваш аккаунт " + login + " был выполнен вход\n\nДата входа в Ваш аккаунт: " +
                                DateTime.Now.ToString("dddd, dd MMMM yyyy HH: mm:ss") +
                                "\n\nIP адрес устройства, с которого был выполнен вход: " +
                                GetLocalIPAddress();
                message.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("zabilpr@gmail.com", "xfexluamjrystnbz");
                smtp.EnableSsl = true;
                smtp.Send(message);
                connectionStringClass.login_forgot_password = textBoxLogin.Text;
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }



        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            string role="";
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            try
            {
                string query1 = "select login_user from login_password WHERE login_user='"+textBoxLogin.Text+"'";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionStringUsers;

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    connection.Open();
                    if(command.ExecuteScalar()==null)
                    {
                        attempt = 0;
                        MessageBox.Show("Пользователя не существует!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        login=command.ExecuteScalar().ToString();
                        string query2 = "select password_user from login_password WHERE login_user='" + textBoxLogin.Text + "'";
                        using(SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            if (command2.ExecuteScalar() != null)
                            {
                            string password=command2.ExecuteScalar().ToString();
                            if (password != textBoxPassword.Text)
                            {
                                    if (attempt == 2)
                                    {
                                        //отправка сообщения о взломе
                                        string query3 = "select e_mail from login_password WHERE login_user='" + textBoxLogin.Text + "'";
                                        using (SqlCommand command3 = new SqlCommand(query3, connection))
                                        {
                                            email= command3.ExecuteScalar().ToString();
                                            SendMessage(email);
                                            MessageBox.Show("Сеанс завершен!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            this.Close();
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        attempt++;
                                        MessageBox.Show("Неверный пароль!\nОсталось попыток: " + (3 - attempt), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                            }
                            else
                                {
                                    string query3 = "select role_user from login_password WHERE login_user='"+textBoxLogin.Text+"'";
                                    using(SqlCommand command3=new SqlCommand(query3, connection))
                                    {
                                        role=command3.ExecuteScalar().ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                string queryEmail = "select e_mail from login_password WHERE login_user='" + textBoxLogin.Text + "'";
                using (SqlCommand commandEmail = new SqlCommand(queryEmail, connection))
                {
                    email = commandEmail.ExecuteScalar().ToString();
                }

                MessageBox.Show("Вход выполнен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SendMessageOK(email);
                this.Hide();
                Form1 form1 = new Form1(role);
                form1.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void buttonViewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void buttonViewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar=true;
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }
    }
}
