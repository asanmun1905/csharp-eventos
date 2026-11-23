class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1");
        Console.WriteLine();

        RegistroVentas registroVentas = new RegistroVentas();
        ServicioRegistro servicioRegistro = new ServicioRegistro();
        ServicioNotificacion servicioNotificacion = new ServicioNotificacion();

        registroVentas.VentaRealizada += servicioRegistro.RegistrarVenta;
        registroVentas.VentaRealizada += servicioNotificacion.EnviarNotificacionVenta;

        registroVentas.ProcesarVenta("Portátil", 899.99);
        Console.WriteLine();
        registroVentas.ProcesarVenta("Ratón", 19.50);
    }
}
