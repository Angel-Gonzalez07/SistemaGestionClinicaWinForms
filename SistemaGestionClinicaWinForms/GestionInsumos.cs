using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

public static class GestionInsumos
{
    private static string rutaArchivoInsumos = "insumos.json";
    private static List<Insumo> insumos = new List<Insumo>();

    public static void AgregarInsumo (Insumo nuevoInsumo)
    {
        insumos.Add(nuevoInsumo);
        GuardarInsumos();
    }

    public static List<Insumo> ObtenerInsumos()
    {
        CargarInsumos();
        return insumos;
    }

    public static void EliminarInsumo(int index)
    {
        if (index >= 0 && index < insumos.Count)
        {
            insumos.RemoveAt(index);
        }
    }

    public static void GuardarInsumos()
    {
        string json = JsonSerializer.Serialize(insumos);
        File.WriteAllText(rutaArchivoInsumos, json);
    }

    public static void CargarInsumos()
    {
        if (File.Exists(rutaArchivoInsumos))
        {
            string json = File.ReadAllText(rutaArchivoInsumos);
            insumos = JsonSerializer.Deserialize<List<Insumo>>(json) ?? new List<Insumo>();
        }
    }
}
