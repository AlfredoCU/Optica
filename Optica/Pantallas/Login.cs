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
using Optica.Clases;

namespace Optica
{
    public partial class Login : Form
    {
        Main m = new Main();
        Doctor d = new Doctor("Conexión");
        Asistente a = new Asistente("Conexión");

        public Login()
        {
            InitializeComponent();
            cbAcceso.Items.Clear();
            cbAcceso.Items.Add("ADMINISTRADOR");
            cbAcceso.Items.Add("DOCTOR");
            cbAcceso.Items.Add("ASISTENTES");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(cbAcceso.SelectedIndex == 0)
            {
                m.txtAcceso.Text = cbAcceso.Text;
                if (txtUsuario.Text == "admin7" && txtContrasena.Text == "212")
                {
                    Conexion c = new Conexion();
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son erróneos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtUsuario.Clear();
                txtContrasena.Clear();
            }

            else if(cbAcceso.SelectedIndex == 1)
            {
                m.txtAcceso.Text = cbAcceso.Text;
                if (d.logear(this.txtUsuario.Text, this.txtContrasena.Text))
                {
                    Conexion c = new Conexion();
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son erróneos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtUsuario.Clear();
                txtContrasena.Clear();
            }

            else if(cbAcceso.SelectedIndex == 2)
            {
                m.txtAcceso.Text = cbAcceso.Text;
                if (a.logear(this.txtUsuario.Text, this.txtContrasena.Text))
                {
                    Conexion c = new Conexion();
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son erróneos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtUsuario.Clear();
                txtContrasena.Clear();
            }

            else
            {
                //Si en algun momento se debe de validar algo más.
            } 
        }

        private void pbAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si necesita ayuda con la aplicación contacte con el Administrador.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Quiere salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            } 
        }
    }
}