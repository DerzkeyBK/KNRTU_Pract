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
    public partial class Form2 : Form
    {
        PostgreServerWorker postgreServerWorker;
        public Form2(User user,PostgreServerWorker postgreServerWorker)
        {
            InitializeComponent();
            label4.Text =Convert.ToString(postgreServerWorker.Time/60000);
            label6.Text = Convert.ToString(postgreServerWorker.Questions);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            int i = 0;
            while (i < postgreServerWorker.Questions)
            {
                
            }
        }
    }
}
