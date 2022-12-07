using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydMinsterBank
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }
        
        
        public void GetDetails(List<double> balances, string setAccount)
        {
            if (setAccount == "CurrentAccount")
            {
                // Able to withdraw and deposit and move can go bellow 0 depending on overdraft
                lblTitle.Text = "Current Account Balance: ";
                lblBalance.Text = balances[0].ToString();
            }
            else if (setAccount == "SimpleAccount")
            {
                // Able to withdraw deposit and move crnt go bellow 0
                lblTitle.Text = "Simple Deposit Account Balance: ";
                lblBalance.Text = balances[1].ToString();
            }
            else if (setAccount == "LongTermAccount")
            {
                //Able to deposit and move
                lblTitle.Text = "Long Term Deposit Account Balance: ";
                lblBalance.Text = balances[2].ToString();
            }
            

        }
        public void updateText(string enteredNumber)
        {
            lblEnterPin.Text = "tEST";
            
        }

        public void ClearPinText()
        {
            lblEnterPin.Text = "****";
        }
    }
}
