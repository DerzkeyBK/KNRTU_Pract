using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KNRTU_Pract;

namespace KNRTU_Pract
{
    public partial class Form1 : Form
    {
        public User user;
        public PostgreServerWorker postgreServerWorker;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            user = new User(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            PostgreServerWorker postgreServerWorker = new PostgreServerWorker(textBox5.Text);
            MessageBox.Shwo
        }
    }
}
