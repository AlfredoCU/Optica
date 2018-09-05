namespace Optica.Reporte
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.reporteFacturaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new Optica.Reporte.dsPrincipal();
            this.rvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteFacturaCompraTableAdapter = new Optica.Reporte.dsPrincipalTableAdapters.reporteFacturaCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFacturaCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteFacturaCompraBindingSource
            // 
            this.reporteFacturaCompraBindingSource.DataMember = "reporteFacturaCompra";
            this.reporteFacturaCompraBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvReporte
            // 
            this.rvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteFacturaCompraBindingSource;
            this.rvReporte.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReporte.LocalReport.ReportEmbeddedResource = "Optica.Reporte.ReporteCompra.rdlc";
            this.rvReporte.Location = new System.Drawing.Point(0, 0);
            this.rvReporte.Margin = new System.Windows.Forms.Padding(4);
            this.rvReporte.Name = "rvReporte";
            this.rvReporte.Size = new System.Drawing.Size(851, 394);
            this.rvReporte.TabIndex = 0;
            // 
            // reporteFacturaCompraTableAdapter
            // 
            this.reporteFacturaCompraTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(851, 394);
            this.Controls.Add(this.rvReporte);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteFacturaCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReporte;
        private System.Windows.Forms.BindingSource reporteFacturaCompraBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.reporteFacturaCompraTableAdapter reporteFacturaCompraTableAdapter;
    }
}