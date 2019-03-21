namespace PostgreSQL.NetCore
{
    public static class ConnectionService
    {
        private static string Server = "PLACEHOLDER.postgres.database.azure.com";
        private static string Username = "PLACEHOLDER@postgresqlserverks";
        private static string Database = "PLACEHOLDER";
        private static string Password = "PLACEHOLDER";

        public static string GetPostgreSQLConnectionString()
            => $"Server={Server};Username={Username};Database={Database};Port=5432;Password={Password};SSLMode=Prefer";
    }
}