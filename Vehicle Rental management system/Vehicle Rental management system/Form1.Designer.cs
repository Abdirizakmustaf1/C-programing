namespace Vehicle_Rental_management_system
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.lblcustomerage = new System.Windows.Forms.Label();
            this.lblrenterdays = new System.Windows.Forms.Label();
            this.lblexperince = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtrenteldays = new System.Windows.Forms.TextBox();
            this.txtexperince = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chekeconomy = new System.Windows.Forms.CheckBox();
            this.cheksuv = new System.Windows.Forms.CheckBox();
            this.chekluxury = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkinsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.ltsrichText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtexperince);
            this.groupBox1.Controls.Add(this.txtrenteldays);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblexperince);
            this.groupBox1.Controls.Add(this.lblrenterdays);
            this.groupBox1.Controls.Add(this.lblcustomerage);
            this.groupBox1.Controls.Add(this.lblcustomername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // lblcustomername
            // 
            this.lblcustomername.AutoSize = true;
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.Location = new System.Drawing.Point(34, 60);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(184, 26);
            this.lblcustomername.TabIndex = 0;
            this.lblcustomername.Text = "Customer Name :";
            // 
            // lblcustomerage
            // 
            this.lblcustomerage.AutoSize = true;
            this.lblcustomerage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerage.Location = new System.Drawing.Point(34, 111);
            this.lblcustomerage.Name = "lblcustomerage";
            this.lblcustomerage.Size = new System.Drawing.Size(164, 26);
            this.lblcustomerage.TabIndex = 1;
            this.lblcustomerage.Text = "Customer Age :";
            // 
            // lblrenterdays
            // 
            this.lblrenterdays.AutoSize = true;
            this.lblrenterdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrenterdays.Location = new System.Drawing.Point(34, 172);
            this.lblrenterdays.Name = "lblrenterdays";
            this.lblrenterdays.Size = new System.Drawing.Size(256, 26);
            this.lblrenterdays.TabIndex = 2;
            this.lblrenterdays.Text = "Number Of Rentel Days :";
            // 
            // lblexperince
            // 
            this.lblexperince.AutoSize = true;
            this.lblexperince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexperince.Location = new System.Drawing.Point(34, 233);
            this.lblexperince.Name = "lblexperince";
            this.lblexperince.Size = new System.Drawing.Size(288, 26);
            this.lblexperince.TabIndex = 3;
            this.lblexperince.Text = "Years Of Driving Experince :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(342, 62);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(175, 26);
            this.txtname.TabIndex = 4;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(342, 122);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(175, 26);
            this.txtage.TabIndex = 5;
            // 
            // txtrenteldays
            // 
            this.txtrenteldays.Location = new System.Drawing.Point(342, 172);
            this.txtrenteldays.Name = "txtrenteldays";
            this.txtrenteldays.Size = new System.Drawing.Size(175, 26);
            this.txtrenteldays.TabIndex = 6;
            // 
            // txtexperince
            // 
            this.txtexperince.Location = new System.Drawing.Point(342, 233);
            this.txtexperince.Name = "txtexperince";
            this.txtexperince.Size = new System.Drawing.Size(175, 26);
            this.txtexperince.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vehicle Type";
            // 
            // chekeconomy
            // 
            this.chekeconomy.AutoSize = true;
            this.chekeconomy.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekeconomy.Location = new System.Drawing.Point(97, 400);
            this.chekeconomy.Name = "chekeconomy";
            this.chekeconomy.Size = new System.Drawing.Size(137, 34);
            this.chekeconomy.TabIndex = 2;
            this.chekeconomy.Text = "Economy";
            this.chekeconomy.UseVisualStyleBackColor = true;
            // 
            // cheksuv
            // 
            this.cheksuv.AutoSize = true;
            this.cheksuv.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheksuv.Location = new System.Drawing.Point(338, 400);
            this.cheksuv.Name = "cheksuv";
            this.cheksuv.Size = new System.Drawing.Size(83, 34);
            this.cheksuv.TabIndex = 3;
            this.cheksuv.Text = "SUV";
            this.cheksuv.UseVisualStyleBackColor = true;
            // 
            // chekluxury
            // 
            this.chekluxury.AutoSize = true;
            this.chekluxury.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekluxury.Location = new System.Drawing.Point(540, 400);
            this.chekluxury.Name = "chekluxury";
            this.chekluxury.Size = new System.Drawing.Size(109, 34);
            this.chekluxury.TabIndex = 4;
            this.chekluxury.Text = "Luxury";
            this.chekluxury.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(12, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Insurance Option";
            // 
            // checkinsurance
            // 
            this.checkinsurance.AutoSize = true;
            this.checkinsurance.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinsurance.Location = new System.Drawing.Point(97, 531);
            this.checkinsurance.Name = "checkinsurance";
            this.checkinsurance.Size = new System.Drawing.Size(349, 34);
            this.checkinsurance.TabIndex = 6;
            this.checkinsurance.Text = "Add insurance($15 per day)";
            this.checkinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(288, 596);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(133, 41);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(465, 596);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(133, 41);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(624, 596);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(133, 41);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // ltsrichText
            // 
            this.ltsrichText.Location = new System.Drawing.Point(795, 29);
            this.ltsrichText.Name = "ltsrichText";
            this.ltsrichText.Size = new System.Drawing.Size(378, 439);
            this.ltsrichText.TabIndex = 10;
            this.ltsrichText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 667);
            this.Controls.Add(this.ltsrichText);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.checkinsurance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chekluxury);
            this.Controls.Add(this.cheksuv);
            this.Controls.Add(this.chekeconomy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblexperince;
        private System.Windows.Forms.Label lblrenterdays;
        private System.Windows.Forms.Label lblcustomerage;
        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.TextBox txtexperince;
        private System.Windows.Forms.TextBox txtrenteldays;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chekeconomy;
        private System.Windows.Forms.CheckBox cheksuv;
        private System.Windows.Forms.CheckBox chekluxury;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkinsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.RichTextBox ltsrichText;
    }
}

