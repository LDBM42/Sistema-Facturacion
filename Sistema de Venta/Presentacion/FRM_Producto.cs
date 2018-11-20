using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using Sistema_de_Venta.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Producto : Form, IFormulario
    {
        private static DataTable dt = new DataTable();
        private static FRM_Producto _Instancia;
        public FRM_Producto()
        {
            InitializeComponent();
        }
        public int Servicios = 0;

        public void InicializarParametros(params object[] parametros)
        {
            if (parametros.Length == 1)
            {
                Servicios = (int)parametros[0];
            }
        }


        public static FRM_Producto GetInscance()
        {
            if (_Instancia == null)
                _Instancia = new FRM_Producto();
            return _Instancia;
        }

        public void SetCategoria(string id, string descripcion)
        {
            text_Categoria.Text = id;
            text_CategoriaDescripcion.Text = descripcion;
        }
 
        private void Buscar_Categoria_Click(object sender, EventArgs e)
        {
            FRM_Categoria FRMCate = new FRM_Categoria();
            FRMCate.SetFlag("1");
            FRMCate.ShowDialog();
        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                Imagen.BackgroundImage = null;
                Imagen.Image = new Bitmap(dialogo.FileName);
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            Imagen.BackgroundImage = Resources.Transparente;
            Imagen.Image = null;
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage;

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
                        Producto producto = new Producto();
                        producto.Nombre = text_Nombre.Text;
                        producto.Categoria.Id = Convert.ToInt32(text_Categoria.Text);
                        producto.Descripcion = text_Descripcion.Text;
                        producto.Stock = Convert.ToInt32(text_Stock.Text);
                        producto.PrecioCompra = Convert.ToDouble(text_PrecioCompra.Text);
                        producto.PrecioVenta = Convert.ToDouble(text_PrecioVenta.Text);
                        producto.FechaVencimiento = text_FechadeVencimiento.Value;

                        MemoryStream ms = new MemoryStream();
                        if (Imagen.Image != null)
                        {
                            Imagen.Image.Save(ms, Imagen.Image.RawFormat);
                        }

                        else
                        {

                            Imagen.Image = Resources.Transparente;
                            Imagen.Image.Save(ms, Imagen.Image.RawFormat);
                        }

                        producto.Imagen = ms.GetBuffer();
                        if (Fproducto.Insertar(producto) > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente");
                            FRM_Producto_Load(null, null);
                        }
                    }

                    else
                    {

                        Producto producto = new Producto();
                        producto.Id = Convert.ToInt32(text_Id.Text);
                        producto.Nombre = text_Nombre.Text;
                        producto.Categoria.Id = Convert.ToInt32(text_Categoria.Text);
                        producto.Descripcion = text_Descripcion.Text;
                        producto.Stock = Convert.ToInt32(text_Stock.Text);
                        producto.PrecioCompra = Convert.ToDouble(text_PrecioCompra.Text);
                        producto.PrecioVenta = Convert.ToDouble(text_PrecioVenta.Text);
                        producto.FechaVencimiento = text_FechadeVencimiento.Value;

                        MemoryStream ms = new MemoryStream();
                        if (Imagen.Image != null)
                        {
                            Imagen.Image.Save(ms, Imagen.Image.RawFormat);
                        }

                        else
                        {

                            Imagen.Image = Resources.Transparente;
                            Imagen.Image.Save(ms, Imagen.Image.RawFormat);
                        }

                        //Solucion del error de no guardar la imagen
                        producto.Imagen = ms.GetBuffer();

                        if (Fproducto.Actualizar(producto) > 0)
                        {
                            MessageBox.Show("Datos Modificados correctamente");
                            FRM_Producto_Load(null, null); 
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
            dgvProductos_CellClick(null, null);
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            //para que me muestre la columna eliminar 
            Eliminar.Visible = true;
            limpiar();
            desactivar(false);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            desactivar(false);
        }

        private void BT_liminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Esta seguro de eliminar los productos seleccionados?", "Eliminacion de Productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Producto producto = new Producto();
                            producto.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (Fproducto.Eliminar(producto) == 0)
                            {
                                MessageBox.Show("El productos fue eliminado", "Eliminacion de Productos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    FRM_Producto_Load(null, null);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {

                text_Id.Text = dgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                text_Categoria.Text = dgvProductos.CurrentRow.Cells["CategoriaId"].Value.ToString();
                text_CategoriaDescripcion.Text = dgvProductos.CurrentRow.Cells["CategoriaDescripcion"].Value.ToString();
                text_Nombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                text_Descripcion.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                text_Stock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                text_PrecioCompra.Text = dgvProductos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                text_PrecioVenta.Text = dgvProductos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                text_FechadeVencimiento.Text = dgvProductos.CurrentRow.Cells["FechaVencimiento"].Value.ToString();


                Imagen.BackgroundImage = null;
                byte[] b = (byte[])dgvProductos.CurrentRow.Cells["Imagen"].Value;
                MemoryStream ms = new MemoryStream(b);
                Imagen.Image = Image.FromStream(ms);
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                desactivar(true);
            }

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductos.Columns["Eliminar"].Index)
            {
                try
                {
                    DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvProductos.Rows[e.RowIndex].Cells["Eliminar"];
                    chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
                }
                catch (Exception)
                {
                }
                
            }

        }

        private void FRM_Producto_Load(object sender, EventArgs e)
        {
            //Form1 frmDetalle = Form1.GetInstance();
            //frmDetalle.SetVenta(venta);
            if (Servicios == 1)
            {
                pbx_Productos.Visible = false;
                pbx_Servicios.Visible = true;
            }
            else
            {
                pbx_Servicios.Visible = false;
                pbx_Productos.Visible = true;
            }

            CMB_Buscar.Text = "Nombre";

            try
            {
                DataSet ds = Fproducto.GetAll();
                dt = ds.Tables[0];
                dgvProductos.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dgvProductos.Columns["Imagen"].Visible = false;
                    noencontrado.Visible = false;
                    dgvProductos_CellClick(null, null);
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

        public void MostrarGuardarCancelar(bool b)
        {

            Guardar.Visible = b;
            Cancelar.Visible = b;
            Nuevo.Visible = !b;
            Editar.Visible = !b;
            Eliminar.Visible = !b;

            dgvProductos.Enabled = !b;

            Cambiar.Visible = b;
            Quitar.Visible = b;






        }

        public void desactivar(bool b)
        {


            text_Nombre.Enabled = !b;

            text_Nombre.Enabled = !b;
            text_Categoria.Enabled = !b;
            text_CategoriaDescripcion.Enabled = !b;
            text_Descripcion.Enabled = !b;
            text_PrecioCompra.Enabled = !b;
            text_PrecioVenta.Enabled = !b;
            text_Stock.Enabled = !b;
            text_Stock.Enabled = !b;
            text_FechadeVencimiento.Enabled = !b;



        }

        public string ValidarDatos()
        {
            string Resultado = "";
            if (text_Nombre.Text == "")
            {
                Resultado = Resultado + " Nombre \n";

            }


            return Resultado;
        }

        public void limpiar()
        {
            text_Id.Clear();
            text_Nombre.Clear();
            text_Categoria.Clear();
            text_CategoriaDescripcion.Clear();
            text_Descripcion.Clear();
            text_PrecioCompra.Clear();
            text_PrecioVenta.Clear();
            text_Stock.Clear();
            text_Stock.Clear();
            text_FechadeVencimiento.Text = "";
            Imagen.BackgroundImage = Resources.Transparente;
            Imagen.Image = null;
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage;

        }



        private void Imagen_Click(object sender, EventArgs e)
        {

        }

        public void SetFlag(string SValor)
        {
            text_Flag.Text = SValor;
        }

        private void text_Flag_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (text_Flag.Text == "1")
            {
                FRM_DetalleVenta frmDetalle = FRM_DetalleVenta.GetInstance();

                if (dgvProductos.CurrentRow != null)
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Id"].Value.ToString());
                    producto.Nombre = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                    producto.Stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Stock"].Value.ToString());
                    producto.PrecioVenta = Convert.ToDouble(dgvProductos.CurrentRow.Cells["PrecioVenta"].Value.ToString());

                    frmDetalle.SetProducto(producto);
                    frmDetalle.Show();
                    Close();
                }
            }
        }

        private void text_FechadeVencimiento_ValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == text_FechadeVencimiento)
            {
                if (text_FechadeVencimiento.Value <= DateTime.Now && text_FechadeVencimiento.Enabled)
                {
                    MessageBox.Show("La fecha de vencimiento no puede ser menor o igual a la fecha actual", "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_FechadeVencimiento.Value = DateTime.Now.AddDays(1);


                }

                
            }
        }

        private void text_CategoriaDescripcion_MouseClick(object sender, MouseEventArgs e)
        {
            FRM_Categoria FRMCate = new FRM_Categoria();
            FRMCate.SetFlag("1");
            FRMCate.ShowDialog();
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

                dgvProductos.DataSource = dv;

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

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
