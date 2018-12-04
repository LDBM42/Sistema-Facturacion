namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_Auditoria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Auditoria = new System.Windows.Forms.DataGridView();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditorialogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSFacturacionDataSetAuditoria = new Sistema_de_Venta.dbSFacturacionDataSetAuditoria();
            this.BT_Cerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.auditoria_logTableAdapter = new Sistema_de_Venta.dbSFacturacionDataSetAuditoriaTableAdapters.auditoria_logTableAdapter();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.CMB_Buscar = new System.Windows.Forms.ComboBox();
            this.noencontrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Auditoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorialogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSFacturacionDataSetAuditoria)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Auditoria
            // 
            this.dgv_Auditoria.AllowUserToAddRows = false;
            this.dgv_Auditoria.AllowUserToDeleteRows = false;
            this.dgv_Auditoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Auditoria.AutoGenerateColumns = false;
            this.dgv_Auditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Auditoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgv_Auditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Auditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Auditoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaHoraDataGridViewTextBoxColumn,
            this.accionDataGridViewTextBoxColumn});
            this.dgv_Auditoria.DataSource = this.auditorialogBindingSource;
            this.dgv_Auditoria.Location = new System.Drawing.Point(328, 88);
            this.dgv_Auditoria.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_Auditoria.Name = "dgv_Auditoria";
            this.dgv_Auditoria.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Auditoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Auditoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv_Auditoria.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Auditoria.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dgv_Auditoria.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgv_Auditoria.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgv_Auditoria.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Auditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Auditoria.Size = new System.Drawing.Size(937, 460);
            this.dgv_Auditoria.TabIndex = 3;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.FillWeight = 33F;
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraDataGridViewTextBoxColumn
            // 
            this.fechaHoraDataGridViewTextBoxColumn.DataPropertyName = "fechaHora";
            this.fechaHoraDataGridViewTextBoxColumn.FillWeight = 33F;
            this.fechaHoraDataGridViewTextBoxColumn.HeaderText = "Fecha y Hora";
            this.fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            this.fechaHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accionDataGridViewTextBoxColumn
            // 
            this.accionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accionDataGridViewTextBoxColumn.DataPropertyName = "Accion";
            this.accionDataGridViewTextBoxColumn.FillWeight = 33F;
            this.accionDataGridViewTextBoxColumn.HeaderText = "Acción";
            this.accionDataGridViewTextBoxColumn.Name = "accionDataGridViewTextBoxColumn";
            this.accionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auditorialogBindingSource
            // 
            this.auditorialogBindingSource.DataMember = "auditoria_log";
            this.auditorialogBindingSource.DataSource = this.dbSFacturacionDataSetAuditoria;
            // 
            // dbSFacturacionDataSetAuditoria
            // 
            this.dbSFacturacionDataSetAuditoria.DataSetName = "dbSFacturacionDataSetAuditoria";
            this.dbSFacturacionDataSetAuditoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BT_Cerrar
            // 
            this.BT_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.BT_Cerrar.FlatAppearance.BorderSize = 0;
            this.BT_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_Cerrar.ForeColor = System.Drawing.Color.White;
            this.BT_Cerrar.Location = new System.Drawing.Point(328, 545);
            this.BT_Cerrar.Margin = new System.Windows.Forms.Padding(5);
            this.BT_Cerrar.Name = "BT_Cerrar";
            this.BT_Cerrar.Size = new System.Drawing.Size(937, 46);
            this.BT_Cerrar.TabIndex = 2;
            this.BT_Cerrar.Text = "Cerrar";
            this.BT_Cerrar.UseVisualStyleBackColor = false;
            this.BT_Cerrar.Click += new System.EventHandler(this.BT_Cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(50, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 536);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_de_Venta.Properties.Resources.icons8_letra_pequeña_100;
            this.pictureBox2.Location = new System.Drawing.Point(0, 172);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 364);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Venta.Properties.Resources.MiEmpresaFicticiaLOGO__peq_;
            this.pictureBox1.Location = new System.Drawing.Point(2, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // auditoria_logTableAdapter
            // 
            this.auditoria_logTableAdapter.ClearBeforeFill = true;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(506, 55);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(759, 24);
            this.Buscar.TabIndex = 1;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // CMB_Buscar
            // 
            this.CMB_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Buscar.FormattingEnabled = true;
            this.CMB_Buscar.Items.AddRange(new object[] {
            "Usuario",
            "Acción"});
            this.CMB_Buscar.Location = new System.Drawing.Point(328, 54);
            this.CMB_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(170, 26);
            this.CMB_Buscar.TabIndex = 0;
            // 
            // noencontrado
            // 
            this.noencontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noencontrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.noencontrado.ForeColor = System.Drawing.Color.White;
            this.noencontrado.Location = new System.Drawing.Point(328, 117);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(937, 431);
            this.noencontrado.TabIndex = 4;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            this.noencontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noencontrado.Visible = false;
            // 
            // FRM_Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1318, 638);
            this.ControlBox = false;
            this.Controls.Add(this.noencontrado);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.CMB_Buscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_Cerrar);
            this.Controls.Add(this.dgv_Auditoria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_Auditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Auditoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Auditoria_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Auditoria_Load);
            this.Enter += new System.EventHandler(this.FRM_Auditoria_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Auditoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorialogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSFacturacionDataSetAuditoria)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Auditoria;
        private System.Windows.Forms.Button BT_Cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbSFacturacionDataSetAuditoria dbSFacturacionDataSetAuditoria;
        private System.Windows.Forms.BindingSource auditorialogBindingSource;
        private dbSFacturacionDataSetAuditoriaTableAdapters.auditoria_logTableAdapter auditoria_logTableAdapter;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Buscar;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
    }
}