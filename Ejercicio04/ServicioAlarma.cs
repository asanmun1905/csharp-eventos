class ServicioAlarma
{
    public void ActivarAlarma(object? sender, IntrusoEventArgs e)
    {
        Console.WriteLine($"[ALARMA] ¡Alarma activada! {e.NombreSensor} abierta fuera de horario");
    }
}
