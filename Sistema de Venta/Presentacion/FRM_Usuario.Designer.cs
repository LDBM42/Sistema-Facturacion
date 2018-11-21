namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Usuario));
            this.BT_liminar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.text_Direccion = new System.Windows.Forms.TextBox();
            this.text_Telefono = new System.Windows.Forms.TextBox();
            this.text_DNI = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.CMB_Buscar = new System.Windows.Forms.ComboBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.text_Apellido = new System.Windows.Forms.TextBox();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.noencontrado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbx_Ventas = new System.Windows.Forms.PictureBox();
            this.pnl_Lista_Categoria = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ventas)).BeginInit();
            this.pnl_Lista_Categoria.SuspendLayout();
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
            this.BT_liminar.Location = new System.Drawing.Point(43, 462);
            this.BT_liminar.Margin = new System.Windows.Forms.Padding(4);
            this.BT_liminar.Name = "BT_liminar";
            this.BT_liminar.Size = new System.Drawing.Size(906, 46);
            this.BT_liminar.TabIndex = 12;
            this.BT_liminar.Text = "Eliminar";
            this.BT_liminar.UseVisualStyleBackColor = false;
            this.BT_liminar.Click += new System.EventHandler(this.BT_liminar_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(255, 375);
            this.Editar.Margin = new System.Windows.Forms.Padding(4);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(106, 40);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardar.Location = new System.Drawing.Point(134, 375);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(106, 40);
            this.Guardar.TabIndex = 13;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar.Location = new System.Drawing.Point(255, 375);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(106, 40);
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
            this.Nuevo.Location = new System.Drawing.Point(134, 375);
            this.Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(106, 40);
            this.Nuevo.TabIndex = 1;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // text_Direccion
            // 
            this.text_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Direccion.Location = new System.Drawing.Point(134, 182);
            this.text_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.text_Direccion.Name = "text_Direccion";
            this.text_Direccion.Size = new System.Drawing.Size(227, 24);
            this.text_Direccion.TabIndex = 10;
            // 
            // text_Telefono
            // 
            this.text_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Telefono.Location = new System.Drawing.Point(134, 219);
            this.text_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.text_Telefono.Name = "text_Telefono";
            this.text_Telefono.Size = new System.Drawing.Size(227, 24);
            this.text_Telefono.TabIndex = 9;
            this.text_Telefono.Text = " ";
            // 
            // text_DNI
            // 
            this.text_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_DNI.Location = new System.Drawing.Point(134, 145);
            this.text_DNI.Margin = new System.Windows.Forms.Padding(4);
            this.text_DNI.Name = "text_DNI";
            this.text_DNI.Size = new System.Drawing.Size(227, 24);
            this.text_DNI.TabIndex = 8;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Location = new System.Drawing.Point(217, 70);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(733, 26);
            this.Buscar.TabIndex = 2;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // CMB_Buscar
            // 
            this.CMB_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Buscar.FormattingEnabled = true;
            this.CMB_Buscar.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "DNI",
            "Telefono",
            "Domicilio"});
            this.CMB_Buscar.Location = new System.Drawing.Point(43, 69);
            this.CMB_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(160, 28);
            this.CMB_Buscar.TabIndex = 1;
            this.CMB_Buscar.SelectedIndexChanged += new System.EventHandler(this.CMB_Buscar_SelectedIndexChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvUsuarios.Location = new System.Drawing.Point(43, 105);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(907, 358);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // text_Nombre
            // 
            this.text_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Nombre.Location = new System.Drawing.Point(134, 71);
            this.text_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(227, 24);
            this.text_Nombre.TabIndex = 7;
            // 
            // text_Apellido
            // 
            this.text_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Apellido.Location = new System.Drawing.Point(134, 108);
            this.text_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.text_Apellido.Name = "text_Apellido";
            this.text_Apellido.Size = new System.Drawing.Size(227, 24);
            this.text_Apellido.TabIndex = 7;
            // 
            // text_Id
            // 
            this.text_Id.Enabled = false;
            this.text_Id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Id.Location = new System.Drawing.Point(331, 30);
            this.text_Id.Margin = new System.Windows.Forms.Padding(4);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(10, 26);
            this.text_Id.TabIndex = 6;
            this.text_Id.Visible = false;
            // 
            // noencontrado
            // 
            this.noencontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noencontrado.AutoSize = true;
            this.noencontrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.noencontrado.ForeColor = System.Drawing.Color.White;
            this.noencontrado.Location = new System.Drawing.Point(388, 275);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(244, 20);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 222);
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
            this.label6.Location = new System.Drawing.Point(41, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Admin",
            "Empleado"});
            this.cbxTipo.Location = new System.Drawing.Point(134, 331);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(227, 28);
            this.cbxTipo.TabIndex = 16;
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(345, 30);
            this.txtFlag.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(11, 26);
            this.txtFlag.TabIndex = 12;
            this.txtFlag.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 296);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(134, 293);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(227, 25);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(134, 256);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 24);
            this.txtUsuario.TabIndex = 14;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(44, 462);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(317, 46);
            this.btn_Cerrar.TabIndex = 16;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxTipo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFlag);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Editar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Guardar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.text_Id);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.text_Apellido);
            this.panel2.Controls.Add(this.Cancelar);
            this.panel2.Controls.Add(this.text_Nombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.text_DNI);
            this.panel2.Controls.Add(this.Nuevo);
            this.panel2.Controls.Add(this.text_Telefono);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.text_Direccion);
            this.panel2.Controls.Add(this.pbx_Ventas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 552);
            this.panel2.TabIndex = 9;
            // 
            // pbx_Ventas
            // 
            this.pbx_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Ventas.Image = global::Sistema_de_Venta.Properties.Resources.UsuariosBig;
            this.pbx_Ventas.Location = new System.Drawing.Point(149, 392);
            this.pbx_Ventas.Name = "pbx_Ventas";
            this.pbx_Ventas.Size = new System.Drawing.Size(107, 99);
            this.pbx_Ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_Ventas.TabIndex = 18;
            this.pbx_Ventas.TabStop = false;
            // 
            // pnl_Lista_Categoria
            // 
            this.pnl_Lista_Categoria.Controls.Add(this.BT_liminar);
            this.pnl_Lista_Categoria.Controls.Add(this.noencontrado);
            this.pnl_Lista_Categoria.Controls.Add(this.dgvUsuarios);
            this.pnl_Lista_Categoria.Controls.Add(this.Buscar);
            this.pnl_Lista_Categoria.Controls.Add(this.CMB_Buscar);
            this.pnl_Lista_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lista_Categoria.Location = new System.Drawing.Point(405, 0);
            this.pnl_Lista_Categoria.Name = "pnl_Lista_Categoria";
            this.pnl_Lista_Categoria.Size = new System.Drawing.Size(993, 552);
            this.pnl_Lista_Categoria.TabIndex = 16;
            this.pnl_Lista_Categoria.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Lista_Categoria_Paint);
            // 
            // FRM_Usuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1398, 552);
            this.Controls.Add(this.pnl_Lista_Categoria);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.FRM_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ventas)).EndInit();
            this.pnl_Lista_Categoria.ResumeLayout(false);
            this.pnl_Lista_Categoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_liminar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.TextBox text_Direccion;
        private System.Windows.Forms.TextBox text_Telefono;
        private System.Windows.Forms.TextBox text_DNI;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Buscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox text_Apellido;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlag;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Lista_Categoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.PictureBox pbx_Ventas;
    }
}