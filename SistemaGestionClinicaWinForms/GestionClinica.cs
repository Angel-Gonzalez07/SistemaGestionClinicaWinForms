using System;
using System.Collections.Generic;

namespace SistemaGestionClinicaWinForms
{
    public class GestionClinica
    {
        public List<string> Citas { get; private set; } = new List<string>();
        public List<string> Pacientes { get; private set; } = new List<string>();

        public void AgregarCita(string cita)
        {
            Citas.Add(cita);
        }

        public void AgregarPaciente(string paciente)
        {
            Pacientes.Add(paciente);
        }

        public List<string> ObtenerCitas()
        {
            return Citas;
        }

        public List<string> ObtenerPacientes()
        {
            return Pacientes;
        }
    }
}

