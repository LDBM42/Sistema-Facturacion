using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_DetalleVenta : Form
    {

        private static DataTable dt = new DataTable();
        public static FRM_DetalleVenta _instancia = null;
        public FRM_DetalleVenta()
        {
            InitializeComponent();
        }
        public static FRM_DetalleVenta GetInstance()
        {
            if (_instancia == null)
                _instancia = new FRM_DetalleVenta();

            return _instancia;
        }

        internal void SetProducto(Producto producto)
        {
            text_ProductoId.Text = producto.Id.ToString();
            text_ProductoDescripcion.Text = producto.Nombre;
            text_stock.Text = producto.Stock.ToString();
            text_PrecioUnitario.Text = producto.PrecioVenta.ToString();
            
        }

        internal void SetVenta(Venta venta)
        {
            textVentaId.Text = venta.Id.ToString();
            text_ClienteId.Text = venta.Cliente.Id.ToString();
            text_ClienteNombre.Text = venta.Cliente.Nombre;
            text_fecha.Text = venta.FechaVenta.ToString();
            cmdTipoDoc.Text = venta.TipoDocumento;
            text_NumeroDoc.Text = Convert.ToString(venta.NumeroDocumento);
        }

        private void FRM_DetalleVenta_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtFlag.Text !=" ")
                { 
               
                DataSet ds = FDetalleVenta.GetAll(Convert.ToInt32((textVentaId.Text)));
                dt = ds.Tables[0];
                dgvVentas.DataSource = dt;
                dgvVentas.Columns["VentaId"].Visible = false;
                dgvVentas.Columns["ProductoId"].Visible = false;
                dgvVentas.Columns["Id"].Visible = false;
                dgvVentas.Columns["PrecioVenta"].Visible = false;

                    if (dt.Rows.Count > 0)  
                {

                    noencontrado.Visible = false;
                   // dgvVentas_CellClick(null, null);
                }
                else
                {

                    noencontrado.Visible = true;
                }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            //MostrarGuardarCancelar(false);
            //text_ClienteId.Enabled = false;
            //text_ClienteNombre.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string sresultado = ValidarDatos();

                if (sresultado == "")
                {

                    DetalleVenta Dventa = new DetalleVenta();


                    
                    Dventa.Venta.Id = Convert.ToInt32(textVentaId.Text);
                    Dventa.Producto.Id = Convert.ToInt32(text_ProductoId.Text);
                    Dventa.Cantidad = Convert.ToInt32(text_Cantidad.Text);
                    Dventa.PrecioUnitario = Convert.ToDouble(text_PrecioUnitario.Text);
                    Dventa.DescripcionVenta = text_DescripcionVenta.Text;

                    int iDVentaId = FDetalleVenta.Insertar(Dventa);

                    if (iDVentaId > 0)
                    {
                        //obteniento nuevo stock
                        int currentStock = Convert.ToInt32(text_stock.Text);
                        string newStock = Convert.ToString(currentStock - Dventa.Cantidad);
                        text_stock.Text = newStock;

                        FRM_DetalleVenta_Load(null, null);
                        MessageBox.Show("El Producto fue agregado correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El Producto no fue agregado, intente nuevamente");

                    }
                }

                else
                {
                    MessageBox.Show(sresultado,"Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }
            FRM_DetalleVenta_Load(null, null);
            
        }

        private void Limpiar()
        {
            text_ProductoId.Clear();
            text_ProductoDescripcion.Clear();
            text_stock.Text = "0";
            text_Cantidad.Text = "1";
            text_PrecioUnitario.Clear();

        }

        private string ValidarDatos()
        {
            string Resultado = "";
            if (text_ProductoId.Text == "")
            {
                Resultado = Resultado + " Debe Seleccionar al menos un producto \n";

            }
            if (Convert.ToInt32(text_Cantidad.Text) > Convert.ToInt32(text_stock.Text))
            {
                Resultado = Resultado + " La cantidad que intenta vender supera el stock \n";
                text_Cantidad.Value = Convert.ToInt32(text_stock.Text);
                text_Cantidad.Focus();
            }

            return Resultado;
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVentas.Columns["Eliminar"].Index)
            {
                try
                {
                    DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvVentas.Rows[e.RowIndex].Cells["Eliminar"];
                    chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
                }
                catch (Exception)
                {
                }
                
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Esta seguro de eliminar los productos seleccionados?", "Eliminacion de Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {




                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            DetalleVenta Dventa = new DetalleVenta();
                            Dventa.Producto.Id = Convert.ToInt32(row.Cells["ProductoId"].Value);
                            Dventa.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                            Dventa.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (!(FDetalleVenta.Eliminar(Dventa) > 0))
                            {
                                MessageBox.Show("El producto no pudo ser quitado de la venta. Intente nuevamente", "Eliminacion de Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    FRM_DetalleVenta_Load(null, null);
                    Limpiar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FRM_ReporteVenta frmRepVenta = new FRM_ReporteVenta();
            frmRepVenta.SetVentaId(Convert.ToInt32(textVentaId.Text));
            frmRepVenta.ShowDialog();
        }

        private void text_ProductoDescripcion_MouseClick(object sender, MouseEventArgs e)
        {
            FRM_Producto FRMPro = FRM_Producto.GetInscance();
            FRMPro.SetFlag("1");
            FRMPro.ShowDialog();
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                if (CMB_Buscar.Text == "Nombre")
                {
                    dv.RowFilter = CMB_Buscar.Text + " LIKE '" + Buscar.Text + "%'";
                }
                else if (Buscar.Text != "")
                {
                    if (Buscar.Text != "")
                    {
                        try
                        {
                            if (Convert.ToInt32(Buscar.Text) >= 0)
                                dv.RowFilter = CMB_Buscar.Text + " = " + Buscar.Text;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Favor escribir un valor correcto", "Texto incorrecto");
                            Buscar.Text = "";
                            Buscar.Focus();
                        }
                    }
                }

                dgvVentas.DataSource = dv;

                if (dv.Count == 0)
                {
                    noencontrado.Visible = true;
                }
                else
                {
                    noencontrado.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor escribir un valor correcto", "Texto incorrecto");
                Buscar.Text = "";
                Buscar.Focus();
            }
        }

        private void CMB_Buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar_TextChanged(null, null);
            Buscar.Focus();
        }
    }
}
