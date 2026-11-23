class ServicioNotificacion
{
    public void EnviarAdvertencia(object? sender, EnergiaEventArgs e)
    {
        Console.WriteLine($"[Advertencia] Consumo excesivo: {e.ConsumoActual} kWh (umbral: {e.Umbral} kWh)");
    }
}
