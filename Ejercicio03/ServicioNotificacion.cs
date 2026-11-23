class ServicioNotificacion
{
    public void EnviarNotificacion(object? sender, BackupEventArgs e)
    {
        Console.WriteLine($"[Notificación] Backup de {e.NombreArchivo} completado");
    }
}
