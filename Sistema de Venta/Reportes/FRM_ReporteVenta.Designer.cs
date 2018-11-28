namespace Sistema_de_Venta
{
    partial class FRM_ReporteVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ReporteVenta));
            this.usp_Reportes_GenrerarReporteVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Sistema_de_Venta.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_Reportes_GenrerarReporteVentaTableAdapter = new Sistema_de_Venta.DataSet2TableAdapters.usp_Reportes_GenrerarReporteVentaTableAdapter();
            this.pnl_factura = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Reportes_GenrerarReporteVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.pnl_factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // usp_Reportes_GenrerarReporteVentaBindingSource
            // 
            this.usp_Reportes_GenrerarReporteVentaBindingSource.DataMember = "usp_Reportes_GenrerarReporteVenta";
            this.usp_Reportes_GenrerarReporteVentaBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.usp_Reportes_GenrerarReporteVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Venta.Reportes.RptReporteVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(825, 785);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_Reportes_GenrerarReporteVentaTableAdapter
            // 
            this.usp_Reportes_GenrerarReporteVentaTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_factura
            // 
            this.pnl_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.pnl_factura.Controls.Add(this.btnClose);
            this.pnl_factura.Controls.Add(this.btnMinimize);
            this.pnl_factura.Controls.Add(this.lbl_Login);
            this.pnl_factura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_factura.Location = new System.Drawing.Point(0, 0);
            this.pnl_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_factura.Name = "pnl_factura";
            this.pnl_factura.Size = new System.Drawing.Size(825, 48);
            this.pnl_factura.TabIndex = 2;
            this.pnl_factura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_factura_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Sistema_de_Venta.Properties.Resources.close_white;
            this.btnClose.Location = new System.Drawing.Point(772, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 37);
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
            this.btnMinimize.Location = new System.Drawing.Point(727, 6);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 37);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.White;
            this.lbl_Login.Location = new System.Drawing.Point(326, 5);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(173, 38);
            this.lbl_Login.TabIndex = 9;
            this.lbl_Login.Text = "FACTURA";
            // 
            // FRM_ReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(825, 833);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnl_factura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(825, 500);
            this.Name = "FRM_ReporteVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FRM_ReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_Reportes_GenrerarReporteVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.pnl_factura.ResumeLayout(false);
            this.pnl_factura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_Reportes_GenrerarReporteVentaBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.usp_Reportes_GenrerarReporteVentaTableAdapter usp_Reportes_GenrerarReporteVentaTableAdapter;
        private System.Windows.Forms.Panel pnl_factura;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label lbl_Login;
    }
}