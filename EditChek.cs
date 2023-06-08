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
    public partial class EditChek : Form
    {
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        string infoChek = "";
        public EditChek(string info)
        {
            InitializeComponent();
            infoChek= info;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                connection.Open();
                string query ="update chek " +
                    "set cod_tovara=" + Convert.ToInt32(textBoxCodTovara.Text) +
                    ", kol_ed=" + Convert.ToInt32(textBoxNumUnits.Text) +
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EditChek_Load(object sender, EventArgs e)
        {
            if (infoChek != "")
            {
                string[] infoSplit = infoChek.Split(';');
                textBoxNumberChek.Text = infoSplit[0];
                textBoxCodTovara.Text = infoSplit[1];
                textBoxNumUnits.Text = infoSplit[2];
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
                    string query = "delete from chek where number_chek=" + Convert.ToInt32(textBoxNumberChek.Text);

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Успешное удаление!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
