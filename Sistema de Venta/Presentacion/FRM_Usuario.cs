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
    public partial class FRM_Usuario : Form, IFormulario
    {
        private static DataTable dt = new DataTable();
        private static FRM_Usuario _instancia = null;
        public FRM_Usuario()
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


        string ncfValidar = ""; //almacena valor anterior a la modificación del NCF

        public static FRM_Usuario GetInstance()
        {
            if (_instancia == null)
                _instancia = new FRM_Usuario();
            return _instancia;
        }

        private void FRM_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = Datos.FUsuario.GetAll();
                dt = ds.Tables[0];
                dgvUsuarios.DataSource = dt;
                dgvUsuarios.ForeColor = Color.Black;

                if (dt.Rows.Count > 0)
                {
                    noencontrado.Visible = false;
                    dgvUsuarios_CellClick(null, null);
                }
                else
                {
                    noencontrado.Visible = true;
                }

                MostrarBotonesOcultos(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            CMB_Buscar.Text = "Nombre";
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                text_Id.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                text_Nombre.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                text_Apellido.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                text_NCF.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                text_Direccion.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                text_Telefono.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
                txtPassword.Text = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
                cbxTipo.Text = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "") // no faltan datos
                {
                    if (text_Id.Text != "") //Actualizar registro
                    {
                        RUsuario usuario = new RUsuario();
                        usuario.Id = Convert.ToInt32(text_Id.Text);
                        usuario.Nombre = text_Nombre.Text;
                        usuario.Apellido = text_Apellido.Text;
                        usuario.Ncf = Convert.ToInt32(text_NCF.Text);
                        usuario.Direccion = text_Direccion.Text;
                        usuario.Telefono = text_Telefono.Text;
                        usuario.Nombreusuario = txtUsuario.Text;
                        usuario.Password = txtPassword.Text;
                        usuario.Tipo = cbxTipo.Text;

                        if (FUsuario.Actualizar(usuario) == 1)
                        {
                            MessageBox.Show("Datos Actualizados Correctamente");
                            FRM_Usuario_Load(null, null);
                        }
                    }
                    else //Nuevo registro
                    {
                        RUsuario usuario = new RUsuario();
                        usuario.Nombre = text_Nombre.Text;
                        usuario.Apellido = text_Apellido.Text;
                        usuario.Ncf = Convert.ToInt32(text_NCF.Text);
                        usuario.Direccion = text_Direccion.Text;
                        usuario.Telefono = text_Telefono.Text;
                        usuario.Nombreusuario = txtUsuario.Text;
                        usuario.Password = txtPassword.Text;
                        usuario.Tipo = cbxTipo.Text;

                        if (FUsuario.Insertar(usuario) > 0)
                        {
                            MessageBox.Show("Datos Insertados Correctamente");
                            FRM_Usuario_Load(null, null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos en: \n" + sResultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Funciones
        public string validarDatos()
        {
            //Funcion para validar los datos e indicarle al usuario si estos fueron completados 
            string resultado = "";
            if (text_Nombre.Text == "") resultado += "El campo: Nombre,\n";
            if (text_Apellido.Text == "") resultado += "El campo: Apellido,\n";
            if (text_Id.Text == "" && text_NCF.Text != "") //está agregando nuevo
            {
                if (FUsuario.VerificarNCF(Convert.ToInt32(text_NCF.Text)) > 0)
                    resultado += "El campo: NCF,\n (NCF ya existe) \n";
            }   
            else //está modificando
            {
                if (text_NCF.Text != ncfValidar)
                {
                    if (FUsuario.VerificarNCF(Convert.ToInt32(text_NCF.Text)) > 0)
                        resultado += "El campo: NCF,\n (NCF ya existe) \n";
                }
            }
            if (txtUsuario.Text == "") resultado += "El campo: Usuario,\n El campo: Password,\n";

            return resultado;
        }

        public void MostrarBotonesOcultos(bool si)
        {
            if (si) this.ActiveControl = text_Nombre;

            Guardar.Visible = si;
            Cancelar.Visible = si;
            Nuevo.Visible = !si;
            Editar.Visible = !si;
            Eliminar.Visible = !si;
            dgvUsuarios.Enabled = !si;

            text_Nombre.Enabled = si;
            text_Apellido.Enabled = si;
            text_NCF.Enabled = si;
            text_Direccion.Enabled = si;
            text_Telefono.Enabled = si;
            txtUsuario.Enabled = si;
            txtPassword.Enabled = si;
            cbxTipo.Enabled = si;

        }
        internal void setFlag(string valor)
        {
            txtFlag.Text = valor;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            MostrarBotonesOcultos(true);
            text_Id.Text = "";
            text_Nombre.Text = "";
            text_Apellido.Text = "";
            text_NCF.Text = "";
            text_Direccion.Text = "";
            text_Telefono.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            cbxTipo.Text = "";   
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            ncfValidar = text_NCF.Text; //asignar NCF anterior a la variable
            MostrarBotonesOcultos(true);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            MostrarBotonesOcultos(false);
            dgvUsuarios_CellClick(null, null);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dgvUsuarios.Columns["Eliminar"].Index)
            {
                try
                {
                    DataGridViewCheckBoxCell chkEliminar =
                        (DataGridViewCheckBoxCell)dgvUsuarios.Rows[e.RowIndex].Cells["Eliminar"];
                    chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
                }
                catch (Exception)
                {

                }
            }
        }
        private bool verificarFilasSeleccionada()
        {
            foreach (DataGridViewRow rows in dgvUsuarios.Rows)
            {
                if (Convert.ToBoolean(rows.Cells["Eliminar"].Value))
                {
                    return true;
                }
            }
            return false;
        }

        private void BT_liminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarFilasSeleccionada() && MessageBox.Show("Desea eliminar los registros seleccionados?", "Eliminacion de Usuario",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            RUsuario usuario = new RUsuario();
                            usuario.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (FUsuario.Eliminar(usuario) != 1)
                            {
                                MessageBox.Show("EL cliene no pudo ser eliminado", "Eliminacion de Usuario",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    FRM_Usuario_Load(null, null);
                }
                else if (!verificarFilasSeleccionada()) MessageBox.Show("Debe selecionar un Registro primero",
                 "Eliminacion de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                if (CMB_Buscar.Text != "NCF")
                {
                    dv.RowFilter = CMB_Buscar.Text + " LIKE '" + Buscar.Text + "%'";
                }
                else if (Buscar.Text != "")
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

                dgvUsuarios.DataSource = dv;

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
                //MessageBox.Show(ex.Message + ex.StackTrace);
                MessageBox.Show("Favor escribir un valor correcto", "Texto incorrecto");
                Buscar.Text = "";
                Buscar.Focus();
            }
        }


        public void SetUsers(string[] value)
        {
           string[] users = value;
        }
        
               // internal
        public void setUser(string usuario, string password)
        {
            MessageBox.Show("Usuario: " + usuario + "\n Password: " + password);
            txtUsuario.Text = usuario;
            txtPassword.Text = password;          
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

        private void pnl_Lista_Categoria_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
