using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICALCULATE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bmi, height, weight;
            height = double.Parse(textBox1.Text);
            weight = double.Parse(textBox2.Text);
            bmi = weight / (height * height);
            bmiout.Text ="BMI值為"+bmi.ToString();
        }
    }
}
