namespace Optica.Pantallas
{
    partial class VerProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegresarVerPro = new System.Windows.Forms.Button();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.lblBuscarProductoVer = new System.Windows.Forms.Label();
            this.txtBuscarProductoVer = new System.Windows.Forms.TextBox();
            this.dgvTablaVerProducto = new System.Windows.Forms.DataGridView();
            this.txtValidar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVerProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarVerPro
            // 
            this.btnRegresarVerPro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarVerPro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresarVerPro.Image")));
            this.btnRegresarVerPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarVerPro.Location = new System.Drawing.Point(748, 14);
            this.btnRegresarVerPro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresarVerPro.Name = "btnRegresarVerPro";
            this.btnRegresarVerPro.Size = new System.Drawing.Size(190, 37);
            this.btnRegresarVerPro.TabIndex = 94;
            this.btnRegresarVerPro.Text = "Regresar";
            this.btnRegresarVerPro.UseVisualStyleBackColor = true;
            this.btnRegresarVerPro.Click += new System.EventHandler(this.btnRegresarVerPro_Click);
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProducto.Image")));
            this.btnSeleccionarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(560, 14);
            this.btnSeleccionarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(180, 37);
            this.btnSeleccionarProducto.TabIndex = 93;
            this.btnSeleccionarProducto.Text = "Seleccionar";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // lblBuscarProductoVer
            // 
            this.lblBuscarProductoVer.AutoSize = true;
            this.lblBuscarProductoVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProductoVer.Location = new System.Drawing.Point(13, 24);
            this.lblBuscarProductoVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarProductoVer.Name = "lblBuscarProductoVer";
            this.lblBuscarProductoVer.Size = new System.Drawing.Size(188, 20);
            this.lblBuscarProductoVer.TabIndex = 91;
            this.lblBuscarProductoVer.Text = "Buscar Producto por Nombre:";
            // 
            // txtBuscarProductoVer
            // 
            this.txtBuscarProductoVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProductoVer.Location = new System.Drawing.Point(207, 21);
            this.txtBuscarProductoVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarProductoVer.Name = "txtBuscarProductoVer";
            this.txtBuscarProductoVer.Size = new System.Drawing.Size(257, 26);
            this.txtBuscarProductoVer.TabIndex = 92;
            this.txtBuscarProductoVer.TextChanged += new System.EventHandler(this.txtBuscarProductoVer_TextChanged);
            // 
            // dgvTablaVerProducto
            // 
            this.dgvTablaVerProducto.AllowUserToAddRows = false;
            this.dgvTablaVerProducto.AllowUserToDeleteRows = false;
            this.dgvTablaVerProducto.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTablaVerProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTablaVerProducto.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVerProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTablaVerProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaVerProducto.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTablaVerProducto.Location = new System.Drawing.Point(17, 61);
            this.dgvTablaVerProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaVerProducto.MultiSelect = false;
            this.dgvTablaVerProducto.Name = "dgvTablaVerProducto";
            this.dgvTablaVerProducto.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVerProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTablaVerProducto.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTablaVerProducto.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTablaVerProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaVerProducto.Size = new System.Drawing.Size(921, 285);
            this.dgvTablaVerProducto.TabIndex = 90;
            this.dgvTablaVerProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaVerProducto_CellClick);
            this.dgvTablaVerProducto.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvTablaVerProducto_ColumnAdded);
            // 
            // txtValidar
            // 
            this.txtValidar.Location = new System.Drawing.Point(471, 21);
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(28, 26);
            this.txtValidar.TabIndex = 95;
            this.txtValidar.Visible = false;
            // 
            // VerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 360);
            this.Controls.Add(this.txtValidar);
            this.Controls.Add(this.btnRegresarVerPro);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.lblBuscarProductoVer);
            this.Controls.Add(this.txtBuscarProductoVer);
            this.Controls.Add(this.dgvTablaVerProducto);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "VerProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Producto";
            this.Load += new System.EventHandler(this.VerProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVerProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarVerPro;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Label lblBuscarProductoVer;
        private System.Windows.Forms.TextBox txtBuscarProductoVer;
        private System.Windows.Forms.DataGridView dgvTablaVerProducto;
        private System.Windows.Forms.TextBox txtValidar;
    }
}