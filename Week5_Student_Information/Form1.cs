using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week5
{
    public class Form1 : Form
    {
        private Label lblTitle, lblName, lblAge, lblCity, lblTotal;
        private TextBox txtName, txtAge, txtCity;
        private Button btnSave, btnClear;
        private RichTextBox richTextBox1;
        private int totalStudents = 0;

        public Form1()
        {
            Text = "Student Information";
            Size = new Size(1000, 650);
            StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label();
            lblTitle.Text = "STUDENT INFORMATION";
            lblTitle.Location = new Point(350, 30);
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            Controls.Add(lblTitle);

            lblName = new Label();
            lblName.Text = "Name:";
            lblName.Location = new Point(100, 110);
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 16);
            Controls.Add(lblName);

            txtName = new TextBox();
            txtName.Location = new Point(250, 110);
            txtName.Width = 280;
            Controls.Add(txtName);

            lblAge = new Label();
            lblAge.Text = "Age:";
            lblAge.Location = new Point(100, 180);
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Arial", 16);
            Controls.Add(lblAge);

            txtAge = new TextBox();
            txtAge.Location = new Point(250, 180);
            txtAge.Width = 280;
            Controls.Add(txtAge);

            lblCity = new Label();
            lblCity.Text = "City:";
            lblCity.Location = new Point(100, 250);
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Arial", 16);
            Controls.Add(lblCity);

            txtCity = new TextBox();
            txtCity.Location = new Point(250, 250);
            txtCity.Width = 280;
            Controls.Add(txtCity);

            btnSave = new Button();
            btnSave.Text = "Save";
            btnSave.Location = new Point(250, 330);
            btnSave.Size = new Size(120, 55);
            btnSave.Click += BtnSave_Click;
            Controls.Add(btnSave);

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Location = new Point(410, 330);
            btnClear.Size = new Size(120, 55);
            btnClear.Click += BtnClear_Click;
            Controls.Add(btnClear);

            lblTotal = new Label();
            lblTotal.Text = "Total Students: 0";
            lblTotal.Location = new Point(650, 90);
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 14, FontStyle.Bold);
            Controls.Add(lblTotal);

            richTextBox1 = new RichTextBox();
            richTextBox1.Location = new Point(650, 130);
            richTextBox1.Size = new Size(280, 300);
            richTextBox1.ReadOnly = true;
            Controls.Add(richTextBox1);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                MessageBox.Show("Enter a valid age!");
                return;
            }

            string student = "Name: " + txtName.Text.Trim() +
                             "\nAge: " + age +
                             "\nCity: " + txtCity.Text.Trim() +
                             "\n------------------------\n";

            richTextBox1.AppendText(student);
            totalStudents++;
            lblTotal.Text = "Total Students: " + totalStudents;

            MessageBox.Show("Student Saved Successfully!");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtCity.Clear();
            txtName.Focus();
        }
    }
}
