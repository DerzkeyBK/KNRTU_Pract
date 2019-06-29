using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace KNRTU_Pract
{
    public class PostgreServerWorker
    {
        
        public string connectionString { get; set; }

        public PostgreServerWorker(string s)
        {
            if(s!=null) connectionString = s;
            else { s= "Server = localhost; Port = 5432; User = postgres; Password = 1q2w3e4r; Database = postgres"; }            
        }
        public void Work()
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            Console.WriteLine("Соединение с БД открыто");
        }
    }
}
