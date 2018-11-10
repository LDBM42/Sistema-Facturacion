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
    public partial class FRM_Categoria : Form
    {
        private static DataTable dt = new DataTable();
        private static FRM_Categoria _instancia;
        public FRM_Categoria()
        {
            InitializeComponent();
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

               if (sresultado =="")
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
                dv.RowFilter = CMB_Descripcion.Text + " Like '" + Buscar.Text + "%'";
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

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

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
            FRM_Producto frmProd = FRM_Producto.GetInscance();
            
           if (dgvCategoria.CurrentRow != null)
            {

                frmProd.SetCategoria(dgvCategoria.CurrentRow.Cells[1].Value.ToString(), dgvCategoria.CurrentRow.Cells[2].Value.ToString()
                    );
                frmProd.Show();
            Close();
                }
            }
        }

        private void text_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Flag_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
