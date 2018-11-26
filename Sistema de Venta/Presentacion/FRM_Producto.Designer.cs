namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Producto));
            this.BT_liminar = new System.Windows.Forms.Button();
            this.noencontrado = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.CMB_Buscar = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Favorito = new System.Windows.Forms.DataGridViewImageColumn();
            this.dialogo = new System.Windows.Forms.OpenFileDialog();
            this.pnl_Lista_Productos = new System.Windows.Forms.Panel();
            this.pnl_Lista_Categoria = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbx_Productos = new System.Windows.Forms.PictureBox();
            this.pbx_Servicios = new System.Windows.Forms.PictureBox();
            this.Editar = new System.Windows.Forms.Button();
            this.lab_stock = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.lab_vencimiento = new System.Windows.Forms.Label();
            this.lab_compra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Quitar = new System.Windows.Forms.Button();
            this.text_CategoriaDescripcion = new System.Windows.Forms.TextBox();
            this.lab_Costo_ProdServ = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cambiar = new System.Windows.Forms.Button();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.text_Categoria = new System.Windows.Forms.TextBox();
            this.text_FechadeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.Nuevo = new System.Windows.Forms.Button();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.text_Stock = new System.Windows.Forms.TextBox();
            this.text_Flag = new System.Windows.Forms.TextBox();
            this.text_PrecioCompra = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.text_PrecioVenta = new System.Windows.Forms.TextBox();
            this.text_Descripcion = new System.Windows.Forms.TextBox();
            this.lab_ITBIS = new System.Windows.Forms.Label();
            this.cbx_ITBIS = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnl_Lista_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Servicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_liminar
            // 
            this.BT_liminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_liminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.BT_liminar.FlatAppearance.BorderSize = 0;
            this.BT_liminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_liminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_liminar.Location = new System.Drawing.Point(42, 553);
            this.BT_liminar.Margin = new System.Windows.Forms.Padding(4);
            this.BT_liminar.Name = "BT_liminar";
            this.BT_liminar.Size = new System.Drawing.Size(803, 46);
            this.BT_liminar.TabIndex = 12;
            this.BT_liminar.Text = "Eliminar";
            this.BT_liminar.UseVisualStyleBackColor = false;
            this.BT_liminar.Click += new System.EventHandler(this.BT_liminar_Click);
            // 
            // noencontrado
            // 
            this.noencontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noencontrado.AutoSize = true;
            this.noencontrado.BackColor = System.Drawing.Color.Transparent;
            this.noencontrado.ForeColor = System.Drawing.Color.White;
            this.noencontrado.Location = new System.Drawing.Point(297, 315);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(293, 25);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Location = new System.Drawing.Point(210, 66);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(635, 30);
            this.Buscar.TabIndex = 2;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // CMB_Buscar
            // 
            this.CMB_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Buscar.FormattingEnabled = true;
            this.CMB_Buscar.Items.AddRange(new object[] {
            "Id",
            "CategoriaId",
            "Nombre",
            "Descripcion",
            "CategoriaDescripcion",
            "PrecioCompra",
            "PrecioVenta"});
            this.CMB_Buscar.Location = new System.Drawing.Point(42, 65);
            this.CMB_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(160, 33);
            this.CMB_Buscar.TabIndex = 1;
            this.CMB_Buscar.SelectedIndexChanged += new System.EventHandler(this.CMB_Buscar_SelectedIndexChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Favorito});
            this.dgvProductos.Location = new System.Drawing.Point(42, 102);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(803, 450);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Favorito
            // 
            this.Favorito.HeaderText = "Favorito";
            this.Favorito.Image = global::Sistema_de_Venta.Properties.Resources.FavoriteOff2;
            this.Favorito.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Favorito.Name = "Favorito";
            this.Favorito.ReadOnly = true;
            // 
            // dialogo
            // 
            this.dialogo.FileName = "openFileDialog1";
            // 
            // pnl_Lista_Productos
            // 
            this.pnl_Lista_Productos.Controls.Add(this.noencontrado);
            this.pnl_Lista_Productos.Controls.Add(this.CMB_Buscar);
            this.pnl_Lista_Productos.Controls.Add(this.dgvProductos);
            this.pnl_Lista_Productos.Controls.Add(this.BT_liminar);
            this.pnl_Lista_Productos.Controls.Add(this.Buscar);
            this.pnl_Lista_Productos.Controls.Add(this.pnl_Lista_Categoria);
            this.pnl_Lista_Productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lista_Productos.Location = new System.Drawing.Point(513, 0);
            this.pnl_Lista_Productos.Name = "pnl_Lista_Productos";
            this.pnl_Lista_Productos.Size = new System.Drawing.Size(885, 640);
            this.pnl_Lista_Productos.TabIndex = 26;
            // 
            // pnl_Lista_Categoria
            // 
            this.pnl_Lista_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lista_Categoria.Location = new System.Drawing.Point(0, 0);
            this.pnl_Lista_Categoria.Name = "pnl_Lista_Categoria";
            this.pnl_Lista_Categoria.Size = new System.Drawing.Size(885, 640);
            this.pnl_Lista_Categoria.TabIndex = 17;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Favorito";
            this.dataGridViewImageColumn1.Image = global::Sistema_de_Venta.Properties.Resources.FavoriteOff1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 391;
            // 
            // pbx_Productos
            // 
            this.pbx_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Productos.Image = global::Sistema_de_Venta.Properties.Resources.ProductosBig;
            this.pbx_Productos.Location = new System.Drawing.Point(204, 499);
            this.pbx_Productos.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_Productos.Name = "pbx_Productos";
            this.pbx_Productos.Size = new System.Drawing.Size(100, 100);
            this.pbx_Productos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_Productos.TabIndex = 22;
            this.pbx_Productos.TabStop = false;
            // 
            // pbx_Servicios
            // 
            this.pbx_Servicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Servicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Servicios.Image = global::Sistema_de_Venta.Properties.Resources.ServiciosBig;
            this.pbx_Servicios.Location = new System.Drawing.Point(204, 344);
            this.pbx_Servicios.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_Servicios.Name = "pbx_Servicios";
            this.pbx_Servicios.Size = new System.Drawing.Size(100, 255);
            this.pbx_Servicios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_Servicios.TabIndex = 23;
            this.pbx_Servicios.TabStop = false;
            this.pbx_Servicios.Visible = false;
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(370, 476);
            this.Editar.Margin = new System.Windows.Forms.Padding(4);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(99, 40);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // lab_stock
            // 
            this.lab_stock.AutoSize = true;
            this.lab_stock.ForeColor = System.Drawing.Color.White;
            this.lab_stock.Location = new System.Drawing.Point(261, 283);
            this.lab_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_stock.Name = "lab_stock";
            this.lab_stock.Size = new System.Drawing.Size(62, 25);
            this.lab_stock.TabIndex = 3;
            this.lab_stock.Text = "Stock";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(40, 142);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(114, 25);
            this.lbl_Descripcion.TabIndex = 2;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardar.Location = new System.Drawing.Point(263, 476);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(99, 40);
            this.Guardar.TabIndex = 13;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // lab_vencimiento
            // 
            this.lab_vencimiento.AutoSize = true;
            this.lab_vencimiento.ForeColor = System.Drawing.Color.White;
            this.lab_vencimiento.Location = new System.Drawing.Point(40, 319);
            this.lab_vencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_vencimiento.Name = "lab_vencimiento";
            this.lab_vencimiento.Size = new System.Drawing.Size(120, 25);
            this.lab_vencimiento.TabIndex = 15;
            this.lab_vencimiento.Text = "Vencimiento";
            // 
            // lab_compra
            // 
            this.lab_compra.AutoSize = true;
            this.lab_compra.ForeColor = System.Drawing.Color.White;
            this.lab_compra.Location = new System.Drawing.Point(261, 247);
            this.lab_compra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_compra.Name = "lab_compra";
            this.lab_compra.Size = new System.Drawing.Size(142, 25);
            this.lab_compra.TabIndex = 4;
            this.lab_compra.Text = "Precio Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoria";
            // 
            // Quitar
            // 
            this.Quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quitar.Location = new System.Drawing.Point(263, 421);
            this.Quitar.Margin = new System.Windows.Forms.Padding(4);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(206, 40);
            this.Quitar.TabIndex = 12;
            this.Quitar.Text = "Quitar Imagen";
            this.Quitar.UseVisualStyleBackColor = false;
            this.Quitar.Visible = false;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // text_CategoriaDescripcion
            // 
            this.text_CategoriaDescripcion.Location = new System.Drawing.Point(153, 69);
            this.text_CategoriaDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.text_CategoriaDescripcion.Name = "text_CategoriaDescripcion";
            this.text_CategoriaDescripcion.ReadOnly = true;
            this.text_CategoriaDescripcion.Size = new System.Drawing.Size(316, 30);
            this.text_CategoriaDescripcion.TabIndex = 17;
            this.text_CategoriaDescripcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_CategoriaDescripcion_MouseClick);
            // 
            // lab_Costo_ProdServ
            // 
            this.lab_Costo_ProdServ.AutoSize = true;
            this.lab_Costo_ProdServ.ForeColor = System.Drawing.Color.White;
            this.lab_Costo_ProdServ.Location = new System.Drawing.Point(40, 247);
            this.lab_Costo_ProdServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Costo_ProdServ.Name = "lab_Costo_ProdServ";
            this.lab_Costo_ProdServ.Size = new System.Drawing.Size(111, 25);
            this.lab_Costo_ProdServ.TabIndex = 5;
            this.lab_Costo_ProdServ.Text = "Costo/Prod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre";
            // 
            // Cambiar
            // 
            this.Cambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cambiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cambiar.Location = new System.Drawing.Point(263, 366);
            this.Cambiar.Margin = new System.Windows.Forms.Padding(4);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(206, 40);
            this.Cambiar.TabIndex = 12;
            this.Cambiar.Text = "Cambiar Imagen";
            this.Cambiar.UseVisualStyleBackColor = false;
            this.Cambiar.Visible = false;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(153, 103);
            this.text_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(316, 30);
            this.text_Nombre.TabIndex = 19;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar.Location = new System.Drawing.Point(370, 476);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(99, 40);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Imagen
            // 
            this.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen.Location = new System.Drawing.Point(45, 366);
            this.Imagen.Margin = new System.Windows.Forms.Padding(4);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(207, 150);
            this.Imagen.TabIndex = 20;
            this.Imagen.TabStop = false;
            this.Imagen.WaitOnLoad = true;
            // 
            // text_Categoria
            // 
            this.text_Categoria.Location = new System.Drawing.Point(392, 23);
            this.text_Categoria.Margin = new System.Windows.Forms.Padding(4);
            this.text_Categoria.Name = "text_Categoria";
            this.text_Categoria.ReadOnly = true;
            this.text_Categoria.Size = new System.Drawing.Size(12, 30);
            this.text_Categoria.TabIndex = 7;
            this.text_Categoria.Visible = false;
            // 
            // text_FechadeVencimiento
            // 
            this.text_FechadeVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_FechadeVencimiento.Location = new System.Drawing.Point(153, 316);
            this.text_FechadeVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.text_FechadeVencimiento.Name = "text_FechadeVencimiento";
            this.text_FechadeVencimiento.Size = new System.Drawing.Size(91, 30);
            this.text_FechadeVencimiento.TabIndex = 21;
            this.text_FechadeVencimiento.Value = new System.DateTime(2018, 12, 24, 22, 45, 0, 0);
            this.text_FechadeVencimiento.ValueChanged += new System.EventHandler(this.text_FechadeVencimiento_ValueChanged);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevo.Location = new System.Drawing.Point(263, 476);
            this.Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(99, 40);
            this.Nuevo.TabIndex = 11;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // text_Id
            // 
            this.text_Id.Enabled = false;
            this.text_Id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Id.Location = new System.Drawing.Point(412, 23);
            this.text_Id.Margin = new System.Windows.Forms.Padding(4);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(15, 30);
            this.text_Id.TabIndex = 6;
            this.text_Id.Visible = false;
            // 
            // text_Stock
            // 
            this.text_Stock.Location = new System.Drawing.Point(378, 280);
            this.text_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.text_Stock.Name = "text_Stock";
            this.text_Stock.Size = new System.Drawing.Size(91, 30);
            this.text_Stock.TabIndex = 8;
            // 
            // text_Flag
            // 
            this.text_Flag.Enabled = false;
            this.text_Flag.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Flag.Location = new System.Drawing.Point(435, 23);
            this.text_Flag.Margin = new System.Windows.Forms.Padding(4);
            this.text_Flag.Name = "text_Flag";
            this.text_Flag.Size = new System.Drawing.Size(11, 30);
            this.text_Flag.TabIndex = 6;
            this.text_Flag.Visible = false;
            // 
            // text_PrecioCompra
            // 
            this.text_PrecioCompra.Location = new System.Drawing.Point(378, 244);
            this.text_PrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.text_PrecioCompra.Name = "text_PrecioCompra";
            this.text_PrecioCompra.Size = new System.Drawing.Size(91, 30);
            this.text_PrecioCompra.TabIndex = 10;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(41, 553);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(426, 46);
            this.btn_Cerrar.TabIndex = 16;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // text_PrecioVenta
            // 
            this.text_PrecioVenta.Location = new System.Drawing.Point(153, 244);
            this.text_PrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.text_PrecioVenta.Name = "text_PrecioVenta";
            this.text_PrecioVenta.Size = new System.Drawing.Size(91, 30);
            this.text_PrecioVenta.TabIndex = 9;
            this.text_PrecioVenta.Text = " ";
            // 
            // text_Descripcion
            // 
            this.text_Descripcion.Location = new System.Drawing.Point(153, 137);
            this.text_Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.text_Descripcion.Multiline = true;
            this.text_Descripcion.Name = "text_Descripcion";
            this.text_Descripcion.Size = new System.Drawing.Size(316, 97);
            this.text_Descripcion.TabIndex = 7;
            // 
            // lab_ITBIS
            // 
            this.lab_ITBIS.AutoSize = true;
            this.lab_ITBIS.ForeColor = System.Drawing.Color.White;
            this.lab_ITBIS.Location = new System.Drawing.Point(40, 283);
            this.lab_ITBIS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ITBIS.Name = "lab_ITBIS";
            this.lab_ITBIS.Size = new System.Drawing.Size(62, 25);
            this.lab_ITBIS.TabIndex = 24;
            this.lab_ITBIS.Text = "ITBIS";
            // 
            // cbx_ITBIS
            // 
            this.cbx_ITBIS.BackColor = System.Drawing.Color.White;
            this.cbx_ITBIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ITBIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_ITBIS.FormattingEnabled = true;
            this.cbx_ITBIS.Items.AddRange(new object[] {
            "18",
            "16",
            "0"});
            this.cbx_ITBIS.Location = new System.Drawing.Point(153, 279);
            this.cbx_ITBIS.Name = "cbx_ITBIS";
            this.cbx_ITBIS.Size = new System.Drawing.Size(91, 33);
            this.cbx_ITBIS.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cbx_ITBIS);
            this.panel2.Controls.Add(this.lab_ITBIS);
            this.panel2.Controls.Add(this.text_Descripcion);
            this.panel2.Controls.Add(this.text_PrecioVenta);
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Controls.Add(this.text_PrecioCompra);
            this.panel2.Controls.Add(this.text_Flag);
            this.panel2.Controls.Add(this.text_Stock);
            this.panel2.Controls.Add(this.text_Id);
            this.panel2.Controls.Add(this.Nuevo);
            this.panel2.Controls.Add(this.text_FechadeVencimiento);
            this.panel2.Controls.Add(this.text_Categoria);
            this.panel2.Controls.Add(this.Imagen);
            this.panel2.Controls.Add(this.Cancelar);
            this.panel2.Controls.Add(this.text_Nombre);
            this.panel2.Controls.Add(this.Cambiar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lab_Costo_ProdServ);
            this.panel2.Controls.Add(this.text_CategoriaDescripcion);
            this.panel2.Controls.Add(this.Quitar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lab_compra);
            this.panel2.Controls.Add(this.lab_vencimiento);
            this.panel2.Controls.Add(this.Guardar);
            this.panel2.Controls.Add(this.lbl_Descripcion);
            this.panel2.Controls.Add(this.lab_stock);
            this.panel2.Controls.Add(this.Editar);
            this.panel2.Controls.Add(this.pbx_Servicios);
            this.panel2.Controls.Add(this.pbx_Productos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 640);
            this.panel2.TabIndex = 22;
            // 
            // FRM_Producto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1398, 640);
            this.Controls.Add(this.pnl_Lista_Productos);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Producto";
            this.Load += new System.EventHandler(this.FRM_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnl_Lista_Productos.ResumeLayout(false);
            this.pnl_Lista_Productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Servicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BT_liminar;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Buscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.OpenFileDialog dialogo;
        private System.Windows.Forms.Panel pnl_Lista_Productos;
        private System.Windows.Forms.Panel pnl_Lista_Categoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Favorito;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.PictureBox pbx_Productos;
        public System.Windows.Forms.PictureBox pbx_Servicios;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Label lab_stock;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label lab_vencimiento;
        private System.Windows.Forms.Label lab_compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.TextBox text_CategoriaDescripcion;
        private System.Windows.Forms.Label lab_Costo_ProdServ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Cambiar;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.TextBox text_Categoria;
        private System.Windows.Forms.DateTimePicker text_FechadeVencimiento;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.TextBox text_Stock;
        private System.Windows.Forms.TextBox text_Flag;
        private System.Windows.Forms.TextBox text_PrecioCompra;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.TextBox text_PrecioVenta;
        private System.Windows.Forms.TextBox text_Descripcion;
        private System.Windows.Forms.Label lab_ITBIS;
        private System.Windows.Forms.ComboBox cbx_ITBIS;
        private System.Windows.Forms.Panel panel2;
    }
}