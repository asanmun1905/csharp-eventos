class MonitorEnergia
{
    private double umbral;

    public event EventHandler<EnergiaEventArgs>? ConsumoExcesivoDetectado;

    public MonitorEnergia(double umbral)
    {
        this.umbral = umbral;
    }

    public void RegistrarConsumo(double consumo)
    {
        Console.WriteLine($"Consumo registrado: {consumo} kWh");
        if (consumo > umbral)
        {
            ConsumoExcesivoDetectado?.Invoke(this, new EnergiaEventArgs(consumo, umbral));
        }
    }
}
