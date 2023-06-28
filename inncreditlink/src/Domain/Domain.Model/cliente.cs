public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Cupo { get; set; }
    public string Deuda { get; set; }
    
    

    public static Cliente CrearCliente(string nombre, string apellido, string email, DateTime fechaNacimiento)
    {
        // Crear instancia de Cliente con los datos solicitados
        var nuevoCliente = new Cliente
        {
            IdCliente = idcliente,
            Nombre = nombre,
            Apellido = apellido,
            Direccion = direccion,
            Telefono = telefono,
            Cupo = cupo,
            Deuda = deuda

            public void GuardarEnBaseDeDatos()
            {
                string connectionString = "tu_cadena_de_conexion"; // Reemplaza con tu cadena de conexion real
                var clienteRepository = new ClienteRepository(connectionString);
                clienteRepository.GuardarCliente(this);
            }
        };
        
        
        return nuevoCliente;
    }
    

    
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
