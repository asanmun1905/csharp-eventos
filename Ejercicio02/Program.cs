class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 2");
        Console.WriteLine();

        ControlTemperatura control = new ControlTemperatura(30);
        ServicioAlerta servicioAlerta = new ServicioAlerta();
        ServicioRegistroTemperatura servicioRegistro = new ServicioRegistroTemperatura();

        control.TemperaturaAlta += servicioAlerta.EnviarAlerta;
        control.TemperaturaAlta += servicioRegistro.RegistrarTemperatura;

        control.ComprobarTemperatura(25);
        Console.WriteLine();
        control.ComprobarTemperatura(32);
        Console.WriteLine();
        control.ComprobarTemperatura(35.5);
    }
}
