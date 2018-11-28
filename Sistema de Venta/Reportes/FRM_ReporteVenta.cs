using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Sistema_de_Venta
{
    public partial class FRM_ReporteVenta : Form
    {
        string nombreReporte, startupPath, tipoCliente;
        int ventaId;

        public FRM_ReporteVenta()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public void SetVentaId_y_TipoCliente(int ventaId, string tipoCliente)
        {
            this.ventaId = ventaId;
            this.tipoCliente = tipoCliente; 
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FRM_ReporteVenta_Load(object sender, EventArgs e)
        {
            if (tipoCliente == "Consumidor Final")
            {
                nombreReporte = "RptReporteVenta.rdlc";
            }
            else if (tipoCliente == "Crédito Fiscal")
            {
                nombreReporte = "RptReporteVentaCFiscal.rdlc";
            }

            startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "Reportes\\" + nombreReporte);
            this.reportViewer1.LocalReport.ReportPath = startupPath;

            // TODO: esta línea de código carga datos en la tabla 'dbSFacturacionDataSet.usp_Reportes_GenrerarReporteVenta' Puede moverla o quitarla según sea necesario.
            this.usp_Reportes_GenrerarReporteVentaTableAdapter.Fill(this.DataSet2.usp_Reportes_GenrerarReporteVenta, ventaId);
            this.reportViewer1.RefreshReport();

        }

        private void pnl_factura_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
