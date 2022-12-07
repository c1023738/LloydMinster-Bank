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
using System.Threading;
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
            lblBack1.Hide();
            lblBack2.Hide();
            

        }



        List<Account> userAccount = new List<Account>();
        List<Account> chosenAccount = new List<Account>();
        List<string> customerDetails = new List<string>();

        public void LoadCustomers()
        {
            SqliteDataAccess dbOb = new SqliteDataAccess();
            // SELECT FROM DATABASE
            string query = "SELECT * FROM Customer";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbOb.myConnection);
            dbOb.OpenConnection();


            SQLiteDataReader result = myCommand.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    string temp = result["CustomerID"].ToString();
                    int customerID = int.Parse(temp);
                    temp = result["CurrentAccountBalance"].ToString();
                    double CurrentAccount = double.Parse(temp);
                    temp = result["SimpleAccountBalance"].ToString();
                    double SimpleAccount = double.Parse(temp);
                    temp = result["LongTermAccountBalance"].ToString();
                    double LongTermAccount = double.Parse(temp);
                    temp = result["OverdraftLimit"].ToString();
                    double Overdraft = double.Parse(temp);
                    temp = result["Pin"].ToString();
                    int pin = int.Parse(temp);
                    userAccount.Add(new Account(customerID, result["FirstName"].ToString(), result["LastName"].ToString(), CurrentAccount, SimpleAccount, LongTermAccount, Overdraft, pin));

                }
            }
            dbOb.CloseConnection();
        }






        public bool Verify(int pin)
        {
            bool result = false;

            foreach (var account in userAccount)
            {
                if (account.getPin() == pin)
                {
                    chosenAccount.Add(account);
                    result = true;
                }
            }


            return result;
        }

        string CurrentForm = "LoginForm";
        string SelectedAccount;




        public void setSelectedAccount(string account)
        {
            SelectedAccount = account;
        }

        public string getSelectedAccount()
        {
            return SelectedAccount;
        }

        public void setCurrentForm(string account)
        {
            CurrentForm = account;
        }

        public string getCurrentForm()
        {
            return CurrentForm;
        }



        public string sideButtons(string buttonPressed)
        {

            if (CurrentForm == "MenuForm")
            {
                if (buttonPressed == "1" || buttonPressed == "2")
                {
                    // Go To Withdraw
                    CurrentForm = "WithdrawForm";
                    return CurrentForm;

                }
                else if (buttonPressed == "3" || buttonPressed == "4")
                {
                    // Go To AccountPage
                    CurrentForm = "AccountForm";
                    return CurrentForm;
                }
                else if (buttonPressed == "5" || buttonPressed == "6")
                {
                    // Go To Deposit
                    CurrentForm = "DepositForm";
                    return CurrentForm;
                }
                else if (buttonPressed == "7" || buttonPressed == "8")
                {
                    // Go To TransferForm
                    CurrentForm = "TransferForm";
                    return CurrentForm;
                }

            }
            else if (CurrentForm == "WithdrawForm")
            {

                if (buttonPressed == "2" || buttonPressed == "7")
                {
                    //Select Current Account
                }
                else if (buttonPressed == "3" || buttonPressed == "8")
                {
                    // Select Simple Account
                }
                else if (buttonPressed == "4" || buttonPressed == "9")
                {
                    // Select Long Account
                }
                else if (buttonPressed == "LeftBack")
                {
                    //Return to Menu
                    CurrentForm = "MenuForm";
                    return CurrentForm;
                }
                else if (buttonPressed == "RightBack")
                {
                    
                    //GO to TransactionForm
                    CurrentForm = "TransactionForm";
                    return CurrentForm;
                }
            }
            else if (CurrentForm == "DepositForm")
            {

                if (buttonPressed == "2" || buttonPressed == "7")
                {
                    //Select Current Account
                }
                else if (buttonPressed == "3" || buttonPressed == "8")
                {
                    // Select Simple Account
                }
                else if (buttonPressed == "4" || buttonPressed == "9")
                {
                    // Select Long Account
                }
                else if (buttonPressed == "LeftBack")
                {
                    //Return to Menu
                    CurrentForm = "MenuForm";
                    return CurrentForm;
                }
                else if (buttonPressed == "RightBack")
                {
                    // GO to TransactionForm
                    CurrentForm = "TransactionForm";
                    return CurrentForm;
                }
            }
            else if (CurrentForm == "AccountForm")
            {

                if (buttonPressed == "1" || buttonPressed == "2")
                {
                    // Go To Withdraw
                    CurrentForm = "WithdrawForm";
                    return CurrentForm;
                }
                else if (buttonPressed == "3" || buttonPressed == "4")
                {
                    // Go To AccountPage
                    CurrentForm = "AccountPage";
                    return CurrentForm;
                }
                else if (buttonPressed == "5" || buttonPressed == "6")
                {
                    // Go To Deposit
                    CurrentForm = "DepositForm";
                    return CurrentForm;
                }
                else if (buttonPressed == "7" || buttonPressed == "8")
                {
                    // Go To AccountPage
                    CurrentForm = "AccountForm";
                    return CurrentForm;
                }
                else if (buttonPressed == "Back")
                {
                    CurrentForm = "MenuForm";
                    return CurrentForm;
                }
            }
            else if (CurrentForm == "TransferForm")
            {

                if (buttonPressed == "2" || buttonPressed == "7")
                {
                    //Select Current Account
                }
                else if (buttonPressed == "3" || buttonPressed == "8")
                {
                    // Select Simple Account
                }
                else if (buttonPressed == "4" || buttonPressed == "9")
                {
                    // Select Long Account
                }
                else if (buttonPressed == "LeftBack")
                {
                    //Return to Menu
                    CurrentForm = "MenuForm";
                    return CurrentForm;
                }
                else if (buttonPressed == "RightBack")
                {
                    // GO to TransactionForm

                    CurrentForm = "TransactionForm";
                    return CurrentForm;
                }
            }
            return CurrentForm;
        }





        // Variables

        protected string userEnteredPin;
        //AccountForm accountPage = new AccountForm ();
        Program program = new Program();
        MenuForm menuForm = new MenuForm();
        LoginForm loginForm = new LoginForm();
        List<Account> accounts = new List<Account>();
        string btn1Text = "Back";
        string btn2Text = "Back";
        List<double> userBalances = new List<double>();
        int customerID;
        string fullName;
        double overdraft;
        public void setChosenCustmerID(int customerID)
        {
            this.customerID = customerID;
        }
        public void setChosenCustomerBalanace(List<double>balance)
        {
            userBalances = balance;
            
        }
        public void setChoseCustomerFullName(string fullName)
        {
            this.fullName = fullName;
        }
        public void setChosenCustomerOverdraft(double overdraft)
        {
            this.overdraft = overdraft;
        }
        public int getChosenCustmerID()
        {
            return customerID;
        }
        public List<double> getChosenCustomerBalanace()
        {
            return userBalances;

        }
        public string getChoseCustomerFullName()
        {
            return fullName;
        }
        public double getChosenCustomerOverdraft()
        {
            return overdraft;
        }





        public void updateSubForm(string form)
        {
            if (form == "MenuForm")
            {
                MenuForm menuForm = new MenuForm();
                setCurrentForm("MenuForm");
                menuForm.TopLevel = false;
                pnlMiddle.Controls.Add(menuForm);
                menuForm.BringToFront();
                menuForm.Show();
                lblBack1.Text = btn1Text;
                lblBack2.Text = btn2Text;
            }
            else if (form == "WithdrawForm")
            {
                WithdrawForm withdrawForm = new WithdrawForm();
                setCurrentForm("WithdrawForm");
                withdrawForm.TopLevel = false;
                pnlMiddle.Controls.Add(withdrawForm);
                withdrawForm.BringToFront();
                withdrawForm.Show();
                lblBack1.Text = btn1Text;
                lblBack2.Text = "Please Enter Amount";
            }
            else if (form == "DepositForm")
            {
                DepositForm depositForm = new DepositForm();
                setCurrentForm("DepositForm");
                depositForm.TopLevel = false;
                pnlMiddle.Controls.Add(depositForm);
                depositForm.BringToFront();
                depositForm.Show();
                lblBack1.Text = btn1Text;
                lblBack2.Text = "Please Enter Amount";
            }
            else if (form == "AccountForm")
            {
                AccountForm accountForm = new AccountForm();
                setCurrentForm("AccountForm");
                accountForm.TopLevel = false;
                pnlMiddle.Controls.Add(accountForm);
                accountForm.BringToFront();
                accountForm.Show();
                lblBack1.Text = btn1Text;
                lblBack2.Text = btn2Text;
            }
            else if (form == "TransferForm")
            {
                TransferForm transferForm = new TransferForm();
                setCurrentForm("TransferForm");
                transferForm.TopLevel = false;
                pnlMiddle.Controls.Add(transferForm);
                transferForm.BringToFront();
                transferForm.Show();
                lblBack1.Text = btn1Text;
                lblBack2.Text = "Please Enter Amount";
            }
        }

        // NUM PAD
        private void btnPinNum0_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "0";
            string currentForm = getCurrentForm();
            if (currentForm == "login")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum1_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "1";
            string currentForm = getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum2_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "2";
            string currentForm = getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum3_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "3";
            string currentForm = getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum4_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "4";
            string currentForm = getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum5_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "5";
            string currentForm = getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum6_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "6";
            string currentForm = getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum7_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "7";
            string currentForm = getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }
        private void btnPinNum8_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "8";
            string currentForm = getCurrentForm();
            if (currentForm == "LoginForm")
            {
                loginForm.UpdatePinText(userEnteredPin);
            }
        }

        private void btnPinNum9_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "9";
            string currentForm = getCurrentForm();
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
            userEnteredPin = "";
            lblBack1.Enabled = false;
            lblBack2.Enabled = false;
            setCurrentForm("LoginForm");
            lblBack1.Hide();
            lblBack2.Hide();
            loginForm.ClearPinText();
        }

        private void btnClearPin_Click(object sender, EventArgs e)
        {
            userEnteredPin = "";
            loginForm.ClearPinText();
        }


        int formatedPin;

        public int getPin()
        {
            return Convert.ToInt32(userEnteredPin);
        }

        private void btnEnterPin_Click(object sender, EventArgs e)
        {
            try
            {

                formatedPin = Convert.ToInt32(userEnteredPin);
                Program program = new Program();
                string currentForm = getCurrentForm();

                if (currentForm == "LoginForm")
                {
                    LoadCustomers();
                    bool verify = Verify(formatedPin);
                    if (verify == true)
                    {
                        setCurrentForm("MenuForm");
                        updateSubForm(getCurrentForm());
                        lblBack1.Show();
                        lblBack2.Show();
                    }
                    else if (verify == false)
                    {
                        loginForm.UpdatePinText("Invalid Input");
                        userEnteredPin = "";
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
            updateSubForm(sideButtons("1"));
     
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("2"));

        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("3"));
        }

        private void btnP4_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("4"));
        }


        private void btnP5_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("5"));
        }

        private void btnP6_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("6"));
        }

        private void btnP7_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("7"));
        }

        private void btnP8_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("8"));
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("LeftBack"));
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            updateSubForm(sideButtons("RightBack"));
        }
    }
}

