namespace week4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.richboxx = new System.Windows.Forms.RichTextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(142, 113);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(104, 32);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(142, 184);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(80, 32);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Age :";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(142, 278);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(78, 32);
            this.lblcity.TabIndex = 3;
            this.lblcity.Text = "City :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox1.Location = new System.Drawing.Point(388, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "STUDENT INFORMATION";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(325, 113);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(315, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(325, 191);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(315, 26);
            this.txtage.TabIndex = 6;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(325, 285);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(315, 26);
            this.txtcity.TabIndex = 7;
            // 
            // richboxx
            // 
            this.richboxx.Location = new System.Drawing.Point(877, 74);
            this.richboxx.Name = "richboxx";
            this.richboxx.Size = new System.Drawing.Size(245, 287);
            this.richboxx.TabIndex = 8;
            this.richboxx.Text = "";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(265, 400);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(132, 88);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(579, 400);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(132, 88);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 614);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.richboxx);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.RichTextBox richboxx;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
    }
}

