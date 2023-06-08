using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abracadabra
{
    public partial class InputCodEmail : Form
    {
        ConnectionStringClass connectionStringClass = new ConnectionStringClass();
        int cod_email;
        string email;
        public InputCodEmail(int cod_mail,string mail)
        {
            InitializeComponent();
            cod_email = cod_mail;
            email = mail;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxCod.Text == null)
            {
                MessageBox.Show("Введите код!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            if (textBoxCod.Text == cod_email.ToString())
            {
                this.Hide();
                this.Dispose();

                //открытие формы изменения пароля
                NewPassword newPassword = new NewPassword(email);
                newPassword.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный код!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
