namespace Optica
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsMenuPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbEmpleado = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPaciente = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbServicios = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOptica = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOInformacion = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.txtAcceso = new System.Windows.Forms.TextBox();
            this.pbInformacion = new System.Windows.Forms.PictureBox();
            this.tsMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuPrincipal
            // 
            this.tsMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEmpleado,
            this.tsSeparator1,
            this.tsbPaciente,
            this.tsSeparator2,
            this.tsbServicios,
            this.tsSeparator3,
            this.tsbOptica,
            this.tsSeparator5,
            this.tsbOInformacion,
            this.tsSeparator4,
            this.tsbSalir,
            this.toolStripSeparator1});
            this.tsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsMenuPrincipal.Name = "tsMenuPrincipal";
            this.tsMenuPrincipal.Size = new System.Drawing.Size(1237, 93);
            this.tsMenuPrincipal.TabIndex = 5;
            this.tsMenuPrincipal.Text = "Menu Principal";
            // 
            // tsbEmpleado
            // 
            this.tsbEmpleado.AutoSize = false;
            this.tsbEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("tsbEmpleado.Image")));
            this.tsbEmpleado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmpleado.Name = "tsbEmpleado";
            this.tsbEmpleado.Size = new System.Drawing.Size(80, 90);
            this.tsbEmpleado.Text = "Empleados";
            this.tsbEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEmpleado.Click += new System.EventHandler(this.tsbEmpleado_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // tsbPaciente
            // 
            this.tsbPaciente.AutoSize = false;
            this.tsbPaciente.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaciente.Image")));
            this.tsbPaciente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaciente.Name = "tsbPaciente";
            this.tsbPaciente.Size = new System.Drawing.Size(80, 90);
            this.tsbPaciente.Text = "Pacientes";
            this.tsbPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPaciente.Click += new System.EventHandler(this.tsbPaciente_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 93);
            // 
            // tsbServicios
            // 
            this.tsbServicios.AutoSize = false;
            this.tsbServicios.Image = ((System.Drawing.Image)(resources.GetObject("tsbServicios.Image")));
            this.tsbServicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbServicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServicios.Name = "tsbServicios";
            this.tsbServicios.Size = new System.Drawing.Size(80, 90);
            this.tsbServicios.Text = "Servicios";
            this.tsbServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbServicios.Click += new System.EventHandler(this.tsbServicios_Click);
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 93);
            // 
            // tsbOptica
            // 
            this.tsbOptica.AutoSize = false;
            this.tsbOptica.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptica.Image")));
            this.tsbOptica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOptica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptica.Name = "tsbOptica";
            this.tsbOptica.Size = new System.Drawing.Size(80, 90);
            this.tsbOptica.Text = "Óptica";
            this.tsbOptica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOptica.Click += new System.EventHandler(this.tsbOptica_Click);
            // 
            // tsSeparator5
            // 
            this.tsSeparator5.Name = "tsSeparator5";
            this.tsSeparator5.Size = new System.Drawing.Size(6, 93);
            // 
            // tsbOInformacion
            // 
            this.tsbOInformacion.AutoSize = false;
            this.tsbOInformacion.Image = ((System.Drawing.Image)(resources.GetObject("tsbOInformacion.Image")));
            this.tsbOInformacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOInformacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOInformacion.Name = "tsbOInformacion";
            this.tsbOInformacion.Size = new System.Drawing.Size(80, 90);
            this.tsbOInformacion.Text = "Información";
            this.tsbOInformacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOInformacion.Click += new System.EventHandler(this.tsbOInformacion_Click);
            // 
            // tsSeparator4
            // 
            this.tsSeparator4.Name = "tsSeparator4";
            this.tsSeparator4.Size = new System.Drawing.Size(6, 93);
            // 
            // tsbSalir
            // 
            this.tsbSalir.AutoSize = false;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(80, 90);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.SystemColors.Window;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBienvenido.Location = new System.Drawing.Point(538, 22);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(648, 55);
            this.lblBienvenido.TabIndex = 6;
            this.lblBienvenido.Text = "Bienvenido Óptica Industrial";
            // 
            // pbInicio
            // 
            this.pbInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbInicio.Image")));
            this.pbInicio.Location = new System.Drawing.Point(210, 131);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(798, 434);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 7;
            this.pbInicio.TabStop = false;
            // 
            // txtAcceso
            // 
            this.txtAcceso.Enabled = false;
            this.txtAcceso.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcceso.Location = new System.Drawing.Point(1108, 557);
            this.txtAcceso.Name = "txtAcceso";
            this.txtAcceso.Size = new System.Drawing.Size(117, 26);
            this.txtAcceso.TabIndex = 8;
            this.txtAcceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbInformacion
            // 
            this.pbInformacion.Image = ((System.Drawing.Image)(resources.GetObject("pbInformacion.Image")));
            this.pbInformacion.Location = new System.Drawing.Point(1193, 12);
            this.pbInformacion.Name = "pbInformacion";
            this.pbInformacion.Size = new System.Drawing.Size(32, 32);
            this.pbInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInformacion.TabIndex = 9;
            this.pbInformacion.TabStop = false;
            this.pbInformacion.Click += new System.EventHandler(this.pbInformacion_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1237, 595);
            this.Controls.Add(this.pbInformacion);
            this.Controls.Add(this.txtAcceso);
            this.Controls.Add(this.pbInicio);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.tsMenuPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Óptica Industrial";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tsMenuPrincipal.ResumeLayout(false);
            this.tsMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMenuPrincipal;
        private System.Windows.Forms.ToolStripButton tsbEmpleado;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPaciente;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton tsbServicios;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
        private System.Windows.Forms.ToolStripButton tsbOInformacion;
        private System.Windows.Forms.ToolStripSeparator tsSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator tsSeparator5;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pbInicio;
        public System.Windows.Forms.TextBox txtAcceso;
        private System.Windows.Forms.PictureBox pbInformacion;
        private System.Windows.Forms.ToolStripButton tsbOptica;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}