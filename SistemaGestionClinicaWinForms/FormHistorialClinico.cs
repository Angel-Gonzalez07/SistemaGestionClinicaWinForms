using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SistemaGestionClinicaWinForms
{
    public partial class FormHistorialClinico : Form
    {
        private Paciente pacienteActual;
        public FormHistorialClinico(Paciente paciente)
        {
            InitializeComponent();
            pacienteActual = paciente;
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtNombrePaciente.Text = pacienteActual.Nombre;
            txtHistorial.Text = pacienteActual.HistorialMedico;

            listBoxHistorial.Items.Clear();
            foreach (var cita in pacienteActual.HistorialCitas)
            {
                listBoxHistorial.Items.Add($"{cita.FechaCita}: {cita.Doctor} - {cita.Consultorio}");
            }
        }



        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHistorial.SelectedIndex != -1)
            {
                MessageBox.Show($"Detalles de la cita:\n{listBoxHistorial.SelectedItem.ToString()}",
                    "Información de la Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FormHistorialClinico_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
