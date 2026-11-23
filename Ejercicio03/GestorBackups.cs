class GestorBackups
{
    public event EventHandler<BackupEventArgs>? BackupCompletado;

    public void RealizarBackup(string nombreArchivo)
    {
        Console.WriteLine($"Haciendo copia de seguridad de {nombreArchivo}...");
        BackupCompletado?.Invoke(this, new BackupEventArgs(nombreArchivo, DateTime.Now));
    }
}
