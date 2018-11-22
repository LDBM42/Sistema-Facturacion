using Sistema_de_Venta.Entidades;
using SistemaVentas.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Cliente : Form, IFormulario
    {
        private static DataTable dt = new DataTable();
        private static FRM_Cliente _instancia;
        public string idCliente, nombreCliente;
        public FRM_Cliente()
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




        public static FRM_Cliente GetInstance()
        {
            if (_instancia == null)
                _instancia = new FRM_Cliente();
            return _instancia;
        }

        private void ViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvClientes.AutoSize = true;
        }


        private void FRM_Cliente_Load(object sender, EventArgs e)
        {
            CMB_Buscar.Text = "Nombre";

            try

            {
                DataSet ds = FClientes.GetAll();
                dt = ds.Tables[0];
                dgvClientes.DataSource = dt;

                if (dt.Rows.Count > 0)

                {

                    noencontrado.Visible = false;
                    dgvClientes_CellClick(null, null);
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

        }

        private void ListaClientes_Enter(object sender, EventArgs e)
        {
            this.CMB_Buscar.AutoSize = true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sresultado = ValidarDatos();

                if (sresultado == "")
                {
                    if (text_Id.Text == "")
                    {

                        Cliente cliente = new Cliente();
                        cliente.Nombre = text_Nombre .Text;
                        cliente.Apellido = text_Apellido.Text;
                        cliente.Domicilio = text_Domicilio.Text;
                        cliente.Ncf = Convert.ToInt32(text_NCF.Text);
                        cliente.Telefono = text_Telefono.Text;

                        //esta en una variable para luego llamarla "idcliente"
                        int idcliente = FClientes.Insertar(cliente);
                        if (idcliente > 0)
                        {

                            MessageBox.Show("Datos insertados correctamente");

                            //este es el metodo para guardar el log con la accion Inserto Cliente
                            Form1.Log(Usuario.Nombreusuario, "Inserto Cliente: " + idcliente + " - " + cliente.Nombre);

                            FRM_Cliente_Load(null, null);
                        }
                    }

                    else
                    {

                        Cliente cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(text_Id.Text);
                        cliente.Nombre = text_Nombre.Text;
                        cliente.Apellido = text_Apellido.Text;
                        cliente.Domicilio = text_Domicilio.Text;
                        cliente.Ncf = Convert.ToInt32(text_NCF.Text);
                        cliente.Telefono = text_Telefono.Text;

                        if (FClientes.Actualizar(cliente) == 1)
                        {

                            MessageBox.Show("Datos Modificados correctamente");
                            FRM_Cliente_Load(null, null);
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

        public string ValidarDatos()
        {
            string Resultado = "";
            if (text_Nombre.Text == "")
            {
                Resultado = Resultado + " Nombre \n";
            }
            if (text_Apellido.Text == "")
            {
                Resultado = Resultado + " Apellido \n";
            }

            return Resultado;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            //para que me muestre la columna eliminar 
            Eliminar.Visible = true;
            limpiar();


        }

        public void MostrarGuardarCancelar(bool b)
        {

            Guardar.Visible = b;
            Cancelar.Visible = b;
            Nuevo.Visible = !b;
            Editar.Visible = !b;
            Eliminar.Visible = !b;

            dgvClientes.Enabled = !b;

            text_Nombre.Enabled = b;
            text_Apellido.Enabled = b;
            text_Telefono.Enabled = b;
            text_NCF.Enabled = b;
            text_Domicilio.Enabled = b;

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClientes.Columns["Eliminar"].Index)
            {
                try
                {
                    DataGridViewCheckBoxCell chkEliminar =
                        (DataGridViewCheckBoxCell)dgvClientes.Rows[e.RowIndex].Cells["Eliminar"];
                    chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
                }
                catch (Exception)
                {
                }
            }


        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvClientes_CellClick(null, null);

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {

                text_Id.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                text_Nombre.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                text_Apellido.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                text_Telefono.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                text_NCF.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                text_Domicilio.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            }
        }

        public void limpiar()
        {
            text_Id.Clear();
            text_Nombre.Clear();
            text_Apellido.Clear();
            text_Domicilio.Clear();
            text_NCF.Clear();
            text_Telefono.Clear();
        }

        private void BT_liminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Esta seguro de eliminar los clientes seleccionados?", "Eliminacion de Clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {


                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Cliente cliente = new Cliente();
                            cliente.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (FClientes.Eliminar(cliente) > 0)
                            {
                                MessageBox.Show("Cliente Eliminado", "Eliminacion de Cliente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("El cliente no pudo ser eliminado", "Eliminacion de Cliente",
                                                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    FRM_Cliente_Load(null, null);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar_TextChanged(null, null);
            Buscar.Focus();
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

                dgvClientes.DataSource = dv;

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





        internal void SetFlag(string band)
        {
            text_Flag.Text = band;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (text_Flag.Text == "1")
            {
                if (dgvClientes.CurrentRow != null)
                {
                    idCliente = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                    nombreCliente = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                    this.DialogResult = DialogResult.OK; //terminar
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

