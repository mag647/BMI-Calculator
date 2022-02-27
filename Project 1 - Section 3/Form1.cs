using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project_1___Section_3
{
    //           Author:  Michele Gay
    // Date of creation:  02/26/2020
    //      Description:  This project calculates a user's BMI based on entered height and weight. 
    //                    When BMI is calculated, an image representing their weight range appears.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variable declaration
            decimal bmi = 0.00M;
            decimal height = 0.00M;
            decimal weight = 0.00M;
            
            
            //Validate entries in weight and height text boxes. If there is an error,
            //show message box and return to form. 
            if (!decimal.TryParse(weightTextBox.Text, out weight)) 
            {
                MessageBox.Show("Re-enter the weight as a decimal number.",
                    "Data Type Entry Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                weightTextBox.Focus();
                weightTextBox.SelectAll();
                return;
            }
            if (!decimal.TryParse(heightTextBox.Text, out height))
            {
                MessageBox.Show("Re-enter the height as a decimal number.",
                    "Data Type Entry Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                heightTextBox.Focus();
                heightTextBox.SelectAll();
                return;
            }
          
            //Validate that height and weight entries are greater than zero. If there is an error,
            //show message box and return to form. 

            if ((weight <= 0) || (height <= 0))
            {
                MessageBox.Show("A number greater than 0 must be entered for both weight and height.",
                    "Data Entry Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {  
                //Calculate BMI
                bmi = (weight * 703) / (height * height);

                //Determine which image to display in picture box based on BMI result
                if (bmi < 18.5M)
                {
                    weightRangePictureBox.Image = imageListWeightRange.Images[0];
                }
                else if ((bmi >= 18.5M) && (bmi < 24.9M))
                {
                    weightRangePictureBox.Image = imageListWeightRange.Images[1];
                }
                else if ((bmi >= 25M) && (bmi <= 29.9M))
                {
                    weightRangePictureBox.Image = imageListWeightRange.Images[2];
                }
                else
                {
                    weightRangePictureBox.Image = imageListWeightRange.Images[3];
                }
              
                //Output BMI to label 
                calculateBMILabel.Text = bmi.ToString("n2");
            }
          
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset controls to their default appearance.
            heightTextBox.Text = "0.00";
            weightTextBox.Text = "0.00";
            calculateBMILabel.Text = "0.00";
            weightRangePictureBox.Image = default;

            //Set focus to the first control.
            weightTextBox.Focus();
            weightTextBox.SelectAll();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Confirm if user would like to exit application
            if (MessageBox.Show("Do you really you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
       
}
