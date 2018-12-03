namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Factura));
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.pnl_factura = new System.Windows.Forms.Panel();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.lab_desactivarTipo = new System.Windows.Forms.Label();
            this.cmb_TipoFactura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FechaFactura = new System.Windows.Forms.DateTimePicker();
            this.Pnl_Buscar = new System.Windows.Forms.Panel();
            this.pbx_BuscarUp = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pbx_ChevronRight = new System.Windows.Forms.PictureBox();
            this.pbx_ChevronLeft = new System.Windows.Forms.PictureBox();
            this.ckb_desactivarFecha = new System.Windows.Forms.CheckBox();
            this.ckb_desactivarTipo = new System.Windows.Forms.CheckBox();
            this.tmr_Buscar = new System.Windows.Forms.Timer(this.components);
            this.tmr_BuscarHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.pnl_factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.Pnl_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BuscarUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ChevronRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ChevronLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(0, 55);
            this.axAcroPDF.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(1523, 669);
            this.axAcroPDF.TabIndex = 1;
            // 
            // pnl_factura
            // 
            this.pnl_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.pnl_factura.Controls.Add(this.lbl_Login);
            this.pnl_factura.Controls.Add(this.btnClose);
            this.pnl_factura.Controls.Add(this.btnMinimize);
            this.pnl_factura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_factura.Location = new System.Drawing.Point(0, 0);
            this.pnl_factura.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_factura.Name = "pnl_factura";
            this.pnl_factura.Size = new System.Drawing.Size(1523, 55);
            this.pnl_factura.TabIndex = 24;
            // 
            // lbl_Login
            // 
            this.lbl_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.White;
            this.lbl_Login.Location = new System.Drawing.Point(672, 11);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(166, 32);
            this.lbl_Login.TabIndex = 12;
            this.lbl_Login.Text = "FACTURAS";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Sistema_de_Venta.Properties.Resources.close_white;
            this.btnClose.Location = new System.Drawing.Point(1477, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::Sistema_de_Venta.Properties.Resources.minimize_white;
            this.btnMinimize.Location = new System.Drawing.Point(1441, 12);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lab_desactivarTipo
            // 
            this.lab_desactivarTipo.AutoSize = true;
            this.lab_desactivarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_desactivarTipo.ForeColor = System.Drawing.Color.White;
            this.lab_desactivarTipo.Location = new System.Drawing.Point(35, 50);
            this.lab_desactivarTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_desactivarTipo.Name = "lab_desactivarTipo";
            this.lab_desactivarTipo.Size = new System.Drawing.Size(56, 25);
            this.lab_desactivarTipo.TabIndex = 25;
            this.lab_desactivarTipo.Text = "Tipo ";
            // 
            // cmb_TipoFactura
            // 
            this.cmb_TipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_TipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TipoFactura.FormattingEnabled = true;
            this.cmb_TipoFactura.Items.AddRange(new object[] {
            "Consumidor Final",
            "Crédito Fiscal"});
            this.cmb_TipoFactura.Location = new System.Drawing.Point(35, 83);
            this.cmb_TipoFactura.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_TipoFactura.Name = "cmb_TipoFactura";
            this.cmb_TipoFactura.Size = new System.Drawing.Size(184, 28);
            this.cmb_TipoFactura.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha";
            // 
            // dtp_FechaFactura
            // 
            this.dtp_FechaFactura.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_FechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaFactura.Location = new System.Drawing.Point(35, 153);
            this.dtp_FechaFactura.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_FechaFactura.Name = "dtp_FechaFactura";
            this.dtp_FechaFactura.Size = new System.Drawing.Size(184, 28);
            this.dtp_FechaFactura.TabIndex = 23;
            this.dtp_FechaFactura.Value = new System.DateTime(2018, 12, 1, 22, 57, 39, 0);
            // 
            // Pnl_Buscar
            // 
            this.Pnl_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Buscar.Controls.Add(this.pbx_BuscarUp);
            this.Pnl_Buscar.Controls.Add(this.btn_buscar);
            this.Pnl_Buscar.Controls.Add(this.pbx_ChevronRight);
            this.Pnl_Buscar.Controls.Add(this.pbx_ChevronLeft);
            this.Pnl_Buscar.Controls.Add(this.ckb_desactivarFecha);
            this.Pnl_Buscar.Controls.Add(this.ckb_desactivarTipo);
            this.Pnl_Buscar.Controls.Add(this.dtp_FechaFactura);
            this.Pnl_Buscar.Controls.Add(this.label2);
            this.Pnl_Buscar.Controls.Add(this.cmb_TipoFactura);
            this.Pnl_Buscar.Controls.Add(this.lab_desactivarTipo);
            this.Pnl_Buscar.Location = new System.Drawing.Point(0, 55);
            this.Pnl_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_Buscar.Name = "Pnl_Buscar";
            this.Pnl_Buscar.Size = new System.Drawing.Size(70, 50);
            this.Pnl_Buscar.TabIndex = 28;
            this.Pnl_Buscar.MouseEnter += new System.EventHandler(this.Pnl_Buscar_MouseEnter);
            // 
            // pbx_BuscarUp
            // 
            this.pbx_BuscarUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_BuscarUp.Image = global::Sistema_de_Venta.Properties.Resources.search_On_50;
            this.pbx_BuscarUp.Location = new System.Drawing.Point(7, 9);
            this.pbx_BuscarUp.Name = "pbx_BuscarUp";
            this.pbx_BuscarUp.Size = new System.Drawing.Size(38, 33);
            this.pbx_BuscarUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_BuscarUp.TabIndex = 33;
            this.pbx_BuscarUp.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = global::Sistema_de_Venta.Properties.Resources.search_On_50;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(35, 213);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_buscar.Size = new System.Drawing.Size(218, 34);
            this.btn_buscar.TabIndex = 27;
            this.btn_buscar.Text = "Buscar      ";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbx_ChevronRight
            // 
            this.pbx_ChevronRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_ChevronRight.Image = global::Sistema_de_Venta.Properties.Resources.chebrón_hacia_la_derecha;
            this.pbx_ChevronRight.Location = new System.Drawing.Point(39, 15);
            this.pbx_ChevronRight.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_ChevronRight.Name = "pbx_ChevronRight";
            this.pbx_ChevronRight.Size = new System.Drawing.Size(20, 20);
            this.pbx_ChevronRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_ChevronRight.TabIndex = 31;
            this.pbx_ChevronRight.TabStop = false;
            // 
            // pbx_ChevronLeft
            // 
            this.pbx_ChevronLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_ChevronLeft.Image = global::Sistema_de_Venta.Properties.Resources.chebrón_hacia_la_izq;
            this.pbx_ChevronLeft.Location = new System.Drawing.Point(39, 15);
            this.pbx_ChevronLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_ChevronLeft.Name = "pbx_ChevronLeft";
            this.pbx_ChevronLeft.Size = new System.Drawing.Size(20, 20);
            this.pbx_ChevronLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_ChevronLeft.TabIndex = 32;
            this.pbx_ChevronLeft.TabStop = false;
            this.pbx_ChevronLeft.Visible = false;
            this.pbx_ChevronLeft.Click += new System.EventHandler(this.pbx_ChevronLeft_Click);
            // 
            // ckb_desactivarFecha
            // 
            this.ckb_desactivarFecha.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_desactivarFecha.AutoSize = true;
            this.ckb_desactivarFecha.BackColor = System.Drawing.Color.White;
            this.ckb_desactivarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_desactivarFecha.ForeColor = System.Drawing.Color.Black;
            this.ckb_desactivarFecha.Image = global::Sistema_de_Venta.Properties.Resources.unlocked_50;
            this.ckb_desactivarFecha.Location = new System.Drawing.Point(222, 150);
            this.ckb_desactivarFecha.Margin = new System.Windows.Forms.Padding(0);
            this.ckb_desactivarFecha.Name = "ckb_desactivarFecha";
            this.ckb_desactivarFecha.Size = new System.Drawing.Size(31, 31);
            this.ckb_desactivarFecha.TabIndex = 30;
            this.ckb_desactivarFecha.UseVisualStyleBackColor = false;
            this.ckb_desactivarFecha.CheckedChanged += new System.EventHandler(this.ckb_desactivarFecha_CheckedChanged);
            // 
            // ckb_desactivarTipo
            // 
            this.ckb_desactivarTipo.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_desactivarTipo.AutoSize = true;
            this.ckb_desactivarTipo.BackColor = System.Drawing.Color.White;
            this.ckb_desactivarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_desactivarTipo.ForeColor = System.Drawing.Color.Black;
            this.ckb_desactivarTipo.Image = global::Sistema_de_Venta.Properties.Resources.unlocked_50;
            this.ckb_desactivarTipo.Location = new System.Drawing.Point(222, 80);
            this.ckb_desactivarTipo.Margin = new System.Windows.Forms.Padding(0);
            this.ckb_desactivarTipo.Name = "ckb_desactivarTipo";
            this.ckb_desactivarTipo.Size = new System.Drawing.Size(31, 31);
            this.ckb_desactivarTipo.TabIndex = 29;
            this.ckb_desactivarTipo.UseVisualStyleBackColor = false;
            this.ckb_desactivarTipo.CheckedChanged += new System.EventHandler(this.ckb_desactivarTipo_CheckedChanged);
            // 
            // tmr_Buscar
            // 
            this.tmr_Buscar.Interval = 10;
            this.tmr_Buscar.Tick += new System.EventHandler(this.tmr_Buscar_Tick);
            // 
            // tmr_BuscarHide
            // 
            this.tmr_BuscarHide.Interval = 10;
            this.tmr_BuscarHide.Tick += new System.EventHandler(this.tmr_BuscarHide_Tick);
            // 
            // FRM_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1523, 724);
            this.Controls.Add(this.Pnl_Buscar);
            this.Controls.Add(this.axAcroPDF);
            this.Controls.Add(this.pnl_factura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Factura";
            this.Text = "FRM_Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.pnl_factura.ResumeLayout(false);
            this.pnl_factura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.Pnl_Buscar.ResumeLayout(false);
            this.Pnl_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BuscarUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ChevronRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ChevronLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.Panel pnl_factura;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label lab_desactivarTipo;
        private System.Windows.Forms.ComboBox cmb_TipoFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FechaFactura;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel Pnl_Buscar;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.CheckBox ckb_desactivarFecha;
        private System.Windows.Forms.CheckBox ckb_desactivarTipo;
        private System.Windows.Forms.PictureBox pbx_ChevronRight;
        private System.Windows.Forms.Timer tmr_Buscar;
        private System.Windows.Forms.PictureBox pbx_ChevronLeft;
        private System.Windows.Forms.Timer tmr_BuscarHide;
        private System.Windows.Forms.PictureBox pbx_BuscarUp;
    }
}