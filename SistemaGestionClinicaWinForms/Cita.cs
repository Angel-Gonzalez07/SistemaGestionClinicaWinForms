using System;

public class Cita
{
    public string NombrePaciente { get; set; }
    public DateTime FechaCita { get; set; }
    public string Doctor { get; set; }
    public string Sintomas { get; set; }
    public string Consultorio { get; set; }

    public Cita(string nombrePaciente, DateTime fechaCita, string doctor, string sintomas, string consultorio)
    {
        NombrePaciente = nombrePaciente;
        FechaCita = fechaCita;
        Doctor = doctor;
        Sintomas = sintomas;
        Consultorio = consultorio;
    }
}

