using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace KNRTU_Pract
{
    public class QuestionModel
    {
        public int id { get; set; }

        public string question { get; set; }

        public string[] answers = new string[4];

        public int correctAnswer { get; set; }


        public QuestionModel(NpgsqlConnection npgSqlConnection,int QuestionID)
        {
            id = QuestionID;
            npgSqlConnection.Open();
            var command_text = "SELECT * FROM test\nWHERE id = '"+id+"'; ";
            var comm = new NpgsqlCommand(command_text, npgSqlConnection);
            NpgsqlDataReader reader =comm.ExecuteReader();
            while (reader.Read())
            {
                question = reader.GetString(0);
                for (int i = 0; i < 4; i++)
                {
                    answers[i] = reader.GetString(i);
                }
                correctAnswer = reader.GetInt32(5);
            }
            npgSqlConnection.Close();
        }
    }
}
