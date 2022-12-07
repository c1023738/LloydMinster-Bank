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
            SetText();
        }


        public void SetText()
        {
            Program program = new Program();
            List<string> details = new List<string>(program.GetChosenAccountDetails());

            lblAccountHolder.Text = details[0];
            lblCurrentAccount.Text = details[1];
            lblSimpleAccount.Text = details[2];
            lblLongAccount.Text = details[3];
        }





    }  
}
