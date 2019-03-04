using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace SysVenda.Api.Data
{
    public class QueryMySql
    {
        private static IConfigurationRoot Configuration { get; set; }
        private string connectionString;
        private MySqlConnection connection = default(MySqlConnection);

        public QueryMySql()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            
            connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            connection = new MySqlConnection(connectionString);            
        }

        public MySqlDataReader SqlOpen(string comando)
        {
            var command = connection.CreateCommand();
            connection.Open();
            command.CommandText = comando;
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void SqlClose()
        {
            connection.Close();
        }

    }
}
