using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace KNRTU_Pract
{
    public class PostgreServerWorker
    {
        public NpgsqlConnection npgSqlConnection;

        public PostgreServerWorker(string s)
        {
            if (s == "")
            {
                var connectionString = "Server = localhost; Port = 5432;  Database = postgres; User ID = postgres; Password = 1q2w3e4r;";
                npgSqlConnection = new NpgsqlConnection(connectionString);

            }
            else
            {
                var connectionString = s;
                npgSqlConnection = new NpgsqlConnection(connectionString);
         }            
        }
        public void TryConnection()
        {
            npgSqlConnection.Open();

            npgSqlConnection.Close();
        }

        public QuestionModel[] GetQuestions(int i)
        {
            QuestionModel[] questionModels = new QuestionModel[i];
            List<int> ids = new List<int>();
            npgSqlConnection.Open();
            var command_text = "SELECT MAX(id) AS number FROM test";
            var comm = new NpgsqlCommand(command_text, npgSqlConnection);
            var result = comm.ExecuteScalar();
            npgSqlConnection.Close();
            Random r = new Random();
            while (ids.Count < i)
            {
                var questionID = r.Next(1, Convert.ToInt32(result));
                if (ids.IndexOf(questionID) == -1)
                {
                    ids.Add(questionID);
                    QuestionModel questionModel = new QuestionModel(npgSqlConnection, questionID);
                    questionModels[ids.Count - 1] = questionModel;
                }
                else
                {
                    continue;
                }
            }
            return questionModels;
        }

    }
}
