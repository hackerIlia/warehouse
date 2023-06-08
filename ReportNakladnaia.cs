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
    public partial class ReportNakladnaia : Form
    {
        public ReportNakladnaia()
        {
            InitializeComponent();
        }

        private void ReportNakladnaia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseDataSet4.nakladnaia". При необходимости она может быть перемещена или удалена.
            this.nakladnaiaTableAdapter.Fill(this.warehouseDataSet4.nakladnaia);

            this.reportViewer1.RefreshReport();
        }
    }
}
