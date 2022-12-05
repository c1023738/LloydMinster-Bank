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
            Application.Run(new LoginForm());
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
                    int userID = int.Parse(temp);
                    temp = result["AccountBalance"].ToString();
                    double AccountBalance = double.Parse(temp);
                    temp = result["OverdraftLimit"].ToString();
                    double Overdraft = double.Parse(temp);
                    temp = result["Pin"].ToString();
                    int pin = int.Parse(temp);

                    if (result["Type"].ToString() == "Current")
                    {

                        userAccount.Add(new CurrentAccount(userID, result["FirstName"].ToString(), result["LastName"].ToString(), AccountBalance, Overdraft, pin));
                    }
                    else if (result["Type"].ToString() == "Simple")
                    {
                        userAccount.Add(new SimpleDepositAccount(userID, result["FirstName"].ToString(), result["LastName"].ToString(), AccountBalance, Overdraft, pin));
                    }
                    else if (result["Type"].ToString() == "Longterm")
                    {
                        userAccount.Add(new LongTermDepositAccount(userID, result["FirstName"].ToString(), result["LastName"].ToString(), AccountBalance, Overdraft, pin));
                    }

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

        public void LoadCustomerList()
        {




            foreach (var accounts in chosenAccount)
            {
                string[] row =
                {
                    accounts.getBalance().ToString();
                }
            }
        }
    } 
}

        //       for (int i = 0; i != rowsNumber; i++)
        //       {
        //           string[] row = { chosenAccount., inventory.quantity[i], inventory.desc[i] };
        //           var listitem = new ListViewItem(row);
        //           listViewAccounts.Items.Add(listitem);
        //       }
        //   
        //  
        //
