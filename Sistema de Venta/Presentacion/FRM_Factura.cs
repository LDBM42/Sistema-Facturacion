using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Factura : Form
    {
        private static DataTable dt = new DataTable();
        private static FRM_Factura _Instancia;
        int x, y;
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
            resetearBuscador();

            // combinar pdfs
            string pathSave = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + "\\Facturas\\FacturasCombinadas\\FacturasCombinadas.pdf";
            string pathGet = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\Facturas");
            string[] archivos = Directory.GetFiles(pathGet, "*.pdf");
            MergePDFs(pathSave, archivos);
        }

        private void resetearBuscador()
        {
            x = 70;
            y = 50;
            cmb_TipoFactura.Text = "Consumidor Final";
            Pnl_Buscar.Size = new Size(x, y);
            pbx_ChevronRight.Visible = true;
            pbx_ChevronLeft.Visible = false;
            pbx_BuscarUp.Visible = true;
        }

        public void leerPDF(string path)
        {
            try
            {
                // leer pdf combinado
                axAcroPDF.LoadFile(path);
                axAcroPDF.setShowToolbar(false);
                axAcroPDF.setZoom(100);
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
                ckb_desactivarTipo.Image = Properties.Resources.locked_50;
                cmb_TipoFactura.Enabled = false;
                ckb_desactivarFecha.Checked = false;
            }
            else
            {
                ckb_desactivarTipo.Image = Properties.Resources.unlocked_50;
                cmb_TipoFactura.Enabled = true;
            }
        }

        private void ckb_desactivarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_desactivarFecha.Checked)
            {
                ckb_desactivarFecha.Image = Properties.Resources.locked_50;
                dtp_FechaFactura.Enabled = false;
                ckb_desactivarTipo.Checked = false;
            }
            else
            {
                ckb_desactivarFecha.Image = Properties.Resources.unlocked_50;
                dtp_FechaFactura.Enabled = true;
            }
        }

        private void tmr_Buscar_Tick(object sender, EventArgs e)
        {
            if (pbx_ChevronRight.Visible == true)
            {
                if (x < 290)
                {
                    Pnl_Buscar.Size = new Size(x, y);
                    x = x + 10;
                }
                else if (y < 300)
                {
                    pbx_BuscarUp.Visible = false;
                    Pnl_Buscar.Size = new Size(x, y);
                    y = y + 10;
                }
                else
                {
                    tmr_Buscar.Stop();
                    pbx_ChevronLeft.Visible = true;
                    pbx_ChevronRight.Visible = false;
                }
            }                
        }

        private void Pnl_Buscar_MouseEnter(object sender, EventArgs e)
        {
            if (pbx_ChevronRight.Visible == true)
                tmr_Buscar.Start();
        }

        private void tmr_BuscarHide_Tick(object sender, EventArgs e)
        {
            if (pbx_ChevronLeft.Visible == true)
            {
                if (y > 50)
                {
                    Pnl_Buscar.Size = new Size(x, y);
                    y = y - 10;
                }
                else if (x > 70)
                {
                    pbx_BuscarUp.Visible = true;
                    Pnl_Buscar.Size = new Size(x, y);
                    x = x - 10;
                }
                else
                {
                    tmr_BuscarHide.Stop();
                    pbx_ChevronLeft.Visible = false;
                    pbx_ChevronRight.Visible = true;
                }
            }
               
        }

        private void pbx_ChevronLeft_Click(object sender, EventArgs e)
        {
            tmr_BuscarHide.Start();
        }
    }
}
