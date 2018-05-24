using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Practice
{
    public partial class Form1 : Form
    {
        //Boolean used to determine if calculation needs to be looped in order to pay off Mortgage
        bool PaidOff = false;

        #region Un-Used Form1 Function
        public Form1()
        {
            InitializeComponent();
        }
        #endregion 

        #region Pay 1 Month Off Mortgage
        public int PayMonth(int MortgageLeft, int MonthPay)
        {
            int NewMortgageLeft = 0;
            NewMortgageLeft = MortgageLeft - MonthPay;
            return NewMortgageLeft;
        }
        #endregion 

        #region Calculate Mortgage Payments
        public string Calc(int MortgageLeft, int MonthPay, double InterestPercent)
        {
            //Set Variables
            int MonthsTotal = 0;
            int Count = 0;
            int OldMortgage = MortgageLeft;
            int YearsTotal = 0;
            string StringResult = "";

            //Check to ensure MortgageLeft isn't 0 already
            if (MortgageLeft > 0)
            {
                double InterestOntop = MortgageLeft / 100;
                InterestOntop = InterestOntop * InterestPercent;
                if (MortgageLeft > OldMortgage)
                {
                    ErrorLabel.Text = "Sorry... Due to the Interest and Monthly Payments, you will never be able to pay off this Mortgage";
                    MortgageLeft = 0;
                }
                else
                {
                    while (MortgageLeft > 0)
                    {
                        MortgageLeft = PayMonth(MortgageLeft, MonthPay);
                        Count++;
                        if (Count == 12)
                        {
                            MortgageLeft = MortgageLeft + Convert.ToInt32(InterestOntop);
                            Count = 0;
                            YearsTotal++;
                            MonthsTotal = 0;
                        }
                        MonthsTotal++;
                    }

                    if (MortgageLeft <= 0)
                    {
                        PaidOff = true;
                        StringResult = YearsTotal + " Years & " + MonthsTotal + " Months.";
                    }
                }
            }
            return StringResult;
        }
        #endregion

        #region Calculate Button Function - Get and Send Variables
        private void Calculate_Click(object sender, EventArgs e)
        {
            string Result = "";
            string Name = NameInput.Text;
            int MortgageLeft = Convert.ToInt32(MortgageInput.Text);
            double TempPay = Convert.ToDouble(Payments.Text);
            int MonthPay = Convert.ToInt32(TempPay);
            double InterestPercent = Convert.ToDouble(Interest.Text);

            while(PaidOff == false)
            {
                Result = Calc(MortgageLeft, MonthPay, InterestPercent);
            }
            ResultLBL.Visible = true;
            ResultLBL.Text = Name + " your Mortgage will be paid off in " + Result + " by Paying: £" + MonthPay + "/Month";
            PaidOff = false;
        }
        #endregion 

        #region Form Input Functions

        #region Validate Name Input Field
        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            if (MortgageInput.Text == "0" | MortgageInput.Text == "0.0" | MortgageInput.Text == "00" | MortgageInput.Text == "000" | MortgageInput.Text == "0000")
            {
                Calculate.Enabled = false;
            }
            else if (MortgageInput.Text != "" | MortgageInput.Text != " " & MortgageInput.Text != "0" | MortgageInput.Text == "0.0" | MortgageInput.Text == "00" | MortgageInput.Text == "000" | MortgageInput.Text == "0000")
            {
                if (NameInput.Text == "" | MortgageInput.Text == "" | Payments.Text == "" | Interest.Text == "")
                {
                    Calculate.Enabled = false;
                }
                else
                {
                    Calculate.Enabled = true;
                }
            }
        }
        #endregion 

        #region Validate Mortgage Input Field
        private void MortgageInput_TextChanged(object sender, EventArgs e)
        {
            if (MortgageInput.Text == "0" | MortgageInput.Text == "0.0" | MortgageInput.Text == "00" | MortgageInput.Text == "000" | MortgageInput.Text == "0000")
            {
                Calculate.Enabled = false;
            }
            else if (MortgageInput.Text != "" | MortgageInput.Text != " " & MortgageInput.Text != "0" | MortgageInput.Text == "0.0" | MortgageInput.Text == "00" | MortgageInput.Text == "000" | MortgageInput.Text == "0000")
            {
                if (NameInput.Text == "" | MortgageInput.Text == "" | Payments.Text == "" | Interest.Text == "")
                {
                    Calculate.Enabled = false;
                }
                else
                {
                    Calculate.Enabled = true;
                }
            } 
        }
        #endregion 

        #region Validate Payments Input Field
        private void Payments_TextChanged(object sender, EventArgs e)
        {
            if (MortgageInput.Text == "0" | MortgageInput.Text == "0.0" | MortgageInput.Text == "00" | MortgageInput.Text == "000" | MortgageInput.Text == "0000")
            {
                Calculate.Enabled = false;
            }
            else if (MortgageInput.Text != "" | MortgageInput.Text != " " & MortgageInput.Text != "0" | MortgageInput.Text == "0.0" | MortgageInput.Text == "00" | MortgageInput.Text == "000" | MortgageInput.Text == "0000")
            {
                if (NameInput.Text == "" | MortgageInput.Text == "" | Payments.Text == "" | Interest.Text == "")
                {
                    Calculate.Enabled = false;
                }
                else
                {
                    Calculate.Enabled = true;
                }
            }
        }
        #endregion

        #region Validate Interest Input Field
        private void Interest_TextChanged(object sender, EventArgs e)
        {
            if (MortgageInput.Text == "0" | MortgageInput.Text == "0.0" | MortgageInput.Text == "00" | MortgageInput.Text == "000" | MortgageInput.Text == "0000")
            {
                Calculate.Enabled = false;
            }
            else if (MortgageInput.Text != "" | MortgageInput.Text != " " & MortgageInput.Text != "0" | MortgageInput.Text == "0.0" | MortgageInput.Text == "00" | MortgageInput.Text == "000" | MortgageInput.Text == "0000")
            {
                if (NameInput.Text == "" | MortgageInput.Text == "" | Payments.Text == "" | Interest.Text == "")
                {
                    Calculate.Enabled = false;
                }
                else
                {
                    Calculate.Enabled = true;
                }
            }
        }
        #endregion

        #endregion
    }

    
}
