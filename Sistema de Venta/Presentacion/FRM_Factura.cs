using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using Sistema_de_Venta.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Factura : Form
    {
        private static DataTable dt = new DataTable();
        private static FRM_Factura _Instancia;
        string buscar;

        public FRM_Factura()
        {
            InitializeComponent();
        }

        public static FRM_Factura GetInscance()
        {
            if (_Instancia == null)
                _Instancia = new FRM_Factura();
            return _Instancia;
        }

        public static void MergePDFs(string targetPath, params string[] pdfs)
        {
            using (PdfDocument targetDoc = new PdfDocument())
            {
                foreach (string pdf in pdfs)
                {
                    using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (int i = 0; i < pdfDoc.PageCount; i++)
                        {
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                        }
                    }
                }
                targetDoc.Save(targetPath);
            }
        }

        private void FRM_Factura_Load(object sender, EventArgs e)
        {
            // combinar pdfs
            string pathSave = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + "\\Facturas\\FacturasCombinadas\\FacturasCombinadas.pdf";
            string pathGet = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\Facturas");
            string[] archivos = Directory.GetFiles(pathGet, "*.pdf");
            MergePDFs(pathSave, archivos);

            leerPDF(pathSave);
        }

        public void leerPDF(string path)
        {
            try
            {
                // leer pdf combinado
                axAcroPDF.LoadFile(path);
                axAcroPDF.setShowToolbar(false);
                //axAcroPDF.setPageMode(PdfSharp.Pdf.PdfPageMode.FullScreen.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaAFormatear = dtp_FechaFactura.Value;
            string nombreFactura = fechaAFormatear.ToString("dd-MM-yyyy") + " - " + cmb_TipoFactura.Text + ".pdf";
            string pathGet = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\Facturas\\" + nombreFactura);

            leerPDF(pathGet);           
        }
    }
}
