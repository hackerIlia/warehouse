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
    public partial class EditNaklPostavshik : Form
    {
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        string infoNaklPostavshik;
        public EditNaklPostavshik(string info)
        {
            InitializeComponent();
            infoNaklPostavshik=info;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                connection.Open();
                string query = "update nakladnaia_postavshik " +
                    "set data_p='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd") +
                    "', cod_firma=" + Convert.ToInt32(textBoxCodFirma.Text) +
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditNaklPostavshik_Load(object sender, EventArgs e)
        {
            try
            {
                if (infoNaklPostavshik != null)
                {
                    string[] strings = infoNaklPostavshik.Split(';');
                    textBoxNumDoc.Text = strings[0];
                    dateTimePicker1.Value = Convert.ToDateTime(strings[1]);
                    textBoxCodFirma.Text = strings[2];
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string query = "DELETE FROM nakladnaia_postavshik WHERE num_doc=" + Convert.ToInt32(textBoxNumDoc.Text);

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
