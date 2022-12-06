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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string pinText;

        public void UpdatePinText(string enteredNumber)
        {            
            lblPinTxt.Text = enteredNumber;
        }

        public void ClearPinText()
        {
            lblPinTxt.Text = "****";
        }




    }
}
