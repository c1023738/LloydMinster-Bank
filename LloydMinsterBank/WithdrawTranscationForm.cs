using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydMinsterBank
{
    public partial class WithdrawTranscationForm : Form
    {
        public WithdrawTranscationForm()
        {
            InitializeComponent();
        }
        List<double> balance = new List<double>();

        string accountOne;
        string accountTwo;
        string transactionType;
        int amount;

        public void GetDetails(List<double> balances, string accountOne)
        {

            this.accountOne = accountOne;
            balance = balances;

            if (accountOne == "CurrentAccount")
            {
                // Able to withdraw and deposit and move can go bellow 0 depending on overdraft
                lblTitle.Text = "Current Account Balance: ";
                lblBalance.Text = balances[0].ToString();
                

            }
            else if (accountOne == "SimpleAccount")
            {
                // Able to withdraw deposit and move crnt go bellow 0
                lblTitle.Text = "Simple Deposit Account Balance: ";
                lblBalance.Text = balances[1].ToString();
            }




        }



        public void updateText(string enteredNumber)
        {
            lblDifferent.Text = enteredNumber;

            
        }

        public void ClearPinText()
        {
            lblDifferent.Text = "****";
        }
    }
}
