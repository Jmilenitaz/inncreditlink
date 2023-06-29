using System;
using InnCreditLink.infrastructure;
public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public decimal Cupo { get; set; }
    public decimal Deuda { get; set; }

    public static Cliente CrearCliente(int idCliente, string nombre, string apellido, string direccion, string telefono, decimal cupo, decimal deuda)
    {
        var nuevoCliente = new Cliente
        {
            IdCliente = idCliente,
            Nombre = nombre,
            Apellido = apellido,
            Direccion = direccion,
            Telefono = telefono,
            Cupo = cupo,
            Deuda = deuda
        };

        return nuevoCliente;
    }

    public void GuardarEnBaseDeDatos()
    {
        string connectionString = "Server=tcp:mssql-co-nop-ingenieria.database.windows.net,1433;Initial Catalog=dbinnovacion;Persist Security Info=False;User ID=dbadmin;Password=m6RdBPgfN)9GTF{2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; // Reemplaza con tu cadena de conexión real
        var clienteRepository = new ClienteRepository(connectionString);
        clienteRepository.GuardarCliente(this);
    }

    public bool ValidarCupoDisponible()
    {
        decimal cupoUtilizado = CalcularCupoUtilizado();
        decimal cupoDisponible = Cupo - cupoUtilizado;
        return cupoDisponible >= 0;
    }

    private decimal CalcularCupoUtilizado()
    {
        decimal deudaTotal = 0;
        foreach (var credito in Creditos)
        {
            deudaTotal += credito.Monto;
        }
        return deudaTotal;
    }
}