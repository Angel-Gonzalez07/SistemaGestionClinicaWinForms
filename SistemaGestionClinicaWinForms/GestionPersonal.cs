using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

public static class GestionPersonal
{
    private static List<Empleado> empleados = new List<Empleado>();

    public static void AgregarEmpleado(Empleado nuevoEmpleado)
    {
        empleados.Add(nuevoEmpleado);
        GuardarPersonal();
    }

    public static List<Empleado> ObtenerEmpleados()
    {
        CargarPersonal();
        return empleados;
    }

    private static string rutaArchivoPersonal = "personal.Json";
   

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

    public static List<Empleado> ObtenerDoctores()
    {
        return empleados.Where(e => e.Cargo == "Médico").ToList();
    }

}

