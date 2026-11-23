class ServicioRegistroIncidencias
{
    public void GuardarIncidencia(object? sender, IntrusoEventArgs e)
    {
        // Simulación: aquí iría el guardado en la base de datos
        Console.WriteLine($"[Base de datos] Incidencia guardada: {e.NombreSensor} a las {e.HoraDeteccion:HH:mm}");
    }
}
