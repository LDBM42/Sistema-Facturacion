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
            System.Windows.Forms.Button Buscar_Categoria;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Producto));
            this.ListaClientes = new System.Windows.Forms.GroupBox();
            this.BT_liminar = new System.Windows.Forms.Button();
            this.noencontrado = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.CMB_Buscar = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatosClientes = new System.Windows.Forms.GroupBox();
            this.text_FechadeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_CategoriaDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Quitar = new System.Windows.Forms.Button();
            this.Cambiar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.text_PrecioCompra = new System.Windows.Forms.TextBox();
            this.text_PrecioVenta = new System.Windows.Forms.TextBox();
            this.text_Stock = new System.Windows.Forms.TextBox();
            this.text_Categoria = new System.Windows.Forms.TextBox();
            this.text_Descripcion = new System.Windows.Forms.TextBox();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dialogo = new System.Windows.Forms.OpenFileDialog();
            this.text_Flag = new System.Windows.Forms.TextBox();
            Buscar_Categoria = new System.Windows.Forms.Button();
            this.ListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.DatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar_Categoria
            // 
            Buscar_Categoria.BackColor = System.Drawing.Color.LightSeaGreen;
            Buscar_Categoria.CausesValidation = false;
            Buscar_Categoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Buscar_Categoria.Location = new System.Drawing.Point(411, 66);
            Buscar_Categoria.Name = "Buscar_Categoria";
            Buscar_Categoria.Size = new System.Drawing.Size(37, 23);
            Buscar_Categoria.TabIndex = 12;
            Buscar_Categoria.Text = "...";
            Buscar_Categoria.UseVisualStyleBackColor = false;
            Buscar_Categoria.Click += new System.EventHandler(this.Buscar_Categoria_Click);
            // 
            // ListaClientes
            // 
            this.ListaClientes.Controls.Add(this.BT_liminar);
            this.ListaClientes.Controls.Add(this.noencontrado);
            this.ListaClientes.Controls.Add(this.Buscar);
            this.ListaClientes.Controls.Add(this.CMB_Buscar);
            this.ListaClientes.Controls.Add(this.dgvProductos);
            this.ListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListaClientes.Location = new System.Drawing.Point(551, 26);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(682, 516);
            this.ListaClientes.TabIndex = 6;
            this.ListaClientes.TabStop = false;
            this.ListaClientes.Text = "Listado de Productos";
            // 
            // BT_liminar
            // 
            this.BT_liminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_liminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_liminar.Location = new System.Drawing.Point(6, 487);
            this.BT_liminar.Name = "BT_liminar";
            this.BT_liminar.Size = new System.Drawing.Size(75, 23);
            this.BT_liminar.TabIndex = 12;
            this.BT_liminar.Text = "Eliminar";
            this.BT_liminar.UseVisualStyleBackColor = false;
            this.BT_liminar.Click += new System.EventHandler(this.BT_liminar_Click);
            // 
            // noencontrado
            // 
            this.noencontrado.AutoSize = true;
            this.noencontrado.Location = new System.Drawing.Point(251, 275);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(193, 15);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(149, 45);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(522, 21);
            this.Buscar.TabIndex = 2;
            // 
            // CMB_Buscar
            // 
            this.CMB_Buscar.FormattingEnabled = true;
            this.CMB_Buscar.Items.AddRange(new object[] {
            "Nombre",
            "Descripcion",
            "Stock",
            "Precio Compra",
            "Precio Venta",
            "Fecha Vencimiento"});
            this.CMB_Buscar.Location = new System.Drawing.Point(19, 45);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(121, 23);
            this.CMB_Buscar.TabIndex = 1;
            this.CMB_Buscar.Text = "Nombre";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvProductos.Location = new System.Drawing.Point(6, 90);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(665, 391);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 67;
            // 
            // DatosClientes
            // 
            this.DatosClientes.Controls.Add(this.text_FechadeVencimiento);
            this.DatosClientes.Controls.Add(this.Imagen);
            this.DatosClientes.Controls.Add(this.text_Nombre);
            this.DatosClientes.Controls.Add(this.label8);
            this.DatosClientes.Controls.Add(this.text_CategoriaDescripcion);
            this.DatosClientes.Controls.Add(this.label1);
            this.DatosClientes.Controls.Add(this.Editar);
            this.DatosClientes.Controls.Add(this.Guardar);
            this.DatosClientes.Controls.Add(Buscar_Categoria);
            this.DatosClientes.Controls.Add(this.Quitar);
            this.DatosClientes.Controls.Add(this.Cambiar);
            this.DatosClientes.Controls.Add(this.Cancelar);
            this.DatosClientes.Controls.Add(this.Nuevo);
            this.DatosClientes.Controls.Add(this.text_PrecioCompra);
            this.DatosClientes.Controls.Add(this.text_PrecioVenta);
            this.DatosClientes.Controls.Add(this.text_Stock);
            this.DatosClientes.Controls.Add(this.text_Categoria);
            this.DatosClientes.Controls.Add(this.text_Descripcion);
            this.DatosClientes.Controls.Add(this.text_Id);
            this.DatosClientes.Controls.Add(this.label5);
            this.DatosClientes.Controls.Add(this.label6);
            this.DatosClientes.Controls.Add(this.label7);
            this.DatosClientes.Controls.Add(this.label4);
            this.DatosClientes.Controls.Add(this.label3);
            this.DatosClientes.Controls.Add(this.label2);
            this.DatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosClientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatosClientes.Location = new System.Drawing.Point(32, 26);
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.Size = new System.Drawing.Size(460, 516);
            this.DatosClientes.TabIndex = 5;
            this.DatosClientes.TabStop = false;
            this.DatosClientes.Text = "Datos del Producto";
            // 
            // text_FechadeVencimiento
            // 
            this.text_FechadeVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_FechadeVencimiento.Location = new System.Drawing.Point(206, 236);
            this.text_FechadeVencimiento.Name = "text_FechadeVencimiento";
            this.text_FechadeVencimiento.Size = new System.Drawing.Size(200, 21);
            this.text_FechadeVencimiento.TabIndex = 21;
            this.text_FechadeVencimiento.ValueChanged += new System.EventHandler(this.text_FechadeVencimiento_ValueChanged);
            // 
            // Imagen
            // 
            this.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen.Location = new System.Drawing.Point(9, 299);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(197, 112);
            this.Imagen.TabIndex = 20;
            this.Imagen.TabStop = false;
            this.Imagen.Click += new System.EventHandler(this.Imagen_Click);
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(206, 95);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(200, 21);
            this.text_Nombre.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre";
            // 
            // text_CategoriaDescripcion
            // 
            this.text_CategoriaDescripcion.Location = new System.Drawing.Point(268, 67);
            this.text_CategoriaDescripcion.Name = "text_CategoriaDescripcion";
            this.text_CategoriaDescripcion.Size = new System.Drawing.Size(127, 21);
            this.text_CategoriaDescripcion.TabIndex = 17;
            this.text_CategoriaDescripcion.TextChanged += new System.EventHandler(this.text_CategoriaDescripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha de Vencimiento";
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(214, 482);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardar.Location = new System.Drawing.Point(133, 431);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 13;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Quitar
            // 
            this.Quitar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Quitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quitar.Location = new System.Drawing.Point(240, 359);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(155, 23);
            this.Quitar.TabIndex = 12;
            this.Quitar.Text = "Quitar Imagen";
            this.Quitar.UseVisualStyleBackColor = false;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // Cambiar
            // 
            this.Cambiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Cambiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cambiar.Location = new System.Drawing.Point(240, 319);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(155, 23);
            this.Cambiar.TabIndex = 12;
            this.Cambiar.Text = "Cambiar Imagen";
            this.Cambiar.UseVisualStyleBackColor = false;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar.Location = new System.Drawing.Point(214, 431);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevo.Location = new System.Drawing.Point(133, 482);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 11;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // text_PrecioCompra
            // 
            this.text_PrecioCompra.Location = new System.Drawing.Point(206, 176);
            this.text_PrecioCompra.Name = "text_PrecioCompra";
            this.text_PrecioCompra.Size = new System.Drawing.Size(83, 21);
            this.text_PrecioCompra.TabIndex = 10;
            // 
            // text_PrecioVenta
            // 
            this.text_PrecioVenta.Location = new System.Drawing.Point(206, 203);
            this.text_PrecioVenta.Name = "text_PrecioVenta";
            this.text_PrecioVenta.Size = new System.Drawing.Size(83, 21);
            this.text_PrecioVenta.TabIndex = 9;
            this.text_PrecioVenta.Text = " ";
            // 
            // text_Stock
            // 
            this.text_Stock.Location = new System.Drawing.Point(206, 149);
            this.text_Stock.Name = "text_Stock";
            this.text_Stock.Size = new System.Drawing.Size(83, 21);
            this.text_Stock.TabIndex = 8;
            this.text_Stock.TextChanged += new System.EventHandler(this.text_Stock_TextChanged);
            // 
            // text_Categoria
            // 
            this.text_Categoria.Location = new System.Drawing.Point(207, 68);
            this.text_Categoria.Name = "text_Categoria";
            this.text_Categoria.Size = new System.Drawing.Size(56, 21);
            this.text_Categoria.TabIndex = 7;
            // 
            // text_Descripcion
            // 
            this.text_Descripcion.Location = new System.Drawing.Point(206, 122);
            this.text_Descripcion.Name = "text_Descripcion";
            this.text_Descripcion.Size = new System.Drawing.Size(200, 21);
            this.text_Descripcion.TabIndex = 7;
            this.text_Descripcion.TextChanged += new System.EventHandler(this.text_Descripcion_TextChanged);
            // 
            // text_Id
            // 
            this.text_Id.Enabled = false;
            this.text_Id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Id.Location = new System.Drawing.Point(206, 39);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(40, 21);
            this.text_Id.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Precio Compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // dialogo
            // 
            this.dialogo.FileName = "openFileDialog1";
            // 
            // text_Flag
            // 
            this.text_Flag.Enabled = false;
            this.text_Flag.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Flag.Location = new System.Drawing.Point(452, 0);
            this.text_Flag.Name = "text_Flag";
            this.text_Flag.Size = new System.Drawing.Size(40, 20);
            this.text_Flag.TabIndex = 6;
            this.text_Flag.Visible = false;
            this.text_Flag.TextChanged += new System.EventHandler(this.text_Flag_TextChanged);
            // 
            // FRM_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1260, 575);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.DatosClientes);
            this.Controls.Add(this.text_Flag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Producto";
            this.Text = "Mantenimiento de Producto";
            this.Load += new System.EventHandler(this.FRM_Producto_Load);
            this.ListaClientes.ResumeLayout(false);
            this.ListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.DatosClientes.ResumeLayout(false);
            this.DatosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ListaClientes;
        private System.Windows.Forms.Button BT_liminar;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Buscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.GroupBox DatosClientes;
        private System.Windows.Forms.TextBox text_CategoriaDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.TextBox text_PrecioCompra;
        private System.Windows.Forms.TextBox text_PrecioVenta;
        private System.Windows.Forms.TextBox text_Stock;
        private System.Windows.Forms.TextBox text_Categoria;
        private System.Windows.Forms.TextBox text_Descripcion;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Button Cambiar;
        private System.Windows.Forms.DateTimePicker text_FechadeVencimiento;
        private System.Windows.Forms.OpenFileDialog dialogo;
        private System.Windows.Forms.TextBox text_Flag;
    }
}