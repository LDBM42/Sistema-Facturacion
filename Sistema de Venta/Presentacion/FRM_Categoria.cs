using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Categoria : Form, IFormulario
    {
        private static DataTable dt = new DataTable();
        private static FRM_Categoria _instancia;
        public string id, descripcion;

        public FRM_Categoria()
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



        public static FRM_Categoria GetInstance()
        {
            if (_instancia == null)
                _instancia = new FRM_Categoria();
            return _instancia;
        }

        public void SetFlag(string valor)
        {
            text_Flag.Text = valor;
        }

        private void FRM_Categoria_Load(object sender, EventArgs e)
        {
            CMB_Buscar.Text = "Descripcion";

            try

            {
                DataSet ds = FCategoria.GetAll();
                dt = ds.Tables[0];
                dgvCategoria.DataSource = dt;

                if (dt.Rows.Count > 0)

                {

                    noencontrado.Visible = false;
                    dgvCategoria_CellClick(null, null);
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


        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sresultado = ValidarDatos();

                if (sresultado == "")
                {
                    if (text_Id.Text == "")
                    {

                        Categoria categoria = new Categoria();
                        categoria.Descripcion = text_Descripcion.Text;

                        if (FCategoria.Insertar(categoria) > 0)
                        {

                            MessageBox.Show("Datos insertados correctamente");
                            FRM_Categoria_Load(null, null);
                        }
                    }

                    else
                    {

                        Categoria categoria = new Categoria();
                        categoria.Descripcion = text_Descripcion.Text;
                        categoria.Id = Convert.ToInt32(text_Id.Text);


                        if (FCategoria.Actualizar(categoria) == 1)
                        {

                            MessageBox.Show("Datos Modificados correctamente");
                            FRM_Categoria_Load(null, null);
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvCategoria_CellClick(null, null);
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            //para que me muestre la columna eliminar 
            Eliminar.Visible = true;
            text_Id.Clear();
            text_Descripcion.Clear();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);

            Eliminar.Visible = true;
        }

        private void BT_liminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Esta seguro de eliminar las categorias seleccionados?", "Eliminacion de Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    foreach (DataGridViewRow row in dgvCategoria.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Categoria categoria = new Categoria();
                            categoria.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (FCategoria.Eliminar(categoria) == 0)
                            {
                                MessageBox.Show("Las Categorias no pudo ser eliminado", "Eliminacion de Categoria",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    FRM_Categoria_Load(null, null);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("La Categoría no pudo ser eliminada porque ha sido asignada a un producto", "Eliminacion Fallida");
            }
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

                dgvCategoria.DataSource = dv;

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

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCategoria.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvCategoria.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }

        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {

                text_Id.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
                text_Descripcion.Text = dgvCategoria.CurrentRow.Cells[2].Value.ToString();
            }
        }


        public string ValidarDatos()
        {
            string Resultado = "";
            if (text_Descripcion.Text == "")
            {
                Resultado = Resultado + " DESCRIPCION \n";

            }

            return Resultado;
        }


        public void MostrarGuardarCancelar(bool b)
        {

            Guardar.Visible = b;
            Cancelar.Visible = b;
            Nuevo.Visible = !b;
            Editar.Visible = !b;
            Eliminar.Visible = !b;
            dgvCategoria.Enabled = !b;
            text_Descripcion.Enabled = b;


        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (text_Flag.Text == "1")
            {
                if (dgvCategoria.CurrentRow != null)
                {
                    id = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
                    descripcion = dgvCategoria.CurrentRow.Cells[2].Value.ToString();
                    this.DialogResult = DialogResult.OK; //terminar
                }
            }
        }

        private void CMB_Buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar_TextChanged(null, null);
            Buscar.Focus();
        }

        private void FRM_Categoria_Enter(object sender, EventArgs e)
        {
            //Carga el Header del form Activo
            Form1 principal = Owner as Form1;
            principal.lab_encabezado.Text = "Categoría         ";
            this.BringToFront();
        }

        private void FRM_Categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 principal = Owner as Form1;
            principal.lab_encabezado.Text = "";
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
