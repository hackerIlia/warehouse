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
    public partial class EditUsers : Form
    {
        ConnectionStringClass connectionStringClass = new ConnectionStringClass();
        public EditUsers()
        {
            InitializeComponent();
        }

        private void EditUsers_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionStringUsers;
                string query = "select * from login_role";
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "info");
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "info";
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                connection.Close();
                dataGridView1.Columns[0].HeaderText = "Логин";
                dataGridView1.Columns[1].HeaderText = "Роль";
                
            }
            catch
            {
                MessageBox.Show("Ошибка подключения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string info = "" + dataGridView1.Rows[index].Cells[0].Value.ToString() + ";" +
                                dataGridView1.Rows[index].Cells[1].Value.ToString();

                EditInfoUsers editInfoUsers = new EditInfoUsers(info);
                editInfoUsers.ShowDialog();
                EditUsers_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Ошибка при попытке редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
