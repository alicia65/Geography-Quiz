using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text;
            answer = answer.ToLower();

            int oceanCount = 5;
            string oceanInfo = $"There are {oceanCount} ocean on earth.";
            //"There are 5 oceans on earth."

            string ocean = "Pacific Ocean";
            double oceanSize = 63800000;
            string oceanSizeUnits = "square miles";

            string pacificInfo = $"The {ocean} is {oceanSize} {oceanSizeUnits}.";
            //"The Pacific Ocean is 6800000 square miles."
            if (answer.Contains("pacific")) 
            {
                MessageBox.Show("Correct!", "Result");
            }
            else 
            {
                MessageBox.Show("Incorrect, the answer is the Pacific Ocean", "Result");
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
