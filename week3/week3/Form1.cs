using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3
{
    public partial class lblname : Form
    {
        public lblname()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                // Read input from TextBoxes
                string firstName = txtfirstname.Text;
                string lastName = txtlastname.Text;

                int age = int.Parse(txtage.Text);
                double score = double.Parse(txtscore.Text);

                // Combine first name and last name
                string fullName = firstName + " " + lastName;

                // Calculate grade
                string grade;

                if (score >= 90)
                {
                    grade = "A";
                }
                else if (score >= 80)
                {
                    grade = "B";
                }
                else if (score >= 70)
                {
                    grade = "C";
                }
                else if (score >= 60)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }

                // Display output
                lblOutput.Text =
                    "Full Name: " + fullName +
                    "\nAge: " + age.ToString() +
                    "\nExam Score: " + score.ToString("F2") +
                    "\nGrade: " + grade;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Please enter valid numeric values!\n" +
                    ex.Message,
                    "Input Error"
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            txtfirstname.Clear();
            txtlastname.Clear();
            txtage.Clear();
            txtscore.Clear();

            // Clear output
            lblOutput.Text = "";

            // Set focus
            txtfirstname.Focus();
        }
    }
}
    

