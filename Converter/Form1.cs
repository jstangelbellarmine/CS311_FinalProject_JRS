/*
*This program begins by importing several external libraries
*in order to function fully. It then initiates a form, explains
*calculations for a button on said form, and ends with code 
*that initializes the rest of the form. This code's main mechanic
*is a large if-else statement using a set equation and
*interpolation. 
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

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//end initialization

        /*
         * Task: Reads which radio button is selected and runs 
         * input through an operation to provide output, which
         * in this context is a converted number.
         * @requirement: a number be input
         * @requirement: a radio button be selected
         */
        private void button1_Click(object sender, EventArgs e)
        {
            
            double input = 0, output = 0;

            if (double.TryParse(txtInput.Text, out input)) 
            {
                if (rbMetToFee.Checked)
                {
                    output = input * 3.28084; 

                    txtOutput.Text = $"{output} Feet";
                }//end if statement
                else if (rbFeeToMet.Checked) 
                {
                    output = input / 3.28084; 

                    txtOutput.Text = $"{output} Meters";
                }//end else if statement
                else if (rbKilToMil.Checked) 
                {
                    output = input * 0.621371; 

                    txtOutput.Text = $"{output} Miles";
                }//end else if statement
                else if (rbMilToKil.Checked) 
                {
                    output = input / 0.621371; 

                    txtOutput.Text = $"{output} Kilometers";
                }//end else if statement
                else if (rbCelToFah.Checked) 
                {
                    output = (input * 9 / 5) + 32;
                    txtOutput.Text = $"{output} °F";
                }//end else if statement
                else if (rbFahToCel.Checked)
                {
                    output = (input - 32) * 5 / 9;
                    txtOutput.Text = $"{output} °C";
                }//end else if statement
                else if (rbKilToPou.Checked)
                {
                    output = input * 2.20462;
                    txtOutput.Text = $"{output} Pounds";
                }//end else if statement
                else if (rbPouToKil.Checked)
                {
                    output = input / 2.20462;
                    txtOutput.Text = $"{output} Kilograms";
                }//end else if statement
                else if (rbGraToOun.Checked)
                {
                    output = input * 0.035274;
                    txtOutput.Text = $"{output} Ounces";
                }//end else if statement
                else if (rbOunToGra.Checked)
                {
                    output = input / 0.035274;
                    txtOutput.Text = $"{output} Grams";
                }//end else if statement
                else
                {
                    MessageBox.Show("Please select a conversion option.");
                }//end radio button checker
            }//end if 
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }//end valid number checker
           
        }//end handler for form function

        private void lblExplination_Click(object sender, EventArgs e)
        {

        }//endlbl

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }//end radiobutton1

        private void label4_Click(object sender, EventArgs e)
        {

        }//end lavel4
    }//end form
}//end namespace
