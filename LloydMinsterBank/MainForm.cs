using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydMinsterBank
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loginForm.TopLevel = false;
            pnlMiddle.Controls.Add(loginForm);
            loginForm.BringToFront();
            loginForm.Show();

        }


        // Variables

        protected string userEnteredPin;
        AccountForm accountPage = new AccountForm ();
        Program program = new Program();
        MenuForm menuForm = new MenuForm();
        LoginForm loginForm = new LoginForm();


        public void updateSubForm(string form)
        {
            if (form == "MenuForm")
            {
                MenuForm menuForm = new MenuForm();
                program.setCurrentForm("MenuForm");
                menuForm.TopLevel = false;
                pnlMiddle.Controls.Add(menuForm);
                menuForm.BringToFront();
                menuForm.Show();
            }
            else if (form == "WithdrawForm")
            {
                WithdrawForm withdrawForm = new WithdrawForm();
                program.setCurrentForm("WithdrawForm");
                withdrawForm.TopLevel = false;
                pnlMiddle.Controls.Add(withdrawForm);
                withdrawForm.BringToFront();
                withdrawForm.Show();
            }
            else if (form == "DepositForm")
            {
                DepositForm depositForm = new DepositForm();
                program.setCurrentForm("DepositForm");
                depositForm.TopLevel = false;
                pnlMiddle.Controls.Add(depositForm);
                depositForm.BringToFront();
                depositForm.Show();
            }
            else if (form == "AccountForm")
            {
                AccountForm accountForm = new AccountForm();
                program.setCurrentForm("AccountForm");
                accountForm.TopLevel = false;
                pnlMiddle.Controls.Add(accountForm);
                accountForm.BringToFront();
                accountForm.Show();
            }
        }

        // NUM PAD
        private void btnPinNum0_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "0";
            string currentForm = program.getCurrentForm();
            if (currentForm == "login")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum1_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "1";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum2_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "2";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum3_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "3";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum4_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "4";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum5_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "5";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum6_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "6";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum7_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "7";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }
        private void btnPinNum8_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "8";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum9_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "9";
            string currentForm = program.getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loginForm.TopLevel = false;
            pnlMiddle.Controls.Add(loginForm);
            loginForm.BringToFront();
            loginForm.Show();
        }

        private void btnClearPin_Click(object sender, EventArgs e)
        {
            userEnteredPin = "";
            loginForm.ClearPinText();
        }




        private void btnEnterPin_Click(object sender, EventArgs e)
        {
            try
            {

                int formatedPin = Convert.ToInt32(userEnteredPin);
                Program program = new Program();
                string currentForm = program.getCurrentForm();

                if (currentForm == "LoginForm")
                {
                    program.LoadCustomers();
                    bool verify = program.Verify(formatedPin);
                    if (verify == true)
                    {

                    }
                    else if (verify == false)
                    {

                    }
                }



            }
            catch (Exception ex)
            {
                //Sends String to Pin label to set it to Invalid

            }
        }

        // SIDE BUTTONS




        private void btnP1_Click(object sender, EventArgs e)
        {
           /* program.sideButtons("1");*/
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            /*program.sideButtons("2");*/
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
           /* program.sideButtons("3");*/
        }

        private void btnP4_Click(object sender, EventArgs e)
        {
          /*  program.sideButtons("4");*/
        }

        private void btnP5_Click(object sender, EventArgs e)
        {
           /* program.sideButtons("5");*/
        }

        private void btnP6_Click(object sender, EventArgs e)
        {
           /* program.sideButtons("6");*/
        }

        private void btnP7_Click(object sender, EventArgs e)
        {
           /* program.sideButtons("7");*/
        }

        private void btnP8_Click(object sender, EventArgs e)
        {
            /*program.sideButtons("8");*/
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            /*program.sideButtons("9");*/
        }
    }
}

