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
    public partial class Empleados : Form
    {
        Doctor c = new Doctor("Sí hay conexión");
        Asistente a = new Asistente("Sí hay conexión");
        Validar v = new Validar();

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            this.rbtRegistrarDoctor.Checked = true;
            this.rbtRegirstrarAsistente.Checked = true;
            EdadDoctor();
            EdadAsistente();

            c.CargarDoctores(dgvTablaDoctores);
            dgvTablaDoctores.Columns[1].HeaderText = "Nombre(s)";
            dgvTablaDoctores.Columns[2].HeaderText = "Apellido(s)";
            dgvTablaDoctores.Columns[4].HeaderText = "Dirección";
            dgvTablaDoctores.Columns[5].HeaderText = "Teléfono";
            dgvTablaDoctores.Columns[11].HeaderText = "Contraseña";

            c.CargarUsuarioDoctor(dgvUsuarioDoctor);
            dgvUsuarioDoctor.Columns[3].HeaderText = "Contraseña";

            a.CargarAsistentes(dgvTablaAsistentes);
            dgvTablaAsistentes.Columns[1].HeaderText = "Nombre(s)";
            dgvTablaAsistentes.Columns[2].HeaderText = "Apellido(s)";
            dgvTablaAsistentes.Columns[5].HeaderText = "Teléfono";
            dgvTablaAsistentes.Columns[6].HeaderText = "Dirección";
            dgvTablaAsistentes.Columns[10].HeaderText = "Contraseña";

            a.CargarUsuarioAsistente(dgvUsuarioAsistente);
            dgvUsuarioAsistente.Columns[3].HeaderText = "Contraseña";
        }

        //Método de limpieza de txt.
        private void LimpiezaDoctorTxt()
        {
            this.txtIdDoctor.Clear();
            this.txtNombreDoctor.Clear();
            this.txtApellidoDoctor.Clear();
            this.cbEdadDoctor.SelectedIndex = -1;
            this.txtDireccionDoctor.Clear();
            this.txtTelefonoDoctor.Clear();
            this.txtMatriculaDoctor.Clear();
            this.txtEspecialidadDoctor.Clear();
            this.txtModificarIdDoctor.Clear();
            this.txtEliminarIdDoctor.Clear();
            this.txtBuscarNombreDoctor.Clear();
            this.txtEmailDoctor.Clear();
            this.txtUsuarioDoctor.Clear();
            this.txtContrasenaDoctor.Clear();

            this.txtIdDoctor.BackColor = Color.White;
            this.txtDireccionDoctor.BackColor = Color.White;
            this.txtEmailDoctor.BackColor = Color.White;
            this.txtUsuarioDoctor.BackColor = Color.White;
            this.txtContrasenaDoctor.BackColor = Color.White;
            this.txtModificarIdDoctor.BackColor = Color.White;
            this.txtEliminarIdDoctor.BackColor = Color.White;
            this.txtBuscarNombreDoctor.BackColor = Color.White;
        }

        private void LimpiezaAsistenteTxt()
        {
            this.txtIdAsistente.Clear();
            this.txtNombreAsistente.Clear();
            this.txtApellidoAsistente.Clear();
            this.txtTipoAsistente.Clear();
            this.cbEdadAsistente.SelectedIndex = -1;
            this.txtTelefonoAsistente.Clear();
            this.txtDireccionAsistente.Clear();
            this.txtEmailAsistente.Clear();
            this.txtUsuarioAsistente.Clear();
            this.txtContrasenaAsistente.Clear();
            this.txtBuscarNombreAsistente.Clear();
            this.txtEliminarIdAsistente.Clear();
            this.txtModificarAsistente.Clear();

            this.txtIdAsistente.BackColor = Color.White;
            this.txtDireccionAsistente.BackColor = Color.White;
            this.txtEmailAsistente.BackColor = Color.White;
            this.txtUsuarioAsistente.BackColor = Color.White;
            this.txtContrasenaAsistente.BackColor = Color.White;
            this.txtBuscarNombreAsistente.BackColor = Color.White;
            this.txtEliminarIdAsistente.BackColor = Color.White;
            this.txtModificarAsistente.BackColor = Color.White;
        }

        private void ActivarDoctorTxt()
        {
            this.txtIdDoctor.Enabled = true;
            this.txtNombreDoctor.Enabled = true;
            this.txtApellidoDoctor.Enabled = true;
            this.cbEdadDoctor.Enabled = true;
            this.txtDireccionDoctor.Enabled = true;
            this.txtTelefonoDoctor.Enabled = true;
            this.txtMatriculaDoctor.Enabled = true;
            this.txtEspecialidadDoctor.Enabled = true;
            this.txtEmailDoctor.Enabled = true;
            this.txtUsuarioDoctor.Enabled = true;
            this.txtContrasenaDoctor.Enabled = true;
        }

        private void ActivarAsistenteTxt()
        {
            this.txtIdAsistente.Enabled = true;
            this.txtNombreAsistente.Enabled = true;
            this.txtApellidoAsistente.Enabled = true;
            this.txtTipoAsistente.Enabled = true;
            this.cbEdadAsistente.Enabled = true;
            this.txtTelefonoAsistente.Enabled = true;
            this.txtDireccionAsistente.Enabled = true;
            this.txtEmailAsistente.Enabled = true;
            this.txtUsuarioAsistente.Enabled = true;
            this.txtContrasenaAsistente.Enabled = true;
        }

        private void DesactivadosDoctorTxt()
        {
            this.txtIdDoctor.Enabled = false;
            this.txtNombreDoctor.Enabled = false;
            this.txtApellidoDoctor.Enabled = false;
            this.cbEdadDoctor.Enabled = false;
            this.txtDireccionDoctor.Enabled = false;
            this.txtTelefonoDoctor.Enabled = false;
            this.txtMatriculaDoctor.Enabled = false;
            this.txtEspecialidadDoctor.Enabled = false;
            this.txtEmailDoctor.Enabled = false;
            this.txtUsuarioDoctor.Enabled = false;
            this.txtContrasenaDoctor.Enabled = false;
        }

        private void DesactivadosAsistenteTxt()
        {
            this.txtIdAsistente.Enabled = false;
            this.txtNombreAsistente.Enabled = false;
            this.txtApellidoAsistente.Enabled = false;
            this.txtTipoAsistente.Enabled = false;
            this.cbEdadAsistente.Enabled = false;
            this.txtTelefonoAsistente.Enabled = false;
            this.txtDireccionAsistente.Enabled = false;
            this.txtEmailAsistente.Enabled = false;
            this.txtUsuarioAsistente.Enabled = false;
            this.txtContrasenaAsistente.Enabled = false;
        }

        //Ingresar.
        private void rbtRegistrarDoctor_CheckedChanged(object sender, EventArgs e)
        {
            ActivarDoctorTxt();
            LimpiezaDoctorTxt();
            this.txtEliminarIdDoctor.Enabled = false;
            this.txtModificarIdDoctor.Enabled = false;
            this.txtBuscarNombreDoctor.Enabled = false;

            this.btnAceptarDoctor.Enabled = false;
            this.btnCancelarDoctor.Enabled = true;
            this.btnModificarDoctor.Enabled = false;
            this.btnEliminarDoctor.Enabled = false;
        }

        private void rbtRegirstrarAsistente_CheckedChanged(object sender, EventArgs e)
        {
            ActivarAsistenteTxt();
            LimpiezaAsistenteTxt();
            this.txtEliminarIdAsistente.Enabled = false;
            this.txtModificarAsistente.Enabled = false;
            this.txtBuscarNombreAsistente.Enabled = false;

            this.btnAceptarAsistente.Enabled = false;
            this.btnCancelarAsistente.Enabled = true;
            this.btnModificarAsistente.Enabled = false;
            this.btnEliminarAsistente.Enabled = false;
        }

        //Modificar.
        private void rbtModificarDoctor_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosDoctorTxt();
            LimpiezaDoctorTxt();
            this.txtEliminarIdDoctor.Enabled = false;
            this.txtModificarIdDoctor.Enabled = true;
            this.txtBuscarNombreDoctor.Enabled = false;

            this.btnAceptarDoctor.Enabled = false;
            this.btnCancelarDoctor.Enabled = true;
            this.btnModificarDoctor.Enabled = false;
            this.btnEliminarDoctor.Enabled = false;
        }

        private void rbtModificarAsistente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosAsistenteTxt();
            LimpiezaAsistenteTxt();
            this.txtEliminarIdAsistente.Enabled = false;
            this.txtModificarAsistente.Enabled = true;
            this.txtBuscarNombreAsistente.Enabled = false;

            this.btnAceptarAsistente.Enabled = false;
            this.btnCancelarAsistente.Enabled = true;
            this.btnModificarAsistente.Enabled = false;
            this.btnEliminarAsistente.Enabled = false;
        }

        //Buscar.
        private void rbtBuscarDoctor_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosDoctorTxt();
            LimpiezaDoctorTxt();
            this.txtEliminarIdDoctor.Enabled = false;
            this.txtModificarIdDoctor.Enabled = false;
            this.txtBuscarNombreDoctor.Enabled = true;

            this.btnAceptarDoctor.Enabled = false;
            this.btnCancelarDoctor.Enabled = false;
            this.btnModificarDoctor.Enabled = false;
            this.btnEliminarDoctor.Enabled = false;
        }

        private void rbtBuscarAsistente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosAsistenteTxt();
            LimpiezaAsistenteTxt();
            this.txtEliminarIdAsistente.Enabled = false;
            this.txtModificarAsistente.Enabled = false;
            this.txtBuscarNombreAsistente.Enabled = true;

            this.btnAceptarAsistente.Enabled = false;
            this.btnCancelarAsistente.Enabled = false;
            this.btnModificarAsistente.Enabled = false;
            this.btnEliminarAsistente.Enabled = false;
        }

        //Eliminar.
        private void rbtEliminarDoctor_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosDoctorTxt();
            LimpiezaDoctorTxt();
            this.txtEliminarIdDoctor.Enabled = true;
            this.txtModificarIdDoctor.Enabled = false;
            this.txtBuscarNombreDoctor.Enabled = false;

            this.btnAceptarDoctor.Enabled = false;
            this.btnCancelarDoctor.Enabled = false;
            this.btnModificarDoctor.Enabled = false;
            this.btnEliminarDoctor.Enabled = false;
        }

        private void rbtEliminarAsistente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosAsistenteTxt();
            LimpiezaAsistenteTxt();
            this.txtEliminarIdAsistente.Enabled = true;
            this.txtModificarAsistente.Enabled = false;
            this.txtBuscarNombreAsistente.Enabled = false;

            this.btnAceptarAsistente.Enabled = false;
            this.btnCancelarAsistente.Enabled = false;
            this.btnModificarAsistente.Enabled = false;
            this.btnEliminarAsistente.Enabled = false;
        }

        //*****************************************DOCTOR*************************************************************
        private bool IdDoctor()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtIdDoctor.Text);
        }

        private void txtIdDoctor_TextChanged(object sender, EventArgs e)
        {
            if (IdDoctor())
            {
                this.txtIdDoctor.BackColor = Color.White;
                this.btnAceptarDoctor.Enabled = true;
            }
            else
            {
                this.txtIdDoctor.BackColor = Color.Red;
                this.btnAceptarDoctor.Enabled = false;
            }
        }

        private void txtIdDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombreDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellidoDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool DireccionDoctor()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtDireccionDoctor.Text);
        }

        private void txtDireccionDoctor_TextChanged(object sender, EventArgs e)
        {
            this.txtDireccionDoctor.BackColor = DireccionDoctor() ? Color.White : Color.Red;
        }

        public void EdadDoctor()
        {
            for (int i = 24; i <= 70; i++)
            {
                cbEdadDoctor.Items.Add(i).ToString();
            }
        }

        private void txtTelefonoDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtMatriculaDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtEspecialidadDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool EmailDoctor()
        {
            return new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$").IsMatch(txtEmailDoctor.Text);
        }

        private void txtEmailDoctor_TextChanged(object sender, EventArgs e)
        {
            if (EmailDoctor())
            {
                this.txtEmailDoctor.BackColor = Color.White;
                if (rbtRegistrarDoctor.Checked)
                {
                    this.btnAceptarDoctor.Enabled = true;
                }
                else if(rbtModificarDoctor.Checked)
                {
                    this.btnModificarDoctor.Enabled = true;
                }
            }
            else
            {
                this.btnAceptarDoctor.Enabled = false;
                this.btnModificarDoctor.Enabled = false;
                this.txtEmailDoctor.BackColor = Color.Red;
            }
        }

        private bool UsuarioDoctor()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtUsuarioDoctor.Text);
        }

        private void txtUsuarioDoctor_TextChanged(object sender, EventArgs e)
        {
            this.txtUsuarioDoctor.BackColor = UsuarioDoctor() ? Color.White : Color.Red;
        }

        private bool ContrasenaDoctor()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtContrasenaDoctor.Text);
        }

        private void txtContrasenaDoctor_TextChanged(object sender, EventArgs e)
        {
            this.txtContrasenaDoctor.BackColor = ContrasenaDoctor() ? Color.White : Color.Red;
        }

        private bool BuscarNombreDoctor()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombreDoctor.Text);
        }

        private void txtBuscarNombreDoctor_TextChanged(object sender, EventArgs e)
        {
            if (BuscarNombreDoctor())
            {
                this.txtBuscarNombreDoctor.BackColor = Color.White;
                if (txtBuscarNombreDoctor.Text != " ")
                {
                    dgvTablaDoctores.DataSource = c.BuscarDoctor(txtBuscarNombreDoctor.Text);
                }
            }
            else
            {
                this.txtBuscarNombreDoctor.BackColor = Color.Red;
                c.CargarDoctores(dgvTablaDoctores);
                c.CargarUsuarioDoctor(dgvUsuarioDoctor);
            }
        }

        private void txtBuscarNombreDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool EliminarIdDoctor()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminarIdDoctor.Text);
        }

        private void txtEliminarIdDoctor_TextChanged(object sender, EventArgs e)
        {
            if (EliminarIdDoctor())
            {
                this.txtEliminarIdDoctor.BackColor = Color.White;
                this.btnEliminarDoctor.Enabled = true;
            }
            else
            {
                this.txtEliminarIdDoctor.BackColor = Color.Red;
                this.btnEliminarDoctor.Enabled = false;
            }
        }

        private void txtEliminarIdDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool IdDoctorModificar()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtModificarIdDoctor.Text);
        }

        private void txtModificarIdDoctor_TextChanged(object sender, EventArgs e)
        {
            txtIdDoctor.Text = txtModificarIdDoctor.Text;
            if (IdDoctorModificar())
            {
                this.txtModificarIdDoctor.BackColor = Color.White;
                if (c.DoctorRegistrado(Convert.ToInt32(txtModificarIdDoctor.Text)) > 0)
                {
                    c.LlenarTexBoxConsultaDoctor(Convert.ToInt32(txtModificarIdDoctor.Text), txtNombreDoctor,
                        txtApellidoDoctor, cbEdadDoctor, txtDireccionDoctor, txtTelefonoDoctor, txtMatriculaDoctor, 
                        txtEspecialidadDoctor,txtEmailDoctor,txtAccesoDoctor ,txtUsuarioDoctor, txtContrasenaDoctor);

                    ActivarDoctorTxt();
                    this.btnAceptarDoctor.Enabled = false;
                    this.btnModificarDoctor.Enabled = true;
                    this.btnEliminarDoctor.Enabled = false;
                    this.txtIdDoctor.Enabled = false;
                    this.txtModificarIdDoctor.BackColor = Color.White;
                }
            }
            else
            {
                LimpiezaDoctorTxt();
                DesactivadosDoctorTxt();
                this.txtModificarIdDoctor.BackColor = Color.Red;
                this.btnModificarDoctor.Enabled = false;
            }
        }

        private void txtModificarIdDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnAceptarDoctor_Click(object sender, EventArgs e)
        {
            if (txtNombreDoctor.Text.Trim().Length == 0 || txtApellidoDoctor.Text.Trim().Length == 0 ||
                !(cbEdadDoctor.SelectedIndex > -1) || txtDireccionDoctor.Text.Trim().Length == 0 ||
                txtTelefonoDoctor.Text.Trim().Length == 0 || txtMatriculaDoctor.Text.Trim().Length == 0 ||
                txtEspecialidadDoctor.Text.Trim().Length == 0 || txtEmailDoctor.Text.Trim().Length == 0 ||
                txtUsuarioDoctor.Text.Trim().Length == 0 || txtContrasenaDoctor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (c.DoctorRegistrado(Convert.ToInt32(txtIdDoctor.Text)) == 0)
            {
                c.InsertarDoctor(Convert.ToInt32(txtIdDoctor.Text), txtNombreDoctor.Text, txtApellidoDoctor.Text,
                    Convert.ToInt32(cbEdadDoctor.Text), txtDireccionDoctor.Text, Convert.ToInt32(txtTelefonoDoctor.Text),
                    Convert.ToInt32(txtMatriculaDoctor.Text), txtEspecialidadDoctor.Text, txtEmailDoctor.Text,
                    txtAccesoDoctor.Text, txtUsuarioDoctor.Text, txtContrasenaDoctor.Text);
                LimpiezaDoctorTxt();
                c.CargarDoctores(dgvTablaDoctores);
                c.CargarUsuarioDoctor(dgvUsuarioDoctor);
            }
            else
            {
                MessageBox.Show("No se pudo registrar, el registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarDoctor_Click(object sender, EventArgs e)
        {
            if (rbtRegistrarDoctor.Checked)
            {
                LimpiezaDoctorTxt();
            }
            if (rbtModificarDoctor.Checked)
            {
                LimpiezaDoctorTxt();
                DesactivadosDoctorTxt();
                this.txtModificarIdDoctor.Enabled = true;
            }
        }

        private void dgvTablaDoctores_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgvUsuarioDoctor_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnEliminarDoctor_Click(object sender, EventArgs e)
        {
            if (c.EliminarDoctor(txtEliminarIdDoctor.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                c.CargarDoctores(dgvTablaDoctores);
                c.CargarUsuarioDoctor(dgvUsuarioDoctor);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminarDoctor.Enabled = false;
            }
            LimpiezaDoctorTxt();
        }

        private void btnModificarDoctor_Click(object sender, EventArgs e)
        {
            if (txtNombreDoctor.Text.Trim().Length == 0 || txtApellidoDoctor.Text.Trim().Length == 0 ||
                !(cbEdadDoctor.SelectedIndex > -1) || txtDireccionDoctor.Text.Trim().Length == 0 ||
                txtTelefonoDoctor.Text.Trim().Length == 0 || txtMatriculaDoctor.Text.Trim().Length == 0 ||
                txtEspecialidadDoctor.Text.Trim().Length == 0 || txtEmailDoctor.Text.Trim().Length == 0 ||
                txtUsuarioDoctor.Text.Trim().Length == 0 || txtContrasenaDoctor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                c.ActualizarDoctor(Convert.ToInt32(txtIdDoctor.Text), txtNombreDoctor.Text, txtApellidoDoctor.Text,
                    Convert.ToInt32(cbEdadDoctor.Text), txtDireccionDoctor.Text, Convert.ToInt32(txtTelefonoDoctor.Text),
                    Convert.ToInt32(txtMatriculaDoctor.Text), txtEspecialidadDoctor.Text, txtEmailDoctor.Text,
                    txtAccesoDoctor.Text, txtUsuarioDoctor.Text, txtContrasenaDoctor.Text);
                LimpiezaDoctorTxt();
                DesactivadosDoctorTxt();
                c.CargarDoctores(dgvTablaDoctores);
                c.CargarUsuarioDoctor(dgvUsuarioDoctor);
            }
        }

        //*****************************************ASISTENTE*************************************************************
        private bool IdAsistente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtIdAsistente.Text);
        }

        private void txtIdAsistente_TextChanged(object sender, EventArgs e)
        {
            if (IdAsistente())
            {
                this.txtIdAsistente.BackColor = Color.White;
                this.btnAceptarAsistente.Enabled = true;
            }
            else
            {
                this.txtIdAsistente.BackColor = Color.Red;
                this.btnAceptarAsistente.Enabled = false;
            }
        }

        private void txtIdAsistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombreAsistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellidoAsistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtTipoAsistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        public void EdadAsistente()
        {
            for (int i = 18; i <= 70; i++)
            {
                cbEdadAsistente.Items.Add(i).ToString();
            }
        }

        private void txtTelefonoAsistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool DireccionAsistente()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtDireccionAsistente.Text);
        }

        private void txtDireccionAsistente_TextChanged(object sender, EventArgs e)
        {
            this.txtDireccionAsistente.BackColor = DireccionAsistente() ? Color.White : Color.Red;
        }

        private bool EmailAsitente()
        {
            return new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$").IsMatch(txtEmailAsistente.Text);
        }

        private void txtEmailAsistente_TextChanged(object sender, EventArgs e)
        {
            if (EmailAsitente())
            {
                this.txtEmailAsistente.BackColor = Color.White;
                if (rbtRegirstrarAsistente.Checked)
                {
                    this.btnAceptarAsistente.Enabled = true;
                }
                else if (rbtModificarAsistente.Checked)
                {
                    this.btnModificarAsistente.Enabled = true;
                }
            }
            else
            {
                this.btnAceptarAsistente.Enabled = false;
                this.btnModificarAsistente.Enabled = false;
                this.txtEmailAsistente.BackColor = Color.Red;
            }
        }

        private bool UsuarioAsistente()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtUsuarioAsistente.Text);
        }

        private void txtUsuarioAsistente_TextChanged(object sender, EventArgs e)
        {
            this.txtUsuarioAsistente.BackColor = UsuarioAsistente() ? Color.White : Color.Red;
        }

        private bool ContrasenaAsistente()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtContrasenaAsistente.Text);
        }

        private void txtContrasenaAsistente_TextChanged(object sender, EventArgs e)
        {
            this.txtContrasenaAsistente.BackColor = ContrasenaAsistente() ? Color.White : Color.Red;
        }

        private bool BuscarAsistente()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombreAsistente.Text);
        }
        
        private void txtBuscarNombreAsistente_TextChanged(object sender, EventArgs e)
        {
            if (BuscarAsistente())
            {
                this.txtBuscarNombreAsistente.BackColor = Color.White;
                if (txtBuscarNombreAsistente.Text != " ")
                {
                    dgvTablaAsistentes.DataSource = a.BuscarAsistente(txtBuscarNombreAsistente.Text);
                }
            }
            else
            {
                this.txtBuscarNombreAsistente.BackColor = Color.Red;
                a.CargarAsistentes(dgvTablaAsistentes);
                a.CargarUsuarioAsistente(dgvUsuarioAsistente);
            }
        }

        private void txtBuscarNombreAsistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool EliminarAsistente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminarIdAsistente.Text);
        }

        private void txtEliminarIdAsistente_TextChanged(object sender, EventArgs e)
        {
            if (EliminarAsistente())
            {
                this.txtEliminarIdAsistente.BackColor = Color.White;
                this.btnEliminarAsistente.Enabled = true;
            }
            else
            {
                this.txtEliminarIdAsistente.BackColor = Color.Red;
                this.btnEliminarAsistente.Enabled = false;
            }
        }

        private void txtEliminarIdAsistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool ModificarAsistente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtModificarAsistente.Text);
        }

        private void txtModificarAsistente_TextChanged(object sender, EventArgs e)
        {
            txtIdAsistente.Text = txtModificarAsistente.Text;
            if (ModificarAsistente())
            {
                this.txtModificarAsistente.BackColor = Color.White;
                if (a.AsistenteRegistrado(Convert.ToInt32(txtModificarAsistente.Text)) > 0)
                {
                    a.LlenarTexBoxConsultaAsistente(Convert.ToInt32(txtModificarAsistente.Text), txtNombreAsistente,
                        txtApellidoAsistente, txtTipoAsistente ,cbEdadAsistente, txtDireccionAsistente, 
                        txtTelefonoAsistente, txtEmailAsistente, txtAccesoAsistente, txtUsuarioAsistente,
                        txtContrasenaAsistente);

                    ActivarAsistenteTxt();
                    this.btnAceptarAsistente.Enabled = false;
                    this.btnModificarAsistente.Enabled = true;
                    this.btnEliminarAsistente.Enabled = false;
                    this.txtIdAsistente.Enabled = false;
                    this.txtModificarAsistente.BackColor = Color.White;
                }
            }
            else
            {
                LimpiezaAsistenteTxt();
                DesactivadosAsistenteTxt();
                this.txtModificarAsistente.BackColor = Color.Red;
                this.btnModificarAsistente.Enabled = false;
            }
        }

        private void txtModificarAsistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnAceptarAsistente_Click(object sender, EventArgs e)
        {
            if (txtNombreAsistente.Text.Trim().Length == 0 || txtApellidoAsistente.Text.Trim().Length == 0 ||
                txtTipoAsistente.Text.Trim().Length == 0 || !(cbEdadAsistente.SelectedIndex > -1) || 
                txtDireccionAsistente.Text.Trim().Length == 0 || txtTelefonoAsistente.Text.Trim().Length == 0 || 
                txtEmailAsistente.Text.Trim().Length == 0 || txtUsuarioAsistente.Text.Trim().Length == 0 || 
                txtContrasenaAsistente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (a.AsistenteRegistrado(Convert.ToInt32(txtIdAsistente.Text)) == 0)
            {
                a.InsertarAsistente(Convert.ToInt32(txtIdAsistente.Text), txtNombreAsistente.Text, 
                    txtApellidoAsistente.Text, txtTipoAsistente.Text, Convert.ToInt32(cbEdadAsistente.Text),
                    txtDireccionAsistente.Text, Convert.ToInt32(txtTelefonoAsistente.Text), txtEmailAsistente.Text,
                    txtAccesoAsistente.Text, txtUsuarioAsistente.Text, txtContrasenaAsistente.Text);
                LimpiezaAsistenteTxt();
                a.CargarAsistentes(dgvTablaAsistentes);
                a.CargarUsuarioAsistente(dgvUsuarioAsistente);
            }
            else
            {
                MessageBox.Show("No se pudo registrar, el registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarAsistente_Click(object sender, EventArgs e)
        {
            if (rbtRegirstrarAsistente.Checked)
            {
                LimpiezaAsistenteTxt();
            }
            if (rbtModificarAsistente.Checked)
            {
                LimpiezaAsistenteTxt();
                DesactivadosAsistenteTxt();
                this.txtModificarAsistente.Enabled = true;
            }
        }

        private void dgvTablaAsistentes_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgvUsuarioAsistente_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnEliminarAsistente_Click(object sender, EventArgs e)
        {
            if (a.EliminarAsistente(txtEliminarIdAsistente.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.CargarAsistentes(dgvTablaAsistentes);
                a.CargarUsuarioAsistente(dgvUsuarioAsistente);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminarAsistente.Enabled = false;
            }
            LimpiezaAsistenteTxt();
        }

        private void btnModificarAsistente_Click(object sender, EventArgs e)
        {
            if (txtNombreAsistente.Text.Trim().Length == 0 || txtApellidoAsistente.Text.Trim().Length == 0 ||
                txtTipoAsistente.Text.Trim().Length == 0 || !(cbEdadAsistente.SelectedIndex > -1) ||
                txtDireccionAsistente.Text.Trim().Length == 0 || txtTelefonoAsistente.Text.Trim().Length == 0 ||
                txtEmailAsistente.Text.Trim().Length == 0 || txtUsuarioAsistente.Text.Trim().Length == 0 ||
                txtContrasenaAsistente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                a.ActualizarAsistente(Convert.ToInt32(txtIdAsistente.Text), txtNombreAsistente.Text,
                    txtApellidoAsistente.Text, txtTipoAsistente.Text, Convert.ToInt32(cbEdadAsistente.Text),
                    txtDireccionAsistente.Text, Convert.ToInt32(txtTelefonoAsistente.Text), txtEmailAsistente.Text,
                    txtAccesoAsistente.Text, txtUsuarioAsistente.Text, txtContrasenaAsistente.Text);
                LimpiezaAsistenteTxt();
                DesactivadosAsistenteTxt();
                a.CargarAsistentes(dgvTablaAsistentes);
                a.CargarUsuarioAsistente(dgvUsuarioAsistente);
            }
        }

        private void btnRegresarEmpleados_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Quiere Regresar al menú principal?", "Regresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}