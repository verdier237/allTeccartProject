using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWin01Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            int convertNumber =Convert.ToInt32(lblNumber.Text);
            convertNumber += 1;
            lblNumber.Text = convertNumber.ToString();
            calc.Text = convertNumber.ToString();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            int convertNumber = Convert.ToInt32(lblNumber.Text);
            convertNumber -= 1;
            lblNumber.Text = convertNumber.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
