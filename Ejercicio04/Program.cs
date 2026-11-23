class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 4");
        Console.WriteLine();

        SensorMonitoreo sensor = new SensorMonitoreo();
        ServicioAlarma servicioAlarma = new ServicioAlarma();
        ServicioRegistroIncidencias servicioIncidencias = new ServicioRegistroIncidencias();

        sensor.AlertaIntruso += servicioAlarma.ActivarAlarma;
        sensor.AlertaIntruso += servicioIncidencias.GuardarIncidencia;

        sensor.DetectarApertura("Puerta principal", new DateTime(2026, 11, 23, 15, 30, 0));
        Console.WriteLine();
        sensor.DetectarApertura("Ventana del salón", new DateTime(2026, 11, 23, 3, 15, 0));
        Console.WriteLine();
        sensor.DetectarApertura("Puerta del garaje", new DateTime(2026, 11, 23, 23, 40, 0));
    }
}
