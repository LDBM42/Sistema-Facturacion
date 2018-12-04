using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using Sistema_de_Venta.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Producto : Form, IFormulario
    {
        private static DataTable dt = new DataTable();
        private static FRM_Producto _Instancia;

        public string id_Producto, stock_Producto, nombre_Producto, precioVenta_Producto;
        

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
                Imagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            Imagen.BackgroundImage = Resources.Transparente;
            Imagen.Image = null;
            Imagen.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sresultado = ValidarDatos();

                if (sresultado == "") // significa que tiene un nombre valido
                {
                    if (text_Id.Text == "")
                    {
                        Producto producto = new Producto();
                        producto.Nombre = text_Nombre.Text;
                        producto.Categoria.Id = Convert.ToInt32(text_Categoria.Text);
                        producto.Descripcion = text_Descripcion.Text;
                        if(Servicios == 0)
                        {
                            producto.Stock = Convert.ToInt32(text_Stock.Text);
                            producto.PrecioCompra = Convert.ToDouble(text_PrecioCompra.Text);
                        }
                        producto.FechaVencimiento = text_FechadeVencimiento.Value;
                        producto.PrecioVenta = Convert.ToDouble(text_PrecioVenta.Text);
                        producto.ProdServ = Servicios == 0 ? "Productos" : "Servicios";
                        producto.Itbis = Convert.ToInt32(cbx_ITBIS.Text);

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
                        int idProducto = Fproducto.Insertar(producto);
                        if (idProducto > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente");

                            //este es el metodo para guardar el log con la accion Inserto producto
                            Form1.Log(Usuario.Nombreusuario, "Inserto producto: " + idProducto + " - " + producto.Nombre);

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
                        if (Servicios == 0)
                        {
                            producto.Stock = Convert.ToInt32(text_Stock.Text);
                            producto.PrecioCompra = Convert.ToDouble(text_PrecioCompra.Text);
                        }
                        producto.PrecioVenta = Convert.ToDouble(text_PrecioVenta.Text);
                        producto.FechaVencimiento = text_FechadeVencimiento.Value;
                        producto.ProdServ = Servicios == 0 ? "Productos" : "Servicios";
                        producto.Itbis = Convert.ToInt32(cbx_ITBIS.Text);

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
                        int idProducto = Fproducto.Actualizar(producto);

                        if (idProducto > 0)
                        {
                            //este es el metodo para guardar el log con la accion Actualizo producto
                            Form1.Log(Usuario.Nombreusuario, "Actualizo producto: " + idProducto + " - " + producto.Nombre);

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
            catch (Exception)
            {
                MessageBox.Show("Algo está mal, Favor intentar denuevo", "Error");
            }


        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            desactivar(true);
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
            text_CategoriaDescripcion.Focus();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            desactivar(false);
            text_CategoriaDescripcion.Focus();
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
                            if (Fproducto.Eliminar(producto) != 0)
                            {
                                MessageBox.Show("El productos pudo ser eliminado\n favor intentar mas tarde", "Eliminacion de Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    FRM_Producto_Load(null, null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo está mal, Favor intentar denuevo", "Error");
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProductos.CurrentRow != null)
            {

                text_Id.Text = dgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                text_Categoria.Text = dgvProductos.CurrentRow.Cells["CategoriaId"].Value.ToString();
                text_CategoriaDescripcion.Text = dgvProductos.CurrentRow.Cells["Categoría"].Value.ToString();
                text_Nombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                text_Descripcion.Text = dgvProductos.CurrentRow.Cells["Descripción"].Value.ToString();
                text_PrecioVenta.Text = dgvProductos.CurrentRow.Cells["Pagar"].Value.ToString();
                cbx_ITBIS.Text = dgvProductos.CurrentRow.Cells["ITBIS"].Value.ToString();
                if (Servicios == 0)
                {
                    text_Stock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                    text_PrecioCompra.Text = dgvProductos.CurrentRow.Cells["Compra"].Value.ToString();
                    text_FechadeVencimiento.Value = Convert.ToDateTime(dgvProductos.CurrentRow.Cells["Venc."].Value);


                    Imagen.BackgroundImage = null;
                    byte[] b = (byte[])dgvProductos.CurrentRow.Cells["Imagen"].Value;
                    MemoryStream ms = new MemoryStream(b);
                    Imagen.Image = Image.FromStream(ms);
                    Imagen.SizeMode = PictureBoxSizeMode.Zoom;
                    desactivar(true);
                }
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
                    MessageBox.Show("Algo está mal, Favor intentar denuevo", "Error");
                }

            }

        }

        private void FRM_Producto_Load(object sender, EventArgs e)
        {
            limpiar();
            desactivar(true);

            if (Servicios == 1)
            {
                pbx_Productos.Visible = false;
                pbx_Servicios.Visible = true;
                lab_Costo_ProdServ.Text = "Costo/Serv";
                Nuevo.Size = new Size(153, 40);
                Nuevo.Location = new Point(153, 316);
                Guardar.Size = new Size(153, 40);
                Guardar.Location = new Point(153, 316);

                Editar.Size = new Size(153, 40);
                Editar.Location = new Point(316, 316);
                Cancelar.Size = new Size(153, 40);
                Cancelar.Location = new Point(316, 316);


                ProdServ(false);
            }
            else
            {
                pbx_Servicios.Visible = false;
                pbx_Productos.Visible = true;
                lab_Costo_ProdServ.Text = "Costo/Prod";
                ProdServ(true);
            }

            CMB_Buscar.Text = "Nombre";
            cbx_ITBIS.Text = "18";

            try
            {
                DataSet ds = Fproducto.GetAll(Servicios == 0 ? "Productos" : "Servicios");
                dt = ds.Tables[0];
                dgvProductos.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dgvProductos.Columns["CategoriaId"].Visible = false;
                    try
                    {
                        dgvProductos.Columns["Imagen"].Visible = false;
                    }
                    catch (Exception)
                    {
                    }
                    noencontrado.Visible = false;
                    dgvProductos_CellClick(null, null);
                }
                else
                {

                    noencontrado.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo está mal, Favor intentar denuevo", "Error");
                //MessageBox.Show(ex.Message + ex.StackTrace);
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

            if(Servicios == 0)
            {
                Cambiar.Visible = b;
                Quitar.Visible = b;
            }
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
            cbx_ITBIS.Enabled = !b;
            text_FechadeVencimiento.Enabled = !b;
        }

        public void ProdServ(bool producto)
        {   
            lab_stock.Visible = producto;
            lab_compra.Visible = producto;
            lab_vencimiento.Visible = producto;

            text_Stock.Visible = producto;
            text_PrecioCompra.Visible = producto;
            text_FechadeVencimiento.Visible = producto;
            Imagen.Visible = producto;
        } // muestra los campos adecuados para los servicios y productos

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
            text_Categoria.Clear();
            text_CategoriaDescripcion.Clear();
            text_Nombre.Clear();
            text_Descripcion.Clear();
            text_PrecioVenta.Clear();
            cbx_ITBIS.Text = "18";

            if(Servicios == 0)
            {
                text_PrecioCompra.Clear();
                text_Stock.Clear();
                text_Stock.Clear();
                text_FechadeVencimiento.Text = "";
                Imagen.BackgroundImage = Resources.Transparente;
                Imagen.Image = null;
                Imagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public void SetFlag(string SValor)
        {
            text_Flag.Text = SValor;
        }

        public void ProdServ(int servicios)
        {
            this.Servicios = servicios;
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (text_Flag.Text == "1")
            {
                if (dgvProductos.CurrentRow != null)
                {

                    id_Producto = dgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                    nombre_Producto = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                    precioVenta_Producto = dgvProductos.CurrentRow.Cells["Pagar"].Value.ToString();
                    if(Servicios == 0)
                    {
                        stock_Producto = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                    }

                    this.DialogResult = DialogResult.OK; //terminar
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
            FRMCate.WindowState = FormWindowState.Maximized;
            DialogResult res = FRMCate.ShowDialog(); //abrimos el formulario Categoría como cuadro de dialogo modal

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario Categoría
                text_Categoria.Text = FRMCate.id;//asignamos al texbox el dato de la variable
                text_CategoriaDescripcion.Text = FRMCate.descripcion;
            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // para activar los favoritos
            if (this.dgvProductos.Columns[e.ColumnIndex].Index == 1)
            {
                if (Convert.ToInt32(this.dgvProductos.Rows[e.RowIndex].Cells["Vendidos"].Value) >= 3)
                    e.Value = Properties.Resources.FavoriteOn;
            }

            if (this.dgvProductos.Columns[e.ColumnIndex].Name == "Venc.")
            {
                if (Convert.ToDateTime(e.Value) <= DateTime.Now)
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void FRM_Producto_Enter(object sender, EventArgs e)
        {
            //Carga el Header del form Activo
            Form1 principal = Owner as Form1;
            if(Servicios == 1)
            {
                principal.lab_encabezado.Text = "   Servicios";
            }
            else
            {
                principal.lab_encabezado.Text = "  Productos";
            }
            this.BringToFront();
        }

        private void FRM_Producto_FormClosing(object sender, FormClosingEventArgs e)
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

        private void text_CategoriaDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_Tab(e);
        }

        private void text_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_TabyValidarLetras(e);
        }

        private void text_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_Tab(e);
        }

        private void text_PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_TabyValidar(e, "0123456789.\b");
        }

        private void text_PrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_TabyValidar(e, "0123456789.\b");
        }

        private void cbx_ITBIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_Tab(e);
        }

        private void text_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_TabyValidar(e, "0123456789\b");
        }

        private void text_FechadeVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 'e' almacena la tecla presionada
            if (e.KeyChar == (char)13) //si la tecla pesionada es igual a ENTER (13)
            {
                e.Handled = true; //.Handled significa que nosotros nos haremos cargo del codigo
                                  //al ser true, evita que apareca la tecla presionada
                Guardar.PerformClick(); // permite hacer clic en el boton por codigo.
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
