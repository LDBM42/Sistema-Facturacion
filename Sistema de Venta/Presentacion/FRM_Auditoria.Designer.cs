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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_Cerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dbSFacturacionDataSetAuditoria = new Sistema_de_Venta.dbSFacturacionDataSetAuditoria();
            this.auditorialogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditoria_logTableAdapter = new Sistema_de_Venta.dbSFacturacionDataSetAuditoriaTableAdapters.auditoria_logTableAdapter();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSFacturacionDataSetAuditoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorialogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaHoraDataGridViewTextBoxColumn,
            this.accionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.auditorialogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(206, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // BT_Cerrar
            // 
            this.BT_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.BT_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_Cerrar.Location = new System.Drawing.Point(206, 430);
            this.BT_Cerrar.Name = "BT_Cerrar";
            this.BT_Cerrar.Size = new System.Drawing.Size(764, 55);
            this.BT_Cerrar.TabIndex = 1;
            this.BT_Cerrar.Text = "Cerrar";
            this.BT_Cerrar.UseVisualStyleBackColor = false;
            this.BT_Cerrar.Click += new System.EventHandler(this.BT_Cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 473);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_de_Venta.Properties.Resources.ProductosBig;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Venta.Properties.Resources.MiEmpresaFicticiaLOGO__peq_;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dbSFacturacionDataSetAuditoria
            // 
            this.dbSFacturacionDataSetAuditoria.DataSetName = "dbSFacturacionDataSetAuditoria";
            this.dbSFacturacionDataSetAuditoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditorialogBindingSource
            // 
            this.auditorialogBindingSource.DataMember = "auditoria_log";
            this.auditorialogBindingSource.DataSource = this.dbSFacturacionDataSetAuditoria;
            // 
            // auditoria_logTableAdapter
            // 
            this.auditoria_logTableAdapter.ClearBeforeFill = true;
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
            this.fechaHoraDataGridViewTextBoxColumn.HeaderText = "fechaHora";
            this.fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            this.fechaHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accionDataGridViewTextBoxColumn
            // 
            this.accionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accionDataGridViewTextBoxColumn.DataPropertyName = "Accion";
            this.accionDataGridViewTextBoxColumn.FillWeight = 33F;
            this.accionDataGridViewTextBoxColumn.HeaderText = "Accion";
            this.accionDataGridViewTextBoxColumn.Name = "accionDataGridViewTextBoxColumn";
            this.accionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FRM_Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 497);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_Cerrar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Auditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Auditoria";
            this.Load += new System.EventHandler(this.FRM_Auditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSFacturacionDataSetAuditoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorialogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BT_Cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbSFacturacionDataSetAuditoria dbSFacturacionDataSetAuditoria;
        private System.Windows.Forms.BindingSource auditorialogBindingSource;
        private dbSFacturacionDataSetAuditoriaTableAdapters.auditoria_logTableAdapter auditoria_logTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
    }
}