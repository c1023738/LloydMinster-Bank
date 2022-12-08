using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydMinsterBank
{
    public partial class TransferTransactionForm : Form
    {
        public TransferTransactionForm()
        {
            InitializeComponent();
        }
        List<double> balance = new List<double>();

        string accountOne;
        string accountTwo;
        string transactionType;
        int amount;

        public void GetDetails(List<double> balances, string accountOne, string accountTwo)
        {
            if (accountOne == accountTwo)
            {
                // NOT VALID
            }
            else
            {
                this.accountOne = accountOne;
                this.accountTwo = accountTwo;
                
                balance = balances;
                if (transactionType == "Withdraw")
                {
                    if (accountOne == "CurrentAccount")
                    {
                        // Able to withdraw and deposit and move can go bellow 0 depending on overdraft
                        lblBalance.Text = "Current Account Balance: ";
                        lblBalance.Text = balances[0].ToString();

                    }
                    else if (accountOne == "SimpleAccount")
                    {
                        // Able to withdraw deposit and move crnt go bellow 0
                        lblBalance.Text = "Simple Deposit Account Balance: ";
                        lblBalance.Text = balances[1].ToString();
                    }

                }
                else if (transactionType == "Transfer")
                {
                    if (accountOne == "CurrentAccount")
                    {

                    }
                }
            }





        }

        public void sendTransaction(string accountOne, string accountTwo, int enteredNumber, int accountOneBalance, int accountTwoBalance)
        {

        }

        public void updateText(string enteredNumber)
        {
            label3.Text = enteredNumber;

            label3.Text = enteredNumber;
        }

        public void ClearPinText()
        {
            label3.Text = "****";
        }
    }
}

