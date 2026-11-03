using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int age, days, experience;

            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Enter customer name.");
                return;
            }

            if (!int.TryParse(txtage.Text, out age) ||
                age < 18 || age > 80)
            {
                MessageBox.Show("Age must be between 18 and 80.");
                return;
            }

            if (!int.TryParse(txtrenteldays.Text, out days) ||
                days < 1 || days > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.");
                return;
            }

            if (!int.TryParse(txtexperince.Text, out experience) ||
                experience < 0)
            {
                MessageBox.Show("Enter valid driving experience.");
                return;
            }

            if (age < 21 || experience < 1)
            {
                MessageBox.Show(
                    "Not eligible. Age must be 21 or above and driving experience at least 1 year.");
                return;
            }

            string vehicle;
            double rate;

            if (chekeconomy.Checked)
            {
                vehicle = "Economy";
                rate = 35;
            }
            else if (cheksuv.Checked)
            {
                vehicle = "SUV";
                rate = 60;
            }
            else if (chekluxury.Checked)
            {
                vehicle = "Luxury";
                rate = 100;

                if (age < 25 || experience < 3)
                {
                    MessageBox.Show(
                        "Luxury requires age 25+ and 3 years experience.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Select a vehicle type.");
                return;
            }

            double basicCost = rate * days;
            double discountRate = 0;

            if (days >= 14)
                discountRate = 0.10;
            else if (days >= 7)
                discountRate = 0.05;

            double discount = basicCost * discountRate;
            double insurance = checkinsurance.Checked ? 15 * days : 0;

            double surcharge = age <= 24 ? basicCost * 0.10 : 0;

            double finalCost = basicCost - discount
                               + insurance + surcharge;

            ltsrichText.Text =
       "VEHICLE RENTAL DETAILS\n" +
       "------------------------------\n" +
       "Customer Name: " + txtname.Text + "\n" +
       "Customer Age: " + age + "\n" +
       "Driving Experience: " + experience + " years\n" +
       "Vehicle Type: " + vehicle + "\n" +
       "Daily Rate: $" + rate.ToString("F2") + "\n" +
       "Rental Days: " + days + "\n" +
       "Basic Rental Cost: $" + basicCost.ToString("F2") + "\n" +
       "Discount: $" + discount.ToString("F2") + "\n" +
       "Insurance Cost: $" + insurance.ToString("F2") + "\n" +
       "Young Driver Surcharge: $" + surcharge.ToString("F2") + "\n" +
       "Final Rental Cost: $" + finalCost.ToString("F2") + "\n" +
       "Rental Status: Approved";


        }
    }
    }

