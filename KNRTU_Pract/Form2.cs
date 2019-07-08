using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Threading;

namespace KNRTU_Pract
{
    public partial class Form2 : Form
    {
        public int corrects = 0;
        public PostgreServerWorker PostgreServerWorker { get; set; }
        public User User { get; set; }
        public Form2(User user,PostgreServerWorker postgreServerWorker)
        {
            InitializeComponent();
            PostgreServerWorker = postgreServerWorker;
            User = user;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(textBox1.Text) * 60 * 1000;
            QuestionModel[] questionModels = PostgreServerWorker.GetQuestions(Convert.ToInt32(textBox2.Text));
            Hide();
            timer1.Start();
            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                QuestionForm questionForm = new QuestionForm(questionModels[i], i);
                questionForm.FormClosing += SecondFormClosing;
                questionForm.ShowDialog();
                if (questionForm.correct) corrects++;
            }

        }

        private void SecondFormClosing(object sender, EventArgs e)
        {
            bool fromSecondForm = (sender as QuestionForm).correct;
            
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
