using System;
using Npgsql;

namespace PostgreSQL.NetCore
{
    public class PostgreSQLService
    {
        private readonly string connectionString;

        public PostgreSQLService()
            => connectionString = ConnectionService.GetPostgreSQLConnectionString();

        public void PrintClients()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM client", connection))
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader.GetInt32(0)} Username: {reader.GetString(1)} Age: {reader.GetInt16(2)}");
                    }
                }
            }
        }

        public void AddClient(Client client)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("INSERT INTO client(username, age) VALUES(@u, @a)", connection))
                {
                    command.Parameters.AddWithValue("u", client.UserName);
                    command.Parameters.AddWithValue("a", client.Age);

                    int rows = command.ExecuteNonQuery();
                    Console.WriteLine($"Number of rows inserted={rows}");
                }
            }
        }

        public void RemoveClient(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("DELETE FROM client WHERE id = @i", connection))
                {
                    command.Parameters.AddWithValue("i", id);

                    int rows = command.ExecuteNonQuery();
                    Console.WriteLine($"Number of rows deleted={rows}");
                }
            }
        }
    }
}