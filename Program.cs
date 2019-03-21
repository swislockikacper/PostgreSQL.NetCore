using System;

namespace PostgreSQL.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PostgreSQLService();
            service.PrintClients();
           
            service.AddClient(new Client
            {
                UserName = "New User",
                Age = 40
            });

            service.RemoveClient(1);

            service.PrintClients();
        }
    }
}
