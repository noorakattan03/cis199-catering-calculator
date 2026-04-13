// Noora Kattan
// CIS 199-01-4248
// Due Date: 11/10/2024
// This program calculates the final price for a catering contract by applying discounts
// based on selected caterer, business, and contract years, by using arrays and loops for searching and matching.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class contractLabel : Form
    {   
        // Declaring a constant for additional discounts based on the number of contract years
        const int MIN_CONTRACT_YEARS = 1; // minimum contract years

        // Array for the contract years ranges and each of their discounts
        int[] yearsRange = { 1, 4, 7, 8 }; // Range of contract years
        double[] yearsDiscount = { 0, 30, 40, 50 }; // Discounts for each range of contract years

        // Array for the catering company and discount rates
        string[] caterers = {"Hill Catering Co.", "Food in a Flash", "Sally’s Sandwiches", "Perry’s Pierogis"}; // the names of the catering companies
        double[] discountRates = { 0.30, 0.20, 0.12, 0.05 }; // discount rates for each catering company

        // Array for businesses and contract prices
        string[] businesses = { "John’s Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" }; // names of the businesses
        double[] contractPrices = { 500, 489, 412, 350, 325, 279 }; // contract price for each business


        public contractLabel()
        {
            InitializeComponent();
            // The Combo Boxes with caterers and businesses
            cateringComboBox.Items.AddRange(caterers); // catering combo box
            businessComboBox.Items.AddRange(businesses); // businesses combo box
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // using if-statments to check that a caterer has been selected
            if (cateringComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a caterer"); // Displaying error message if no caterer is selected
                return; // Exits the method if no caterer is selected
            }
            // using if-statments to check that a business has been selected
            if (businessComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a business"); // Displaying error message if no business is selected
                return; // Exits the method if no business is selected
            }
            // using if and TryParse to validate the contract years by user input
            if (!int.TryParse(contractYearsTxt.Text, out int contractYears) || (contractYears < MIN_CONTRACT_YEARS))
            {
                MessageBox.Show("Please provide valid contract years"); // Displaying error if input is invalid
                return; // Exits the method if the contract years input is invalid
            }
            // Getting the selected discount rate and contract price
            double discountRate = discountRates[cateringComboBox.SelectedIndex]; // Searching the discount rate for selected caterer
            double contractPrice = contractPrices[businessComboBox.SelectedIndex]; // Searching the contract price for selected business

            // Calculating the base discount 
            double discountAmount = contractPrice * discountRate; // Discount amount based on the caterer's discount rate

            // Discount based on contract year
            double contractDiscount = 0; // Initialize the contract discount variable to 0
            for (int i = 0; i < yearsRange.Length; i++) // using for loop to loop through the years range array
            {
                if (contractYears <= yearsRange[i]) // If contract years fall within the range
                {
                    contractDiscount = yearsDiscount[i]; // Applying the corresponding discount
                    break; // Exits the loop after finding the correct discount
                }
            }

            // Calculate Final Price 
            double finalPrice = contractPrice - discountAmount - contractDiscount;  // Final price after both discounts are applied

            // Displaying the final price in Currency (dollar amount) and two decimal places.
            priceOutPut.Text = $"${finalPrice:F2}"; // results will show in the priceOutput Label
        }
    }
}
    

