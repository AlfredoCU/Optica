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
using Optica.Reporte;

namespace Optica.Pantallas
{
    public partial class Servicios : Form
    {
        Producto pr = new Producto("Sí hay conexión");
        Compra co = new Compra("Sí hay conexión");
        Validar v = new Validar();

        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            pr.CargarProducto(dgvTablaProducto);
            dgvTablaProducto.Columns[3].HeaderText = "Descripción";
            co.CargarCompra(dgvTablaCompra);
            dgvTablaCompra.Columns[3].HeaderText = "Costo de Examen";
            dgvTablaCompra.Columns[7].HeaderText = "Descripción";
            dgvTablaCompra.Columns[8].HeaderText =  "Costo de Producto";
            this.rbtRegistrarProducto.Checked = true;
            this.rbtRegistrarCompra.Checked = true;
            lblMensaje.Text = "";
        }

        //Método de limpieza de txt.
        private void LimpiezaProductoTxt()
        {
            this.txtIdProducto.Clear();
            this.txtNombreProducto.Clear();
            this.txtMarcaProducto.Clear();
            this.rbtDescripcionProducto.Clear();
            this.txtCostoProducto.Clear();
            this.txtBuscarNombreProducto.Clear();
            this.txtEliminarIdProducto.Clear();
            this.txtModificarIdProducto.Clear();
            this.txtIdProducto.BackColor = Color.White;
            this.txtMarcaProducto.BackColor = Color.White;
            this.rbtDescripcionProducto.BackColor = Color.White;
            this.txtBuscarNombreProducto.BackColor = Color.White;
            this.txtEliminarIdProducto.BackColor = Color.White;
            this.txtModificarIdProducto.BackColor = Color.White;
        }

        private void LimpiezaCompraTxt()
        {
            this.txtIdExamenCom.Clear();
            this.txtNombrePacienteCom.Clear();
            this.txtCostoExamenCom.Clear();
            this.txtIdProductoCom.Clear();
            this.txtNomProductoCom.Clear();
            this.txtCostoProductoCom.Clear();
            this.txtIdCompra.Clear();
            this.txtTotalCompra.Clear();
            this.txtBuscarCompra.Clear();
            this.txtEliminarCompra.Clear();
            this.txtModificarIdCompra.Clear();
            this.txtIdExamenCom.BackColor = Color.White;
            this.txtNombrePacienteCom.BackColor = Color.White;
            this.txtCostoExamenCom.BackColor = Color.White;
            this.txtIdProductoCom.BackColor = Color.White;
            this.txtNomProductoCom.BackColor = Color.White;
            this.txtCostoProductoCom.BackColor = Color.White;
            this.txtIdCompra.BackColor = Color.White;
            this.txtTotalCompra.BackColor = Color.White;
            this.txtBuscarCompra.BackColor = Color.White;
            this.txtEliminarCompra.BackColor = Color.White;
            this.txtModificarIdCompra.BackColor = Color.White;
        }

        private void ActivarProductoTxt()
        {
            this.txtIdProducto.Enabled = true;
            this.txtNombreProducto.Enabled = true;
            this.txtMarcaProducto.Enabled = true;
            this.rbtDescripcionProducto.Enabled = true;
            this.txtCostoProducto.Enabled = true;
        }

        private void ActivarCompraTxt()
        {
            this.txtIdCompra.Enabled = true;
            this.dtpFechaCompra.Enabled = true;
        }

        private void DesactivadosProductoTxt()
        {
            this.txtIdProducto.Enabled = false;
            this.txtNombreProducto.Enabled = false;
            this.txtMarcaProducto.Enabled = false;
            this.rbtDescripcionProducto.Enabled = false;
            this.txtCostoProducto.Enabled = false;
        }

        private void DesactivarCompraTxt()
        {
            this.txtIdCompra.Enabled = false;
            this.dtpFechaCompra.Enabled = false;
        }

        private void rbtRegistrarProducto_CheckedChanged(object sender, EventArgs e)
        {
            ActivarProductoTxt();
            LimpiezaProductoTxt();
            this.txtEliminarIdProducto.Enabled = false;
            this.txtModificarIdProducto.Enabled = false;
            this.txtBuscarNombreProducto.Enabled = false;

            this.btnAceptarProducto.Enabled = false;
            this.btnCancelarProducto.Enabled = true;
            this.btnModificarProducto.Enabled = false;
            this.btnEliminarProducto.Enabled = false;
        }

        private void rbtRegistrarCompra_CheckedChanged(object sender, EventArgs e)
        {
            ActivarCompraTxt();
            LimpiezaCompraTxt();
            this.txtEliminarCompra.Enabled = false;
            this.txtModificarIdCompra.Enabled = false;
            this.txtBuscarCompra.Enabled = false;
            this.pbExamenTabla.Enabled = true;
            this.pbProductoTabla.Enabled = true;
            this.pbSuma.Enabled = false;

            this.btnAceptarCompra.Enabled = false;
            this.btnCancelarCompra.Enabled = true;
            this.btnModificarIdCompra.Enabled = false;
            this.btnEliminarCompra.Enabled = false;
        }

        private void rbtModificarProducto_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosProductoTxt();
            LimpiezaProductoTxt();
            this.txtEliminarIdProducto.Enabled = false;
            this.txtModificarIdProducto.Enabled = true;
            this.txtBuscarNombreProducto.Enabled = false;

            this.btnAceptarProducto.Enabled = false;
            this.btnCancelarProducto.Enabled = true;
            this.btnModificarProducto.Enabled = false;
            this.btnEliminarProducto.Enabled = false;
        }

        private void rbtModificarCompra_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarCompraTxt();
            LimpiezaCompraTxt();
            this.txtEliminarCompra.Enabled = false;
            this.txtModificarIdCompra.Enabled = true;
            this.txtBuscarCompra.Enabled = false;
            this.pbExamenTabla.Enabled = true;
            this.pbProductoTabla.Enabled = true;
            this.pbSuma.Enabled = false;

            this.btnAceptarCompra.Enabled = false;
            this.btnCancelarCompra.Enabled = true;
            this.btnModificarIdCompra.Enabled = false;
            this.btnEliminarCompra.Enabled = false;
        }

        private void rbtBuscarProducto_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosProductoTxt();
            LimpiezaProductoTxt();
            this.txtEliminarIdProducto.Enabled = false;
            this.txtModificarIdProducto.Enabled = false;
            this.txtBuscarNombreProducto.Enabled = true;

            this.btnAceptarProducto.Enabled = false;
            this.btnCancelarProducto.Enabled = false;
            this.btnModificarProducto.Enabled = false;
            this.btnEliminarProducto.Enabled = false;
        }

        private void rbtBuscarCompra_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarCompraTxt();
            LimpiezaCompraTxt();
            this.txtEliminarCompra.Enabled = false;
            this.txtModificarIdCompra.Enabled = false;
            this.txtBuscarCompra.Enabled = true;
            this.pbExamenTabla.Enabled = false;
            this.pbProductoTabla.Enabled = false;
            this.pbSuma.Enabled = false;

            this.btnAceptarCompra.Enabled = false;
            this.btnCancelarCompra.Enabled = false;
            this.btnModificarIdCompra.Enabled = false;
            this.btnEliminarCompra.Enabled = false;
        }

        private void rbtEliminarProducto_CheckedChanged(object sender, EventArgs e)
        {
            DesactivadosProductoTxt();
            LimpiezaProductoTxt();
            this.txtEliminarIdProducto.Enabled = true;
            this.txtModificarIdProducto.Enabled = false;
            this.txtBuscarNombreProducto.Enabled = false;

            this.btnAceptarProducto.Enabled = false;
            this.btnCancelarProducto.Enabled = false;
            this.btnModificarProducto.Enabled = false;
            this.btnEliminarProducto.Enabled = false;
        }

        private void rbtEliminarCompra_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarCompraTxt();
            LimpiezaCompraTxt();
            this.txtEliminarCompra.Enabled = true;
            this.txtModificarIdCompra.Enabled = false;
            this.txtBuscarCompra.Enabled = false;
            this.pbExamenTabla.Enabled = false;
            this.pbProductoTabla.Enabled = false;
            this.pbSuma.Enabled = false;

            this.btnAceptarCompra.Enabled = false;
            this.btnCancelarCompra.Enabled = false;
            this.btnModificarIdCompra.Enabled = false;
            this.btnEliminarCompra.Enabled = false;
        }

        //*****************************************PRODUCTO**********************************************************
        private bool IdProducto()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtIdProducto.Text);
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (IdProducto())
            {
                this.txtIdProducto.BackColor = Color.White;
                this.btnAceptarProducto.Enabled = true;
            }
            else
            {
                this.txtIdProducto.BackColor = Color.Red;
                this.btnAceptarProducto.Enabled = false;
            }
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool MarcaProducto()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtMarcaProducto.Text);
        }

        private void txtMarcaProducto_TextChanged(object sender, EventArgs e)
        {
            this.txtMarcaProducto.BackColor = MarcaProducto() ? Color.White : Color.Red;
        }

        private bool DescripcionProducto()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(rbtRegistrarProducto.Text);
        }

        private void rbtDescripcionProducto_TextChanged(object sender, EventArgs e)
        {
            this.rbtDescripcionProducto.BackColor = DescripcionProducto() ? Color.White : Color.Red;
        }

        private void txtCostoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloCostos(e);
        }

        private bool BuscarNombreProducto()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombreProducto.Text);
        }

        private void txtBuscarNombreProducto_TextChanged(object sender, EventArgs e)
        {
            if (BuscarNombreProducto())
            {
                this.txtBuscarNombreProducto.BackColor = Color.White;
                if (txtBuscarNombreProducto.Text != " ")
                {
                    dgvTablaProducto.DataSource = pr.BuscarProducto(txtBuscarNombreProducto.Text);
                }
            }
            else
            {
                this.txtBuscarNombreProducto.BackColor = Color.Red;
                pr.CargarProducto(dgvTablaProducto);
            }
        }

        private void txtBuscarNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool EliminarIdProducto()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminarIdProducto.Text);
        }

        private void txtEliminarIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (EliminarIdProducto())
            {
                this.txtEliminarIdProducto.BackColor = Color.White;
                this.btnEliminarProducto.Enabled = true;
            }
            else
            {
                this.txtEliminarIdProducto.BackColor = Color.Red;
                this.btnEliminarProducto.Enabled = false;
            }
        }

        private void txtEliminarIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool ModificarIdProducto()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtModificarIdProducto.Text);
        }

        private void txtModificarIdProducto_TextChanged(object sender, EventArgs e)
        {
            txtIdProducto.Text = txtModificarIdProducto.Text;
            if (ModificarIdProducto())
            {
                this.txtModificarIdProducto.BackColor = Color.White;
                if (pr.ProductoRegistrado(Convert.ToInt32(txtModificarIdProducto.Text)) > 0)
                {
                    pr.LlenarTexBoxConsultaProducto(Convert.ToInt32(txtModificarIdProducto.Text), txtNombreProducto,
                        txtMarcaProducto, rbtDescripcionProducto, txtCostoProducto);

                    ActivarProductoTxt();
                    this.btnAceptarProducto.Enabled = false;
                    this.btnModificarProducto.Enabled = true;
                    this.btnEliminarProducto.Enabled = false;
                    this.txtIdProducto.Enabled = false;
                    this.txtModificarIdProducto.BackColor = Color.White;
                }
            }
            else
            {
                LimpiezaProductoTxt();
                DesactivadosProductoTxt();
                this.txtModificarIdProducto.BackColor = Color.Red;
                this.btnModificarProducto.Enabled = false;
            }
        }

        private void txtModificarIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Trim().Length == 0 || txtMarcaProducto.Text.Trim().Length == 0 ||
                rbtDescripcionProducto.Text.Trim().Length == 0 || txtCostoProducto.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (pr.ProductoRegistrado(Convert.ToInt32(txtIdProducto.Text)) == 0)
            {
                pr.InsertarProducto(Convert.ToInt32(txtIdProducto.Text), txtNombreProducto.Text, txtMarcaProducto.Text,
                     rbtDescripcionProducto.Text, Convert.ToSingle(txtCostoProducto.Text));
                LimpiezaProductoTxt();
                pr.CargarProducto(dgvTablaProducto);
            }
            else
            {
                MessageBox.Show("No se pudo registrar, el registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            if (rbtRegistrarProducto.Checked)
            {
                LimpiezaProductoTxt();
            }
            if (rbtModificarProducto.Checked)
            {
                LimpiezaProductoTxt();
                DesactivadosProductoTxt();
                this.txtModificarIdProducto.Enabled = true;
            }
        }

        private void dgvTablaProducto_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (pr.EliminarProducto(txtEliminarIdProducto.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pr.CargarProducto(dgvTablaProducto);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminarProducto.Enabled = false;
            }
            LimpiezaProductoTxt();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Trim().Length == 0 || txtMarcaProducto.Text.Trim().Length == 0 ||
                rbtDescripcionProducto.Text.Trim().Length == 0 || txtCostoProducto.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pr.ActualizarProducto(Convert.ToInt32(txtIdProducto.Text), txtNombreProducto.Text, 
                    txtMarcaProducto.Text, rbtDescripcionProducto.Text, Convert.ToSingle(txtCostoProducto.Text));
                LimpiezaProductoTxt();
                DesactivadosProductoTxt();
                pr.CargarProducto(dgvTablaProducto);
            }
        }

        //*****************************************COMPRA**********************************************************
        private void pbExamenTabla_Click(object sender, EventArgs e)
        {
            VerExamen vistaTablaExamen = new VerExamen();
            vistaTablaExamen.enviadoId += new VerExamen.enviarId(EjecutarIdE);
            vistaTablaExamen.enviadoNom += new VerExamen.enviarNom(EjecutarNom);
            vistaTablaExamen.enviadoCos += new VerExamen.enviarCos(EjecutarCos);
            vistaTablaExamen.ShowDialog();
        }

        public void EjecutarIdE(string dato)
        {
            txtIdExamenCom.Text = dato;
        }

        public void EjecutarNom(string dato)
        {
            txtNombrePacienteCom.Text = dato;
        }

        public void EjecutarCos(string dato)
        {
            txtCostoExamenCom.Text = dato;
        }

        private void pbProductoTabla_Click(object sender, EventArgs e)
        {
            VerProducto vistaTablaProducto = new VerProducto();
            vistaTablaProducto.enviadoIdP += new VerProducto.enviarIdP(EjecutarIdP);
            vistaTablaProducto.enviadoNomP += new VerProducto.enviarNomP(EjecutarNomP);
            vistaTablaProducto.enviadoCosP += new VerProducto.enviarCosP(EjecutarComP);
            vistaTablaProducto.ShowDialog();
        }

        public void EjecutarIdP(string dato)
        {
            txtIdProductoCom.Text = dato;
        }

        public void EjecutarNomP(string dato)
        {
            txtNomProductoCom.Text = dato;
        }

        public void EjecutarComP(string dato)
        {
            txtCostoProductoCom.Text = dato;
        }

        private bool IdCompra()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtIdCompra.Text);
        }

        private void txtIdCompra_TextChanged(object sender, EventArgs e)
        {
            this.txtIdCompra.BackColor = IdCompra() ? Color.White : Color.Red;
            this.pbSuma.Enabled = true;
        }

        private void txtIdCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void dtpFechaCompra_ValueChanged(object sender, EventArgs e)
        {
            //PROGRAMAR SI ES NECESARIO.
        }

        private void pbSuma_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtCostoExamenCom.Text);
            int b = Convert.ToInt32(txtCostoProductoCom.Text);
            int suma = a + b;
            this.txtTotalCompra.Text = Convert.ToString(suma);
            if (rbtRegistrarCompra.Checked)
            {
                this.btnAceptarCompra.Enabled = true;
            }
            if (rbtModificarCompra.Checked)
            {
                this.btnModificarIdCompra.Enabled = true;
            }
        }

        private bool BuscarCompra()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtBuscarCompra.Text);
        }

        private void txtBuscarCompra_TextChanged(object sender, EventArgs e)
        {
            if (BuscarCompra())
            {
                this.txtBuscarCompra.BackColor = Color.White;
                if (txtBuscarCompra.Text != " ")
                {
                    dgvTablaCompra.DataSource = co.BuscarCompra(Convert.ToInt32(txtBuscarCompra.Text));
                }
            }
            else
            {
                this.txtBuscarCompra.BackColor = Color.Red;
                co.CargarCompra(dgvTablaCompra);
            }
        }

        private void txtBuscarCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool EliminarCompra()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminarCompra.Text);
        }

        private void txtEliminarCompra_TextChanged(object sender, EventArgs e)
        {
            if (EliminarCompra())
            {
                this.txtEliminarCompra.BackColor = Color.White;
                this.btnEliminarCompra.Enabled = true;
            }
            else
            {
                this.txtEliminarCompra.BackColor = Color.Red;
                this.btnEliminarCompra.Enabled = false;
            }
        }

        private void txtEliminarCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool ModificarIdCompra()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtModificarIdCompra.Text);
        }

        private void txtModificarIdCompra_TextChanged(object sender, EventArgs e)
        {
            txtIdCompra.Text = txtModificarIdCompra.Text;
            if (ModificarIdCompra())
            {
                this.txtModificarIdCompra.BackColor = Color.White;
                if (co.CompraRegistrado(Convert.ToInt32(txtModificarIdCompra.Text)) > 0)
                {
                    co.LlenarTexBoxConsultaCompra(Convert.ToInt32(txtModificarIdCompra.Text), txtIdExamenCom, txtIdProductoCom, dtpFechaCompra, 
                        txtTotalCompra);
                    ActivarCompraTxt();
                    this.btnAceptarCompra.Enabled = false;
                    this.btnEliminarCompra.Enabled = false;
                    this.pbSuma.Enabled = true;
                    this.txtIdCompra.Enabled = false;
                    lblMensaje.Text = "Vuelve a insertar el costo de examen y producto.";
                    this.txtNombrePacienteCom.BackColor = Color.LightCoral;
                    this.txtNomProductoCom.BackColor = Color.LightCoral;
                    this.txtCostoExamenCom.BackColor = Color.LightCoral;
                    this.txtCostoProductoCom.BackColor = Color.LightCoral;
                    this.txtModificarIdCompra.BackColor = Color.White;
                }
            }
            else
            {
                LimpiezaCompraTxt();
                DesactivarCompraTxt();
                lblMensaje.Text = "";
                this.txtModificarIdCompra.BackColor = Color.Red;
                this.btnModificarIdCompra.Enabled = false;
                this.pbSuma.Enabled = false;
            }
        }

        private void txtModificarIdCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnAceptarCompra_Click(object sender, EventArgs e)
        {
            if (txtIdExamenCom.Text.Trim().Length == 0 || txtNombrePacienteCom.Text.Trim().Length == 0 || 
                txtIdProductoCom.Text.Trim().Length == 0 || txtNomProductoCom.Text.Trim().Length == 0 ||
                txtCostoExamenCom.Text.Trim().Length == 0 || txtCostoProductoCom.Text.Trim().Length == 0 ||
                txtTotalCompra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (co.CompraRegistrado(Convert.ToInt32(txtIdCompra.Text)) == 0)
            {
                co.InsertarCompra(Convert.ToInt32(txtIdCompra.Text), Convert.ToInt32(txtIdExamenCom.Text),
                    Convert.ToInt32(txtIdProductoCom.Text), dtpFechaCompra.Text, Convert.ToSingle(txtTotalCompra.Text));
                LimpiezaCompraTxt();
                this.btnAceptarCompra.Enabled = false;
                this.pbSuma.Enabled = false;
                co.CargarCompra(dgvTablaCompra);
            }
            else
            {
                MessageBox.Show("No se pudo registrar, el registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            if (rbtRegistrarCompra.Checked)
            {
                LimpiezaCompraTxt();
            }
            if (rbtModificarCompra.Checked)
            {
                LimpiezaCompraTxt();
                DesactivarCompraTxt();
                this.txtModificarIdCompra.Enabled = true;
            }
        }

        private void dgvTablaCompra_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            if (co.EliminarCompra(txtEliminarCompra.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                co.CargarCompra(dgvTablaCompra);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminarCompra.Enabled = false;
            }
            LimpiezaCompraTxt();
        }

        private void btnModificarIdCompra_Click(object sender, EventArgs e)
        {
            if (txtIdExamenCom.Text.Trim().Length == 0 || txtNombrePacienteCom.Text.Trim().Length == 0 ||
                txtIdProductoCom.Text.Trim().Length == 0 || txtNomProductoCom.Text.Trim().Length == 0 ||
                txtCostoExamenCom.Text.Trim().Length == 0 || txtCostoProductoCom.Text.Trim().Length == 0 ||
                txtTotalCompra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                co.ActualizarCompra(Convert.ToInt32(txtIdCompra.Text), Convert.ToInt32(txtIdExamenCom.Text),
                    Convert.ToInt32(txtIdProductoCom.Text), dtpFechaCompra.Text, Convert.ToSingle(txtTotalCompra.Text));
                LimpiezaCompraTxt();
                DesactivarCompraTxt();
                this.pbSuma.Enabled = false;
                this.btnModificarIdCompra.Enabled = false;
                co.CargarCompra(dgvTablaCompra);
            }
        }

        private void btnImprimirCompra_Click(object sender, EventArgs e)
        {
            Reportes re = new Reportes();
            re.IdCompra = Convert.ToInt32(this.dgvTablaCompra.CurrentRow.Cells["Id Compra"].Value);
            re.ShowDialog();
        }

        private void btnRegresarServicios_Click(object sender, EventArgs e)
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