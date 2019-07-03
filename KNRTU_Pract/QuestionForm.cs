using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNRTU_Pract
{
    public partial class QuestionForm : Form
    {
        int Answer { get; set; }
        public QuestionForm(QuestionModel questionModel,int i)
        {
            InitializeComponent();
            label1.Text = label1.Text +Convert.ToString(i);
            label2.Text = questionModel.question;
            button2.Text = questionModel.answers[0];
            button3.Text = questionModel.answers[1];
            button4.Text = questionModel.answers[2];
            button5.Text = questionModel.answers[3];

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Answer = 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Answer = 2;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Answer = 3;
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            Answer = 4;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
