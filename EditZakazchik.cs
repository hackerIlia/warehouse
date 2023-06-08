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
    public partial class EditZakazchik : Form
    {
        string infoZakazchik;
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        public EditZakazchik(string info)
        {
            InitializeComponent();
            infoZakazchik = info;
        }

        private void EditZakazchik_Load(object sender, EventArgs e)
        {
            try
            {
                if(infoZakazchik!= null)
                {
                    string[] strings = infoZakazchik.Split(';');
                    textBoxCodFirma.Text = strings[0];
                    textBoxNameFirma.Text = strings[1];
                    textBoxAddressFirma.Text = strings[2];
                    textBoxTelFax.Text = strings[3];
                }
            }
            catch 
            {
                
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionStringClass.ConnectionString;
                connection.Open();
                string query = "update zacazchik " +
                    "set name_firma_z='" + textBoxNameFirma.Text +
                    "', adres_z='" +textBoxAddressFirma.Text +
                    "', telfax_z='" + textBoxTelFax.Text +
                    "' where cod_firma_z=" + Convert.ToInt32(textBoxCodFirma.Text);
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

                    string query =  "declare @cod_firma_z int "+
                                    "set @cod_firma_z = "+Convert.ToInt32(textBoxCodFirma.Text)+
                                    " begin tran "+
                                    "delete from chek where number_chek IN (select number_chek "+
                                                                        "from chek_zakazchik "+
                                                                        "where cod_firma_z = @cod_firma_z) "+
                                    "delete from chek_zakazchik where cod_firma_z = @cod_firma_z "+
                                    "delete from zacazchik where cod_firma_z = @cod_firma_z "+
                                    "commit tran ";

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
