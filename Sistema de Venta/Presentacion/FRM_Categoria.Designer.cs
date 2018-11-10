namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Categoria));
            this.ListaClientes = new System.Windows.Forms.GroupBox();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.noencontrado = new System.Windows.Forms.Label();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            this.CMB_Descripcion = new System.Windows.Forms.ComboBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatosClientes = new System.Windows.Forms.GroupBox();
            this.Editar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.text_Descripcion = new System.Windows.Forms.TextBox();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Flag = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.ListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.DatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaClientes
            // 
            this.ListaClientes.Controls.Add(this.Buscar);
            this.ListaClientes.Controls.Add(this.noencontrado);
            this.ListaClientes.Controls.Add(this.BT_Eliminar);
            this.ListaClientes.Controls.Add(this.CMB_Descripcion);
            this.ListaClientes.Controls.Add(this.dgvCategoria);
            this.ListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListaClientes.Location = new System.Drawing.Point(359, 28);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(417, 451);
            this.ListaClientes.TabIndex = 6;
            this.ListaClientes.TabStop = false;
            this.ListaClientes.Text = "Listado de Categoria";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(149, 45);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(247, 21);
            this.Buscar.TabIndex = 2;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // noencontrado
            // 
            this.noencontrado.AutoSize = true;
            this.noencontrado.Location = new System.Drawing.Point(107, 246);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(193, 15);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            // 
            // BT_Eliminar
            // 
            this.BT_Eliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_Eliminar.Location = new System.Drawing.Point(19, 422);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.BT_Eliminar.TabIndex = 12;
            this.BT_Eliminar.Text = "Eliminar";
            this.BT_Eliminar.UseVisualStyleBackColor = false;
            this.BT_Eliminar.Click += new System.EventHandler(this.BT_liminar_Click);
            // 
            // CMB_Descripcion
            // 
            this.CMB_Descripcion.FormattingEnabled = true;
            this.CMB_Descripcion.Items.AddRange(new object[] {
            "Descripcion"});
            this.CMB_Descripcion.Location = new System.Drawing.Point(19, 45);
            this.CMB_Descripcion.Name = "CMB_Descripcion";
            this.CMB_Descripcion.Size = new System.Drawing.Size(121, 23);
            this.CMB_Descripcion.TabIndex = 1;
            this.CMB_Descripcion.Text = "Descripcion";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvCategoria.Location = new System.Drawing.Point(19, 89);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(377, 304);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
            this.dgvCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // DatosClientes
            // 
            this.DatosClientes.Controls.Add(this.Editar);
            this.DatosClientes.Controls.Add(this.Guardar);
            this.DatosClientes.Controls.Add(this.Cancelar);
            this.DatosClientes.Controls.Add(this.Nuevo);
            this.DatosClientes.Controls.Add(this.text_Descripcion);
            this.DatosClientes.Controls.Add(this.text_Id);
            this.DatosClientes.Controls.Add(this.label3);
            this.DatosClientes.Controls.Add(this.label2);
            this.DatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosClientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatosClientes.Location = new System.Drawing.Point(12, 28);
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.Size = new System.Drawing.Size(322, 451);
            this.DatosClientes.TabIndex = 5;
            this.DatosClientes.TabStop = false;
            this.DatosClientes.Text = "Datos de Categoria";
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(196, 411);
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
            this.Guardar.Location = new System.Drawing.Point(81, 358);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 13;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar.Location = new System.Drawing.Point(196, 358);
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
            this.Nuevo.Location = new System.Drawing.Point(81, 411);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 2;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // text_Descripcion
            // 
            this.text_Descripcion.Location = new System.Drawing.Point(94, 116);
            this.text_Descripcion.Name = "text_Descripcion";
            this.text_Descripcion.Size = new System.Drawing.Size(200, 21);
            this.text_Descripcion.TabIndex = 1;
            // 
            // text_Id
            // 
            this.text_Id.Enabled = false;
            this.text_Id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Id.Location = new System.Drawing.Point(94, 61);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(82, 21);
            this.text_Id.TabIndex = 0;
            this.text_Id.TextChanged += new System.EventHandler(this.text_Id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // text_Flag
            // 
            this.text_Flag.Enabled = false;
            this.text_Flag.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Flag.Location = new System.Drawing.Point(280, 2);
            this.text_Flag.Name = "text_Flag";
            this.text_Flag.Size = new System.Drawing.Size(54, 20);
            this.text_Flag.TabIndex = 6;
            this.text_Flag.Visible = false;
            this.text_Flag.TextChanged += new System.EventHandler(this.text_Flag_TextChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salir.Location = new System.Drawing.Point(665, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Cerrar";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // FRM_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(798, 504);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.DatosClientes);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.text_Flag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Categoria";
            this.Text = "Mantenimiento de Categoria";
            this.Load += new System.EventHandler(this.FRM_Categoria_Load);
            this.ListaClientes.ResumeLayout(false);
            this.ListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.DatosClientes.ResumeLayout(false);
            this.DatosClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ListaClientes;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Descripcion;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.GroupBox DatosClientes;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.TextBox text_Descripcion;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Flag;
        private System.Windows.Forms.Button btn_salir;
    }
}