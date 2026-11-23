class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 5");
        Console.WriteLine();

        MonitorEnergia monitor = new MonitorEnergia(100);
        ServicioNotificacion servicioNotificacion = new ServicioNotificacion();
        ServicioAjusteAutomatizado servicioAjuste = new ServicioAjusteAutomatizado();

        monitor.ConsumoExcesivoDetectado += servicioNotificacion.EnviarAdvertencia;
        monitor.ConsumoExcesivoDetectado += servicioAjuste.AjustarDispositivos;

        monitor.RegistrarConsumo(80);
        Console.WriteLine();
        monitor.RegistrarConsumo(120);
        Console.WriteLine();
        monitor.RegistrarConsumo(150.5);
    }
}
