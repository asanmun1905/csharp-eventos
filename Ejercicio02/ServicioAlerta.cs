class ServicioAlerta
{
    public void EnviarAlerta(object? sender, TemperaturaEventArgs e)
    {
        Console.WriteLine($"[ALERTA] ¡Temperatura alta en el invernadero! {e.TemperaturaActual}°C (umbral: {e.Umbral}°C)");
    }
}
