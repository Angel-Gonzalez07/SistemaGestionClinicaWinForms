using System;
using System.Windows.Forms;
using SistemaGestionClinica;

namespace SistemaGestionClinicaWinForms
{

    public partial class FormGestionCitasPacientes : Form
    {
        private GestionClinica gestionClinica = new GestionClinica();

        private List<Cita> citas = new List<Cita>();

        public FormGestionCitasPacientes()
        {
            InitializeComponent();

        }

        private void FormGestionCitasPaciente_Load(object sender, EventArgs e)
        {
            dgvCitas.Rows.Clear();
            dgvCitas.DataSource = GestionPacientesCitas.ObtenerCitas();

            foreach ( var cita in citas)
            {
                dgvCitas.Rows.Add(cita.NombrePaciente, cita.FechaCita, cita.Doctor, cita.Sintomas, cita.Consultorio);

            }
            foreach (var doctor in GestionPersonal.ObtenerDoctores())
            {
                comboBoxDoctor.Items.Add(doctor.Nombre + "- Consultorio" + doctor.Consultorio);
            }
        }

        private List<string> listaCitas = new List<string>();
        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            Cita nuevaCita = new Cita(txtNombrePaciente.Text, dtpFechaCita.Value, comboBoxDoctor.SelectedItem.ToString(), txtSintomas.Text, txtConsultorio.Text);
            GestionPacientesCitas.AgendarCita(nuevaCita);
            MessageBox.Show("CIta Afendada con exito.");
        }



        private void btnMostrarCitas_Click(object sender, EventArgs e)
        {

            foreach (var cita in gestionClinica.ObtenerPacientes())
            {

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            txtFechaHoraCita.Text = dtpFechaCita.Value.ToString("dd/MM/yyyy HH:mm");
            if (dtpFechaCita.Value < DateTime.Now)
            {
                MessageBox.Show("No se puede sellecionar una fecha/Hora pasada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaCita.Value = DateTime.Now; //Aqui se restrablece a la fecha actual

            }
        }

        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSintomas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaCita_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConsultorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            Paciente nuevoPaciente = new Paciente
            {
                Nombre = txtNombrePaciente.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                HistorialMedico = txtHistorialClinico.Text
            };
            GestionPacientesCitas.AgregarPaciente(nuevoPaciente);
            MessageBox.Show("Paciente Resgistrado Con Exito");
        }

        private void btnAgendarCita_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text) ||
                string.IsNullOrWhiteSpace(txtConsultorio.Text) ||
                string.IsNullOrWhiteSpace(txtSintomas.Text) ||
                comboBoxDoctor.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtFechaHoraCita.Text))
            {
                MessageBox.Show("Todos los cambos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaCita;
            if (!DateTime.TryParse(txtFechaHoraCita.Text, out fechaCita))
            {
                MessageBox.Show("Formato de fecha incorreto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validar que la fecha no sea el mismo dia ni el anterior
            if (fechaCita.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("No puedes agendar citas para hoy ni fechas anteriores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cita nuevaCita = new Cita(txtNombrePaciente.Text, dtpFechaCita.Value, comboBoxDoctor.SelectedItem.ToString(), txtSintomas.Text, txtConsultorio.Text);

            citas.Add(nuevaCita);

            string? nombrePaciente = dgvCitas.SelectedRows[0].Cells["NombrePaciente"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(nombrePaciente))
            {
                MessageBox.Show("El Paciente no tiene nombre resgistrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Paciente> listaPacientes = GestionPacientesCitas.ObtenerPacientes();
            Paciente paciente = listaPacientes.Find(p => p.Nombre == nombrePaciente);

            if (paciente != null)
            {
                paciente.AgregarCitaAlHistorial(nuevaCita);

            }
            else
            {
                MessageBox.Show("Paciente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GestionPacientesCitas.AgendarCita(nuevaCita);
            MessageBox.Show("Cita agendada con exito");
        }

        private void txtHistorialClinico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHistorialClinico_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sellecione un paciente para ver su historial. ");
                return;
            }

            string nombrePaciente = dgvCitas.SelectedRows[0].Cells["NombrePaciente"].Value.ToString();
            Paciente paciente = GestionPacientesCitas.ObtenerPacientes().Find(p => p.Nombre == nombrePaciente);


            if (paciente != null)
            {
                FormHistorialClinico formHistorial = new FormHistorialClinico(paciente);
                formHistorial.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se encontro la informacion del Paciente. ");
            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void ActualizarListaCitas()
        {
            dgvCitas.Rows.Clear(); // Limpia la tabla antes de agregar nuevos datos

            List<Cita> citas = GestionPacientesCitas.ObtenerCitas(); // Obtiene todas las citas registradas

            foreach (var cita in citas)
            {
                dgvCitas.Rows.Add(cita.NombrePaciente, cita.FechaCita, cita.Doctor, cita.Sintomas, cita.Consultorio);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
