/* UserInterface.cs
 * Author: Christopher Xu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Basic Calculator
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Values of the first and second number inputed
        /// </summary>
        float num1, num2;

        /// <summary>
        /// Denotes the desired math symbol
        /// </summary>
        int symbol;

        /// <summary>
        /// Initializes the UI
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClear_Click(object sender, EventArgs e)
        {
            uxDisplay.Clear();
            uxDisplay.Focus();
        }

        /// <summary>
        /// Computes the value of the desired
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCompute_Click(object sender, EventArgs e)
        {
            float ans = 0;
            num2 = float.Parse(uxDisplay.Text.Substring(num1.ToString().Length + 1));
            switch (symbol)
            {
                case 0:
                    ans = num1 + num2;
                    break;
                case 1:
                    ans = num1 - num2;
                    break;
                case 2:
                    ans = num1 * num2;
                    break;
                case 3: 
                    ans = num1 / num2;
                    break;
                default: 
                    break;
            }
            uxDisplay.Text = (ans).ToString();
        }

        /// <summary>
        /// Displays addition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(uxDisplay.Text);
            uxDisplay.Text += "+";
            symbol = 0;
        }

        /// <summary>
        /// Displays subtraction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(uxDisplay.Text);
            uxDisplay.Text += "-";
            symbol = 1;
        }

        /// <summary>
        /// Display multiplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMult_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(uxDisplay.Text);
            uxDisplay.Text += "*";
            symbol = 2;
        }

        /// <summary>
        /// Display division
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(uxDisplay.Text);
            uxDisplay.Text += "/";
            symbol = 3;
        }

        /// <summary>
        /// Switches value between positive and negative
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPM_Click(object sender, EventArgs e)
        {
            double text = float.Parse(uxDisplay.Text);
            uxDisplay.Clear();
            uxDisplay.Focus();
            uxDisplay.Text = (text * -1).ToString();
        }

        /// <summary>
        /// Adds zero to the display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxZero_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 0;
        }

        /// <summary>
        /// Displays a decimal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDecimal_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += ".";
        }

        /// <summary>
        /// Displays a 1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOne_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 1;
        }

        /// <summary>
        /// Displays a 2 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxTwo_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 2;
        }

        /// <summary>
        /// Displays a 3 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxThree_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 3;
        }

        /// <summary>
        /// Displays a 4 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFour_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 4;
        }


        /// <summary>
        /// Displays a 5 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFive_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 5;
        }

        /// <summary>
        /// Displays a 6 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSix_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 6;
        }

        /// <summary>
        /// Displays a 7 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSeven_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 7;
        }

        /// <summary>
        /// Displays a 8 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEight_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 8;
        }

        /// <summary>
        /// Displays a 9 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNine_Click(object sender, EventArgs e)
        {
            uxDisplay.Text += 9;
        }
    }
}
