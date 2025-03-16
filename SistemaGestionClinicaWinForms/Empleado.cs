using System;

public class Empleado
{
    public string Nombre { get; set; }
    public string Cargo { get; set; }
    public string Consultorio { get; set; }
    public string Telefono { get; set; }

    public Empleado(string nombre, string cargo, string consultorio, string telefono)
    {
        Nombre = nombre;
        Cargo = cargo;
        Consultorio = consultorio;
        Telefono = telefono;
    }
}
