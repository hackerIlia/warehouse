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
    public partial class ReportChek : Form
    {
        public ReportChek()
        {
            InitializeComponent();
        }

        private void ReportChek_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseDataSet2.chek". При необходимости она может быть перемещена или удалена.
            this.chekTableAdapter.Fill(this.warehouseDataSet2.chek);

            this.reportViewer1.RefreshReport();
        }
    }
}
