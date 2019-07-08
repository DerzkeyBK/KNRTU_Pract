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
    public partial class FinalForm : Form
    {
        public FinalForm(int corrects,int full)
        {
            InitializeComponent();
            label4.Text = Convert.ToString(corrects) + "/" + Convert.ToString(full);
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
