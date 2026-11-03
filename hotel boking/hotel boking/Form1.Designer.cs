namespace hotel_boking
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
            this.txtgusst = new System.Windows.Forms.TextBox();
            this.txtNighs = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbnguest = new System.Windows.Forms.Label();
            this.lblNight = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.detalis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chekstandr = new System.Windows.Forms.CheckBox();
            this.cheknormal = new System.Windows.Forms.CheckBox();
            this.chekhight = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cheks = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.txtgusst);
            this.groupBox1.Controls.Add(this.txtNighs);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbnguest);
            this.groupBox1.Controls.Add(this.lblNight);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Booking";
            // 
            // txtgusst
            // 
            this.txtgusst.Location = new System.Drawing.Point(271, 197);
            this.txtgusst.Name = "txtgusst";
            this.txtgusst.Size = new System.Drawing.Size(252, 26);
            this.txtgusst.TabIndex = 8;
            // 
            // txtNighs
            // 
            this.txtNighs.Location = new System.Drawing.Point(271, 152);
            this.txtNighs.Name = "txtNighs";
            this.txtNighs.Size = new System.Drawing.Size(252, 26);
            this.txtNighs.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(271, 99);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(252, 26);
            this.txtAge.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 26);
            this.txtName.TabIndex = 5;
            // 
            // lbnguest
            // 
            this.lbnguest.AutoSize = true;
            this.lbnguest.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbnguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnguest.Location = new System.Drawing.Point(27, 194);
            this.lbnguest.Name = "lbnguest";
            this.lbnguest.Size = new System.Drawing.Size(172, 29);
            this.lbnguest.TabIndex = 4;
            this.lbnguest.Text = "number guest :";
            // 
            // lblNight
            // 
            this.lblNight.AutoSize = true;
            this.lblNight.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNight.Location = new System.Drawing.Point(27, 148);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(187, 29);
            this.lblNight.TabIndex = 3;
            this.lblNight.Text = "Nigths Number :";
            this.lblNight.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(27, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(68, 29);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(27, 53);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(90, 29);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name :";
            // 
            // detalis
            // 
            this.detalis.Location = new System.Drawing.Point(680, 12);
            this.detalis.Name = "detalis";
            this.detalis.Size = new System.Drawing.Size(317, 418);
            this.detalis.TabIndex = 1;
            this.detalis.Text = "HOTEL BOOKING ROOM DETALIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Type";
            // 
            // chekstandr
            // 
            this.chekstandr.AutoSize = true;
            this.chekstandr.Location = new System.Drawing.Point(113, 374);
            this.chekstandr.Name = "chekstandr";
            this.chekstandr.Size = new System.Drawing.Size(139, 24);
            this.chekstandr.TabIndex = 3;
            this.chekstandr.Text = "Standar Room";
            this.chekstandr.UseVisualStyleBackColor = true;
            // 
            // cheknormal
            // 
            this.cheknormal.AutoSize = true;
            this.cheknormal.Location = new System.Drawing.Point(317, 374);
            this.cheknormal.Name = "cheknormal";
            this.cheknormal.Size = new System.Drawing.Size(132, 24);
            this.cheknormal.TabIndex = 4;
            this.cheknormal.Text = "Normal Room";
            this.cheknormal.UseVisualStyleBackColor = true;
            // 
            // chekhight
            // 
            this.chekhight.AutoSize = true;
            this.chekhight.Location = new System.Drawing.Point(480, 374);
            this.chekhight.Name = "chekhight";
            this.chekhight.Size = new System.Drawing.Size(120, 24);
            this.chekhight.TabIndex = 5;
            this.chekhight.Text = "Hight Room";
            this.chekhight.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Additional options";
            // 
            // cheks
            // 
            this.cheks.AutoSize = true;
            this.cheks.Location = new System.Drawing.Point(164, 505);
            this.cheks.Name = "cheks";
            this.cheks.Size = new System.Drawing.Size(244, 24);
            this.cheks.TabIndex = 7;
            this.cheks.Text = "Guest(15 per guest per night)";
            this.cheks.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(228, 574);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(129, 41);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(404, 574);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 41);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(581, 574);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(129, 41);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 652);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.cheks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chekhight);
            this.Controls.Add(this.cheknormal);
            this.Controls.Add(this.chekstandr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detalis);
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
        private System.Windows.Forms.Label lbnguest;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RichTextBox detalis;
        private System.Windows.Forms.TextBox txtgusst;
        private System.Windows.Forms.TextBox txtNighs;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chekstandr;
        private System.Windows.Forms.CheckBox cheknormal;
        private System.Windows.Forms.CheckBox chekhight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cheks;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

