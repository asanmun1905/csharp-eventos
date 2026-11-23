class IntrusoEventArgs : EventArgs
{
    public string NombreSensor { get; }
    public DateTime HoraDeteccion { get; }

    public IntrusoEventArgs(string nombreSensor, DateTime horaDeteccion)
    {
        NombreSensor = nombreSensor;
        HoraDeteccion = horaDeteccion;
    }
}
