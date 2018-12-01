using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Factura : Form
    {
        private static DataTable dt = new DataTable();
        private static FRM_Factura _Instancia;

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

        public void MergePDFs(string targetPath, string [] pdfs, string condicionBusqueda = "Todas")
        {

            try
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

                //lee pdf
                leerPDF(targetPath);
            }
                catch (Exception)
                {
                    if (condicionBusqueda == "Fecha") 
                    {
                        MessageBox.Show("No existe ninguna factura con la Fecha especificada", "Factura no encontrada");
                    }
                    else if (condicionBusqueda == "Tipo") 
                    {
                        MessageBox.Show("No existe ninguna factura con el Tipo especificado", "Factura no encontrada");
                    }
                    else // busqueda por tipo y fecha
                    {
                        MessageBox.Show("No existe ninguna factura con la Fecha y el Tipo especificado", "Factura no encontrada");
                    }
                }
        }

        private void FRM_Factura_Load(object sender, EventArgs e)
        {
            // combinar pdfs
            string pathSave = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + "\\Facturas\\FacturasCombinadas\\FacturasCombinadas.pdf";
            string pathGet = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\Facturas");
            string[] archivos = Directory.GetFiles(pathGet, "*.pdf");
            MergePDFs(pathSave, archivos);

        }

        public void leerPDF(string path)
        {
            try
            {
                // leer pdf combinado
                axAcroPDF.LoadFile(path);
                axAcroPDF.setShowToolbar(false);
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
            string nombreFactura;
            string condicionBusqueda;

            if (ckb_desactivarTipo.Checked == true) // buscar solo por fecha
            {
                nombreFactura = "* - " + fechaAFormatear.ToString("dd-MM-yyyy") + "*.pdf";
                condicionBusqueda = "Fecha";
            }
            else if (ckb_desactivarFecha.Checked == true) // buscar solo por tipo
            {
                nombreFactura = cmb_TipoFactura.Text + " - " + "*.pdf";
                condicionBusqueda = "Tipo";
            }
            else // buscar por tipo y fecha
            {
                nombreFactura = cmb_TipoFactura.Text + " - " + fechaAFormatear.ToString("dd-MM-yyyy") + "*.pdf";
                condicionBusqueda = "Todas";
            }


            // combinar pdfs
            string temporalPathSave = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + "\\Facturas\\FacturasCombinadas\\BusquedaPorDias\\FacturasCombinadas.pdf";
            string pathGet = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\Facturas\\");
            MergePDFs(temporalPathSave, obtenerArchivosDirectorio(pathGet, nombreFactura), condicionBusqueda);

            //leer archivo pdf está dentro de merge...          
        }

        
        public string [] obtenerArchivosDirectorio(string rutaArchivo, string nombreArchivo)
        {
            string[] Rutas = Directory.GetFiles(rutaArchivo, nombreArchivo);
            return Rutas;
        }

        private void ckb_desactivarTipo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_desactivarTipo.Checked)
            {
                cmb_TipoFactura.Enabled = false;
                ckb_desactivarFecha.Checked = false;
            }
            else
            {
                cmb_TipoFactura.Enabled = true;
            }
        }

        private void ckb_desactivarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_desactivarFecha.Checked)
            {
                dtp_FechaFactura.Enabled = false;
                ckb_desactivarTipo.Checked = false;
            }
            else
            {
                dtp_FechaFactura.Enabled = true;
            }
        }
    }
}
