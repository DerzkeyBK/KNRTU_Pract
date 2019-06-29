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
        public int Questions;
        public int Time;

        public string connectionString { get; set; }

        public PostgreServerWorker(string s)
        {
            if(s!="") connectionString = s;
            else { connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=1q2w3e4r;Database=postgres;"; }            
        }
        public void Work()
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            var command_text = "SELECT MAX(id) AS number FROM test";
            var comm = new NpgsqlCommand(command_text, npgSqlConnection);
            var result = comm.ExecuteScalar();
            Questions = Convert.ToInt32(result);
            command_text = "SELECT SUM(time) FROM test";
            comm = new NpgsqlCommand(command_text, npgSqlConnection);
            result = comm.ExecuteScalar();
            Time = Convert.ToInt32(result);
            npgSqlConnection.Close();

        }
    }
}
