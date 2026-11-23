class TemperaturaEventArgs : EventArgs
{
    public double TemperaturaActual { get; }
    public double Umbral { get; }

    public TemperaturaEventArgs(double temperaturaActual, double umbral)
    {
        TemperaturaActual = temperaturaActual;
        Umbral = umbral;
    }
}
