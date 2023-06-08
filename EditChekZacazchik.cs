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
    public partial class EditChekZacazchik : Form
    {
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        string infoChekZakazchik = "";
        public EditChekZacazchik(string info)
        {
            InitializeComponent();
            infoChekZakazchik = info;

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                connection.Open();
                string query = "update chek_zakazchik " +
                    "set data_z='" + Convert.ToDateTime(dateTimePickerDataZ.Value).ToString("yyyy-MM-dd") +
                    "', cod_firma_z=" + Convert.ToInt32(textBoxCodFirmaZakazchik.Text) +
                    " where number_chek=" + Convert.ToInt32(textBoxNumberChek.Text);
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
                    connection.ConnectionString = connectionStringClass.ConnectionString;
                    connection.Open();

                    string query = "DELETE FROM chek_zakazchik WHERE number_chek=" + Convert.ToInt32(textBoxNumberChek.Text);

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
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EditChekZacazchik_Load(object sender, EventArgs e)
        {
            if (infoChekZakazchik != "")
            {
                string[] infoSplit = infoChekZakazchik.Split(';');
                textBoxNumberChek.Text = infoSplit[0];
                dateTimePickerDataZ.Value = Convert.ToDateTime(infoSplit[1]);
                textBoxCodFirmaZakazchik.Text = infoSplit[2];
            }
        }
    }
}
