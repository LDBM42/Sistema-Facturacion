using Sistema_de_Venta.Entidades;
using SistemaVentas.Datos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Cliente : Form, IFormulario
    {
        private static DataTable dt = new DataTable();
        private static FRM_Cliente _instancia;
        public string idCliente, nombreCliente, nuevo_o_Registrado;
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

            if (cbx_FiscalConsumo.Text == null)
                cbx_FiscalConsumo.Text = "Consumidor Final";

            try

            {
                DataSet ds = FClientes.GetAll();
                dt = ds.Tables[0];
                dgvClientes.DataSource = dt;


                if (dt.Rows.Count > 0)
                {
                    noencontrado.Visible = false;
                    dgvClientes_CellClick(null, null);

                    if (nuevo_o_Registrado == "Cliente Nuevo")
                    {
                        Nuevo_Click(null, null);
                    }
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

            if (nuevo_o_Registrado != "Cliente Nuevo")
            {
                MostrarGuardarCancelar(false);
                cbx_FiscalConsumo.Enabled = false;
            }


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
                        cliente.Nombre = text_Nombre.Text;
                        cliente.Domicilio = text_Domicilio.Text;
                        cliente.Ncf = text_NCF.Text;
                        cliente.VencimientoSecuencia = text_VencimientoSecuencia.Value;
                        cliente.Telefono = text_Telefono.Text;
                        cliente.TipoCliente = cbx_FiscalConsumo.Text;

                        if (cbx_FiscalConsumo.Text != "Crédito Fiscal")
                        {
                            cliente.Apellido = text_Apellido.Text;
                            cliente.Rnc = 0;
                            cliente.NoRSocial = "NA";
                        }
                        else
                        {
                            cliente.Apellido = "NA";
                            cliente.Rnc = Convert.ToInt32(tbx_RNC.Text);
                            cliente.NoRSocial = tbx_NoRSocial.Text;
                        }

                        //esta en una variable para luego llamarla "idcliente"
                        int idcliente = FClientes.Insertar(cliente);
                        if (idcliente > 0)
                        {

                            MessageBox.Show("Datos insertados correctamente");

                            //este es el metodo para guardar el log con la accion Inserto Cliente
                            Form1.Log(Usuario.Nombreusuario, "Inserto Cliente: " + idcliente + " - " + cliente.Nombre);

                            FRM_Cliente_Load(null, null);
                            buscarCeldaYEntrar(cliente.Ncf);
                        }
                    }

                    else
                    {
                        Cliente cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(text_Id.Text);
                        cliente.Nombre = text_Nombre.Text;
                        cliente.Domicilio = text_Domicilio.Text;
                        cliente.Ncf = text_NCF.Text;
                        cliente.VencimientoSecuencia = text_VencimientoSecuencia.Value;
                        cliente.Telefono = text_Telefono.Text;
                        cliente.TipoCliente = cbx_FiscalConsumo.Text;
                        if (cbx_FiscalConsumo.Text != "Crédito Fiscal")
                        {
                            cliente.Apellido = text_Apellido.Text;
                            cliente.Rnc = 0;
                            cliente.NoRSocial = "NA";
                        }
                        else
                        {
                            cliente.Apellido = "NA";
                            cliente.Rnc = Convert.ToInt32(tbx_RNC.Text);
                            cliente.NoRSocial = tbx_NoRSocial.Text;
                        }


                        int idcliente = FClientes.Actualizar(cliente);
                        if (idcliente > 0)
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
            if (text_Apellido.Text == "" && cbx_FiscalConsumo.Text != "Crédito Fiscal")
            {
                Resultado = Resultado + " Apellido \n";
            }

            return Resultado;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            cbx_FiscalConsumo.Enabled = true;
            //para que me muestre la columna eliminar 
            Eliminar.Visible = true;
            limpiar();

            BloquearControlesClienteNuevo();
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
            text_VencimientoSecuencia.Enabled = b;
            text_Domicilio.Enabled = b;
            tbx_RNC.Enabled = b;
            tbx_NoRSocial.Enabled = b;
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            text_NCF.Focus();
            MostrarGuardarCancelar(true);
            cbx_FiscalConsumo.Enabled = false;

            BloquearControlesClienteNuevo();
        }

        private void BloquearControlesClienteNuevo()
        {
            if (nuevo_o_Registrado == "Cliente Nuevo")
            {
                text_Domicilio.Enabled = false;
                text_Telefono.Enabled = false;
                text_Nombre.Enabled = false;
                text_Apellido.Enabled = false;
                Cancelar.Enabled = false;
            }
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
            cbx_FiscalConsumo.Enabled = false;
            dgvClientes_CellClick(null, null);

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {

                text_Id.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                text_Nombre.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                text_Apellido.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                text_Telefono.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                text_NCF.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
                text_Domicilio.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
                cbx_FiscalConsumo.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
                // total articulos comprados es el 9
                tbx_RNC.Text = dgvClientes.CurrentRow.Cells[10].Value.ToString();
                tbx_NoRSocial.Text = dgvClientes.CurrentRow.Cells[11].Value.ToString();
                text_VencimientoSecuencia.Value = Convert.ToDateTime(dgvClientes.CurrentRow.Cells[12].Value);
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
            tbx_RNC.Clear();
            tbx_NoRSocial.Clear();

            if (nuevo_o_Registrado == "Cliente Nuevo")
            {
                cbx_FiscalConsumo.Text = "Consumidor Final";
                text_Domicilio.Text = "NA";
                text_Telefono.Text = "NA";
                text_Nombre.Text = "NUEVO CLIENTE";
                text_Apellido.Text = "NA";
                tbx_RNC.Text = "NA";
                tbx_NoRSocial.Text = "NA";
            }

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

        internal void Nuevo_o_Registrado(string nuevo_o_Registrado)
        {
            if (nuevo_o_Registrado == "Cliente Nuevo")
            {
                this.nuevo_o_Registrado = nuevo_o_Registrado;
            }
        }

        //sirve para dar doble clic automaticamente a la celda del nuevo comprador
        private void buscarCeldaYEntrar(string NCF)
        {
            // busca en el campo 'NCF' la celda Cuya columna es ‘NCF’
            foreach (DataGridViewRow Row in dgvClientes.Rows)
            {
                int rowIndex = Row.Index;
                string valor = Convert.ToString(Row.Cells["NCF"].Value);

                if (valor == NCF)
                {
                    dgvClientes.CurrentCell = dgvClientes.Rows[rowIndex].Cells["NCF"];
                    dgvClientes_CellDoubleClick(null, null);
                }
            }
        }


        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (text_Flag.Text == "1")
            {
                if (dgvClientes.CurrentRow != null)
                {
                    idCliente = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                    nombreCliente = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                    this.DialogResult = DialogResult.OK; //terminar
                }
            }
        }

        private void cbx_FiscalConsumo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbx_FiscalConsumo.Text == "Crédito Fiscal")
            {
                FiscalConsumo_Mostrar(false);
                PosicionBotones(119, 249, 423);
            }
            else
            {
                FiscalConsumo_Mostrar(true);
                PosicionBotones(119, 249, 342);
            }
        }

        public void PosicionBotones(int x1, int x2, int y)
        {
            Nuevo.Location = new Point(x1, y);
            Guardar.Location = new Point(x1, y);
            Cancelar.Location = new Point(x2, y);
            Editar.Location = new Point(x2, y);
        }

        public void FiscalConsumo_Mostrar(bool visible)
        {
            lab_Apellido.Visible = visible;
            text_Apellido.Visible = visible;

            lab_InfReceptor.Visible = !visible;
            lab_RNC.Visible = !visible;
            lab_NoRSocial.Visible = !visible;
            tbx_RNC.Visible = !visible;
            tbx_NoRSocial.Visible = !visible;

        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // para activar los favoritos
            if (this.dgvClientes.Columns[e.ColumnIndex].Index == 1)
            {
                //e.CellStyle.BackColor = Color.FromArgb(255, 142, 188, 229);

                if (Convert.ToInt32(this.dgvClientes.Rows[e.RowIndex].Cells["Total Arts. Comprados"].Value) >= 3)
                {
                    e.Value = Properties.Resources.FavoriteOn;
                }
            }

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "Válida hasta")
            {
                if (Convert.ToDateTime(e.Value) <= DateTime.Now)
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void FRM_Cliente_Enter(object sender, EventArgs e)
        {
            //Carga el Header del form Activo
            Form1 principal = Owner as Form1;
            principal.lab_encabezado.Text = "Cliente     ";
            this.BringToFront();
        }

        private void FRM_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 principal = Owner as Form1;
            principal.lab_encabezado.Text = "";
        }

        private void text_VencimientoSecuencia_ValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == text_VencimientoSecuencia)
            {
                if (text_VencimientoSecuencia.Value <= DateTime.Now && text_VencimientoSecuencia.Enabled)
                {
                    MessageBox.Show("La fecha de vencimiento de la secuencia no puede ser menor o igual a la fecha actual", "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_VencimientoSecuencia.Value = DateTime.Now.AddDays(1); // Coloca la fecha de hoy más uno
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

