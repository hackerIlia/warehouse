using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abracadabra
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-3MC65OQ\SQLEXPRESS;Initial Catalog=warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        ConnectionStringClass connectionStringClass=new ConnectionStringClass();
        string role_user;
        public Form1(string role)
        {
            InitializeComponent();
            role_user = role;
        }
       

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ShowPostavshik showPostavshik = new ShowPostavshik(role_user);
            showPostavshik.ShowDialog();
        }


        private void поставщикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewPostavshik newPostavshik = new NewPostavshik();
            newPostavshik.ShowDialog();
        }

        private void чекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChek showChek = new ShowChek(role_user);
            showChek.ShowDialog();
        }

        

        private void чToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chek chek= new chek();
            chek.ShowDialog();
        }

        private void чекзаказчикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chek_zacazchik cz = new chek_zacazchik();
            cz.ShowDialog();
        }

        private void журналToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            jurnal jurnal = new jurnal();
            jurnal.ShowDialog();
        }

        private void накладнаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nakladnaia nakladnaia = new nakladnaia();
            nakladnaia.ShowDialog();
        }

        private void накладнаяпоставщикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nakladnaia_postavshik np = new nakladnaia_postavshik();
            np.ShowDialog();
        }

        private void типТовараToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tip_tovara tt = new tip_tovara();
            tt.ShowDialog();
        }

        private void товарToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tovar tovar = new tovar();
            tovar.ShowDialog();
        }

        private void заказчикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            zakazchik zakazchik = new zakazchik();
            zakazchik.ShowDialog();
        }

        private void buttonTovar_Click(object sender, EventArgs e)
        {
            ShowTovar showTovar= new ShowTovar(role_user);
            showTovar.ShowDialog();
        }

        private void buttonChekZakazchik_Click(object sender, EventArgs e)
        {
            ShowChekZakazchik showChekZakazchik= new ShowChekZakazchik(role_user);
            showChekZakazchik.ShowDialog();
        }

        private void buttonJurnal_Click(object sender, EventArgs e)
        {
            ShowJurnal showJurnal = new ShowJurnal(role_user);
            showJurnal.ShowDialog();
        }

        private void buttonNakladnaia_Click(object sender, EventArgs e)
        {
            ShowNakladnaia showNakladnaia = new ShowNakladnaia(role_user);
            showNakladnaia.ShowDialog();
        }

        private void buttonNaklPostavshik_Click(object sender, EventArgs e)
        {
            ShowNaklPostavshik showNaklPostavshik= new ShowNaklPostavshik(role_user);
            showNaklPostavshik.ShowDialog();
        }

        private void buttonTipTovara_Click(object sender, EventArgs e)
        {
            ShowTipTovara showTipTovara = new ShowTipTovara(role_user);
            showTipTovara.ShowDialog();
        }

        private void buttonZakazchik_Click(object sender, EventArgs e)
        {
            ShowZakazchik showZakazchik = new ShowZakazchik(role_user);
            showZakazchik.ShowDialog();
        }

        private void создатьРезервнуюКопиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = folderBrowserDialog1.SelectedPath;
                    string query = "BACKUP DATABASE warehouse\r\nTO DISK = '" + path + "\\backup_warehouse.bak' \r\nWITH NOFORMAT, NOINIT,\r\nNAME = 'BACKUP-WAREHOUSE', SKIP, NOREWIND, NOUNLOAD, STATS = 10;";
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = connectionStringClass.ConnectionString;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Резервная копия успешно создана!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void восстановитьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try
                {
                    string path = openFileDialog1.FileName;
                    if (!path.Contains(".bak"))
                    {
                        MessageBox.Show("Неверный тип файла!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string query = "USE master RESTORE DATABASE warehouse "+ 
                                    "FROM DISK = N'"+path+"' WITH FILE = 1, NOUNLOAD, STATS = 5; ";
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = connectionStringClass.ConnectionString;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("База данных успешно восстановлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            administration.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(role_user=="admin")
            {
                buttonAdministration.Visible = true;
                labelAdministration.Visible = true;
            }
            else
            {
                buttonAdministration.Visible = false;
                labelAdministration.Visible = false;
                buttonNakladnaia.Visible = false;
                labelNakladnaia.Visible=false;
                buttonNaklPostavshik.Visible = false;
                labelNaklPostavshik.Visible=false;
                buttonChekZakazchik.Visible = false;
                labelChekZakazchik.Visible=false;
                buttonJurnal.Visible = false;
                labelJurnal.Visible=false;
                buttonChek.Visible=false;
                labelChek.Visible=false;
            }    
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            this.Close();
        }

        private void buttonAdministration_Click(object sender, EventArgs e)
        {
            Administration administration1 = new Administration();
            administration1.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                DialogResult result = MessageBox.Show("Вы действительно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel= true;
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"..\..\Resources\Help.pdf");
            }
            catch
            {
                System.Diagnostics.Process.Start(@"Help.pdf");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox2 aboutBox2 = new AboutBox2();
            aboutBox2.ShowDialog();
        }
    }
}
