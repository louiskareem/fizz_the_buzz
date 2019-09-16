using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fizzbuzz_week_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method to display the results
        private void DisplayResults()
        {
            // Vars
            int numThree = 3;
            int numFive = 5;
            int numFifteen = 15;

            // After every iteration, increment fizzes by 1. Fizzes has a limit of 100.
            for (int fizzes = 1; fizzes <= 100; fizzes++)
            {
                /*
                 * Check if fizzes divided by 3 is equal to 0, if so then print fizzes
                 * if not do the same check, but with the number 5, if true print buzz.
                 * Attempt to do the same check but this with umbr fifteen
                */
                if (fizzes % numFifteen == 0)
                {
                    listBox1.Items.Add($"Fizz Buzz" + "\n");
                }
                else if (fizzes % numThree == 0)
                {
                    listBox1.Items.Add($"Fizz" + "\n");
                }
                else if (fizzes % numFive == 0)
                {
                    listBox1.Items.Add($"Buzz" + "\n");
                }
                else
                {
                    listBox1.Items.Add(fizzes);
                }
            }
        }

        // Method runs whenever button "Start fizzing" is clicked
        private void Button1_Click(object sender, EventArgs e)
        {
            DisplayResults();
        }
    }
}
