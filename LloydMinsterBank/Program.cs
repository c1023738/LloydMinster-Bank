using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydMinsterBank
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
        List<Account> userAccount = new List<Account>();
        List<Account> chosenAccount = new List<Account>();
        
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
                    userAccount.Add(new Account(customerID, result["FirstName"].ToString(), result["LastName"].ToString(), CurrentAccount,SimpleAccount,LongTermAccount, Overdraft, pin));

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

        public void setCurrentForm(string form)
        {
            CurrentForm = form;
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
                    // Go To AccountPage
                    CurrentForm = "AccountForm";
                    return CurrentForm;
                }
            }
            else if (CurrentForm == "WithdrawForm")
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
            }
            else if (CurrentForm == "DepositForm")
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
                else if(buttonPressed == "5" || buttonPressed == "6")
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
            }
            return CurrentForm;
        }



    }   
}
