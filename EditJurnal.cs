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
    public partial class EditJurnal : Form
    {
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        string infoJurnal;
        public EditJurnal(string info)
        {
            InitializeComponent();
            infoJurnal = info;
        }

        private void EditJurnal_Load(object sender, EventArgs e)
        {
            try
            {
                if (infoJurnal != null)
                {
                    string[] infoSplit = infoJurnal.Split(';');
                    textBoxCodTovara.Text = infoSplit[0];
                    dateTimePicker1.Value = DateTime.Parse(infoSplit[1]);
                    textBoxOstatok.Text = infoSplit[2];
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
                string query = "update jurnal " +
                    "set data_p='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd") +
                    "', ostatok=" + Convert.ToInt32(textBoxOstatok.Text) +
                    " where cod_tovara=" + Convert.ToInt32(textBoxCodTovara.Text);
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

                    string query = "DELETE FROM jurnal WHERE cod_tovara=" + Convert.ToInt32(textBoxCodTovara.Text);

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
    }
}
