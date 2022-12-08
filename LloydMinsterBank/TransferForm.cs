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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        public void GetDetails(List<double> balances)
        {
            lblLeftCurrentAccount.Text = balances[0].ToString();
            lblLeftSimpleAccount.Text = balances[1].ToString();
            lblLeftLongTerm.Text = balances[2].ToString();
            lblRightLongTermAccount.Text = balances[2].ToString();
            lblRightSimpleAccount.Text = balances[1].ToString();
            lblRightCurrentAccount.Text = balances[0].ToString();

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
