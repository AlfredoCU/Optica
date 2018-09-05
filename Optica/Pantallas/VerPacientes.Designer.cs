namespace Optica.Pantallas
{
    partial class VerPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPacientes));
            this.dgvTablaVerPaciente = new System.Windows.Forms.DataGridView();
            this.lblBuscarPacienteVer = new System.Windows.Forms.Label();
            this.txtBuscarNombreVer = new System.Windows.Forms.TextBox();
            this.btnSeleccionarPaciente = new System.Windows.Forms.Button();
            this.btnRegresarVerPac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVerPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaVerPaciente
            // 
            this.dgvTablaVerPaciente.AllowUserToAddRows = false;
            this.dgvTablaVerPaciente.AllowUserToDeleteRows = false;
            this.dgvTablaVerPaciente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTablaVerPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaVerPaciente.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVerPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaVerPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaVerPaciente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaVerPaciente.Location = new System.Drawing.Point(16, 61);
            this.dgvTablaVerPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaVerPaciente.MultiSelect = false;
            this.dgvTablaVerPaciente.Name = "dgvTablaVerPaciente";
            this.dgvTablaVerPaciente.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVerPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTablaVerPaciente.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTablaVerPaciente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTablaVerPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaVerPaciente.Size = new System.Drawing.Size(921, 285);
            this.dgvTablaVerPaciente.TabIndex = 75;
            this.dgvTablaVerPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaVerPaciente_CellClick);
            this.dgvTablaVerPaciente.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvTablaVerPaciente_ColumnAdded);
            // 
            // lblBuscarPacienteVer
            // 
            this.lblBuscarPacienteVer.AutoSize = true;
            this.lblBuscarPacienteVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPacienteVer.Location = new System.Drawing.Point(12, 24);
            this.lblBuscarPacienteVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPacienteVer.Name = "lblBuscarPacienteVer";
            this.lblBuscarPacienteVer.Size = new System.Drawing.Size(186, 20);
            this.lblBuscarPacienteVer.TabIndex = 76;
            this.lblBuscarPacienteVer.Text = "Buscar Paciente por Nombre:";
            // 
            // txtBuscarNombreVer
            // 
            this.txtBuscarNombreVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombreVer.Location = new System.Drawing.Point(206, 21);
            this.txtBuscarNombreVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarNombreVer.Name = "txtBuscarNombreVer";
            this.txtBuscarNombreVer.Size = new System.Drawing.Size(257, 26);
            this.txtBuscarNombreVer.TabIndex = 77;
            this.txtBuscarNombreVer.TextChanged += new System.EventHandler(this.txtBuscarNombreVer_TextChanged);
            // 
            // btnSeleccionarPaciente
            // 
            this.btnSeleccionarPaciente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarPaciente.Image")));
            this.btnSeleccionarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarPaciente.Location = new System.Drawing.Point(559, 14);
            this.btnSeleccionarPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionarPaciente.Name = "btnSeleccionarPaciente";
            this.btnSeleccionarPaciente.Size = new System.Drawing.Size(180, 37);
            this.btnSeleccionarPaciente.TabIndex = 78;
            this.btnSeleccionarPaciente.Text = "Seleccionar";
            this.btnSeleccionarPaciente.UseVisualStyleBackColor = true;
            this.btnSeleccionarPaciente.Click += new System.EventHandler(this.btnSeleccionarPaciente_Click);
            // 
            // btnRegresarVerPac
            // 
            this.btnRegresarVerPac.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarVerPac.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresarVerPac.Image")));
            this.btnRegresarVerPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarVerPac.Location = new System.Drawing.Point(747, 14);
            this.btnRegresarVerPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresarVerPac.Name = "btnRegresarVerPac";
            this.btnRegresarVerPac.Size = new System.Drawing.Size(190, 37);
            this.btnRegresarVerPac.TabIndex = 84;
            this.btnRegresarVerPac.Text = "Regresar";
            this.btnRegresarVerPac.UseVisualStyleBackColor = true;
            this.btnRegresarVerPac.Click += new System.EventHandler(this.btnRegresarVerPac_Click);
            // 
            // VerPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 360);
            this.Controls.Add(this.btnRegresarVerPac);
            this.Controls.Add(this.btnSeleccionarPaciente);
            this.Controls.Add(this.lblBuscarPacienteVer);
            this.Controls.Add(this.txtBuscarNombreVer);
            this.Controls.Add(this.dgvTablaVerPaciente);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "VerPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Pacientes";
            this.Load += new System.EventHandler(this.VerPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVerPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaVerPaciente;
        private System.Windows.Forms.Label lblBuscarPacienteVer;
        private System.Windows.Forms.TextBox txtBuscarNombreVer;
        private System.Windows.Forms.Button btnSeleccionarPaciente;
        private System.Windows.Forms.Button btnRegresarVerPac;
    }
}