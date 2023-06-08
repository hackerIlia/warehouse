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
    public partial class ReportPostavshik : Form
    {
        public ReportPostavshik()
        {
            InitializeComponent();
        }

        private void ReportPostavshik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseDataSetPostavshik.postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.warehouseDataSetPostavshik.postavshik);

            this.reportViewer1.RefreshReport();
        }
    }
}
