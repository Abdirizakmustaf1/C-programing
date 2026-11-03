using System.Drawing;
using System.Windows.Forms;

namespace Week1
{
    public class Form1 : Form
    {
        private readonly Label titleLabel;
        private readonly Label nameLabel;
        private readonly TextBox nameTextBox;
        private readonly Button showButton;
        private readonly Label resultLabel;

        public Form1()
        {
            Text = "Week 1 - Introduction to Visual C#";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(480, 280);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            titleLabel = new Label { Text = "My First C# Program", AutoSize = true, Font = new Font("Segoe UI", 16, FontStyle.Bold), Location = new Point(105, 25) };
            nameLabel = new Label { Name = "nameLabel", Text = "Student name:", AutoSize = true, Location = new Point(55, 95) };
            nameTextBox = new TextBox { Name = "nameTextBox", Location = new Point(155, 90), Width = 240 };
            showButton = new Button { Name = "showButton", Text = "Show Name", Location = new Point(155, 130), Width = 110, Height = 32 };
            resultLabel = new Label { Name = "resultLabel", Text = "Enter your name above.", AutoSize = true, Location = new Point(55, 190) };

            showButton.Click += ShowButton_Click;
            Controls.AddRange(new Control[] { titleLabel, nameLabel, nameTextBox, showButton, resultLabel });
        }

        private void ShowButton_Click(object sender, System.EventArgs e)
        {
            resultLabel.Text = "Student name: " + nameTextBox.Text;
        }
    }
}
