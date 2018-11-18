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
    public partial class FRM_Ventas : Form
    {
        private static DataTable dt = new DataTable();
        private static FRM_Ventas _Instancia =null;
        public FRM_Ventas()
        {
            InitializeComponent();
        }

        public static FRM_Ventas GetInstance()
        {
            if (_Instancia == null)
                _Instancia = new FRM_Ventas();
            return _Instancia;
        }
        private void FRM_Ventas_Load(object sender, EventArgs e)
        {
            CMB_Buscar.Text = "Nombre";

            try
            {
                DataSet ds = FVenta.GetAll();
                dt = ds.Tables[0];
                dgvVentas.DataSource = dt;

                if (dt.Rows.Count > 0)
                {

                    noencontrado.Visible = false;
                    dgvVentas_CellClick(null, null);
                }
                else
                {

                    noencontrado.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            MostrarGuardarCancelar(false);
            text_ClienteId.Enabled = false;
            text_ClienteNombre.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {//guardar
            try
            {
                string sresultado = ValidarDatos();

                if (sresultado == "")
                {
                    if (textId.Text == "")
                    {

                        Venta venta = new Venta();
                        venta.Cliente.Id = Convert.ToInt32(text_ClienteId.Text);
                        venta.FechaVenta = text_fecha.Value;
                        venta.TipoDocumento = cmdTipoDoc.Text;
                        venta.NumeroDocumento = text_NumeroDoc.Text;
                        venta.Cliente.Nombre = text_ClienteNombre.Text;
                        
                        int iVentaId =FVenta.Insertar(venta);
                        if ( iVentaId> 0)
                        {
                            FRM_Ventas_Load(null, null);
                            venta.Id = iVentaId;
                            CargarDetalle(venta);
                        }
                    }

                    else
                    {

                        Venta venta = new Venta();
                        venta.Id = Convert.ToInt32(textId.Text);
                        venta.Cliente.Id = Convert.ToInt32(text_ClienteId.Text);
                        venta.FechaVenta = text_fecha.Value;
                        venta.TipoDocumento = cmdTipoDoc.Text;
                        venta.NumeroDocumento = text_NumeroDoc.Text;

                        if (FVenta.Actualizar(venta) == 1)
                        {

                            MessageBox.Show("Datos Modificados correctamente");
                            FRM_Ventas_Load(null, null);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Faltan Completar Datos: \n " + sresultado);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        private void CargarDetalle(Venta venta)
        {

            FRM_DetalleVenta frmDetalle = FRM_DetalleVenta.GetInstance();
            frmDetalle.SetVenta(venta);
            frmDetalle.ShowDialog();
            frmDetalle.BringToFront();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvVentas_CellClick(null, null);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            //para que me muestre la columna eliminar 
            Eliminar.Visible = true;
            limpiar();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                try
                {
                    dv.RowFilter = CMB_Buscar.Text + " Like '" + Buscar.Text + "%'";

                }
                catch (Exception)
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
                
                else {
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

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {

                textId.Text = dgvVentas.CurrentRow.Cells["Id"].Value.ToString();
                text_ClienteId.Text = dgvVentas.CurrentRow.Cells["ClienteId"].Value.ToString();
                text_ClienteNombre.Text = dgvVentas.CurrentRow.Cells["Nombre"].Value.ToString() +" "+ dgvVentas.CurrentRow.Cells["Apellido"].Value.ToString();
                text_fecha.Text = dgvVentas.CurrentRow.Cells["FechaVenta"].Value.ToString();
                cmdTipoDoc.Text = dgvVentas.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                text_NumeroDoc.Text = dgvVentas.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
            }
        }

        public void MostrarGuardarCancelar(bool b)
        {

            btnGuardar.Visible = b;
            btnCancelar.Visible = b;
            btnNuevo.Visible = !b;
            btnEditar.Visible = !b;
            
            dgvVentas.Enabled = !b;

            //text_ClienteId.Enabled = b;
            text_ClienteNombre.Enabled = b;
            text_NumeroDoc.Enabled = b;
            text_fecha.Enabled = b;
            cmdTipoDoc.Enabled = b;
            text_NumeroDoc.Enabled = b;
        }

        public string ValidarDatos()
        {
            string Resultado = "";
            if (text_ClienteId.Text == "")
            {
                Resultado = Resultado + " Cliente \n";

            }
            if (text_NumeroDoc.Text == "")
            {

                Resultado = Resultado + " Numero Documento \n";
            }

            return Resultado;
        }
        public void limpiar()
        {
            textId.Clear();
            text_ClienteId.Clear();
            text_ClienteNombre.Clear();
            text_NumeroDoc.Clear();
            text_fecha.Text = "";

        }


        internal void SetClientes(string sIdCliente, string sNombreCliente)
        {
            text_ClienteId.Text = sIdCliente;
            text_ClienteNombre.Text = sNombreCliente;
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                Venta venta = new Venta();
                venta.Id = Convert.ToInt32(dgvVentas.CurrentRow.Cells["Id"].Value.ToString());
                venta.Cliente.Id = Convert.ToInt32(dgvVentas.CurrentRow.Cells["ClienteId"].Value.ToString());
                venta.Cliente.Nombre= dgvVentas.CurrentRow.Cells["Nombre"].Value.ToString() + " " + dgvVentas.CurrentRow.Cells["Apellido"].Value.ToString();
                venta.FechaVenta = Convert.ToDateTime(dgvVentas.CurrentRow.Cells["FechaVenta"].Value.ToString());
                venta.TipoDocumento= dgvVentas.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                venta.NumeroDocumento = dgvVentas.CurrentRow.Cells["NumeroDocumento"].Value.ToString();

                CargarDetalle(venta);
            }
        }

        private void text_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == text_fecha)
            {
                if (text_fecha.Value < DateTime.Now && text_fecha.Enabled)
                {
                    MessageBox.Show("La Fecha de venta no puede menor a la fecha actual", "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_fecha.Value = DateTime.Now;
                
                }
                if (text_fecha.Value > DateTime.Now && text_fecha.Enabled)
                {
                    MessageBox.Show("La fecha de venta no puede ser mayor a la fecha", "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_fecha.Value = DateTime.Now;


                }


            }            
        }

        private void text_ClienteNombre_MouseClick(object sender, MouseEventArgs e)
        {
            FRM_Cliente FRMCli = new FRM_Cliente();
            FRMCli.SetFlag("1");
            FRMCli.Show();
        }

        private void CMB_Buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar_TextChanged(null, null);
            Buscar.Focus();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
