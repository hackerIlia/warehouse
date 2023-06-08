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
    public partial class EditPostavshik : Form
    {
        ConnectionStringClass connectionStringClass= new ConnectionStringClass();
        string infoPostavhik="";
        public EditPostavshik(string info)
        {
            InitializeComponent();
            infoPostavhik= info;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                connection.Open();
                string query =
                    "declare @cod_firma int, @name_firma name_pr, @adres_firma name_pr, @telfax_firma name_pr, @rashet name_pr " +
                    "  set @cod_firma= '" + Convert.ToInt32(textBoxCodFirma.Text) +
                    "' set @name_firma= '" + textBoxNameFirma.Text +
                    "' set @adres_firma= '" + textBoxAddressFirma.Text +
                    "' set @telfax_firma= '" + textBoxTelFax.Text +
                    "' set @rashet= '" + textBoxRashet.Text +
                    "' exec edit_postavshik @cod_firma ,@name_firma ,@adres_firma ,@telfax_firma ,@rashet ";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //cmd.Parameters.AddWithValue("@cod_firma", Convert.ToInt32(textBoxCodFirma.Text));
                    //cmd.Parameters.AddWithValue("@name_firma",(textBoxNameFirma.Text));
                    //cmd.Parameters.AddWithValue("@adres_firma",(textBoxAddressFirma.Text));
                    //cmd.Parameters.AddWithValue("@telfax_firma", (textBoxTelFax.Text));
                    //cmd.Parameters.AddWithValue("@rashet", (textBoxRashet.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешное редактирование!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    connection.ConnectionString = connectionStringClass.ConnectionString;
                    connection.Open();

                    string query = "DELETE FROM postavshik WHERE cod_firma=" + Convert.ToInt32(textBoxCodFirma.Text);

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
                        MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else { }
        }

        private void EditPostavshik_Load(object sender, EventArgs e)
        {
            if (infoPostavhik != "")
            {
                string[] infoSplit = infoPostavhik.Split(';');
                textBoxCodFirma.Text = infoSplit[0];
                textBoxNameFirma.Text = infoSplit[1];
                textBoxAddressFirma.Text = infoSplit[2];
                textBoxTelFax.Text = infoSplit[3];
                textBoxRashet.Text = infoSplit[4];
            }
        }
    }
}
