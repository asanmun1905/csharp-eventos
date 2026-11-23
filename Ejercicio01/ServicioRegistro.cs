class ServicioRegistro
{
    public void RegistrarVenta(object? sender, VentaEventArgs e)
    {
        Console.WriteLine($"[Registro] Venta guardada: {e.Producto} por {e.Precio:0.00}€");
    }
}
