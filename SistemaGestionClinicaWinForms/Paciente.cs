using System;
using System.Collections.Generic;

namespace SistemaGestionClinicaWinForms
{
    public class Paciente
    {
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public required string Direccion { get; set; }
        public List<Cita> HistorialCitas { get; set; } = new List<Cita>();
        public string HistorialMedico { get; set; } = "";

        public void AgregarCitaAlHistorial(Cita cita)
        {
            HistorialCitas.Add(cita);
            HistorialMedico += $"{cita.FechaCita}: {cita.Doctor} - {cita.Sintomas} - Consultorio {cita.Consultorio}\n";
        }
    }
}