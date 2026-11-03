using System.Drawing;
using System.Windows.Forms;

namespace Week2
{
    public class Form1 : Form
    {
        private readonly Label titleLabel;
        private readonly Label nameLabel;
        private readonly TextBox nameTextBox;
        private readonly Button messageButton;
        private readonly Button clearButton;
        private readonly Button exitButton;
        private readonly Label outputLabel;

        public Form1()
        {
            Text = "Week 2 - Forms, Controls and Events";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(520, 330);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            titleLabel = new Label { Text = "Hello World Application", AutoSize = true, Font = new Font("Segoe UI", 16, FontStyle.Bold), Location = new Point(105, 25) };
            nameLabel = new Label { Text = "Enter your name:", AutoSize = true, Location = new Point(45, 95) };
            nameTextBox = new TextBox { Name = "nameTextBox", Location = new Point(165, 90), Width = 290 };
            messageButton = new Button { Name = "messageButton", Text = "Show Message", Location = new Point(45, 145), Width = 125, Height = 35 };
            clearButton = new Button { Name = "clearButton", Text = "Clear", Location = new Point(185, 145), Width = 100, Height = 35 };
            exitButton = new Button { Name = "exitButton", Text = "Exit", Location = new Point(300, 145), Width = 100, Height = 35 };
            outputLabel = new Label { Name = "outputLabel", Text = "Your message will appear here.", AutoSize = true, Location = new Point(45, 215) };

            messageButton.Click += MessageButton_Click;
            clearButton.Click += ClearButton_Click;
            exitButton.Click += ExitButton_Click;
            Controls.AddRange(new Control[] { titleLabel, nameLabel, nameTextBox, messageButton, clearButton, exitButton, outputLabel });
        }

        private void MessageButton_Click(object sender, System.EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Please enter your name.", "Missing Name");
                return;
            }

            outputLabel.Text = "Hello World, " + name + "!";
            MessageBox.Show(outputLabel.Text, "Welcome");
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            nameTextBox.Clear();
            outputLabel.Text = "Your message will appear here.";
            nameTextBox.Focus();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
