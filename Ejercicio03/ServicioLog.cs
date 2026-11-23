class ServicioLog
{
    public void RegistrarBackup(object? sender, BackupEventArgs e)
    {
        Console.WriteLine($"[Log] {e.Fecha:dd/MM/yyyy HH:mm:ss} - Backup de {e.NombreArchivo}");
    }
}
