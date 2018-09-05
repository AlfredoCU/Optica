using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Optica.Pantallas;

namespace Optica
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GestionUsuario();
        }

        private void tsbEmpleado_Click(object sender, EventArgs e)
        {
            Empleados pantallaEmpleado = new Empleados();
            this.Hide();
            pantallaEmpleado.ShowDialog();
            this.Show();
        }

        private void tsbPaciente_Click(object sender, EventArgs e)
        {
            Pacientes pantallaPacientes = new Pacientes();
            this.Hide();
            pantallaPacientes.ShowDialog();
            this.Show();
        }

        private void tsbServicios_Click(object sender, EventArgs e)
        {
            Servicios pantallaServicios = new Servicios();
            this.Hide();
            pantallaServicios.ShowDialog();
            this.Show();
        }

        private void tsbOptica_Click(object sender, EventArgs e)
        {
            OpticaMisionVisionValores pantallaOptica = new OpticaMisionVisionValores();
            this.Hide();
            pantallaOptica.ShowDialog();
            this.Show();
        }

        private void tsbOInformacion_Click(object sender, EventArgs e)
        {
            Pantallas.OpticaInformacion pantallaInformacion = new Pantallas.OpticaInformacion();
            this.Hide();
            pantallaInformacion.ShowDialog();
            this.Show();
        }

        private void GestionUsuario()
        {
            if (txtAcceso.Text == "ADMINISTRADOR")
            {
                this.tsbEmpleado.Enabled = true;
                this.tsbPaciente.Enabled = true;
                this.tsbServicios.Enabled = true;
                this.tsbOptica.Enabled = true;
                this.tsbOInformacion.Enabled = true;
                this.pbInformacion.Enabled = true;
                this.tsbSalir.Enabled = true;
            }

            else if (txtAcceso.Text == "DOCTOR")
            {
                this.tsbEmpleado.Enabled = false;
                this.tsbPaciente.Enabled = true;
                this.tsbServicios.Enabled = false;
                this.tsbOptica.Enabled = true;
                this.tsbOInformacion.Enabled = true;
                this.pbInformacion.Enabled = true;
                this.tsbSalir.Enabled = true;
            }

            else if (txtAcceso.Text == "ASISTENTES")
            {
                this.tsbEmpleado.Enabled = false;
                this.tsbPaciente.Enabled = false;
                this.tsbServicios.Enabled = true;
                this.tsbOptica.Enabled = true;
                this.tsbOInformacion.Enabled = true;
                this.pbInformacion.Enabled = true;
                this.tsbSalir.Enabled = true;
            }

            else
            {
                //Si en algun momento se debe de validar algo más.
            }
        }

        private void pbInformacion_Click(object sender, EventArgs e)
        {
            string mensaje = "Este sistema esta creado por ArdComputer y MyComputer.\n\nProgramador: Alfredo CU\n\nVersión: 1.0";
            MessageBox.Show(mensaje, "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Quiere Regresar al login?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}