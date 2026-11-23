class RegistroVentas
{
    public event EventHandler<VentaEventArgs>? VentaRealizada;

    public void ProcesarVenta(string producto, double precio)
    {
        Console.WriteLine($"Procesando venta de {producto}...");
        VentaRealizada?.Invoke(this, new VentaEventArgs(producto, precio));
    }
}
