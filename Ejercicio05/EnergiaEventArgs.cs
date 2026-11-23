class EnergiaEventArgs : EventArgs
{
    public double ConsumoActual { get; }
    public double Umbral { get; }

    public EnergiaEventArgs(double consumoActual, double umbral)
    {
        ConsumoActual = consumoActual;
        Umbral = umbral;
    }
}
