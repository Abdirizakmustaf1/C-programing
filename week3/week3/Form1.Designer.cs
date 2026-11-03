namespace week3
{
    partial class lblname
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.RichTextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(84, 129);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(140, 29);
            this.lbllastname.TabIndex = 1;
            this.lbllastname.Text = "Last Name :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(84, 172);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(68, 29);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Age :";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(84, 227);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(155, 29);
            this.lblscore.TabIndex = 3;
            this.lblscore.Text = "Exam Score :";
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(152, 299);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(218, 157);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show Info";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclear.Location = new System.Drawing.Point(471, 299);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(218, 157);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(790, 50);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(218, 265);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(270, 82);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(298, 26);
            this.txtfirstname.TabIndex = 7;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(270, 176);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(298, 26);
            this.txtage.TabIndex = 8;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(270, 129);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(298, 26);
            this.txtlastname.TabIndex = 9;
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(270, 227);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(298, 26);
            this.txtscore.TabIndex = 10;
            // 
            // lblname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 569);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.label1);
            this.Name = "lblname";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.RichTextBox lblOutput;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtscore;
    }
}

