public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Cupo { get; set; }
    public string Deuda { get; set; }
    public bool ValidarCupoDisponible(decimal Cupo)
    {
        decimal cupoUtilizado = CalcularCupoUtilizado();
        decimal cupoDisponible = CupoMaximo - cupoUtilizado;

        return Cupo <= cupoDisponible;
    }

    private decimal CalcularCupoUtilizado()
    {
        decimal Deuda = 0;

        foreach (var credito in Creditos)
        {
            Deuda += credito.Monto;
        }

        return cupoUtilizado;
    }

}
