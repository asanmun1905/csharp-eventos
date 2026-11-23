class ControlTemperatura
{
    private double umbral;

    public event EventHandler<TemperaturaEventArgs>? TemperaturaAlta;

    public ControlTemperatura(double umbral)
    {
        this.umbral = umbral;
    }

    public void ComprobarTemperatura(double temperatura)
    {
        Console.WriteLine($"Temperatura medida: {temperatura}°C");
        if (temperatura > umbral)
        {
            TemperaturaAlta?.Invoke(this, new TemperaturaEventArgs(temperatura, umbral));
        }
    }
}
