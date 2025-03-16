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
    public partial class FormGestionInsumos : Form
    {
        public FormGestionInsumos()
        {
            InitializeComponent();
        }

        private void FormGestionInsumos_Load(object sender, EventArgs e)
        {
            dgvInsumos.Rows.Clear();
            List<Insumo> insumos = GestionInsumos.ObtenerInsumos();

            foreach (var insumo in insumos)
            {
                dgvInsumos.Rows.Add(insumo.Nombre, insumo.Cantidad, insumo.Proveedor, insumo.FechaVencimiento.ToShortDateString());
            }
        }

        private List<string> listaInsumos = new List<string>();
        private void btnGuardarInsumo_Click(object sender, EventArgs e)
        {
            Insumo nuevoInsumo = new Insumo(
            txtNombreInsumo.Text,
            (int)numCantidad.Value,
            txtProveedor.Text,
            dtpFechaVencimiento.Value
            );

        }
        private void ActualizarListaInsumos()
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarInsumo_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.SelectedRows.Count > 0)
            {
                int index = dgvInsumos.SelectedRows[0].Index;
                GestionInsumos.EliminarInsumo(index);
                MessageBox.Show("Insumo Eliminado");
            }
        }

        private void txtNombreInsumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarInsumo_Click_1(object sender, EventArgs e)
        {

        }
    }
}

