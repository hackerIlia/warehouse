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
    public partial class ReportJurnal : Form
    {
        public ReportJurnal()
        {
            InitializeComponent();
        }

        private void ReportJurnal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseDataSet1.jurnal". При необходимости она может быть перемещена или удалена.
            this.jurnalTableAdapter.Fill(this.warehouseDataSet1.jurnal);

            this.reportViewer1.RefreshReport();
        }
    }
}
