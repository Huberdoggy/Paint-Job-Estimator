/* AUTHOR: Kyle Huber
 * DATE: 09/14/2020
 * DESCRIPTION: A program which will calculate the following information for a paint job:
 * 1) Number of gallons required, 2) Hours of labor required, 3) Total cost of paint
 * 4) Total labor charges, 5) The total cost of the job */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Job_Estimator
{
    public partial class PaintJobEstimator : Form
    {
        /*Declare private field vars for wallspace price of paint,
         * baseline wallspace, baseline labor hours & rate per hr as specified in the problem */
        double wallSpace = 0;
        double priceOfPaint_PerGal = 0;
        const double feetBaseline = 115.0;
        const double hoursBaseline = 8.0;
        const double ratePerHour = 20.00;
        
        public PaintJobEstimator()
        {
            InitializeComponent();
        }

        private void calculateJobButton_Click(object sender, EventArgs e)
        {
            

            //Init a try/catch block
            try
            {
                //Toggle the previously disabled form fields
                totalPaintGallonsLabel.Visible = true;
                totalLaborHoursLabel.Visible = true;
                totalCostOfPaintLabel.Visible = true;
                totalLaborChargesLabel.Visible = true;
                totalJobCostLabel.Visible = true;

                totalPaintGallonsTextbox.Visible = true;
                totalLaborHoursTextbox.Visible = true;
                totalCostOfPaintTextBox.Visible = true;
                totalLaborChargesTextbox.Visible = true;
                totalJobCostTextbox.Visible = true;

                totalPaintGallonsTextbox.Enabled = true;
                totalLaborHoursTextbox.Enabled = true;
                totalCostOfPaintTextBox.Enabled = true;
                totalLaborChargesTextbox.Enabled = true;
                totalJobCostTextbox.Enabled = true;

                //Assign wallspace value to user specified form data
                wallSpace = double.Parse(wallSpaceTextBox.Text);
                priceOfPaint_PerGal = double.Parse(pricePerGallonTextBox.Text);

                //Calc the number of gallons required
                double gallonsRequired = wallSpace / feetBaseline; 
                //Calc hours of labor required
                double hoursOfLabor_Required = (wallSpace / feetBaseline) * hoursBaseline;
                //Calc total cost of paint
                double totalPriceOfPaint = priceOfPaint_PerGal * gallonsRequired;
                //Calc total labor charges
                double totalLaborCharges = hoursOfLabor_Required * ratePerHour;
                //Calc total cost of the job
                double grandTotal = totalPriceOfPaint + totalLaborCharges;

                //Display outputs..
                totalPaintGallonsTextbox.Text = gallonsRequired.ToString("n2");
                totalLaborHoursTextbox.Text = hoursOfLabor_Required.ToString("n1"); //Just one dec place should suffice here
                totalCostOfPaintTextBox.Text = totalPriceOfPaint.ToString("C");
                totalLaborChargesTextbox.Text = totalLaborCharges.ToString("C");
                totalJobCostTextbox.Text = grandTotal.ToString("C");
            }

            catch (Exception ex)
            {
                //Toggle disabled again

                totalPaintGallonsLabel.Visible = false;
                totalLaborHoursLabel.Visible = false;
                totalCostOfPaintLabel.Visible = false;
                totalLaborChargesLabel.Visible = false;
                totalJobCostLabel.Visible = false;

                totalPaintGallonsTextbox.Visible = false;
                totalLaborHoursTextbox.Visible = false;
                totalCostOfPaintTextBox.Visible = false;
                totalLaborChargesTextbox.Visible = false;
                totalJobCostTextbox.Visible = false;

                totalPaintGallonsTextbox.Enabled = false;
                totalLaborHoursTextbox.Enabled = false;
                totalCostOfPaintTextBox.Enabled = false;
                totalLaborChargesTextbox.Enabled = false;
                totalJobCostTextbox.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear everything...
            
            wallSpaceTextBox.Text = "";
            pricePerGallonTextBox.Text = "";
            totalPaintGallonsTextbox.Text = "";
            totalLaborHoursTextbox.Text = "";
            totalCostOfPaintTextBox.Text = "";
            totalLaborChargesTextbox.Text = "";
            totalJobCostTextbox.Text = "";
            //Return focus to first box
            wallSpaceTextBox.Focus();

            //Toggle disabled again

            totalPaintGallonsTextbox.Visible = false;
            totalLaborHoursTextbox.Visible = false;
            totalCostOfPaintTextBox.Visible = false;
            totalLaborChargesTextbox.Visible = false;
            totalJobCostTextbox.Visible = false;

            totalPaintGallonsTextbox.Enabled = false;
            totalLaborHoursTextbox.Enabled = false;
            totalCostOfPaintTextBox.Enabled = false;
            totalLaborChargesTextbox.Enabled = false;
            totalJobCostTextbox.Enabled = false;

            totalPaintGallonsLabel.Visible = false;
            totalLaborHoursLabel.Visible = false;
            totalCostOfPaintLabel.Visible = false;
            totalLaborChargesLabel.Visible = false;
            totalJobCostLabel.Visible = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Display messgage and exit
            MessageBox.Show("Goodbye and Happy Painting!");
            this.Close();
        }
    }
}
