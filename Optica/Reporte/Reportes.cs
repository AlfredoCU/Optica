using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optica.Reporte
{
    public partial class Reportes : Form
    {
        private int idCompra;
        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.reporteFacturaCompra' Puede moverla o quitarla según sea necesario.
            try
            {
                this.reporteFacturaCompraTableAdapter.Fill(this.dsPrincipal.reporteFacturaCompra, idCompra);
                this.rvReporte.RefreshReport();
            }
            catch
            {
                this.rvReporte.RefreshReport();
            }
        }
    }
}
