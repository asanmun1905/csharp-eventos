class ServicioRegistroTemperatura
{
    public void RegistrarTemperatura(object? sender, TemperaturaEventArgs e)
    {
        Console.WriteLine($"[Registro] Temperatura registrada: {e.TemperaturaActual}°C");
    }
}
