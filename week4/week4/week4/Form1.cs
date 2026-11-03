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

namespace week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" ||
               txtage.Text == "" ||
               txtcity.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!int.TryParse(txtage.Text, out int age) || age < 0)
            {
                MessageBox.Show("Please enter a valid age!");
                return;
            }

            string student = "Name: " + txtname.Text +
                             " | Age: " + age +
                             " | City: " + txtcity.Text;

            richboxx.AppendText(student + Environment.NewLine);

            MessageBox.Show("Student Saved Successfully!");
        }

        // Clear Button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtcity.Clear();

            txtname.Focus();
        }
    }
}