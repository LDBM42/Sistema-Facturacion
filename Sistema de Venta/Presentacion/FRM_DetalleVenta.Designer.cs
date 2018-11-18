namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_DetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DetalleVenta));
            this.cmdTipoDoc = new System.Windows.Forms.ComboBox();
            this.text_fecha = new System.Windows.Forms.DateTimePicker();
            this.text_NumeroDoc = new System.Windows.Forms.TextBox();
            this.text_ClienteId = new System.Windows.Forms.TextBox();
            this.text_ClienteNombre = new System.Windows.Forms.TextBox();
            this.textVentaId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noencontrado = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.CMB_Buscar = new System.Windows.Forms.ComboBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.text_DescripcionVenta = new System.Windows.Forms.TextBox();
            this.Lbl_Comentario = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.text_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.text_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.text_ProductoId = new System.Windows.Forms.TextBox();
            this.text_ProductoDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdTipoDoc
            // 
            this.cmdTipoDoc.Enabled = false;
            this.cmdTipoDoc.FormattingEnabled = true;
            this.cmdTipoDoc.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cmdTipoDoc.Location = new System.Drawing.Point(980, 177);
            this.cmdTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTipoDoc.Name = "cmdTipoDoc";
            this.cmdTipoDoc.Size = new System.Drawing.Size(265, 26);
            this.cmdTipoDoc.TabIndex = 16;
            this.cmdTipoDoc.Text = "Factura";
            // 
            // text_fecha
            // 
            this.text_fecha.Enabled = false;
            this.text_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_fecha.Location = new System.Drawing.Point(980, 137);
            this.text_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(265, 24);
            this.text_fecha.TabIndex = 15;
            // 
            // text_NumeroDoc
            // 
            this.text_NumeroDoc.Enabled = false;
            this.text_NumeroDoc.Location = new System.Drawing.Point(980, 219);
            this.text_NumeroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.text_NumeroDoc.Name = "text_NumeroDoc";
            this.text_NumeroDoc.Size = new System.Drawing.Size(265, 24);
            this.text_NumeroDoc.TabIndex = 0;
            // 
            // text_ClienteId
            // 
            this.text_ClienteId.Enabled = false;
            this.text_ClienteId.Location = new System.Drawing.Point(980, 97);
            this.text_ClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.text_ClienteId.Name = "text_ClienteId";
            this.text_ClienteId.Size = new System.Drawing.Size(69, 24);
            this.text_ClienteId.TabIndex = 7;
            // 
            // text_ClienteNombre
            // 
            this.text_ClienteNombre.Enabled = false;
            this.text_ClienteNombre.Location = new System.Drawing.Point(1057, 97);
            this.text_ClienteNombre.Margin = new System.Windows.Forms.Padding(4);
            this.text_ClienteNombre.Name = "text_ClienteNombre";
            this.text_ClienteNombre.Size = new System.Drawing.Size(188, 24);
            this.text_ClienteNombre.TabIndex = 7;
            // 
            // textVentaId
            // 
            this.textVentaId.Enabled = false;
            this.textVentaId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textVentaId.Location = new System.Drawing.Point(980, 57);
            this.textVentaId.Margin = new System.Windows.Forms.Padding(4);
            this.textVentaId.Name = "textVentaId";
            this.textVentaId.Size = new System.Drawing.Size(69, 24);
            this.textVentaId.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(864, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Numero Doc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(864, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tipo Doc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(864, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(864, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(864, 60);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Venta Id";
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 65;
            // 
            // noencontrado
            // 
            this.noencontrado.AutoSize = true;
            this.noencontrado.BackColor = System.Drawing.Color.Transparent;
            this.noencontrado.ForeColor = System.Drawing.Color.White;
            this.noencontrado.Location = new System.Drawing.Point(329, 246);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(217, 18);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeight = 30;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVentas.Location = new System.Drawing.Point(27, 87);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dgvVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgvVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(766, 372);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(195, 51);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(598, 24);
            this.Buscar.TabIndex = 22;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // CMB_Buscar
            // 
            this.CMB_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Buscar.FormattingEnabled = true;
            this.CMB_Buscar.Items.AddRange(new object[] {
            "Nombre",
            "Cantidad",
            "PrecioUnitario"});
            this.CMB_Buscar.Location = new System.Drawing.Point(27, 51);
            this.CMB_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(160, 26);
            this.CMB_Buscar.TabIndex = 21;
            this.CMB_Buscar.SelectedIndexChanged += new System.EventHandler(this.CMB_Buscar_SelectedIndexChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitar.Location = new System.Drawing.Point(27, 501);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(160, 44);
            this.btnQuitar.TabIndex = 13;
            this.btnQuitar.Text = "Quitrar Producto";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // text_DescripcionVenta
            // 
            this.text_DescripcionVenta.Location = new System.Drawing.Point(1018, 373);
            this.text_DescripcionVenta.Margin = new System.Windows.Forms.Padding(4);
            this.text_DescripcionVenta.Multiline = true;
            this.text_DescripcionVenta.Name = "text_DescripcionVenta";
            this.text_DescripcionVenta.Size = new System.Drawing.Size(227, 74);
            this.text_DescripcionVenta.TabIndex = 20;
            // 
            // Lbl_Comentario
            // 
            this.Lbl_Comentario.AutoSize = true;
            this.Lbl_Comentario.Location = new System.Drawing.Point(864, 376);
            this.Lbl_Comentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Comentario.Name = "Lbl_Comentario";
            this.Lbl_Comentario.Size = new System.Drawing.Size(87, 18);
            this.Lbl_Comentario.TabIndex = 19;
            this.Lbl_Comentario.Text = "Descripción";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnImprimir.BackgroundImage = global::Sistema_de_Venta.Properties.Resources.Print_icon_icons_com_73705;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(1141, 464);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 94);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // text_Cantidad
            // 
            this.text_Cantidad.Location = new System.Drawing.Point(980, 299);
            this.text_Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.text_Cantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.text_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.text_Cantidad.Name = "text_Cantidad";
            this.text_Cantidad.Size = new System.Drawing.Size(83, 24);
            this.text_Cantidad.TabIndex = 1;
            this.text_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregar.BackgroundImage = global::Sistema_de_Venta.Properties.Resources.add_carro;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(1020, 464);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 94);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // text_stock
            // 
            this.text_stock.Enabled = false;
            this.text_stock.Location = new System.Drawing.Point(1180, 299);
            this.text_stock.Margin = new System.Windows.Forms.Padding(4);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(65, 24);
            this.text_stock.TabIndex = 7;
            this.text_stock.Text = "0";
            // 
            // text_PrecioUnitario
            // 
            this.text_PrecioUnitario.Location = new System.Drawing.Point(1018, 336);
            this.text_PrecioUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.text_PrecioUnitario.Name = "text_PrecioUnitario";
            this.text_PrecioUnitario.Size = new System.Drawing.Size(227, 24);
            this.text_PrecioUnitario.TabIndex = 2;
            // 
            // text_ProductoId
            // 
            this.text_ProductoId.Enabled = false;
            this.text_ProductoId.Location = new System.Drawing.Point(980, 259);
            this.text_ProductoId.Margin = new System.Windows.Forms.Padding(4);
            this.text_ProductoId.Name = "text_ProductoId";
            this.text_ProductoId.Size = new System.Drawing.Size(52, 24);
            this.text_ProductoId.TabIndex = 7;
            // 
            // text_ProductoDescripcion
            // 
            this.text_ProductoDescripcion.Location = new System.Drawing.Point(1042, 259);
            this.text_ProductoDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.text_ProductoDescripcion.Name = "text_ProductoDescripcion";
            this.text_ProductoDescripcion.ReadOnly = true;
            this.text_ProductoDescripcion.Size = new System.Drawing.Size(203, 24);
            this.text_ProductoDescripcion.TabIndex = 7;
            this.text_ProductoDescripcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_ProductoDescripcion_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1093, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 339);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Precio Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(864, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(1345, 13);
            this.txtFlag.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(52, 24);
            this.txtFlag.TabIndex = 9;
            this.txtFlag.Visible = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(866, 464);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(138, 94);
            this.btn_Cerrar.TabIndex = 21;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // FRM_DetalleVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1282, 603);
            this.Controls.Add(this.txtFlag);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.text_DescripcionVenta);
            this.Controls.Add(this.Lbl_Comentario);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_Cantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdTipoDoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_NumeroDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_PrecioUnitario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_ProductoId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_ProductoDescripcion);
            this.Controls.Add(this.textVentaId);
            this.Controls.Add(this.text_ClienteId);
            this.Controls.Add(this.text_ClienteNombre);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.CMB_Buscar);
            this.Controls.Add(this.noencontrado);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnQuitar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdTipoDoc;
        private System.Windows.Forms.DateTimePicker text_fecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox text_NumeroDoc;
        private System.Windows.Forms.TextBox text_ClienteId;
        private System.Windows.Forms.TextBox text_ClienteNombre;
        private System.Windows.Forms.TextBox textVentaId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.NumericUpDown text_Cantidad;
        private System.Windows.Forms.TextBox text_stock;
        private System.Windows.Forms.TextBox text_PrecioUnitario;
        private System.Windows.Forms.TextBox text_ProductoId;
        private System.Windows.Forms.TextBox text_ProductoDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtFlag;
        private System.Windows.Forms.TextBox text_DescripcionVenta;
        private System.Windows.Forms.Label Lbl_Comentario;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Buscar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}