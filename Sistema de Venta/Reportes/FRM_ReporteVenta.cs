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

        public void SetVentaId(int ventaId)
        {
            txtVentaId.Text = ventaId.ToString();
        } 

        private void FRM_ReporteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.usp_Reportes_GenrerarReporteVenta' Puede moverla o quitarla según sea necesario.
            this.usp_Reportes_GenrerarReporteVentaTableAdapter.Fill(this.DataSet2.usp_Reportes_GenrerarReporteVenta, Convert.ToInt32(txtVentaId.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
