using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta
{
    public partial class FRM_ReporteVenta : Form
    {
        public FRM_ReporteVenta()
        {
            InitializeComponent();
        }

        public void SetventaId(int VentaId)
        {
            textVentaId.Text = VentaId.ToString();
        }
        private void FRM_ReporteVenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.usp_Reportes_GeneralReporteVenta' table. You can move, or remove it, as needed.
            this.usp_Reportes_GeneralReporteVentaTableAdapter.Fill(this.DataSetPrincipal.usp_Reportes_GeneralReporteVenta, Convert.ToInt32(textVentaId.Text));

            this.reportViewer1.RefreshReport();
        }

        private void textVentaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
