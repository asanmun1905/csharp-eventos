class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 3");
        Console.WriteLine();

        GestorBackups gestor = new GestorBackups();
        ServicioNotificacion servicioNotificacion = new ServicioNotificacion();
        ServicioLog servicioLog = new ServicioLog();

        gestor.BackupCompletado += servicioNotificacion.EnviarNotificacion;
        gestor.BackupCompletado += servicioLog.RegistrarBackup;

        gestor.RealizarBackup("documentos.zip");
        Console.WriteLine();
        gestor.RealizarBackup("fotos.zip");
    }
}
