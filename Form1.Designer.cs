namespace Monthly_Payment_Calculator2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtAmountToFinance = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(242, 101);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(146, 26);
            this.txtPurchasePrice.TabIndex = 2;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(242, 172);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(146, 26);
            this.txtDownPayment.TabIndex = 3;
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(242, 246);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(146, 26);
            this.txtAnnualInterestRate.TabIndex = 4;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(242, 315);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(146, 26);
            this.txtLoanTerm.TabIndex = 5;
            // 
            // txtAmountToFinance
            // 
            this.txtAmountToFinance.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtAmountToFinance.Location = new System.Drawing.Point(743, 101);
            this.txtAmountToFinance.Name = "txtAmountToFinance";
            this.txtAmountToFinance.ReadOnly = true;
            this.txtAmountToFinance.Size = new System.Drawing.Size(154, 26);
            this.txtAmountToFinance.TabIndex = 6;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtMonthlyPayment.Location = new System.Drawing.Point(743, 169);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(154, 26);
            this.txtMonthlyPayment.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Purchase Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Down Payment Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Interest Rate (annual):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loan Term (months):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount to Finance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monthly Payment:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(911, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.txtAmountToFinance);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.txtAnnualInterestRate);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Monthly Payment Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtAmountToFinance;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

