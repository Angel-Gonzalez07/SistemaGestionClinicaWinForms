namespace SistemaGestionClinicaWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGestionCitas = new Button();
            btnHistorialCinico = new Button();
            btnGestionInsumos = new Button();
            btnGestionPersonal = new Button();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnGestionCitas
            // 
            btnGestionCitas.BackColor = Color.MidnightBlue;
            btnGestionCitas.BackgroundImageLayout = ImageLayout.Stretch;
            btnGestionCitas.ForeColor = SystemColors.ButtonFace;
            btnGestionCitas.Location = new Point(0, 50);
            btnGestionCitas.Name = "btnGestionCitas";
            btnGestionCitas.Size = new Size(189, 32);
            btnGestionCitas.TabIndex = 0;
            btnGestionCitas.Text = "Gestion de Citas y Pacientes";
            btnGestionCitas.UseVisualStyleBackColor = false;
            btnGestionCitas.Click += btnGestionCitas_Click;
            // 
            // btnHistorialCinico
            // 
            btnHistorialCinico.BackColor = Color.MidnightBlue;
            btnHistorialCinico.ForeColor = SystemColors.ButtonFace;
            btnHistorialCinico.Location = new Point(0, 137);
            btnHistorialCinico.Name = "btnHistorialCinico";
            btnHistorialCinico.Size = new Size(189, 32);
            btnHistorialCinico.TabIndex = 2;
            btnHistorialCinico.Text = "Historial Clinico";
            btnHistorialCinico.UseVisualStyleBackColor = false;
            btnHistorialCinico.Click += btnHistorialCinico_Click_1;
            // 
            // btnGestionInsumos
            // 
            btnGestionInsumos.BackColor = Color.MidnightBlue;
            btnGestionInsumos.ForeColor = Color.White;
            btnGestionInsumos.Location = new Point(0, 205);
            btnGestionInsumos.Name = "btnGestionInsumos";
            btnGestionInsumos.Size = new Size(189, 32);
            btnGestionInsumos.TabIndex = 3;
            btnGestionInsumos.Text = "Gestion de insumos Medicos";
            btnGestionInsumos.UseVisualStyleBackColor = false;
            btnGestionInsumos.Click += btnGestionInsumos_Click;
            // 
            // btnGestionPersonal
            // 
            btnGestionPersonal.BackColor = Color.MidnightBlue;
            btnGestionPersonal.ForeColor = SystemColors.ButtonFace;
            btnGestionPersonal.Location = new Point(3, 274);
            btnGestionPersonal.Name = "btnGestionPersonal";
            btnGestionPersonal.Size = new Size(189, 32);
            btnGestionPersonal.TabIndex = 4;
            btnGestionPersonal.Text = "Gestion del Personal";
            btnGestionPersonal.UseVisualStyleBackColor = false;
            btnGestionPersonal.Click += btnGestionPersonal_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 77);
            panel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(345, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 50);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Menu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(btnGestionPersonal);
            panel2.Controls.Add(btnGestionInsumos);
            panel2.Controls.Add(btnHistorialCinico);
            panel2.Controls.Add(btnGestionCitas);
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(837, 465);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(828, 483);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionCitas;
        private Button btnHistorialCinico;
        private Button btnGestionInsumos;
        private Button btnGestionPersonal;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel linkLabel1;
    }
}
