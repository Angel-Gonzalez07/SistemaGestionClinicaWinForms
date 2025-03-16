namespace SistemaGestionClinicaWinForms
{
    partial class FormGestionInsumos
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
            txtNombreInsumo = new TextBox();
            txtCantidad = new TextBox();
            txtProveedor = new TextBox();
            btnGuardarInsumo = new Button();
            btnVolver = new Button();
            dtpFechaVencimiento = new DateTimePicker();
            dgvInsumos = new DataGridView();
            btnEliminarInsumo = new Button();
            numCantidad = new NumericUpDown();
            NombreInsumo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreInsumo
            // 
            txtNombreInsumo.Location = new Point(3, 13);
            txtNombreInsumo.Name = "txtNombreInsumo";
            txtNombreInsumo.PlaceholderText = "Nombre del Insumo";
            txtNombreInsumo.Size = new Size(166, 23);
            txtNombreInsumo.TabIndex = 3;
            txtNombreInsumo.TextChanged += txtNombreInsumo_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(3, 58);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Cantida";
            txtCantidad.Size = new Size(166, 23);
            txtCantidad.TabIndex = 4;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(0, 148);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.PlaceholderText = "Proveedor";
            txtProveedor.Size = new Size(172, 23);
            txtProveedor.TabIndex = 5;
            // 
            // btnGuardarInsumo
            // 
            btnGuardarInsumo.Location = new Point(0, 196);
            btnGuardarInsumo.Name = "btnGuardarInsumo";
            btnGuardarInsumo.Size = new Size(169, 23);
            btnGuardarInsumo.TabIndex = 6;
            btnGuardarInsumo.Text = "Agregar Insumo";
            btnGuardarInsumo.UseVisualStyleBackColor = true;
            btnGuardarInsumo.Click += btnGuardarInsumo_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(3, 354);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(166, 32);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(5, 10);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(254, 23);
            dtpFechaVencimiento.TabIndex = 9;
            dtpFechaVencimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dgvInsumos
            // 
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Columns.AddRange(new DataGridViewColumn[] { NombreInsumo, Cantidad, Proveedor, FechaVencimiento });
            dgvInsumos.Location = new Point(175, 64);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.Size = new Size(613, 397);
            dgvInsumos.TabIndex = 10;
            dgvInsumos.CellContentClick += dgvInsumos_CellContentClick;
            // 
            // btnEliminarInsumo
            // 
            btnEliminarInsumo.Location = new Point(0, 242);
            btnEliminarInsumo.Name = "btnEliminarInsumo";
            btnEliminarInsumo.Size = new Size(169, 23);
            btnEliminarInsumo.TabIndex = 11;
            btnEliminarInsumo.Text = "Eliminar Insumo";
            btnEliminarInsumo.UseVisualStyleBackColor = true;
            btnEliminarInsumo.Click += btnEliminarInsumo_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(3, 102);
            numCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(166, 23);
            numCantidad.TabIndex = 12;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.ValueChanged += numCantidad_ValueChanged;
            // 
            // NombreInsumo
            // 
            NombreInsumo.HeaderText = "Nombre del Insumo";
            NombreInsumo.Name = "NombreInsumo";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "Fecha de Vencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(dtpFechaVencimiento);
            panel1.Location = new Point(-5, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 60);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(txtProveedor);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(btnEliminarInsumo);
            panel2.Controls.Add(numCantidad);
            panel2.Controls.Add(txtNombreInsumo);
            panel2.Controls.Add(btnGuardarInsumo);
            panel2.Controls.Add(btnVolver);
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(172, 386);
            panel2.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(245, 10);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(490, 50);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Gestion de Insumos Medicos";
            // 
            // FormGestionInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvInsumos);
            Name = "FormGestionInsumos";
            Text = "FormGestionInsumos";
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNombreInsumo;
        private TextBox txtCantidad;
        private TextBox txtProveedor;
        private Button btnGuardarInsumo;
        private Button btnVolver;
        private DateTimePicker dtpFechaVencimiento;
        private DataGridView dgvInsumos;
        private Button btnEliminarInsumo;
        private NumericUpDown numCantidad;
        private DataGridViewTextBoxColumn NombreInsumo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Panel panel2;
    }
}