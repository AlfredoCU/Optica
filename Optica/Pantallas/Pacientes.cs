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
    public partial class Pacientes : Form
    {
        Paciente p = new Paciente("Sí hay conexión");
        Examen ex = new Examen("Sí hay conexión");
        Validar v = new Validar();

        public Pacientes()
        {
            InitializeComponent();
        }
        
        private void Pacientes_Load(object sender, EventArgs e)
        {
            this.rbtRegistrarPaciente.Checked = true;
            this.rbtRegistrarExamen.Checked = true;
            EdadPaciente();

            p.CargarPaciente(dgvTablaPaciente);
            ex.CargarPacienteDoctorExamen(dgvTablaExamen);
            dgvTablaPaciente.Columns[1].HeaderText = "Nombre(s)";
            dgvTablaPaciente.Columns[2].HeaderText = "Apellido(s)";
            dgvTablaPaciente.Columns[5].HeaderText = "Teléfono";
            dgvTablaPaciente.Columns[6].HeaderText = "Dirección";

            dgvTablaExamen.Columns[1].HeaderText = "Nompre(s) Paciente";
            dgvTablaExamen.Columns[2].HeaderText = "Apellido(s) Paciente";
            dgvTablaExamen.Columns[4].HeaderText = "Nombre(s) Doctor";
            dgvTablaExamen.Columns[5].HeaderText = "Apellido(s) Doctor";
        }

        private void LimpiezaPacienteTxt()
        {
            this.txtIdPaciente.Clear();
            this.txtNombrePaciente.Clear();
            this.txtApellidoPaciente.Clear();
            this.txtTipoPaciente.Clear();
            this.cbEdadPaciente.SelectedIndex = -1;
            this.txtTelefonoPaciente.Clear();
            this.txtEmailPaciente.Clear();
            this.txtDireccionPaciente.Clear();
            this.txtModificarIdPaciente.Clear();
            this.txtEliminarIdPaciente.Clear();
            this.txtBuscarNombrePaciente.Clear();

            this.txtIdPaciente.BackColor = Color.White;
            this.txtEmailPaciente.BackColor = Color.White;
            this.txtDireccionPaciente.BackColor = Color.White;
            this.txtModificarIdPaciente.BackColor = Color.White;
            this.txtEliminarIdPaciente.BackColor = Color.White;
            this.txtBuscarNombrePaciente.BackColor = Color.White;
        }

        private void LimpiezaExamenTxt()
        {
            this.txtIdPacienteExa.Clear();
            this.txtIdDoctorExa.Clear();
            this.txtIdExamen.Clear();
            this.rtbObservacionesExamen.Clear();
            this.txtCostoExamen.Clear();
            this.txtBuscarNombreExamen.Clear();
            this.txtEliminarIdExamen.Clear();
            this.txtModificarIdExamen.Clear();

            this.txtIdPacienteExa.BackColor = Color.White;
            this.txtIdDoctorExa.BackColor = Color.White;
            this.txtIdExamen.BackColor = Color.White;
            this.rtbObservacionesExamen.BackColor = Color.White;
            this.txtBuscarNombreExamen.BackColor = Color.White;
            this.txtEliminarIdExamen.BackColor = Color.White;
            this.txtModificarIdExamen.BackColor = Color.White;
        }

        private void ActivarPacienteTxt()
        {
            this.txtIdPaciente.Enabled = true;
            this.txtNombrePaciente.Enabled = true;
            this.txtApellidoPaciente.Enabled = true;
            this.txtTipoPaciente.Enabled = true;
            this.cbEdadPaciente.Enabled = true;
            this.txtTelefonoPaciente.Enabled = true;
            this.txtEmailPaciente.Enabled = true;
            this.txtDireccionPaciente.Enabled = true;
        }

        private void ActivarExamenTxt()
        {
            this.txtIdExamen.Enabled = true;
            this.rtbObservacionesExamen.Enabled = true;
            this.dtpFechaExamen.Enabled = true;
            this.txtCostoExamen.Enabled = true;
        }

        private void DesactivarPacienteTxt()
        {
            this.txtIdPaciente.Enabled = false;
            this.txtNombrePaciente.Enabled = false;
            this.txtApellidoPaciente.Enabled = false;
            this.txtTipoPaciente.Enabled = false;
            this.cbEdadPaciente.Enabled = false;
            this.txtTelefonoPaciente.Enabled = false;
            this.txtEmailPaciente.Enabled = false;
            this.txtDireccionPaciente.Enabled = false;
        }

        private void DesactivarExamenTxt()
        {
            this.txtIdExamen.Enabled = false;
            this.rtbObservacionesExamen.Enabled = false;
            this.dtpFechaExamen.Enabled = false;
            this.txtCostoExamen.Enabled = false;
        }

        private void rbtRegistrarPaciente_CheckedChanged(object sender, EventArgs e)
        {
            ActivarPacienteTxt();
            LimpiezaPacienteTxt();
            this.txtEliminarIdPaciente.Enabled = false;
            this.txtModificarIdPaciente.Enabled = false;
            this.txtBuscarNombrePaciente.Enabled = false;

            this.btnAceptarPaciente.Enabled = false;
            this.btnCancelarPaciente.Enabled = true;
            this.btnModificarPaciente.Enabled = false;
            this.btnEliminarPaciente.Enabled = false;
        }

        private void rbtRegistrarExamen_CheckedChanged(object sender, EventArgs e)
        {
            ActivarExamenTxt();
            LimpiezaExamenTxt();
            this.txtEliminarIdExamen.Enabled = false;
            this.txtModificarIdExamen.Enabled = false;
            this.txtBuscarNombreExamen.Enabled = false;
            this.pbPacienteTabla.Enabled = true;
            this.pbDoctorTabla.Enabled = true;

            this.btnAceptarExamen.Enabled = false;
            this.btnCancelarExamen.Enabled = true;
            this.btnModificarExamen.Enabled = false;
            this.btnEliminarExamen.Enabled = false;
        }

        private void rbtModificarPaciente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarPacienteTxt();
            LimpiezaPacienteTxt();
            this.txtEliminarIdPaciente.Enabled = false;
            this.txtModificarIdPaciente.Enabled = true;
            this.txtBuscarNombrePaciente.Enabled = false;

            this.btnAceptarPaciente.Enabled = false;
            this.btnCancelarPaciente.Enabled = true;
            this.btnModificarPaciente.Enabled = false;
            this.btnEliminarPaciente.Enabled = false;
        }

        private void rbtModificarExamen_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarExamenTxt();
            LimpiezaExamenTxt();
            this.txtEliminarIdExamen.Enabled = false;
            this.txtModificarIdExamen.Enabled = true;
            this.txtBuscarNombreExamen.Enabled = false;
            this.pbPacienteTabla.Enabled = true;
            this.pbDoctorTabla.Enabled = true;

            this.btnAceptarExamen.Enabled = false;
            this.btnCancelarExamen.Enabled = true;
            this.btnModificarExamen.Enabled = false;
            this.btnEliminarExamen.Enabled = false;
        }

        private void rbtBuscarPaciente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarPacienteTxt();
            LimpiezaPacienteTxt();
            this.txtEliminarIdPaciente.Enabled = false;
            this.txtModificarIdPaciente.Enabled = false;
            this.txtBuscarNombrePaciente.Enabled = true;

            this.btnAceptarPaciente.Enabled = false;
            this.btnCancelarPaciente.Enabled = false;
            this.btnModificarPaciente.Enabled = false;
            this.btnEliminarPaciente.Enabled = false;
        }

        private void rbtBuscarExamen_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarExamenTxt();
            LimpiezaExamenTxt();
            this.txtEliminarIdExamen.Enabled = false;
            this.txtModificarIdExamen.Enabled = false;
            this.txtBuscarNombreExamen.Enabled = true;
            this.pbPacienteTabla.Enabled = false;
            this.pbDoctorTabla.Enabled = false;

            this.btnAceptarExamen.Enabled = false;
            this.btnCancelarExamen.Enabled = false;
            this.btnModificarExamen.Enabled = false;
            this.btnEliminarExamen.Enabled = false;
        }

        private void rbtEliminarPaciente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarPacienteTxt();
            LimpiezaPacienteTxt();
            this.txtEliminarIdPaciente.Enabled = true;
            this.txtModificarIdPaciente.Enabled = false;
            this.txtBuscarNombrePaciente.Enabled = false;

            this.btnAceptarPaciente.Enabled = false;
            this.btnCancelarPaciente.Enabled = false;
            this.btnModificarPaciente.Enabled = false;
            this.btnEliminarPaciente.Enabled = false;
        }

        private void rbtEliminarExamen_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarExamenTxt();
            LimpiezaExamenTxt();
            this.txtEliminarIdExamen.Enabled = true;
            this.txtModificarIdExamen.Enabled = false;
            this.txtBuscarNombreExamen.Enabled = false;
            this.pbPacienteTabla.Enabled = false;
            this.pbDoctorTabla.Enabled = false;

            this.btnAceptarExamen.Enabled = false;
            this.btnCancelarExamen.Enabled = false;
            this.btnModificarExamen.Enabled = false;
            this.btnEliminarExamen.Enabled = false;
        }

        //*************************************PACIENTE****************************************************
        private bool IdPaciente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtIdPaciente.Text);
        }

        private void txtIdPaciente_TextChanged(object sender, EventArgs e)
        {
            if (IdPaciente())
            {
                this.txtIdPaciente.BackColor = Color.White;
                this.btnAceptarPaciente.Enabled = true;
            }
            else
            {
                this.txtIdPaciente.BackColor = Color.Red;
                this.btnAceptarPaciente.Enabled = false;
            }
        }

        private void txtIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellidoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtTipoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        public void EdadPaciente()
        {
            for (int i = 0; i <= 100; i++)
            {
                cbEdadPaciente.Items.Add(i).ToString();
            }
        }

        private void txtTelefonoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool EmailPaciente()
        {
            return new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$").IsMatch(txtEmailPaciente.Text);
        }

        private void txtEmailPaciente_TextChanged(object sender, EventArgs e)
        {
            if (EmailPaciente())
            {
                this.txtEmailPaciente.BackColor = Color.White;
                if (rbtRegistrarPaciente.Checked)
                {
                    this.btnAceptarPaciente.Enabled = true;
                }
                else if (rbtModificarPaciente.Checked)
                {
                    this.btnModificarPaciente.Enabled = true;
                }
            }
            else
            {
                this.btnAceptarPaciente.Enabled = false;
                this.btnModificarPaciente.Enabled = false;
                this.txtEmailPaciente.BackColor = Color.Red;
            }
        }

        private bool DireccionPaciente()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtDireccionPaciente.Text);
        }

        private void txtDireccionPaciente_TextChanged(object sender, EventArgs e)
        {
            this.txtDireccionPaciente.BackColor = DireccionPaciente() ? Color.White : Color.Red;
        }

        private bool BuscarNombrePaciente()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombrePaciente.Text);
        }

        private void txtBuscarNombrePaciente_TextChanged(object sender, EventArgs e)
        {
            if (BuscarNombrePaciente())
            {
                this.txtBuscarNombrePaciente.BackColor = Color.White;
                if (txtBuscarNombrePaciente.Text != " ")
                {
                    dgvTablaPaciente.DataSource = p.BuscarPaciente(txtBuscarNombrePaciente.Text);
                }
            }
            else
            {
                this.txtBuscarNombrePaciente.BackColor = Color.Red;
                p.CargarPaciente(dgvTablaPaciente);
            }
        }

        private void txtBuscarNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool EliminarIdPaciente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminarIdPaciente.Text);
        }

        private void txtEliminarIdPaciente_TextChanged(object sender, EventArgs e)
        {
            if (EliminarIdPaciente())
            {
                this.txtEliminarIdPaciente.BackColor = Color.White;
                this.btnEliminarPaciente.Enabled = true;
            }
            else
            {
                this.txtEliminarIdPaciente.BackColor = Color.Red;
                this.btnEliminarPaciente.Enabled = false;
            }
        }

        private void txtEliminarIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool ModificarIdPaciente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtModificarIdPaciente.Text);
        }

        private void txtModificarIdPaciente_TextChanged(object sender, EventArgs e)
        {
            txtIdPaciente.Text = txtModificarIdPaciente.Text;
            if (ModificarIdPaciente())
            {
                this.txtModificarIdPaciente.BackColor = Color.White;
                if (p.PacienteRegistrado(Convert.ToInt32(txtModificarIdPaciente.Text)) > 0)
                {
                    p.LlenarTexBoxConsultaPaciente(Convert.ToInt32(txtModificarIdPaciente.Text), txtNombrePaciente, 
                        txtApellidoPaciente, txtTipoPaciente, cbEdadPaciente, txtTelefonoPaciente, txtDireccionPaciente,
                        txtEmailPaciente);

                    ActivarPacienteTxt();
                    this.btnAceptarPaciente.Enabled = false;
                    this.btnModificarPaciente.Enabled = true;
                    this.btnEliminarPaciente.Enabled = false;
                    this.txtIdPaciente.Enabled = false;
                    this.txtModificarIdPaciente.BackColor = Color.White;
                }
            }
            else
            {
                LimpiezaPacienteTxt();
                DesactivarPacienteTxt();
                this.txtModificarIdPaciente.BackColor = Color.Red;
                this.btnModificarPaciente.Enabled = false;
            }
        }

        private void txtModificarIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnAceptarPaciente_Click(object sender, EventArgs e)
        {
            if (txtNombrePaciente.Text.Trim().Length == 0 || txtApellidoPaciente.Text.Trim().Length == 0 ||
                txtTipoPaciente.Text.Trim().Length == 0 || !(cbEdadPaciente.SelectedIndex > -1) ||
                txtTelefonoPaciente.Text.Trim().Length == 0 || txtDireccionPaciente.Text.Trim().Length == 0 ||
                txtEmailPaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (p.PacienteRegistrado(Convert.ToInt32(txtIdPaciente.Text)) == 0)
            {
                p.InsertarPaciente(Convert.ToInt32(txtIdPaciente.Text), txtNombrePaciente.Text, txtApellidoPaciente.Text,
                    txtTipoPaciente.Text, Convert.ToInt32(cbEdadPaciente.Text), Convert.ToInt32(txtTelefonoPaciente.Text),
                    txtDireccionPaciente.Text, txtEmailPaciente.Text);
                LimpiezaPacienteTxt();
                p.CargarPaciente(dgvTablaPaciente);
            }
            else
            {
                MessageBox.Show("No se pudo registrar, el registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarPaciente_Click(object sender, EventArgs e)
        {
            if (rbtRegistrarPaciente.Checked)
            {
                LimpiezaPacienteTxt();
            }
            if (rbtModificarPaciente.Checked)
            {
                LimpiezaPacienteTxt();
                DesactivarPacienteTxt();
                this.txtModificarIdPaciente.Enabled = true;
            }
        }

        private void dgvTablaPaciente_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (p.EliminarPaciente(txtEliminarIdPaciente.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                p.CargarPaciente(dgvTablaPaciente);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminarPaciente.Enabled = false;
            }
            LimpiezaPacienteTxt();
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            if (txtNombrePaciente.Text.Trim().Length == 0 || txtApellidoPaciente.Text.Trim().Length == 0 ||
                txtTipoPaciente.Text.Trim().Length == 0 || !(cbEdadPaciente.SelectedIndex > -1) ||
                txtTelefonoPaciente.Text.Trim().Length == 0 || txtDireccionPaciente.Text.Trim().Length == 0 ||
                txtEmailPaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                p.ActualizarPaciente(Convert.ToInt32(txtIdPaciente.Text), txtNombrePaciente.Text, txtApellidoPaciente.Text,
                    txtTipoPaciente.Text, Convert.ToInt32(cbEdadPaciente.Text), Convert.ToInt32(txtTelefonoPaciente.Text),
                    txtDireccionPaciente.Text, txtEmailPaciente.Text);
                LimpiezaPacienteTxt();
                DesactivarPacienteTxt();
                p.CargarPaciente(dgvTablaPaciente);
            }
        }

        //*************************************EXAMEN****************************************************
        private void pbPacienteTabla_Click(object sender, EventArgs e)
        {
            VerPacientes vistaTablaPaciente = new VerPacientes();
            vistaTablaPaciente.enviado += new VerPacientes.enviar(EjecutarIdP);
            vistaTablaPaciente.ShowDialog();
        }

        public void EjecutarIdP(string dato)
        {
           txtIdPacienteExa.Text = dato;
        }

        private void pbDoctorTabla_Click(object sender, EventArgs e)
        {
            VerDoctores vistaTablaDoctor = new VerDoctores();
            vistaTablaDoctor.enviado += new VerDoctores.enviar(EjecutarIdD); 
            vistaTablaDoctor.ShowDialog();
        }

        public void EjecutarIdD(string dato)
        {
            txtIdDoctorExa.Text = dato;
        }

        private bool IdExamen()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtIdExamen.Text);
        }

        private void txtIdExamen_TextChanged(object sender, EventArgs e)
        {
            if (IdExamen())
            {
                this.txtIdExamen.BackColor = Color.White;
                this.btnAceptarExamen.Enabled = true;
            }
            else
            {
                this.txtIdExamen.BackColor = Color.Red;
                this.btnAceptarExamen.Enabled = false;
            }
        }

        private void txtIdExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void dtpFechaExamen_ValueChanged(object sender, EventArgs e)
        {
            //PROGRAMAR SI ES NECESARIO.
        }

        private bool Observacion()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(rtbObservacionesExamen.Text);
        }

        private void rtbObservacionesExamen_TextChanged(object sender, EventArgs e)
        {
            this.rtbObservacionesExamen.BackColor = Observacion() ? Color.White : Color.Red;
        }

        private void txtCostoExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloCostos(e);
        }

        private bool BuscarExamen()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombreExamen.Text);
        }

        private void txtBuscarNombreExamen_TextChanged(object sender, EventArgs e)
        {
            if (BuscarExamen())
            {
                this.txtBuscarNombreExamen.BackColor = Color.White;
                if (txtBuscarNombreExamen.Text != " ")
                {
                    dgvTablaExamen.DataSource = ex.BuscarExamen(txtBuscarNombreExamen.Text);
                }
            }
            else
            {
                this.txtBuscarNombreExamen.BackColor = Color.Red;
                ex.CargarPacienteDoctorExamen(dgvTablaExamen);
            }
        }

        private void txtBuscarNombreExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool EliminarIdExamen()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminarIdExamen.Text);
        }

        private void txtEliminarIdExamen_TextChanged(object sender, EventArgs e)
        {
            if (EliminarIdExamen())
            {
                this.txtEliminarIdExamen.BackColor = Color.White;
                this.btnEliminarExamen.Enabled = true;
            }
            else
            {
                this.txtEliminarIdExamen.BackColor = Color.Red;
                this.btnEliminarExamen.Enabled = false;
            }
        }

        private bool ModificarIdExamen()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtModificarIdExamen.Text);
        }

        private void txtModificarIdExamen_TextChanged(object sender, EventArgs e)
        {
            txtIdExamen.Text = txtModificarIdExamen.Text;
            if (ModificarIdExamen())
            {
                this.txtModificarIdExamen.BackColor = Color.White;
                if (ex.ExamenRegistrado(Convert.ToInt32(txtModificarIdExamen.Text)) > 0)
                {
                    ex.LlenarTexBoxConsultaExamen(txtIdPacienteExa, txtIdDoctorExa, Convert.ToInt32(txtModificarIdExamen.Text),
                        rtbObservacionesExamen , dtpFechaExamen, txtCostoExamen);
                    ActivarExamenTxt();
                    this.btnAceptarExamen.Enabled = false;
                    this.btnModificarExamen.Enabled = true;
                    this.btnEliminarExamen.Enabled = false;
                    this.txtIdExamen.Enabled = false;
                    this.txtModificarIdExamen.BackColor = Color.White;
                }
            }
            else
            {
                LimpiezaExamenTxt();
                DesactivarExamenTxt();
                this.txtModificarIdExamen.BackColor = Color.Red;
                this.btnModificarExamen.Enabled = false;
            }
        }

        private void btnAceptarExamen_Click(object sender, EventArgs e)
        {
            if (txtIdPacienteExa.Text.Trim().Length == 0 || txtIdDoctorExa.Text.Trim().Length == 0 || 
                rtbObservacionesExamen.Text.Trim().Length == 0 || txtCostoExamen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ex.ExamenRegistrado(Convert.ToInt32(txtIdExamen.Text)) == 0)
            {
                ex.InsertarExamen(Convert.ToInt32(txtIdPacienteExa.Text),Convert.ToInt32(txtIdDoctorExa.Text), 
                    Convert.ToInt32(txtIdExamen.Text),rtbObservacionesExamen.Text, dtpFechaExamen.Text, 
                    Convert.ToSingle(txtCostoExamen.Text));
                LimpiezaExamenTxt();
                ex.CargarPacienteDoctorExamen(dgvTablaExamen);
            }
            else
            {
                MessageBox.Show("No se pudo registrar, el registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarExamen_Click(object sender, EventArgs e)
        {
            if (rbtRegistrarExamen.Checked)
            {
                LimpiezaExamenTxt();
            }
            if (rbtModificarExamen.Checked)
            {
                LimpiezaExamenTxt();
                DesactivarExamenTxt();
                this.txtModificarIdExamen.Enabled = true;
            }
        }

        private void dgvTablaExamen_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnEliminarExamen_Click(object sender, EventArgs e)
        {
            if (ex.EliminarExamen(txtEliminarIdExamen.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ex.CargarPacienteDoctorExamen(dgvTablaExamen);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminarExamen.Enabled = false;
            }
            LimpiezaExamenTxt();
        }

        private void txtEliminarIdExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnModificarIdExamen_Click(object sender, EventArgs e)
        {
            if (txtIdPacienteExa.Text.Trim().Length == 0 || txtIdDoctorExa.Text.Trim().Length == 0 ||
                rtbObservacionesExamen.Text.Trim().Length == 0 || txtCostoExamen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ex.ActualizarExamen(Convert.ToInt32(txtIdPacienteExa.Text), Convert.ToInt32(txtIdDoctorExa.Text),
                    Convert.ToInt32(txtIdExamen.Text), rtbObservacionesExamen.Text, dtpFechaExamen.Text,
                    Convert.ToSingle(txtCostoExamen.Text));
                LimpiezaExamenTxt();
                DesactivarExamenTxt();
                ex.CargarPacienteDoctorExamen(dgvTablaExamen);
            }
        }

        private void txtModificarIdExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnRegresarPacientes_Click(object sender, EventArgs e)
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