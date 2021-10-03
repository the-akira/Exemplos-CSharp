using System;
using System.Data.SqlClient;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obtendo dados de conexão...");

            var datasource = @"localhost,1433"; // servidor
            var database = "TestDB"; // nome do banco de dados
            var username = "SA"; // username do servidor
            var password = "senha"; //senha

            // String de conexão 
            string connString = $@"Data Source={datasource};
                                   Initial Catalog={database};
                                   Persist Security Info=True;
                                   User ID={username};
                                   Password={password}";

            // Criar instância do banco de dados de conexão
            SqlConnection conn = new SqlConnection(connString);
            
            try
            {
                Console.WriteLine("Abrindo conexão...");
                conn.Open();
                Console.WriteLine("Conectado com sucesso!");
                conn.Close();
                Console.WriteLine("Fechando a conexão...");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}