public class ClienteRepository
{
    private string connectionString; 

    public ClienteRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void GuardarCliente(Cliente cliente)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Clientes (IdCliente, Nombre, Apellido, Direccion, Telefono, Cupo, Deuda  ) VALUES (@IdCliente, @Nombre, @Apellido, @Direccion, @Telefono, @Cupo, @Deuda)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
            command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            command.Parameters.AddWithValue("@Cupo", cliente.Cupo);
            command.Parameters.AddWithValue("@Deuda", cliente.Deuda);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}


