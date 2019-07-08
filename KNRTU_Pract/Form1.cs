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
using Npgsql;

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
            try
            {
                postgreServerWorker.TryConnection();
            }
            catch (Exception s)
            {
                MessageBox.Show(Convert.ToString(s)); 
            }

            Form2 form2 = new Form2(user,postgreServerWorker);
            form2.FormClosing += SecondFormClosing;
            Hide();
            form2.ShowDialog();
            FinalForm form = new FinalForm(form2.corrects, Convert.ToInt32(form2.textBox2.Text));
            form.ShowDialog();
            Close();
            
          
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SecondFormClosing(object sender, EventArgs e)
        {
            int fromSecondForm1 = (sender as Form2).corrects;
            string fromSecondForm2 = (sender as Form2).textBox2.Text;
        }
    }
}
