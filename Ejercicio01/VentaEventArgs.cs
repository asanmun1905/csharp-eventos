class VentaEventArgs : EventArgs
{
    public string Producto { get; }
    public double Precio { get; }

    public VentaEventArgs(string producto, double precio)
    {
        Producto = producto;
        Precio = precio;
    }
}
