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
    public partial class VerPacientes : Form
    {
        Paciente p = new Paciente("Sí hay conexión");

        public int idPaciente;
        public delegate void enviar(string id);
        public event enviar enviado;

        public VerPacientes()
        {
            InitializeComponent();
        }

        private void VerPacientes_Load(object sender, EventArgs e)
        {
            p.CargarPaciente(dgvTablaVerPaciente);
            dgvTablaVerPaciente.Columns[1].HeaderText = "Nombre(s)";
            dgvTablaVerPaciente.Columns[2].HeaderText = "Apellido(s)";
            dgvTablaVerPaciente.Columns[5].HeaderText = "Teléfono";
            dgvTablaVerPaciente.Columns[6].HeaderText = "Dirección";
        }

        private void dgvTablaVerPaciente_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        //Se desactivo el evento RowHeadersVisible que es la barra que viene por defecto en la parte izquierda.
        //Ya que si se selecciona todas las tuplas tendremos un error.
        private void dgvTablaVerPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) //Evita que si por error el usuario da click en el encabezado no truene el programa por ser -1.
            {
                idPaciente = Convert.ToInt32(dgvTablaVerPaciente.Rows[e.RowIndex].Cells["Id Paciente"].Value.ToString());
            }
        }

        private bool BuscarNombrePacienteVer()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombreVer.Text);
        }

        private void txtBuscarNombreVer_TextChanged(object sender, EventArgs e)
        {
            if (BuscarNombrePacienteVer())
            {
                this.txtBuscarNombreVer.BackColor = Color.White;
                if (txtBuscarNombreVer.Text != " ")
                {
                    dgvTablaVerPaciente.DataSource = p.BuscarPaciente(txtBuscarNombreVer.Text);
                }
            }
            else
            {
                this.txtBuscarNombreVer.BackColor = Color.Red;
                p.CargarPaciente(dgvTablaVerPaciente);
            }
        }

        private void btnSeleccionarPaciente_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(idPaciente) == "0")
            {
                MessageBox.Show("Seleccione una fila para elegir a un paciente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                enviado(Convert.ToString(idPaciente));
                this.Hide();
            }
        }

        private void btnRegresarVerPac_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}