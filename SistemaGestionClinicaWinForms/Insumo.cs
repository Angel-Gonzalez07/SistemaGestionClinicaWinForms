using System;

public class Insumo
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public string Proveedor { get; set; }
    public DateTime FechaVencimiento { get; set; }

    public Insumo(string nombre, int cantidad, string proveedor, DateTime fechavencimiento)
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Proveedor = proveedor;
        FechaVencimiento = fechavencimiento;    
    }
}
