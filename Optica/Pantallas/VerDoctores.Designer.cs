namespace Optica.Pantallas
{
    partial class VerDoctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerDoctores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSeleccionarDoctor = new System.Windows.Forms.Button();
            this.lblBuscarDoctorVer = new System.Windows.Forms.Label();
            this.txtBuscarNombreVer = new System.Windows.Forms.TextBox();
            this.dgvTablaVerDoctor = new System.Windows.Forms.DataGridView();
            this.btnRegresarVerDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVerDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarDoctor
            // 
            this.btnSeleccionarDoctor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarDoctor.Image")));
            this.btnSeleccionarDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarDoctor.Location = new System.Drawing.Point(559, 14);
            this.btnSeleccionarDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionarDoctor.Name = "btnSeleccionarDoctor";
            this.btnSeleccionarDoctor.Size = new System.Drawing.Size(180, 37);
            this.btnSeleccionarDoctor.TabIndex = 82;
            this.btnSeleccionarDoctor.Text = "Seleccionar";
            this.btnSeleccionarDoctor.UseVisualStyleBackColor = true;
            this.btnSeleccionarDoctor.Click += new System.EventHandler(this.btnSeleccionarDoctor_Click);
            // 
            // lblBuscarDoctorVer
            // 
            this.lblBuscarDoctorVer.AutoSize = true;
            this.lblBuscarDoctorVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDoctorVer.Location = new System.Drawing.Point(13, 24);
            this.lblBuscarDoctorVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarDoctorVer.Name = "lblBuscarDoctorVer";
            this.lblBuscarDoctorVer.Size = new System.Drawing.Size(173, 20);
            this.lblBuscarDoctorVer.TabIndex = 80;
            this.lblBuscarDoctorVer.Text = "Buscar Doctor por Nombre:";
            // 
            // txtBuscarNombreVer
            // 
            this.txtBuscarNombreVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombreVer.Location = new System.Drawing.Point(194, 21);
            this.txtBuscarNombreVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarNombreVer.Name = "txtBuscarNombreVer";
            this.txtBuscarNombreVer.Size = new System.Drawing.Size(257, 26);
            this.txtBuscarNombreVer.TabIndex = 81;
            this.txtBuscarNombreVer.TextChanged += new System.EventHandler(this.txtBuscarNombreVer_TextChanged);
            // 
            // dgvTablaVerDoctor
            // 
            this.dgvTablaVerDoctor.AllowUserToAddRows = false;
            this.dgvTablaVerDoctor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTablaVerDoctor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaVerDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaVerDoctor.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVerDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaVerDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaVerDoctor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaVerDoctor.Location = new System.Drawing.Point(17, 61);
            this.dgvTablaVerDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaVerDoctor.MultiSelect = false;
            this.dgvTablaVerDoctor.Name = "dgvTablaVerDoctor";
            this.dgvTablaVerDoctor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVerDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTablaVerDoctor.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTablaVerDoctor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTablaVerDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaVerDoctor.Size = new System.Drawing.Size(920, 285);
            this.dgvTablaVerDoctor.TabIndex = 79;
            this.dgvTablaVerDoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaVerDoctor_CellClick);
            this.dgvTablaVerDoctor.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvTablaVerDoctor_ColumnAdded);
            // 
            // btnRegresarVerDoc
            // 
            this.btnRegresarVerDoc.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarVerDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresarVerDoc.Image")));
            this.btnRegresarVerDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarVerDoc.Location = new System.Drawing.Point(747, 14);
            this.btnRegresarVerDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresarVerDoc.Name = "btnRegresarVerDoc";
            this.btnRegresarVerDoc.Size = new System.Drawing.Size(190, 37);
            this.btnRegresarVerDoc.TabIndex = 83;
            this.btnRegresarVerDoc.Text = "Regresar";
            this.btnRegresarVerDoc.UseVisualStyleBackColor = true;
            this.btnRegresarVerDoc.Click += new System.EventHandler(this.btnRegresarVerDoc_Click);
            // 
            // VerDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 360);
            this.Controls.Add(this.btnRegresarVerDoc);
            this.Controls.Add(this.btnSeleccionarDoctor);
            this.Controls.Add(this.lblBuscarDoctorVer);
            this.Controls.Add(this.txtBuscarNombreVer);
            this.Controls.Add(this.dgvTablaVerDoctor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "VerDoctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Doctores";
            this.Load += new System.EventHandler(this.VerDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVerDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarDoctor;
        private System.Windows.Forms.Label lblBuscarDoctorVer;
        private System.Windows.Forms.TextBox txtBuscarNombreVer;
        private System.Windows.Forms.DataGridView dgvTablaVerDoctor;
        private System.Windows.Forms.Button btnRegresarVerDoc;
    }
}