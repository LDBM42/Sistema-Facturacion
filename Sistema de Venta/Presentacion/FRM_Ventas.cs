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
    public partial class FRM_Ventas : Form, IFormulario
    {
        private static DataTable dt = new DataTable();
        private static FRM_Ventas _Instancia = null;
        public FRM_Ventas()
        {
            InitializeComponent();
        }

        public void InicializarParametros(params object[] parametros)
        {
            if (parametros.Length == 1)
            {
                int parametro1 = (int)parametros[0];
                //string parametro2 = parametros[1].ToString();
            }
            //else
            // {
            //     throw new Exception("El número de parámetros es incorrecto");
            // }
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
            catch (Exception)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
                MessageBox.Show("Algo salió mal, favor volver a cargar las Ventas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MostrarGuardarCancelar(false);
            text_ClienteId.Enabled = false;
            text_ClienteNombre.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                        venta.NumeroDocumento = Convert.ToInt32(text_NumeroDoc.Text);
                        venta.Cliente.Nombre = text_ClienteNombre.Text;

                        
                        int iVentaId = FVenta.Insertar(venta);
                        if (iVentaId > 0)
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
                        venta.NumeroDocumento = Convert.ToInt32(text_NumeroDoc.Text);

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
            catch (Exception)
            {

                MessageBox.Show("Algo salió mal, Favor llenar correctamente todos los campos e intentarlo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void CargarDetalle(Venta venta)
        {
            FRM_DetalleVenta frmDetalle = FRM_DetalleVenta.GetInstance();
            frmDetalle.SetVenta(venta);
            frmDetalle.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvVentas_CellClick(null, null);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            limpiar();
            GetNumeroDocumento();
            cbx_clienteNuevoORegistrado.Focus();
        }
        public void GetNumeroDocumento()
        {
            DataSet ds = FVenta.GetNumeroDocumento();
            dt = ds.Tables[0];
            Venta venta = new Venta();
            venta.NumeroDocumento = Convert.ToInt32(dt.Rows[0][0].ToString());
            text_NumeroDoc.Text = (venta.NumeroDocumento > 9 ? "00000" : "000000") + venta.NumeroDocumento;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            cbx_clienteNuevoORegistrado.Focus();
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

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {

                textId.Text = dgvVentas.CurrentRow.Cells["Id"].Value.ToString();
                text_ClienteId.Text = dgvVentas.CurrentRow.Cells["ClienteId"].Value.ToString();
                //para saber si se mostrará el apellido
                string NoApellido = dgvVentas.CurrentRow.Cells["Apellido"].Value.ToString() != "NA" ? dgvVentas.CurrentRow.Cells["Apellido"].Value.ToString() : "";
                text_ClienteNombre.Text = dgvVentas.CurrentRow.Cells["Nombre"].Value.ToString() + " " + NoApellido;
                text_fecha.Text = dgvVentas.CurrentRow.Cells["FechaVenta"].Value.ToString();
                // para saber que cantidad de ceros poner al principio
                string InicialesNoDoc = Convert.ToInt32(dgvVentas.CurrentRow.Cells["NumeroDocumento"].Value) > 9 ? "00000" : "000000";
                text_NumeroDoc.Text = InicialesNoDoc + dgvVentas.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
            }
        }

        public void MostrarGuardarCancelar(bool b)
        {

            btnGuardar.Visible = b;
            btnCancelar.Visible = b;
            btnNuevo.Visible = !b;
            btnEditar.Visible = !b;

            dgvVentas.Enabled = !b;
                       
            text_ClienteNombre.Enabled = b;
            text_fecha.Enabled = b;

            cbx_clienteNuevoORegistrado.Enabled = b;
            //mostrar cliente nuevo o cliente Registrado, dependiendo de si está visible o no
            if (b == false)
            {
                cbx_clienteNuevoORegistrado.Text = "Cliente Registrado";
            }
            else
            {
                cbx_clienteNuevoORegistrado.Text = "Cliente Nuevo";
            }
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

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                Venta venta = new Venta();
                venta.Id = Convert.ToInt32(dgvVentas.CurrentRow.Cells["Id"].Value.ToString());
                venta.Cliente.Id = Convert.ToInt32(dgvVentas.CurrentRow.Cells["ClienteId"].Value.ToString());
                venta.Cliente.Nombre = dgvVentas.CurrentRow.Cells["Nombre"].Value.ToString() + " " + dgvVentas.CurrentRow.Cells["Apellido"].Value.ToString();
                venta.FechaVenta = Convert.ToDateTime(dgvVentas.CurrentRow.Cells["FechaVenta"].Value.ToString());
                venta.NumeroDocumento = Convert.ToInt32(dgvVentas.CurrentRow.Cells["NumeroDocumento"].Value.ToString());

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
            FRMCli.Nuevo_o_Registrado(cbx_clienteNuevoORegistrado.Text);
            FRMCli.WindowState = FormWindowState.Maximized;
            DialogResult res = FRMCli.ShowDialog(); //abrimos el formulario CLiente como cuadro de dialogo modal
            
            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del Cliente
                text_ClienteId.Text = FRMCli.idCliente;//asignamos al texbox el dato de la variable
                text_ClienteNombre.Text = FRMCli.nombreCliente;
            }
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

        private void FRM_Ventas_Enter(object sender, EventArgs e)
        {
            //Carga el Header del form Activo
            Form1 principal = Owner as Form1;
            principal.lab_encabezado.Text = "Ventas   ";
            this.BringToFront();
        }

        private void FRM_Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 principal = Owner as Form1;
            try
            {
                principal.lab_encabezado.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void text_ClienteNombre_Enter(object sender, EventArgs e)
        {
            text_ClienteNombre_MouseClick(null, null);
        }
    }
}
