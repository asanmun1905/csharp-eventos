class BackupEventArgs : EventArgs
{
    public string NombreArchivo { get; }
    public DateTime Fecha { get; }

    public BackupEventArgs(string nombreArchivo, DateTime fecha)
    {
        NombreArchivo = nombreArchivo;
        Fecha = fecha;
    }
}
