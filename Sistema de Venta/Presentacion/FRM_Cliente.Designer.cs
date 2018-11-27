namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cliente));
            this.Editar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.text_Domicilio = new System.Windows.Forms.TextBox();
            this.text_Telefono = new System.Windows.Forms.TextBox();
            this.text_NCF = new System.Windows.Forms.TextBox();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.text_Apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_Apellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.BT_liminar = new System.Windows.Forms.Button();
            this.noencontrado = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.CMB_Buscar = new System.Windows.Forms.ComboBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Favorite = new System.Windows.Forms.DataGridViewImageColumn();
            this.text_Flag = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.pnl_Lista_Categoria = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_VencimientoSecuencia = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_InfReceptor = new System.Windows.Forms.Label();
            this.lab_RNC = new System.Windows.Forms.Label();
            this.lab_NoRSocial = new System.Windows.Forms.Label();
            this.tbx_RNC = new System.Windows.Forms.TextBox();
            this.tbx_NoRSocial = new System.Windows.Forms.TextBox();
            this.cbx_FiscalConsumo = new System.Windows.Forms.ComboBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.pbx_Ventas = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnl_Lista_Categoria.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(249, 423);
            this.Editar.Margin = new System.Windows.Forms.Padding(4);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(117, 40);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar.Location = new System.Drawing.Point(249, 423);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(117, 40);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevo.Location = new System.Drawing.Point(119, 423);
            this.Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(117, 40);
            this.Nuevo.TabIndex = 0;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // text_Domicilio
            // 
            this.text_Domicilio.Location = new System.Drawing.Point(119, 186);
            this.text_Domicilio.Margin = new System.Windows.Forms.Padding(4);
            this.text_Domicilio.Name = "text_Domicilio";
            this.text_Domicilio.Size = new System.Drawing.Size(247, 27);
            this.text_Domicilio.TabIndex = 5;
            // 
            // text_Telefono
            // 
            this.text_Telefono.Location = new System.Drawing.Point(119, 225);
            this.text_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.text_Telefono.Name = "text_Telefono";
            this.text_Telefono.Size = new System.Drawing.Size(247, 27);
            this.text_Telefono.TabIndex = 6;
            this.text_Telefono.Text = " ";
            // 
            // text_NCF
            // 
            this.text_NCF.Location = new System.Drawing.Point(119, 108);
            this.text_NCF.Margin = new System.Windows.Forms.Padding(4);
            this.text_NCF.Name = "text_NCF";
            this.text_NCF.Size = new System.Drawing.Size(247, 27);
            this.text_NCF.TabIndex = 4;
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(119, 264);
            this.text_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(247, 27);
            this.text_Nombre.TabIndex = 2;
            // 
            // text_Apellido
            // 
            this.text_Apellido.Location = new System.Drawing.Point(119, 303);
            this.text_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.text_Apellido.Name = "text_Apellido";
            this.text_Apellido.Size = new System.Drawing.Size(247, 27);
            this.text_Apellido.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "NCF";
            // 
            // lab_Apellido
            // 
            this.lab_Apellido.AutoSize = true;
            this.lab_Apellido.ForeColor = System.Drawing.Color.White;
            this.lab_Apellido.Location = new System.Drawing.Point(42, 306);
            this.lab_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Apellido.Name = "lab_Apellido";
            this.lab_Apellido.Size = new System.Drawing.Size(77, 20);
            this.lab_Apellido.TabIndex = 2;
            this.lab_Apellido.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres";
            // 
            // text_Id
            // 
            this.text_Id.Enabled = false;
            this.text_Id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Id.Location = new System.Drawing.Point(331, 22);
            this.text_Id.Margin = new System.Windows.Forms.Padding(4);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(14, 27);
            this.text_Id.TabIndex = 1;
            this.text_Id.Visible = false;
            // 
            // BT_liminar
            // 
            this.BT_liminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_liminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.BT_liminar.FlatAppearance.BorderSize = 0;
            this.BT_liminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_liminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_liminar.Location = new System.Drawing.Point(43, 591);
            this.BT_liminar.Margin = new System.Windows.Forms.Padding(4);
            this.BT_liminar.Name = "BT_liminar";
            this.BT_liminar.Size = new System.Drawing.Size(906, 46);
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
            this.noencontrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.noencontrado.ForeColor = System.Drawing.Color.White;
            this.noencontrado.Location = new System.Drawing.Point(345, 327);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(244, 20);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Location = new System.Drawing.Point(211, 70);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(739, 27);
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
            "Nombre",
            "Apellido",
            "Ncf",
            "Telefono",
            "Domicilio",
            "TipoCliente",
            "RNC",
            "NoRSocial"});
            this.CMB_Buscar.Location = new System.Drawing.Point(43, 69);
            this.CMB_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(160, 28);
            this.CMB_Buscar.TabIndex = 1;
            this.CMB_Buscar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Favorite});
            this.dgvClientes.Location = new System.Drawing.Point(43, 105);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(907, 490);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Favorite
            // 
            this.Favorite.HeaderText = "Favorito";
            this.Favorite.Image = global::Sistema_de_Venta.Properties.Resources.FavoriteOff2;
            this.Favorite.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Favorite.Name = "Favorite";
            this.Favorite.ReadOnly = true;
            // 
            // text_Flag
            // 
            this.text_Flag.BackColor = System.Drawing.SystemColors.Window;
            this.text_Flag.Enabled = false;
            this.text_Flag.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Flag.Location = new System.Drawing.Point(353, 22);
            this.text_Flag.Margin = new System.Windows.Forms.Padding(4);
            this.text_Flag.Name = "text_Flag";
            this.text_Flag.Size = new System.Drawing.Size(13, 27);
            this.text_Flag.TabIndex = 6;
            this.text_Flag.Visible = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(45, 591);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(321, 46);
            this.btn_Cerrar.TabIndex = 16;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pnl_Lista_Categoria
            // 
            this.pnl_Lista_Categoria.Controls.Add(this.BT_liminar);
            this.pnl_Lista_Categoria.Controls.Add(this.noencontrado);
            this.pnl_Lista_Categoria.Controls.Add(this.CMB_Buscar);
            this.pnl_Lista_Categoria.Controls.Add(this.Buscar);
            this.pnl_Lista_Categoria.Controls.Add(this.dgvClientes);
            this.pnl_Lista_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lista_Categoria.Location = new System.Drawing.Point(405, 0);
            this.pnl_Lista_Categoria.Name = "pnl_Lista_Categoria";
            this.pnl_Lista_Categoria.Size = new System.Drawing.Size(993, 681);
            this.pnl_Lista_Categoria.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.text_VencimientoSecuencia);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lab_InfReceptor);
            this.panel2.Controls.Add(this.lab_RNC);
            this.panel2.Controls.Add(this.lab_NoRSocial);
            this.panel2.Controls.Add(this.tbx_RNC);
            this.panel2.Controls.Add(this.tbx_NoRSocial);
            this.panel2.Controls.Add(this.cbx_FiscalConsumo);
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Controls.Add(this.Editar);
            this.panel2.Controls.Add(this.text_Flag);
            this.panel2.Controls.Add(this.Guardar);
            this.panel2.Controls.Add(this.text_Id);
            this.panel2.Controls.Add(this.Cancelar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Nuevo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.text_Domicilio);
            this.panel2.Controls.Add(this.lab_Apellido);
            this.panel2.Controls.Add(this.text_Telefono);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.text_NCF);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.text_Nombre);
            this.panel2.Controls.Add(this.text_Apellido);
            this.panel2.Controls.Add(this.pbx_Ventas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 681);
            this.panel2.TabIndex = 1;
            // 
            // text_VencimientoSecuencia
            // 
            this.text_VencimientoSecuencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_VencimientoSecuencia.Location = new System.Drawing.Point(119, 147);
            this.text_VencimientoSecuencia.Margin = new System.Windows.Forms.Padding(4);
            this.text_VencimientoSecuencia.Name = "text_VencimientoSecuencia";
            this.text_VencimientoSecuencia.Size = new System.Drawing.Size(247, 27);
            this.text_VencimientoSecuencia.TabIndex = 29;
            this.text_VencimientoSecuencia.Value = new System.DateTime(2018, 12, 24, 22, 45, 0, 0);
            this.text_VencimientoSecuencia.ValueChanged += new System.EventHandler(this.text_VencimientoSecuencia_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Vence";
            // 
            // lab_InfReceptor
            // 
            this.lab_InfReceptor.AutoSize = true;
            this.lab_InfReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_InfReceptor.ForeColor = System.Drawing.Color.White;
            this.lab_InfReceptor.Location = new System.Drawing.Point(119, 312);
            this.lab_InfReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_InfReceptor.Name = "lab_InfReceptor";
            this.lab_InfReceptor.Size = new System.Drawing.Size(220, 20);
            this.lab_InfReceptor.TabIndex = 26;
            this.lab_InfReceptor.Text = "Información del Receptor";
            // 
            // lab_RNC
            // 
            this.lab_RNC.AutoSize = true;
            this.lab_RNC.ForeColor = System.Drawing.Color.White;
            this.lab_RNC.Location = new System.Drawing.Point(42, 345);
            this.lab_RNC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_RNC.Name = "lab_RNC";
            this.lab_RNC.Size = new System.Drawing.Size(45, 20);
            this.lab_RNC.TabIndex = 22;
            this.lab_RNC.Text = "RNC";
            // 
            // lab_NoRSocial
            // 
            this.lab_NoRSocial.ForeColor = System.Drawing.Color.White;
            this.lab_NoRSocial.Location = new System.Drawing.Point(42, 383);
            this.lab_NoRSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_NoRSocial.Name = "lab_NoRSocial";
            this.lab_NoRSocial.Size = new System.Drawing.Size(69, 79);
            this.lab_NoRSocial.TabIndex = 23;
            this.lab_NoRSocial.Text = "Nombre o Razón Social";
            // 
            // tbx_RNC
            // 
            this.tbx_RNC.Location = new System.Drawing.Point(119, 342);
            this.tbx_RNC.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_RNC.Name = "tbx_RNC";
            this.tbx_RNC.Size = new System.Drawing.Size(247, 27);
            this.tbx_RNC.TabIndex = 24;
            // 
            // tbx_NoRSocial
            // 
            this.tbx_NoRSocial.Location = new System.Drawing.Point(119, 383);
            this.tbx_NoRSocial.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_NoRSocial.Name = "tbx_NoRSocial";
            this.tbx_NoRSocial.Size = new System.Drawing.Size(247, 27);
            this.tbx_NoRSocial.TabIndex = 25;
            // 
            // cbx_FiscalConsumo
            // 
            this.cbx_FiscalConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.cbx_FiscalConsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_FiscalConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_FiscalConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_FiscalConsumo.ForeColor = System.Drawing.Color.White;
            this.cbx_FiscalConsumo.FormattingEnabled = true;
            this.cbx_FiscalConsumo.Items.AddRange(new object[] {
            "Consumidor Final",
            "Crédito Fiscal"});
            this.cbx_FiscalConsumo.Location = new System.Drawing.Point(119, 68);
            this.cbx_FiscalConsumo.Name = "cbx_FiscalConsumo";
            this.cbx_FiscalConsumo.Size = new System.Drawing.Size(247, 28);
            this.cbx_FiscalConsumo.TabIndex = 21;
            this.cbx_FiscalConsumo.SelectedValueChanged += new System.EventHandler(this.cbx_FiscalConsumo_SelectedValueChanged);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardar.Location = new System.Drawing.Point(119, 423);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(117, 40);
            this.Guardar.TabIndex = 13;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // pbx_Ventas
            // 
            this.pbx_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbx_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Ventas.Image = global::Sistema_de_Venta.Properties.Resources.UsuarioBig;
            this.pbx_Ventas.Location = new System.Drawing.Point(152, 470);
            this.pbx_Ventas.Name = "pbx_Ventas";
            this.pbx_Ventas.Size = new System.Drawing.Size(107, 118);
            this.pbx_Ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Ventas.TabIndex = 19;
            this.pbx_Ventas.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Favorite";
            this.dataGridViewImageColumn1.Image = global::Sistema_de_Venta.Properties.Resources.FavoriteOff;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 443;
            // 
            // FRM_Cliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1398, 681);
            this.Controls.Add(this.pnl_Lista_Categoria);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(0, 660);
            this.Name = "FRM_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Cliente";
            this.Load += new System.EventHandler(this.FRM_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnl_Lista_Categoria.ResumeLayout(false);
            this.pnl_Lista_Categoria.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.TextBox text_Domicilio;
        private System.Windows.Forms.TextBox text_Telefono;
        private System.Windows.Forms.TextBox text_NCF;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.TextBox text_Apellido;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_liminar;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Buscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.TextBox text_Flag;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Panel pnl_Lista_Categoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbx_Ventas;
        private System.Windows.Forms.ComboBox cbx_FiscalConsumo;
        private System.Windows.Forms.Label lab_RNC;
        private System.Windows.Forms.Label lab_NoRSocial;
        private System.Windows.Forms.TextBox tbx_RNC;
        private System.Windows.Forms.TextBox tbx_NoRSocial;
        private System.Windows.Forms.Label lab_InfReceptor;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Favorite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker text_VencimientoSecuencia;
    }
}