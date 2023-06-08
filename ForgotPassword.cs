using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abracadabra
{
    public partial class ForgotPassword : Form
    {
        ConnectionStringClass connectionStringClass = new ConnectionStringClass();
        int cod_mail;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private bool SendMessage(string email)
        {
            try
            {
                MailAddress from = new MailAddress("zabilpr@gmail.com", "Служба безопасности БД");
                MailAddress to = new MailAddress(email);
                MailMessage message = new MailMessage(from,to);
                message.Subject = "Восстановление пароля";

                Random random = new Random();
                cod_mail = random.Next(1000, 10000);

                message.Body = "Чтобы восстановить пароль, введите в приложении этот код: " + cod_mail;
                message.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
                smtp.Credentials=new NetworkCredential("zabilpr@gmail.com", "xfexluamjrystnbz");
                smtp.EnableSsl = true;
                smtp.Send(message);
                Close();
                connectionStringClass.login_forgot_password = textBoxLogin.Text;
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        string email = "";
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                string query = "select e_mail from login_password where login_user='"+textBoxLogin.Text+"'";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionStringUsers;

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();
                    if (command.ExecuteScalar() == null) 
                    {
                        MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                    email=command.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (IsValidEmail(email))
            {
                if (SendMessage(email))
                {
                    MessageBox.Show("Введите код, отправленный на электронную почту!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Hide();
                    InputCodEmail inputCodEmail = new InputCodEmail(cod_mail,textBoxLogin.Text);
                    inputCodEmail.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при отправке сообщения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Неверный адрес эл.почты!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
