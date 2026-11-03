namespace airline_Ticket
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblticket = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.lstdetailsrich = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checfirst = new System.Windows.Forms.CheckBox();
            this.checknormal = new System.Windows.Forms.CheckBox();
            this.checkbusiness = new System.Windows.Forms.CheckBox();
            this.checkinsurance = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.txtticket);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblweight);
            this.groupBox1.Controls.Add(this.lblticket);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(14, 55);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(246, 36);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Passenger Name:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(14, 114);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(220, 36);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Passenger Age:";
            // 
            // lblticket
            // 
            this.lblticket.AutoSize = true;
            this.lblticket.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticket.Location = new System.Drawing.Point(14, 174);
            this.lblticket.Name = "lblticket";
            this.lblticket.Size = new System.Drawing.Size(268, 36);
            this.lblticket.TabIndex = 2;
            this.lblticket.Text = "Number of Tickets:";
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(14, 239);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(289, 36);
            this.lblweight.TabIndex = 3;
            this.lblweight.Text = "baggage weight(kg):";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(318, 55);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(221, 26);
            this.txtname.TabIndex = 4;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(318, 124);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(221, 26);
            this.txtage.TabIndex = 5;
            // 
            // txtticket
            // 
            this.txtticket.Location = new System.Drawing.Point(318, 184);
            this.txtticket.Name = "txtticket";
            this.txtticket.Size = new System.Drawing.Size(221, 26);
            this.txtticket.TabIndex = 6;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(318, 249);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(221, 26);
            this.txtweight.TabIndex = 7;
            // 
            // lstdetailsrich
            // 
            this.lstdetailsrich.Location = new System.Drawing.Point(886, 12);
            this.lstdetailsrich.Name = "lstdetailsrich";
            this.lstdetailsrich.Size = new System.Drawing.Size(344, 419);
            this.lstdetailsrich.TabIndex = 1;
            this.lstdetailsrich.Text = "Airline Booking Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "travels Type";
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(232, 627);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(157, 52);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(468, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(651, 627);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(129, 52);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Additional Options";
            // 
            // checfirst
            // 
            this.checfirst.AutoSize = true;
            this.checfirst.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checfirst.Location = new System.Drawing.Point(117, 407);
            this.checfirst.Name = "checfirst";
            this.checfirst.Size = new System.Drawing.Size(152, 35);
            this.checfirst.TabIndex = 7;
            this.checfirst.Text = "First Class";
            this.checfirst.UseVisualStyleBackColor = true;
            // 
            // checknormal
            // 
            this.checknormal.AutoSize = true;
            this.checknormal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checknormal.Location = new System.Drawing.Point(359, 407);
            this.checknormal.Name = "checknormal";
            this.checknormal.Size = new System.Drawing.Size(189, 35);
            this.checknormal.TabIndex = 8;
            this.checknormal.Text = "Normal Class";
            this.checknormal.UseVisualStyleBackColor = true;
            // 
            // checkbusiness
            // 
            this.checkbusiness.AutoSize = true;
            this.checkbusiness.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbusiness.Location = new System.Drawing.Point(598, 407);
            this.checkbusiness.Name = "checkbusiness";
            this.checkbusiness.Size = new System.Drawing.Size(202, 35);
            this.checkbusiness.TabIndex = 9;
            this.checkbusiness.Text = "Business Class";
            this.checkbusiness.UseVisualStyleBackColor = true;
            // 
            // checkinsurance
            // 
            this.checkinsurance.AutoSize = true;
            this.checkinsurance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinsurance.Location = new System.Drawing.Point(77, 564);
            this.checkinsurance.Name = "checkinsurance";
            this.checkinsurance.Size = new System.Drawing.Size(453, 35);
            this.checkinsurance.TabIndex = 10;
            this.checkinsurance.Text = "Add Travel insurance($25 per ticket)";
            this.checkinsurance.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 708);
            this.Controls.Add(this.checkinsurance);
            this.Controls.Add(this.checkbusiness);
            this.Controls.Add(this.checknormal);
            this.Controls.Add(this.checfirst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstdetailsrich);
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
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblticket;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RichTextBox lstdetailsrich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checfirst;
        private System.Windows.Forms.CheckBox checknormal;
        private System.Windows.Forms.CheckBox checkbusiness;
        private System.Windows.Forms.CheckBox checkinsurance;
    }
}

