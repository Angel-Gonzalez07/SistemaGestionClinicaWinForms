using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionClinicaWinForms
{
    public partial class FormGestionPersonal : Form
    {
        public FormGestionPersonal()
        {
            InitializeComponent();
        }

        private void FormGestionPersonal_Load(object sender, EventArgs e)
        {
            dgvPersonal.Rows.Clear();
            List<Empleado> empleados = GestionPersonal.ObtenerEmpleados();

            foreach (var empleado in empleados)
            {
                dgvPersonal.Rows.Add(empleado.Nombre, empleado.Cargo, empleado.Consultorio, empleado.Telefono);
            }
        }

        private List<string> listaPersonal = new List<string>();

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePersonal.Text;
            string cargo = cmbCargo.SelectedItem.ToString();
            string consultorio = txtConsultorio.Text;
            string telefono = txtTelefonoPersonal.Text;


            if (!string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono)) 
            {
                MessageBox.Show("Por favor, complete todos los campos Obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado nuevoEmpleado = new Empleado(nombre, cargo, consultorio, telefono);
            GestionPersonal.AgregarEmpleado(nuevoEmpleado);

            MessageBox.Show("Empleado registrado corretamente. ");

        }
        private void ActualizarListaPersonal()
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombrePersonal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
