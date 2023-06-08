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
    public partial class ShowChekZakazchik : Form
    {
        ConnectionStringClass connectionStringClass= new ConnectionStringClass();
        int index=-1;
        string info = "",role_user="";

        public ShowChekZakazchik(string role)
        {
            InitializeComponent();
            role_user = role;
        }

        private void ShowChekZakazchik_Load(object sender, EventArgs e)
        {
            if(role_user=="admin")
            {
                buttonAddChek.Visible = true;
                buttonEditChek.Visible=true;
            }
            else
            {
                buttonAddChek.Visible = false;
                buttonEditChek.Visible = false;
            }


            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                string query = "select * from chek_zakazchik";
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
                dataGridView1.Columns[0].HeaderText = "Номер чека";
                dataGridView1.Columns[1].HeaderText = "Дата заказа";
                dataGridView1.Columns[2].HeaderText = "Код фирмы заказчика";
            }
            catch
            {
                MessageBox.Show("Ошибка подключения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                index = 0;
                info = "" + dataGridView1.Rows[index].Cells[0].Value + ";" +
               dataGridView1.Rows[index].Cells[1].Value + ";" +
               dataGridView1.Rows[index].Cells[2].Value;
            }
            catch 
            {

            }
        }

        private void buttonAddChek_Click(object sender, EventArgs e)
        {
            chek_zacazchik chek_Zacazchik=new chek_zacazchik();
            chek_Zacazchik.ShowDialog();
            ShowChekZakazchik_Load(sender, e);
        }

        private void buttonEditChek_Click(object sender, EventArgs e)
        {
            EditChekZacazchik editChekZacazchik = new EditChekZacazchik(info);
            editChekZacazchik.ShowDialog();
            ShowChekZakazchik_Load(sender , e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.SelectedRows[0].Index;
            info = "" + dataGridView1.Rows[index].Cells[0].Value+";"+
                dataGridView1.Rows[index].Cells[1].Value+";"+
                dataGridView1.Rows[index].Cells[2].Value;
        }
    }
}
