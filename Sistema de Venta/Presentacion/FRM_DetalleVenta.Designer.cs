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
            this.ListaClientes = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.text_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_BuscarProducto = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.ListaClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.cmdTipoDoc.Location = new System.Drawing.Point(130, 237);
            this.cmdTipoDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdTipoDoc.Name = "cmdTipoDoc";
            this.cmdTipoDoc.Size = new System.Drawing.Size(298, 30);
            this.cmdTipoDoc.TabIndex = 16;
            this.cmdTipoDoc.Text = "Factura";
            // 
            // text_fecha
            // 
            this.text_fecha.Enabled = false;
            this.text_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_fecha.Location = new System.Drawing.Point(130, 175);
            this.text_fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(298, 28);
            this.text_fecha.TabIndex = 15;
            // 
            // text_NumeroDoc
            // 
            this.text_NumeroDoc.Enabled = false;
            this.text_NumeroDoc.Location = new System.Drawing.Point(130, 297);
            this.text_NumeroDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_NumeroDoc.Name = "text_NumeroDoc";
            this.text_NumeroDoc.Size = new System.Drawing.Size(298, 28);
            this.text_NumeroDoc.TabIndex = 0;
            // 
            // text_ClienteId
            // 
            this.text_ClienteId.Enabled = false;
            this.text_ClienteId.Location = new System.Drawing.Point(130, 115);
            this.text_ClienteId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_ClienteId.Name = "text_ClienteId";
            this.text_ClienteId.Size = new System.Drawing.Size(58, 28);
            this.text_ClienteId.TabIndex = 7;
            // 
            // text_ClienteNombre
            // 
            this.text_ClienteNombre.Enabled = false;
            this.text_ClienteNombre.Location = new System.Drawing.Point(200, 115);
            this.text_ClienteNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_ClienteNombre.Name = "text_ClienteNombre";
            this.text_ClienteNombre.Size = new System.Drawing.Size(192, 28);
            this.text_ClienteNombre.TabIndex = 7;
            // 
            // textVentaId
            // 
            this.textVentaId.Enabled = false;
            this.textVentaId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textVentaId.Location = new System.Drawing.Point(130, 54);
            this.textVentaId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textVentaId.Name = "textVentaId";
            this.textVentaId.Size = new System.Drawing.Size(121, 28);
            this.textVentaId.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Numero Doc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tipo Doc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Venta Id";
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 88;
            // 
            // noencontrado
            // 
            this.noencontrado.AutoSize = true;
            this.noencontrado.Location = new System.Drawing.Point(362, 306);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(285, 22);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvVentas.Location = new System.Drawing.Point(9, 85);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(998, 468);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // ListaClientes
            // 
            this.ListaClientes.Controls.Add(this.noencontrado);
            this.ListaClientes.Controls.Add(this.dgvVentas);
            this.ListaClientes.Controls.Add(this.btnQuitar);
            this.ListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListaClientes.Location = new System.Drawing.Point(574, 42);
            this.ListaClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListaClientes.Size = new System.Drawing.Size(1032, 694);
            this.ListaClientes.TabIndex = 8;
            this.ListaClientes.TabStop = false;
            this.ListaClientes.Text = "Detalles de Venta";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitar.Location = new System.Drawing.Point(9, 562);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(216, 49);
            this.btnQuitar.TabIndex = 13;
            this.btnQuitar.Text = "Quitrar Producto";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.text_Cantidad);
            this.groupBox1.Controls.Add(this.cmdTipoDoc);
            this.groupBox1.Controls.Add(this.text_fecha);
            this.groupBox1.Controls.Add(this.btn_BuscarProducto);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.text_NumeroDoc);
            this.groupBox1.Controls.Add(this.text_stock);
            this.groupBox1.Controls.Add(this.text_PrecioUnitario);
            this.groupBox1.Controls.Add(this.text_ProductoId);
            this.groupBox1.Controls.Add(this.text_ProductoDescripcion);
            this.groupBox1.Controls.Add(this.text_ClienteId);
            this.groupBox1.Controls.Add(this.text_ClienteNombre);
            this.groupBox1.Controls.Add(this.textVentaId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(18, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(488, 694);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Ventas";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnImprimir.BackgroundImage = global::Sistema_de_Venta.Properties.Resources.Print_icon_icons_com_73705;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(262, 511);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(195, 157);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // text_Cantidad
            // 
            this.text_Cantidad.Location = new System.Drawing.Point(130, 425);
            this.text_Cantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.text_Cantidad.Size = new System.Drawing.Size(93, 28);
            this.text_Cantidad.TabIndex = 1;
            this.text_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_BuscarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarProducto.Location = new System.Drawing.Point(402, 360);
            this.btn_BuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(76, 35);
            this.btn_BuscarProducto.TabIndex = 13;
            this.btn_BuscarProducto.Text = "...";
            this.btn_BuscarProducto.UseVisualStyleBackColor = false;
            this.btn_BuscarProducto.Click += new System.EventHandler(this.btn_BuscarProducto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregar.BackgroundImage = global::Sistema_de_Venta.Properties.Resources.add_carro;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(28, 511);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(195, 157);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // text_stock
            // 
            this.text_stock.Enabled = false;
            this.text_stock.Location = new System.Drawing.Point(356, 423);
            this.text_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(73, 28);
            this.text_stock.TabIndex = 7;
            this.text_stock.Text = "0";
            // 
            // text_PrecioUnitario
            // 
            this.text_PrecioUnitario.Location = new System.Drawing.Point(172, 469);
            this.text_PrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_PrecioUnitario.Name = "text_PrecioUnitario";
            this.text_PrecioUnitario.Size = new System.Drawing.Size(126, 28);
            this.text_PrecioUnitario.TabIndex = 2;
            // 
            // text_ProductoId
            // 
            this.text_ProductoId.Enabled = false;
            this.text_ProductoId.Location = new System.Drawing.Point(130, 360);
            this.text_ProductoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_ProductoId.Name = "text_ProductoId";
            this.text_ProductoId.Size = new System.Drawing.Size(58, 28);
            this.text_ProductoId.TabIndex = 7;
            // 
            // text_ProductoDescripcion
            // 
            this.text_ProductoDescripcion.Enabled = false;
            this.text_ProductoDescripcion.Location = new System.Drawing.Point(200, 360);
            this.text_ProductoDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_ProductoDescripcion.Name = "text_ProductoDescripcion";
            this.text_ProductoDescripcion.Size = new System.Drawing.Size(192, 28);
            this.text_ProductoDescripcion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 469);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Precio Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(444, 20);
            this.txtFlag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(58, 26);
            this.txtFlag.TabIndex = 9;
            this.txtFlag.Visible = false;
            // 
            // FRM_DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1636, 768);
            this.Controls.Add(this.txtFlag);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Detalle de Venta";
            this.Load += new System.EventHandler(this.FRM_DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ListaClientes.ResumeLayout(false);
            this.ListaClientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox ListaClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown text_Cantidad;
        private System.Windows.Forms.Button btn_BuscarProducto;
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
    }
}