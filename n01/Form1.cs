using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace n01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double p = double.Parse(textBox1.Text);
            double t = double.Parse(textBox2.Text);
            double r = double.Parse(textBox3.Text);
            double si = p * t * r / 100;
            textBox4.Text = si + "";
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbxNumber.Text);
            int n = x * (-1);
            tbxNegation.Text = n + "";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            long x = long.Parse(tbxNumber_last.Text);
            long l = x % 10;
            tbxLast.Text = l + "";

        }

        

       

    }
}
