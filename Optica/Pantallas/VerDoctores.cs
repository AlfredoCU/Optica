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
    public partial class VerDoctores : Form
    {
        Doctor d = new Doctor("Sí hay Conexión");

        public int idDoctor;
        public delegate void enviar(string id);
        public event enviar enviado;
              
        public VerDoctores()
        {
            InitializeComponent();
        }

        private void VerDoctores_Load(object sender, EventArgs e)
        {
            d.CargarDoctoresVer(dgvTablaVerDoctor);
            dgvTablaVerDoctor.Columns[1].HeaderText = "Nombre(s)";
            dgvTablaVerDoctor.Columns[2].HeaderText = "Apellido(s)";
        }

        private void dgvTablaVerDoctor_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        //Se desactivo el evento RowHeadersVisible que es la barra que viene por defecto en la parte izquierda.
        //Ya que si se selecciona todas las tuplas tendremos un error.
        private void dgvTablaVerDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Evita que si por error el usuario da click en el encabezado no truene el programa por ser -1.
            {
                idDoctor = Convert.ToInt32(dgvTablaVerDoctor.Rows[e.RowIndex].Cells["Id Doctor"].Value.ToString());
            }
        }

        private bool BuscarNombreDoctorVer()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombreVer.Text);
        }

        private void txtBuscarNombreVer_TextChanged(object sender, EventArgs e)
        {
            if (BuscarNombreDoctorVer())
            {
                this.txtBuscarNombreVer.BackColor = Color.White;
                if (txtBuscarNombreVer.Text != " ")
                {
                    dgvTablaVerDoctor.DataSource = d.BuscarDoctor(txtBuscarNombreVer.Text);
                }
            }
            else
            {
                this.txtBuscarNombreVer.BackColor = Color.Red;
                d.CargarDoctoresVer(dgvTablaVerDoctor);
            }
        }

        private void btnSeleccionarDoctor_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(idDoctor) == "0")
            {
                MessageBox.Show("Seleccione una fila para elegir a un paciente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                enviado(Convert.ToString(idDoctor));
                this.Hide();
            }
        }

        private void btnRegresarVerDoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}