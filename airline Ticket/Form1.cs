using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace airline_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int age, tickets;
            double baggage;

            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            if (!int.TryParse(txtage.Text, out age) ||
                age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            if (!int.TryParse(lblticket.Text, out tickets) ||
                tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }
            if (!double.TryParse(txtweight.Text, out baggage) ||
            baggage < 0 || baggage > 50 * tickets)
            {
                MessageBox.Show(
                    "Baggage cannot exceed 50 kg per passenger.");
                return;
            }

           
            double ticketPrice;

            if (checfirst.Checked)
            {
                if (age < 12)
                {
                    MessageBox.Show(
                        "Passengers below 12 cannot book First Class.");
                    return;
                }
                ticketPrice = 200;
            }
            else if (checknormal.Checked)
            {
                ticketPrice = 100;
            }
            else if (checkbusiness.Checked)
            {
                ticketPrice = 300;
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }
            double basicCost = ticketPrice * tickets;

            
            double ticketDiscount = 0;

            if (tickets >= 5)
                ticketDiscount = 0.10;
            else if (tickets >= 3)
                ticketDiscount = 0.05;

            double discountAmount = basicCost * ticketDiscount;

           
            double ageDiscount = 0;

            if (age < 12)
                ageDiscount = 0.20;
            else if (age >= 60)
                ageDiscount = 0.10;

            double ageDiscountAmount =
                (basicCost - discountAmount) * ageDiscount;

            
            double insuranceCost = 0;

            if (checkinsurance.Checked)
                insuranceCost = 25 * tickets;

        
            double totalDiscount =
                discountAmount + ageDiscountAmount;

            double finalCost =
                basicCost - totalDiscount + insuranceCost;

           
            lstdetailsrich.Clear();

            lstdetailsrich.AppendText("AIRLINE TICKET BOOKING\n");
            lstdetailsrich.AppendText("------------------------------\n");
            lstdetailsrich.AppendText("Passenger: " + txtname.Text + "\n");
            lstdetailsrich.AppendText("Age: " + age + "\n");
            lstdetailsrich.AppendText("Number of tickets: " + tickets + "\n");
            lstdetailsrich.AppendText("Baggage weight: " + baggage + " kg\n");

            string travelClass = checfirst.Checked
                ? "First Class"
                : checknormal.Checked
                    ? "Normal Class"
                    : "Business Class";
            lstdetailsrich.AppendText("Travel class: " + travelClass + "\n");
            lstdetailsrich.AppendText(
                "Ticket price: $" + ticketPrice.ToString("F2") + "\n");
            lstdetailsrich.AppendText(
                "Basic cost: $" + basicCost.ToString("F2") + "\n");
            lstdetailsrich.AppendText(
                "Ticket discount: $" + discountAmount.ToString("F2") + "\n");
            lstdetailsrich.AppendText(
                "Age discount: $" + ageDiscountAmount.ToString("F2") + "\n");
            lstdetailsrich.AppendText(
                "Insurance: $" + insuranceCost.ToString("F2") + "\n");
            lstdetailsrich.AppendText("------------------------------\n");
            lstdetailsrich.AppendText(
                "TOTAL COST: $" + finalCost.ToString("F2") + "\n");
            lstdetailsrich.AppendText("Booking Approved!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtticket.Clear();
            txtweight.Clear();

            checfirst.Checked = false;
            checknormal.Checked = false;
            checkbusiness.Checked = false;
            checkinsurance.Checked = false;

            lstdetailsrich.Clear();
            txtname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }


