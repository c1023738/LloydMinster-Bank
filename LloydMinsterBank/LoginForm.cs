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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        // Variables

        protected string userEnteredPin;
        Login userLogin = new Login();
        List<Account> userAccount = new List<Account>();




        private void btnPinNum1_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "1";
        }

        private void btnPinNum2_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "2";
        }

        private void btnPinNum3_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "3";
        }

        private void btnPinNum4_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "4";
        }

        private void btnPinNum5_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "5";
        }

        private void btnPinNum6_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "6";
        }

        private void btnPinNum7_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "7";
        }
        private void btnPinNum8_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "8";
        }

        private void btnPinNum9_Click(object sender, EventArgs e)
        {
            userEnteredPin = userEnteredPin + "9";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnClearPin_Click(object sender, EventArgs e)
        {
            foreach (int number in userEnteredPin)
            {
                userEnteredPin.Remove(number);
            }
        }

        private void btnEnterPin_Click(object sender, EventArgs e)
        {
            int formatedPin = Convert.ToInt32(userEnteredPin);
            int customerID = int.Parse(txtCustomerIDInput.Text);
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
                    int CID = int.Parse(temp);
                    temp = result["AccountBalance"].ToString();
                    double AccountBalance = double.Parse(temp);
                    temp = result["OverdraftLimit"].ToString();
                    double Overdraft = double.Parse(temp);
                    temp = result["Pin"].ToString();
                    int pin = int.Parse(temp);

                   // userAccount.Add(CID, result["FirstName"].ToString(), result["LastName"].ToString(), AccountBalance, Overdraft, pin);

                }
            }

            dbOb.CloseConnection();
            //LoadCustomer(customerID,formatedPin);
            if (userLogin.VerifyPin(formatedPin) == true)
            {
                this.Hide();
                MainMenu mMenu = new MainMenu();
                mMenu.Show();
            }
            else
            {
                lblPinText.Text = "Incorrect Pin";
            }
        }

        // These Buttons dont do anything just there to make it look good and not leave Random Space 

        private void btnEmpty1_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpty2_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpty3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

