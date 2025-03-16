namespace SistemaGestionClinicaWinForms
{
    partial class FormHistorialClinico
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
            txtNombrePaciente = new TextBox();
            btnGuardarHistorial = new Button();
            btnVolverMenu = new Button();
            txtHistorial = new TextBox();
            listBoxHistorial = new ListBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(3, 37);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.PlaceholderText = "Nombre del Paciente";
            txtNombrePaciente.Size = new Size(138, 23);
            txtNombrePaciente.TabIndex = 3;
            txtNombrePaciente.TextChanged += txtNombrePaciente_TextChanged;
            // 
            // btnGuardarHistorial
            // 
            btnGuardarHistorial.Location = new Point(3, 169);
            btnGuardarHistorial.Name = "btnGuardarHistorial";
            btnGuardarHistorial.Size = new Size(138, 23);
            btnGuardarHistorial.TabIndex = 6;
            btnGuardarHistorial.Text = "Guardar Cambios";
            btnGuardarHistorial.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(3, 124);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(138, 23);
            btnVolverMenu.TabIndex = 8;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(3, 76);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.PlaceholderText = "Historial Medico";
            txtHistorial.ReadOnly = true;
            txtHistorial.ScrollBars = ScrollBars.Vertical;
            txtHistorial.Size = new Size(138, 23);
            txtHistorial.TabIndex = 9;
            // 
            // listBoxHistorial
            // 
            listBoxHistorial.FormattingEnabled = true;
            listBoxHistorial.IntegralHeight = false;
            listBoxHistorial.ItemHeight = 15;
            listBoxHistorial.Location = new Point(147, 72);
            listBoxHistorial.Name = "listBoxHistorial";
            listBoxHistorial.ScrollAlwaysVisible = true;
            listBoxHistorial.Size = new Size(786, 484);
            listBoxHistorial.TabIndex = 11;
            listBoxHistorial.SelectedIndexChanged += listBoxHistorial_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 71);
            panel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(303, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(303, 50);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Historial Clinico";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Controls.Add(txtNombrePaciente);
            panel2.Controls.Add(txtHistorial);
            panel2.Controls.Add(btnVolverMenu);
            panel2.Controls.Add(btnGuardarHistorial);
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 451);
            panel2.TabIndex = 13;
            // 
            // FormHistorialClinico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(932, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listBoxHistorial);
            Name = "FormHistorialClinico";
            Text = "x";
            Load += FormHistorialClinico_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNombrePaciente;
        private Button btnGuardarHistorial;
        private Button btnVolverMenu;
        private TextBox txtHistorial;
        private ListBox listBoxHistorial;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel linkLabel1;
    }
}