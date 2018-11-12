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
            this.label2 = new System.Windows.Forms.Label();
            this.ListaClientes = new System.Windows.Forms.GroupBox();
            this.DatosClientes = new System.Windows.Forms.GroupBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.ListaClientes.SuspendLayout();
            this.DatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_liminar
            // 
            this.BT_liminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_liminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_liminar.Location = new System.Drawing.Point(28, 649);
            this.BT_liminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_liminar.Name = "BT_liminar";
            this.BT_liminar.Size = new System.Drawing.Size(112, 35);
            this.BT_liminar.TabIndex = 12;
            this.BT_liminar.Text = "Eliminar";
            this.BT_liminar.UseVisualStyleBackColor = false;
            this.BT_liminar.Click += new System.EventHandler(this.BT_liminar_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(262, 549);
            this.Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(112, 35);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardar.Location = new System.Drawing.Point(141, 505);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(112, 35);
            this.Guardar.TabIndex = 13;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar.Location = new System.Drawing.Point(262, 505);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(112, 35);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevo.Location = new System.Drawing.Point(141, 549);
            this.Nuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(112, 35);
            this.Nuevo.TabIndex = 11;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // text_Direccion
            // 
            this.text_Direccion.Location = new System.Drawing.Point(134, 252);
            this.text_Direccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Direccion.Name = "text_Direccion";
            this.text_Direccion.Size = new System.Drawing.Size(298, 28);
            this.text_Direccion.TabIndex = 10;
            // 
            // text_Telefono
            // 
            this.text_Telefono.Location = new System.Drawing.Point(134, 298);
            this.text_Telefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Telefono.Name = "text_Telefono";
            this.text_Telefono.Size = new System.Drawing.Size(298, 28);
            this.text_Telefono.TabIndex = 9;
            this.text_Telefono.Text = " ";
            // 
            // text_DNI
            // 
            this.text_DNI.Location = new System.Drawing.Point(134, 206);
            this.text_DNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_DNI.Name = "text_DNI";
            this.text_DNI.Size = new System.Drawing.Size(298, 28);
            this.text_DNI.TabIndex = 8;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(224, 69);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(781, 28);
            this.Buscar.TabIndex = 2;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // CMB_Buscar
            // 
            this.CMB_Buscar.FormattingEnabled = true;
            this.CMB_Buscar.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "DNI",
            "Telefono",
            "Domicilio"});
            this.CMB_Buscar.Location = new System.Drawing.Point(28, 69);
            this.CMB_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(180, 30);
            this.CMB_Buscar.TabIndex = 1;
            this.CMB_Buscar.Text = "Nombre";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvUsuarios.Location = new System.Drawing.Point(9, 138);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(998, 468);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 88;
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(134, 114);
            this.text_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(298, 28);
            this.text_Nombre.TabIndex = 7;
            // 
            // text_Apellido
            // 
            this.text_Apellido.Location = new System.Drawing.Point(134, 160);
            this.text_Apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Apellido.Name = "text_Apellido";
            this.text_Apellido.Size = new System.Drawing.Size(298, 28);
            this.text_Apellido.TabIndex = 7;
            // 
            // text_Id
            // 
            this.text_Id.Enabled = false;
            this.text_Id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Id.Location = new System.Drawing.Point(130, 51);
            this.text_Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(121, 28);
            this.text_Id.TabIndex = 6;
            this.text_Id.TextChanged += new System.EventHandler(this.text_Id_TextChanged);
            // 
            // noencontrado
            // 
            this.noencontrado.AutoSize = true;
            this.noencontrado.Location = new System.Drawing.Point(339, 360);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(285, 22);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // ListaClientes
            // 
            this.ListaClientes.Controls.Add(this.BT_liminar);
            this.ListaClientes.Controls.Add(this.noencontrado);
            this.ListaClientes.Controls.Add(this.Buscar);
            this.ListaClientes.Controls.Add(this.CMB_Buscar);
            this.ListaClientes.Controls.Add(this.dgvUsuarios);
            this.ListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListaClientes.Location = new System.Drawing.Point(723, 83);
            this.ListaClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListaClientes.Size = new System.Drawing.Size(1032, 694);
            this.ListaClientes.TabIndex = 8;
            this.ListaClientes.TabStop = false;
            this.ListaClientes.Text = "Listado de Usuarios";
            // 
            // DatosClientes
            // 
            this.DatosClientes.Controls.Add(this.cbxTipo);
            this.DatosClientes.Controls.Add(this.txtFlag);
            this.DatosClientes.Controls.Add(this.Editar);
            this.DatosClientes.Controls.Add(this.Guardar);
            this.DatosClientes.Controls.Add(this.label9);
            this.DatosClientes.Controls.Add(this.label8);
            this.DatosClientes.Controls.Add(this.Cancelar);
            this.DatosClientes.Controls.Add(this.label1);
            this.DatosClientes.Controls.Add(this.Nuevo);
            this.DatosClientes.Controls.Add(this.txtPassword);
            this.DatosClientes.Controls.Add(this.text_Direccion);
            this.DatosClientes.Controls.Add(this.txtUsuario);
            this.DatosClientes.Controls.Add(this.text_Telefono);
            this.DatosClientes.Controls.Add(this.text_DNI);
            this.DatosClientes.Controls.Add(this.text_Nombre);
            this.DatosClientes.Controls.Add(this.text_Apellido);
            this.DatosClientes.Controls.Add(this.text_Id);
            this.DatosClientes.Controls.Add(this.label5);
            this.DatosClientes.Controls.Add(this.label6);
            this.DatosClientes.Controls.Add(this.label7);
            this.DatosClientes.Controls.Add(this.label4);
            this.DatosClientes.Controls.Add(this.label3);
            this.DatosClientes.Controls.Add(this.label2);
            this.DatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosClientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatosClientes.Location = new System.Drawing.Point(57, 83);
            this.DatosClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatosClientes.Size = new System.Drawing.Size(561, 694);
            this.DatosClientes.TabIndex = 7;
            this.DatosClientes.TabStop = false;
            this.DatosClientes.Text = "Datos de Usuario";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Admin",
            "Empleado"});
            this.cbxTipo.Location = new System.Drawing.Point(130, 443);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(301, 30);
            this.cbxTipo.TabIndex = 16;
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(460, 51);
            this.txtFlag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(70, 28);
            this.txtFlag.TabIndex = 12;
            this.txtFlag.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(9, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(10, 448);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(134, 395);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(298, 30);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(134, 348);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0, 5, 4, 5);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(298, 29);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // FRM_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1820, 834);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.DatosClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.FRM_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ListaClientes.ResumeLayout(false);
            this.ListaClientes.PerformLayout();
            this.DatosClientes.ResumeLayout(false);
            this.DatosClientes.PerformLayout();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox text_Apellido;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ListaClientes;
        private System.Windows.Forms.GroupBox DatosClientes;
        private System.Windows.Forms.TextBox txtFlag;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label9;
    }
}