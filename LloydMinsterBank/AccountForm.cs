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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();

        }


        public void GetDetails(string fullName,List<double> balances)
        {
            lblAccountHolder.Text = fullName; 
            lblCurrentAccount.Text = balances[0].ToString();
            lblSimpleAccount.Text = balances[1].ToString();
            lblLongAccount.Text = balances[2].ToString();
        }





    }
}
