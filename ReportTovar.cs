using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abracadabra
{
    public partial class ReportTovar : Form
    {
        public ReportTovar()
        {
            InitializeComponent();
        }

        private void ReportPostavshik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseDataSet.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.warehouseDataSet.tovar);

            this.reportViewer1.RefreshReport();
        }
    }
}
