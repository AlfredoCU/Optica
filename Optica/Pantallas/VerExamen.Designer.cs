namespace Optica.Pantallas
{
    partial class VerExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerExamen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegresarVerExa = new System.Windows.Forms.Button();
            this.btnSeleccionarExamen = new System.Windows.Forms.Button();
            this.lblBuscarExamenVer = new System.Windows.Forms.Label();
            this.txtBuscarExamenVer = new System.Windows.Forms.TextBox();
            this.dgvTablaVerExamen = new System.Windows.Forms.DataGridView();
            this.txtValidar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVerExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarVerExa
            // 
            this.btnRegresarVerExa.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarVerExa.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresarVerExa.Image")));
            this.btnRegresarVerExa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarVerExa.Location = new System.Drawing.Point(748, 14);
            this.btnRegresarVerExa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresarVerExa.Name = "btnRegresarVerExa";
            this.btnRegresarVerExa.Size = new System.Drawing.Size(190, 37);
            this.btnRegresarVerExa.TabIndex = 89;
            this.btnRegresarVerExa.Text = "Regresar";
            this.btnRegresarVerExa.UseVisualStyleBackColor = true;
            this.btnRegresarVerExa.Click += new System.EventHandler(this.btnRegresarVerExa_Click);
            // 
            // btnSeleccionarExamen
            // 
            this.btnSeleccionarExamen.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarExamen.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarExamen.Image")));
            this.btnSeleccionarExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarExamen.Location = new System.Drawing.Point(560, 14);
            this.btnSeleccionarExamen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionarExamen.Name = "btnSeleccionarExamen";
            this.btnSeleccionarExamen.Size = new System.Drawing.Size(180, 37);
            this.btnSeleccionarExamen.TabIndex = 88;
            this.btnSeleccionarExamen.Text = "Seleccionar";
            this.btnSeleccionarExamen.UseVisualStyleBackColor = true;
            this.btnSeleccionarExamen.Click += new System.EventHandler(this.btnSeleccionarExamen_Click);
            // 
            // lblBuscarExamenVer
            // 
            this.lblBuscarExamenVer.AutoSize = true;
            this.lblBuscarExamenVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarExamenVer.Location = new System.Drawing.Point(13, 24);
            this.lblBuscarExamenVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarExamenVer.Name = "lblBuscarExamenVer";
            this.lblBuscarExamenVer.Size = new System.Drawing.Size(186, 20);
            this.lblBuscarExamenVer.TabIndex = 86;
            this.lblBuscarExamenVer.Text = "Buscar Paciente por Nombre:";
            // 
            // txtBuscarExamenVer
            // 
            this.txtBuscarExamenVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarExamenVer.Location = new System.Drawing.Point(207, 21);
            this.txtBuscarExamenVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarExamenVer.Name = "txtBuscarExamenVer";
            this.txtBuscarExamenVer.Size = new System.Drawing.Size(257, 26);
            this.txtBuscarExamenVer.TabIndex = 87;
            this.txtBuscarExamenVer.TextChanged += new System.EventHandler(this.txtBuscarExamenVer_TextChanged);
            // 
            // dgvTablaVerExamen
            // 
            this.dgvTablaVerExamen.AllowUserToAddRows = false;
            this.dgvTablaVerExamen.AllowUserToDeleteRows = false;
            this.dgvTablaVerExamen.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTablaVerExamen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTablaVerExamen.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVerExamen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTablaVerExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaVerExamen.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTablaVerExamen.Location = new System.Drawing.Point(17, 61);
            this.dgvTablaVerExamen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaVerExamen.MultiSelect = false;
            this.dgvTablaVerExamen.Name = "dgvTablaVerExamen";
            this.dgvTablaVerExamen.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVerExamen.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTablaVerExamen.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTablaVerExamen.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTablaVerExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaVerExamen.Size = new System.Drawing.Size(921, 285);
            this.dgvTablaVerExamen.TabIndex = 85;
            this.dgvTablaVerExamen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaVerExamen_CellClick);
            this.dgvTablaVerExamen.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvTablaVerExamen_ColumnAdded);
            // 
            // txtValidar
            // 
            this.txtValidar.Location = new System.Drawing.Point(471, 21);
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(28, 26);
            this.txtValidar.TabIndex = 90;
            this.txtValidar.Visible = false;
            // 
            // VerExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 360);
            this.Controls.Add(this.txtValidar);
            this.Controls.Add(this.btnRegresarVerExa);
            this.Controls.Add(this.btnSeleccionarExamen);
            this.Controls.Add(this.lblBuscarExamenVer);
            this.Controls.Add(this.txtBuscarExamenVer);
            this.Controls.Add(this.dgvTablaVerExamen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "VerExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Examen";
            this.Load += new System.EventHandler(this.VerExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVerExamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarVerExa;
        private System.Windows.Forms.Button btnSeleccionarExamen;
        private System.Windows.Forms.Label lblBuscarExamenVer;
        private System.Windows.Forms.TextBox txtBuscarExamenVer;
        private System.Windows.Forms.DataGridView dgvTablaVerExamen;
        private System.Windows.Forms.TextBox txtValidar;
    }
}