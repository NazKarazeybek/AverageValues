using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValues
{
    public partial class Form1 : Form
    {
        private double sum = 0;
        private int totalNumbers = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(valueInput.Text);
                if (number == 0)
                {
                    double average = totalNumbers > 0 ? sum / totalNumbers : 0; 
                    //? is calculates the average of all values entered. It checks (totalNumbers > 0). If yes, it calculates (sum / totalNumbers).
                    outputLabel.Text = $"Average of all values entered: {average:F2}";
                }
                else
                {
                    sum += number;
                    totalNumbers++;
                    outputLabel.Text = $"Number added: {number}";
                }
            }
            catch (FormatException)
            {
                outputLabel.Text = "Please enter a valid number.";
            }

            valueInput.Clear();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            totalNumbers = 0;
            outputLabel.Text = "";
            valueInput.Clear();
        }
    }
}
