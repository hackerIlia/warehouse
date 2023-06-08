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
    public partial class EditTovar : Form
    {
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        string infoTovar;
        public EditTovar(string info)
        {
            InitializeComponent();
            infoTovar = info;

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                connection.Open();
                string query = "update tovar " +
                    "set name_tovara='" + textBoxNameTovara.Text +
                    "', cod_tipa=" + Convert.ToInt32(textBoxCodTipa.Text) +
                    ", price_z="+Convert.ToInt32(textBoxPriceZ.Text)+
                    ", koef="+Convert.ToInt32(textBoxKoef.Text)+
                    ", ves_tovara="+Convert.ToInt32(textBoxVesTovara.Text)+
                    ", ed_izm='"+textBoxEdIzm.Text +
                    "' where cod_tovara=" + Convert.ToInt32(textBoxCodTovara.Text);
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

        private void EditTovar_Load(object sender, EventArgs e)
        {
            if (infoTovar != null)
            {
                string[] strings = infoTovar.Split(';');
                textBoxCodTovara.Text= strings[0];
                textBoxNameTovara.Text = strings[1];
                textBoxCodTipa.Text= strings[2];
                textBoxPriceZ.Text= strings[3];
                textBoxKoef.Text= strings[4];
                textBoxVesTovara.Text= strings[5];
                textBoxEdIzm.Text= strings[6];
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

                    string query =  "declare @cod_tovara int " +
                                    "set @cod_tovara = " +Convert.ToInt32(textBoxCodTovara.Text)+
                                    "begin tran " +
                                    "delete from chek where cod_tovara = @cod_tovara " +
                                    "delete from nakladnaia where cod_tovara = @cod_tovara " +
                                    "delete from jurnal where cod_tovara = @cod_tovara " +
                                    "delete from tovar where cod_tovara=@cod_tovara "+
                                    "commit tran";

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
    }
}
