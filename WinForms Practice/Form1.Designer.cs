namespace WinForms_Practice
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MortgageInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Payments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Interest = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ResultLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(97, 10);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 1;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mortgage Left: ";
            // 
            // MortgageInput
            // 
            this.MortgageInput.Location = new System.Drawing.Point(97, 36);
            this.MortgageInput.Name = "MortgageInput";
            this.MortgageInput.Size = new System.Drawing.Size(100, 20);
            this.MortgageInput.TabIndex = 3;
            this.MortgageInput.TextChanged += new System.EventHandler(this.MortgageInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monthly Payments of £:";
            // 
            // Payments
            // 
            this.Payments.Location = new System.Drawing.Point(135, 67);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(100, 20);
            this.Payments.TabIndex = 5;
            this.Payments.TextChanged += new System.EventHandler(this.Payments_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interest in %:";
            // 
            // Interest
            // 
            this.Interest.Location = new System.Drawing.Point(135, 95);
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(100, 20);
            this.Interest.TabIndex = 7;
            this.Interest.TextChanged += new System.EventHandler(this.Interest_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.Enabled = false;
            this.Calculate.Location = new System.Drawing.Point(65, 136);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(97, 199);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 9;
            // 
            // ResultLBL
            // 
            this.ResultLBL.AutoSize = true;
            this.ResultLBL.Location = new System.Drawing.Point(12, 167);
            this.ResultLBL.Name = "ResultLBL";
            this.ResultLBL.Size = new System.Drawing.Size(13, 13);
            this.ResultLBL.TabIndex = 10;
            this.ResultLBL.Text = "0";
            this.ResultLBL.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 186);
            this.Controls.Add(this.ResultLBL);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Interest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Payments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MortgageInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MortgageInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Payments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Interest;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ResultLBL;
    }
}

