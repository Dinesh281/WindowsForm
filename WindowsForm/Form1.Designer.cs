
namespace WindowsForm
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
            this.lblNamr = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBasicSal = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblTotalSal = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNamr
            // 
            this.lblNamr.AutoSize = true;
            this.lblNamr.Location = new System.Drawing.Point(95, 34);
            this.lblNamr.Name = "lblNamr";
            this.lblNamr.Size = new System.Drawing.Size(63, 13);
            this.lblNamr.TabIndex = 0;
            this.lblNamr.Text = "Enter Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(95, 84);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(72, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Enter Number";
            // 
            // lblBasicSal
            // 
            this.lblBasicSal.AutoSize = true;
            this.lblBasicSal.Location = new System.Drawing.Point(95, 133);
            this.lblBasicSal.Name = "lblBasicSal";
            this.lblBasicSal.Size = new System.Drawing.Size(93, 13);
            this.lblBasicSal.TabIndex = 2;
            this.lblBasicSal.Text = "Enter Basic Salary";
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.Location = new System.Drawing.Point(95, 187);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(30, 13);
            this.lblHRA.TabIndex = 3;
            this.lblHRA.Text = "HRA";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(95, 242);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(22, 13);
            this.lblDA.TabIndex = 4;
            this.lblDA.Text = "DA";
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Location = new System.Drawing.Point(95, 295);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(21, 13);
            this.lblTA.TabIndex = 5;
            this.lblTA.Text = "TA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(227, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(227, 239);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(227, 292);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // lblTotalSal
            // 
            this.lblTotalSal.AutoSize = true;
            this.lblTotalSal.Location = new System.Drawing.Point(95, 347);
            this.lblTotalSal.Name = "lblTotalSal";
            this.lblTotalSal.Size = new System.Drawing.Size(69, 13);
            this.lblTotalSal.TabIndex = 12;
            this.lblTotalSal.Text = "Toatal Salary";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(227, 344);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lblTotalSal);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.lblHRA);
            this.Controls.Add(this.lblBasicSal);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblNamr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamr;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBasicSal;
        private System.Windows.Forms.Label lblHRA;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblTotalSal;
        private System.Windows.Forms.TextBox textBox7;
    }
}

