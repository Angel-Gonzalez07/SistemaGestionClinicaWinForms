namespace SistemaGestionClinicaWinForms
{
    partial class FormGestionPersonal
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
            txtNombrePersonal = new TextBox();
            txtTelefonoPersonal = new TextBox();
            btnGuardarPersonal = new Button();
            btnVolver = new Button();
            cmbCargo = new ComboBox();
            txtConsultorio = new TextBox();
            btnEliminar = new Button();
            dgvPersonal = new DataGridView();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            panel3 = new Panel();
            Nombre = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Consultorio = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombrePersonal
            // 
            txtNombrePersonal.Location = new Point(0, 27);
            txtNombrePersonal.Name = "txtNombrePersonal";
            txtNombrePersonal.PlaceholderText = "Nombre de el Personal";
            txtNombrePersonal.Size = new Size(177, 23);
            txtNombrePersonal.TabIndex = 3;
            txtNombrePersonal.TextChanged += txtNombrePersonal_TextChanged;
            // 
            // txtTelefonoPersonal
            // 
            txtTelefonoPersonal.Location = new Point(0, 200);
            txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            txtTelefonoPersonal.PlaceholderText = "Telefono";
            txtTelefonoPersonal.Size = new Size(177, 23);
            txtTelefonoPersonal.TabIndex = 5;
            // 
            // btnGuardarPersonal
            // 
            btnGuardarPersonal.Location = new Point(0, 264);
            btnGuardarPersonal.Name = "btnGuardarPersonal";
            btnGuardarPersonal.Size = new Size(177, 23);
            btnGuardarPersonal.TabIndex = 6;
            btnGuardarPersonal.Text = "Agregar Personal";
            btnGuardarPersonal.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(714, 57);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(177, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver al Menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Medico", "Enfermero", "Recepcionista", "Administrador", "Otro" });
            cmbCargo.Location = new Point(0, 78);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(177, 23);
            cmbCargo.TabIndex = 9;
            // 
            // txtConsultorio
            // 
            txtConsultorio.Location = new Point(0, 138);
            txtConsultorio.Name = "txtConsultorio";
            txtConsultorio.PlaceholderText = "Consultorio";
            txtConsultorio.Size = new Size(177, 23);
            txtConsultorio.TabIndex = 10;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(503, 57);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(177, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvPersonal
            // 
            dgvPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonal.Columns.AddRange(new DataGridViewColumn[] { Nombre, Cargo, Consultorio, Telefono });
            dgvPersonal.Location = new Point(177, 79);
            dgvPersonal.Name = "dgvPersonal";
            dgvPersonal.Size = new Size(771, 424);
            dgvPersonal.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnEliminar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 83);
            panel1.TabIndex = 13;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.MediumBlue;
            linkLabel1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(323, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(357, 50);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Gestion de Personal";
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 449);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumBlue;
            panel3.Controls.Add(txtNombrePersonal);
            panel3.Controls.Add(cmbCargo);
            panel3.Controls.Add(txtConsultorio);
            panel3.Controls.Add(btnGuardarPersonal);
            panel3.Controls.Add(txtTelefonoPersonal);
            panel3.Location = new Point(0, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 461);
            panel3.TabIndex = 14;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // Consultorio
            // 
            Consultorio.HeaderText = "Consultorio";
            Consultorio.Name = "Consultorio";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // FormGestionPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(943, 504);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dgvPersonal);
            Name = "FormGestionPersonal";
            Text = "FormGestionPersonal";
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNombrePersonal;
        private TextBox txtTelefonoPersonal;
        private Button btnGuardarPersonal;
        private Button btnVolver;
        private ComboBox cmbCargo;
        private TextBox txtConsultorio;
        private Button btnEliminar;
        private DataGridView dgvPersonal;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Consultorio;
        private DataGridViewTextBoxColumn Telefono;
    }
}