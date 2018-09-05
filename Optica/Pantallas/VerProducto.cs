using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Optica.Clases;

namespace Optica.Pantallas
{
    public partial class VerProducto : Form
    {
        Producto pro = new Producto("Sí hay conexión");

        public int idProducto;
        public string nomProducto;
        public float cosProducto;

        public delegate void enviarIdP(string id);
        public event enviarIdP enviadoIdP;

        public delegate void enviarNomP(string nom);
        public event enviarNomP enviadoNomP;

        public delegate void enviarCosP(string cos);
        public event enviarCosP enviadoCosP;

        public VerProducto()
        {
            InitializeComponent();
        }

        private void VerProducto_Load(object sender, EventArgs e)
        {
            pro.CargarProductoVer(dgvTablaVerProducto);
        }

        private void dgvTablaVerProducto_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgvTablaVerProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Evita que si por error el usuario da click en el encabezado no truene el programa por ser -1.
            {
                idProducto = Convert.ToInt32(dgvTablaVerProducto.Rows[e.RowIndex].Cells["Id Producto"].Value.ToString());
                nomProducto = dgvTablaVerProducto.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                cosProducto = Convert.ToSingle(dgvTablaVerProducto.Rows[e.RowIndex].Cells["Costo"].Value.ToString());
            }
        }

        private bool BuscarProductoVer()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarProductoVer.Text);
        }

        private void txtBuscarProductoVer_TextChanged(object sender, EventArgs e)
        {
            if (BuscarProductoVer())
            {
                this.txtBuscarProductoVer.BackColor = Color.White;
                if (txtBuscarProductoVer.Text != " ")
                {
                    dgvTablaVerProducto.DataSource = pro.BuscarProducto(txtBuscarProductoVer.Text);
                }
            }
            else
            {
                this.txtBuscarProductoVer.BackColor = Color.Red;
                pro.CargarProductoVer(dgvTablaVerProducto);
            }
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            txtValidar.Text = nomProducto;
            if (txtValidar.Text == "")
            {
                MessageBox.Show("Seleccione una fila para elegir a un paciente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                enviadoIdP(Convert.ToString(idProducto));
                enviadoNomP(nomProducto);
                enviadoCosP(Convert.ToString(cosProducto));
                this.Hide();
            }
        }

        private void btnRegresarVerPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}