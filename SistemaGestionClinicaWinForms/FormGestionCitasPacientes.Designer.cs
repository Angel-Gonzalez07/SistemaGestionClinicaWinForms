namespace SistemaGestionClinicaWinForms
{
    partial class FormGestionCitasPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionCitasPacientes));
            txtFechaHoraCita = new TextBox();
            txtNombrePaciente = new TextBox();
            btnAgendarCita = new Button();
            btnVolver = new Button();
            comboBoxDoctor = new ComboBox();
            txtConsultorio = new TextBox();
            txtSintomas = new TextBox();
            dtpFechaCita = new DateTimePicker();
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            linkLabel1 = new LinkLabel();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtHistorialClinico = new TextBox();
            btnGuardarPaciente = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            dgvCitas = new DataGridView();
            NombrePaciente = new DataGridViewTextBoxColumn();
            FechaCita = new DataGridViewTextBoxColumn();
            Doctoe = new DataGridViewTextBoxColumn();
            Sintomas = new DataGridViewTextBoxColumn();
            Consultorio = new DataGridViewTextBoxColumn();
            btnModificarCita = new Button();
            btnEliminarCita = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // txtFechaHoraCita
            // 
            txtFechaHoraCita.Location = new Point(268, 222);
            txtFechaHoraCita.Name = "txtFechaHoraCita";
            txtFechaHoraCita.PlaceholderText = "Fecha de la Cita y Hora";
            txtFechaHoraCita.ReadOnly = true;
            txtFechaHoraCita.Size = new Size(212, 23);
            txtFechaHoraCita.TabIndex = 1;
            txtFechaHoraCita.TextChanged += txtFechaCita_TextChanged;
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(0, 105);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.PlaceholderText = "Nombre del Paciente";
            txtNombrePaciente.Size = new Size(209, 23);
            txtNombrePaciente.TabIndex = 2;
            txtNombrePaciente.TextChanged += txtNombrePaciente_TextChanged;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.ForeColor = SystemColors.ButtonFace;
            btnAgendarCita.Location = new Point(268, 318);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(209, 23);
            btnAgendarCita.TabIndex = 6;
            btnAgendarCita.Text = "Agendar Cita";
            btnAgendarCita.Click += btnAgendarCita_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Navy;
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(4, 490);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(153, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver al Menu";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(268, 125);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(209, 23);
            comboBoxDoctor.TabIndex = 6;
            comboBoxDoctor.Text = "Sellecione un Doctor";
            comboBoxDoctor.SelectedIndexChanged += comboBoxDoctor_SelectedIndexChanged;
            // 
            // txtConsultorio
            // 
            txtConsultorio.Location = new Point(268, 269);
            txtConsultorio.Name = "txtConsultorio";
            txtConsultorio.PlaceholderText = "Numero de consultorio";
            txtConsultorio.Size = new Size(209, 23);
            txtConsultorio.TabIndex = 9;
            txtConsultorio.TextChanged += txtConsultorio_TextChanged;
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(268, 170);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.PlaceholderText = "Sintomas";
            txtSintomas.Size = new Size(209, 23);
            txtSintomas.TabIndex = 10;
            txtSintomas.TextChanged += txtSintomas_TextChanged;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.CalendarForeColor = SystemColors.ButtonFace;
            dtpFechaCita.CalendarMonthBackground = Color.DarkBlue;
            dtpFechaCita.CalendarTitleForeColor = SystemColors.ButtonFace;
            dtpFechaCita.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaCita.Location = new Point(740, 75);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(281, 23);
            dtpFechaCita.TabIndex = 11;
            dtpFechaCita.ValueChanged += dtpFechaCita_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 70);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(409, 1);
            label2.Name = "label2";
            label2.Size = new Size(389, 65);
            label2.TabIndex = 0;
            label2.Text = "Gestion de Citas";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(157, 78);
            panel3.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BorderStyle = BorderStyle.FixedSingle;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(0, 81);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 17);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Datos del Paciente";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(0, 151);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(209, 23);
            txtTelefono.TabIndex = 16;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(-3, 205);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(212, 23);
            txtDireccion.TabIndex = 17;
            // 
            // txtHistorialClinico
            // 
            txtHistorialClinico.Location = new Point(-3, 257);
            txtHistorialClinico.Multiline = true;
            txtHistorialClinico.Name = "txtHistorialClinico";
            txtHistorialClinico.PlaceholderText = "Historial Clinico (Multilinea)";
            txtHistorialClinico.ReadOnly = true;
            txtHistorialClinico.ScrollBars = ScrollBars.Vertical;
            txtHistorialClinico.Size = new Size(209, 23);
            txtHistorialClinico.TabIndex = 18;
            txtHistorialClinico.TextChanged += txtHistorialClinico_TextChanged;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.Location = new Point(0, 318);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(209, 23);
            btnGuardarPaciente.TabIndex = 19;
            btnGuardarPaciente.Text = "Guardar Paciente";
            btnGuardarPaciente.UseVisualStyleBackColor = true;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BorderStyle = BorderStyle.FixedSingle;
            linkLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(293, 91);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(83, 17);
            linkLabel2.TabIndex = 20;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Agendar Cita:";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BorderStyle = BorderStyle.FixedSingle;
            linkLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(570, 111);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(113, 17);
            linkLabel3.TabIndex = 21;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Citas Programadas:\r\n";
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Columns.AddRange(new DataGridViewColumn[] { NombrePaciente, FechaCita, Doctoe, Sintomas, Consultorio });
            dgvCitas.Location = new Point(506, 145);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(743, 374);
            dgvCitas.TabIndex = 22;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // NombrePaciente
            // 
            NombrePaciente.HeaderText = "Nombre del Paciente";
            NombrePaciente.Name = "NombrePaciente";
            // 
            // FechaCita
            // 
            FechaCita.HeaderText = "Fecha y Hora de la cita";
            FechaCita.Name = "FechaCita";
            // 
            // Doctoe
            // 
            Doctoe.HeaderText = "Nombre del doctor asignado";
            Doctoe.Name = "Doctoe";
            // 
            // Sintomas
            // 
            Sintomas.HeaderText = "Sintomas del Paciente";
            Sintomas.Name = "Sintomas";
            // 
            // Consultorio
            // 
            Consultorio.HeaderText = "Consultorio";
            Consultorio.Name = "Consultorio";
            // 
            // btnModificarCita
            // 
            btnModificarCita.Location = new Point(703, 107);
            btnModificarCita.Name = "btnModificarCita";
            btnModificarCita.Size = new Size(129, 23);
            btnModificarCita.TabIndex = 23;
            btnModificarCita.Text = "Modificar Cita";
            btnModificarCita.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.Location = new Point(864, 105);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(129, 23);
            btnEliminarCita.TabIndex = 24;
            btnEliminarCita.Text = "Eliminar Cita";
            btnEliminarCita.UseVisualStyleBackColor = true;
            btnEliminarCita.Click += btnEliminarCita_Click;
            // 
            // FormGestionCitasPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1261, 525);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminarCita);
            Controls.Add(btnModificarCita);
            Controls.Add(btnAgendarCita);
            Controls.Add(dgvCitas);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(btnGuardarPaciente);
            Controls.Add(txtHistorialClinico);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(linkLabel1);
            Controls.Add(dtpFechaCita);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txtSintomas);
            Controls.Add(txtConsultorio);
            Controls.Add(comboBoxDoctor);
            Controls.Add(txtNombrePaciente);
            Controls.Add(txtFechaHoraCita);
            Name = "FormGestionCitasPacientes";
            Text = "FormGestionCitas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFechaHoraCita;
        private TextBox txtNombrePaciente;
        private Button btnAgendarCita;
        private Button btnVolver;
        private ComboBox comboBoxDoctor;
        private TextBox txtConsultorio;
        private TextBox txtSintomas;
        private DateTimePicker dtpFechaCita;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtHistorialClinico;
        private Button btnGuardarPaciente;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private DataGridView dgvCitas;
        private Button btnModificarCita;
        private Button btnEliminarCita;
        private Button btnHistorialClinico;
        private DataGridViewTextBoxColumn NombrePaciente;
        private DataGridViewTextBoxColumn FechaCita;
        private DataGridViewTextBoxColumn Doctoe;
        private DataGridViewTextBoxColumn Sintomas;
        private DataGridViewTextBoxColumn Consultorio;
    }
}