using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using SistemaGestionClinicaWinForms;

public static class GestionPacientesCitas
{


    private static List<Paciente> pacientes = new List<Paciente>();
    private static List<Cita> citas = new List<Cita>();

    public static void AgregarPaciente(Paciente nuevoPaciente)
    {
        pacientes.Add(nuevoPaciente);
    }

    public static List<Paciente> ObtenerPacientes()
    {
        return pacientes;
    }

    public static void AgendarCita(Cita nuevaCita)
    {
        citas.Add(nuevaCita);

        Paciente paciente = pacientes.Find(p => p.Nombre == nuevaCita.NombrePaciente);
        if(paciente != null)
        {
            paciente.AgregarCitaAlHistorial(nuevaCita);
        }
    }

    public static List<Cita> ObtenerCitas()
    {
        return citas;
    }

    public static void ModificarCita(int index, Cita citaActualizada)
    {
        if (index >= 0 && index < citas.Count)
        {
            citas[index] = citaActualizada;
        }
    }

    public static void EliminarCita(int index)
    {
        if (index >= 0 && index < citas.Count)
        {
            citas.RemoveAt(index);
        }
    }

    private static string rutaArchivoPersonal = "personal.json";
    private static List<Empleado> empleados = new List<Empleado>();

    public static void GuardarPersonal()
    {
        string json = JsonSerializer.Serialize(empleados);
        File.WriteAllText(rutaArchivoPersonal, json);
    }

    public static void CargarPersonal()
    {
        if (File.Exists(rutaArchivoPersonal))
        {
            string json = File.ReadAllText(rutaArchivoPersonal);
            empleados = JsonSerializer.Deserialize<List<Empleado>>(json) ?? new List<Empleado>();
        }
    }

    public static void AgregarEmpleado(Empleado nuevoEmpleado)
    {
        empleados.Add(nuevoEmpleado);
        GuardarPersonal(); // 🔹 Guardar cada vez que se agregue un empleado
    }

    public static List<Empleado> ObtenerEmpleados()
    {
        CargarPersonal(); // 🔹 Cargar antes de devolver la lista
        return empleados;
    }

}


