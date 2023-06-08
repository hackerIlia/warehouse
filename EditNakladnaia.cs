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
    public partial class EditNakladnaia : Form
    {
        string infoNakladnaia;
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        public EditNakladnaia(string info)
        {
            InitializeComponent();
            infoNakladnaia = info;
        }

        private void EditNakladnaia_Load(object sender, EventArgs e)
        {
            try
            {
                if (infoNakladnaia != null)
                {
                    string[] strings = infoNakladnaia.Split(';');
                    textBoxNumDoc.Text = strings[0];
                    textBoxCodTovara.Text = strings[1];
                    textBoxNumUnits.Text = strings[2];
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                connection.Open();
                string query = "update nakladnaia " +
                    "set cod_tovara='" + Convert.ToInt32(textBoxCodTovara.Text) +
                    "', kol_ed=" + Convert.ToInt32(textBoxNumUnits.Text) +
                    " where num_doc=" + Convert.ToInt32(textBoxNumDoc.Text);
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

                    string query = "DELETE FROM nakladnaia WHERE num_doc=" + Convert.ToInt32(textBoxNumDoc.Text);

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
