class ServicioNotificacion
{
    public void EnviarNotificacionVenta(object? sender, VentaEventArgs e)
    {
        Console.WriteLine($"[Notificación] Se ha vendido {e.Producto} por {e.Precio:0.00}€");
    }
}
