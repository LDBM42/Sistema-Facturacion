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
            this.txtVentaId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Reportes_GenrerarReporteVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
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
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1050, 750);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_Reportes_GenrerarReporteVentaTableAdapter
            // 
            this.usp_Reportes_GenrerarReporteVentaTableAdapter.ClearBeforeFill = true;
            // 
            // txtVentaId
            // 
            this.txtVentaId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVentaId.Location = new System.Drawing.Point(30, 86);
            this.txtVentaId.Name = "txtVentaId";
            this.txtVentaId.Size = new System.Drawing.Size(992, 22);
            this.txtVentaId.TabIndex = 1;
            this.txtVentaId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVentaId.Visible = false;
            // 
            // FRM_ReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 750);
            this.Controls.Add(this.txtVentaId);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 500);
            this.Name = "FRM_ReporteVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FRM_ReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_Reportes_GenrerarReporteVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_Reportes_GenrerarReporteVentaBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.usp_Reportes_GenrerarReporteVentaTableAdapter usp_Reportes_GenrerarReporteVentaTableAdapter;
        private System.Windows.Forms.TextBox txtVentaId;
    }
}