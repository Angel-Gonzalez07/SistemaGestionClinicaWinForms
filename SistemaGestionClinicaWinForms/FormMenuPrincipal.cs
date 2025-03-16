using System;
using System.Windows.Forms;

namespace SistemaGestionClinicaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGestionCitas_Click(object sender, EventArgs e)
        {
            FormGestionCitasPacientes formCitas = new FormGestionCitasPacientes();
            formCitas.Show();
            this.Hide();  // Oculta el menú mientras se abre el módulo
        }

        private void btnGestionInsumos_Click(object sender, EventArgs e)
        {
            FormGestionInsumos formInsumos = new FormGestionInsumos();
            formInsumos.Show();
            this.Hide();
        }

        private void btnGestionPersonal_Click(object sender, EventArgs e)
        {
            FormGestionPersonal formPersonal = new FormGestionPersonal();
            formPersonal.Show();
            this.Hide();
        }


        private void btnHistorialCinico_Click_1(object sender, EventArgs e)
        {
            List<Paciente> listaPacientes = GestionPacientesCitas.ObtenerPacientes();

            if (listaPacientes.Count > 0)
            {
                FormHistorialClinico formHistorial = new FormHistorialClinico(listaPacientes[0]);
                formHistorial.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay pacientes registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
