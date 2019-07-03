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

namespace KNRTU_Pract
{
    public partial class Form2 : Form
    {
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
            int corrects = 0;
            Hide();
            for(int i = 0; i < 20; i++)
            {
                corrects=+PostgreServerWorker.GetQuestion(i);
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
