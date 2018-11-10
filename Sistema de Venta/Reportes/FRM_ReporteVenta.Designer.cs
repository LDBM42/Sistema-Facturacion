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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textVentaId = new System.Windows.Forms.TextBox();
            this.usp_Reportes_GeneralReporteVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new Sistema_de_Venta.DataSetPrincipal();
            this.usp_Reportes_GeneralReporteVentaTableAdapter = new Sistema_de_Venta.DataSetPrincipalTableAdapters.usp_Reportes_GeneralReporteVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Reportes_GeneralReporteVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usp_Reportes_GeneralReporteVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Venta.Reportes.RPT_ReporteVenra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1014, 498);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // textVentaId
            // 
            this.textVentaId.Location = new System.Drawing.Point(776, 67);
            this.textVentaId.Name = "textVentaId";
            this.textVentaId.Size = new System.Drawing.Size(100, 20);
            this.textVentaId.TabIndex = 1;
            this.textVentaId.Visible = false;
            this.textVentaId.TextChanged += new System.EventHandler(this.textVentaId_TextChanged);
            // 
            // usp_Reportes_GeneralReporteVentaBindingSource
            // 
            this.usp_Reportes_GeneralReporteVentaBindingSource.DataMember = "usp_Reportes_GeneralReporteVenta";
            this.usp_Reportes_GeneralReporteVentaBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_Reportes_GeneralReporteVentaTableAdapter
            // 
            this.usp_Reportes_GeneralReporteVentaTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_ReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 498);
            this.Controls.Add(this.textVentaId);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_ReporteVenta";
            this.Text = "FRM_ReporteVenta";
            this.Load += new System.EventHandler(this.FRM_ReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_Reportes_GeneralReporteVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_Reportes_GeneralReporteVentaBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.usp_Reportes_GeneralReporteVentaTableAdapter usp_Reportes_GeneralReporteVentaTableAdapter;
        private System.Windows.Forms.TextBox textVentaId;
    }
}