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

        public NpgsqlConnection npgSqlConnection { get; set; }

        public PostgreServerWorker(string s)
        {
            if (s != "")
            {
                var connectionString = s;
                npgSqlConnection = new NpgsqlConnection(connectionString);
            }
            else
            {
                var connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=1q2w3e4r;Database=postgres;";
                npgSqlConnection = new NpgsqlConnection(connectionString);
            }            
        }
        public void TryConnection()
        {
            npgSqlConnection.Open();
            npgSqlConnection.Close();

        }

        public int GetQuestion(int i)
        {
            npgSqlConnection.Open();
            var command_text = "SELECT MAX(id) AS number FROM test";
            var comm = new NpgsqlCommand(command_text, npgSqlConnection);
            var result = comm.ExecuteScalar();
            npgSqlConnection.Close();
            Random r = new Random();
            var questionID =r.Next(1,Convert.ToInt32(result));
            QuestionModel questionModel = new QuestionModel(npgSqlConnection,questionID);
            QuestionForm question = new QuestionForm(questionModel,i);
            

        }
    }
}
