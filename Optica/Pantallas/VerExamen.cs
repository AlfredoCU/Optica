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
    public partial class VerExamen : Form
    {
        Examen exa = new Examen("Sí hay conexión");

        public int idExamen;
        public string nomPaciente;
        public float cosExamen;

        public delegate void enviarId(string id);
        public event enviarId enviadoId;

        public delegate void enviarNom(string nom);
        public event enviarNom enviadoNom;

        public delegate void enviarCos(string cos);
        public event enviarCos enviadoCos;

        public VerExamen()
        {
            InitializeComponent();
        }

        private void VerExamen_Load(object sender, EventArgs e)
        {
            exa.CargarExamen(dgvTablaVerExamen);
            dgvTablaVerExamen.Columns[1].HeaderText = "Nompre(s) Paciente";
            dgvTablaVerExamen.Columns[2].HeaderText = "Apellido(s) Paciente";
            dgvTablaVerExamen.Columns[4].HeaderText = "Nombre(s) Doctor";
            dgvTablaVerExamen.Columns[5].HeaderText = "Apellido(s) Doctor";
        }

        private void dgvTablaVerExamen_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgvTablaVerExamen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) //Evita que si por error el usuario da click en el encabezado no truene el programa por ser -1.
            {
                idExamen = Convert.ToInt32(dgvTablaVerExamen.Rows[e.RowIndex].Cells["Id Examen"].Value.ToString());
                nomPaciente = dgvTablaVerExamen.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                cosExamen = Convert.ToSingle(dgvTablaVerExamen.Rows[e.RowIndex].Cells["Costo"].Value.ToString());
            }
        }

        private bool BuscarExamenVer()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarExamenVer.Text);
        }

        private void txtBuscarExamenVer_TextChanged(object sender, EventArgs e)
        {
            if (BuscarExamenVer())
            {
                this.txtBuscarExamenVer.BackColor = Color.White;
                if (txtBuscarExamenVer.Text != " ")
                {
                    dgvTablaVerExamen.DataSource = exa.BuscarExamen(txtBuscarExamenVer.Text);
                }
            }
            else
            {
                this.txtBuscarExamenVer.BackColor = Color.Red;
                exa.CargarExamen(dgvTablaVerExamen);
            }
        }

        private void btnSeleccionarExamen_Click(object sender, EventArgs e)
        {
            txtValidar.Text = nomPaciente;
            if (txtValidar.Text == "")
            {
                MessageBox.Show("Seleccione una fila para elegir a un paciente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                enviadoId(Convert.ToString(idExamen));
                enviadoNom(nomPaciente);
                enviadoCos(Convert.ToString(cosExamen));
                this.Hide();
            }
        }

        private void btnRegresarVerExa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
