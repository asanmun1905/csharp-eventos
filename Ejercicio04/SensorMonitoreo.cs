class SensorMonitoreo
{
    // Horario permitido: de las 8:00 a las 22:00
    private int horaInicio = 8;
    private int horaFin = 22;

    public event EventHandler<IntrusoEventArgs>? AlertaIntruso;

    public void DetectarApertura(string nombreSensor, DateTime hora)
    {
        Console.WriteLine($"{nombreSensor} abierta a las {hora:HH:mm}");
        if (hora.Hour < horaInicio || hora.Hour >= horaFin)
        {
            AlertaIntruso?.Invoke(this, new IntrusoEventArgs(nombreSensor, hora));
        }
    }
}
