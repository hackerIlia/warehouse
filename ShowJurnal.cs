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
    public partial class ShowJurnal : Form
    {
        ConnectionStringClass connectionStringClass = new ConnectionStringClass();
        int index=-1;
        string info = "",role_user="";
        public ShowJurnal(string role)
        {
            InitializeComponent();
            role_user = role;
        }

        private void ShowJurnal_Load(object sender, EventArgs e)
        {
            if(role_user=="admin")
            {
                buttonAddJurnal.Visible = true;
                buttonEditJurnal.Visible = true;
            }
            else
            {
                buttonAddJurnal.Visible = false;
                buttonEditJurnal.Visible = false;
            }


            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                string query = "select * from jurnal order by data_p";
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
                dataGridView1.Columns[0].HeaderText = "Код товара";
                dataGridView1.Columns[1].HeaderText = "Дата проверки";
                dataGridView1.Columns[2].HeaderText = "Остаток";
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
            jurnal jurnal=new jurnal();
            jurnal.ShowDialog();
            ShowJurnal_Load(sender, e);
        }

        private void buttonEditChek_Click(object sender, EventArgs e)
        {
            EditJurnal editJurnal=new EditJurnal(info);
            editJurnal.ShowDialog();
            ShowJurnal_Load(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.SelectedRows[0].Index;
            info = "" + dataGridView1.Rows[index].Cells[0].Value + ";" +
                dataGridView1.Rows[index].Cells[1].Value + ";" +
                dataGridView1.Rows[index].Cells[2].Value;
        }

        private void buttonReportChek_Click(object sender, EventArgs e)
        {
            ReportJurnal reportJurnal = new ReportJurnal();
            reportJurnal.ShowDialog();
        }
    }
}
