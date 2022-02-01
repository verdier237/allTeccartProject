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
    public partial class round : Form
    {
        public round()
        {
            InitializeComponent();
            prgbfooter.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerIncrement.Start();
        }

        private void lblincrement_Click(object sender, EventArgs e)
        {

        }

        private void timerIncrement_Tick(object sender, EventArgs e)
        {
            int i;
            prgbfooter.Value += 1;
            lblincrement.Text = prgbfooter.Value.ToString() + "%";
            i = prgbfooter.Value / 10;
            if (prgbfooter.Value == i)
            {

            }
                if (prgbfooter.Value == 100)
            {
                timerIncrement.Enabled = false;
            }
        }

        private void btndecrement_Click(object sender, EventArgs e)
        {
            timerDecrement.Start();
        }

        private void timerDecrement_Tick(object sender, EventArgs e)
        {
            try
            {
                prgbfooter.Value -= 1;
                lblincrement.Text = prgbfooter.Value.ToString() + "%";
                if (prgbfooter.Value == 0)
                {
                    timerDecrement.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                prgbfooter.Value = 0;
                
                Console.WriteLine("{0} Exception caught.", exc);
            }


        }

        private void prgbfooter_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
