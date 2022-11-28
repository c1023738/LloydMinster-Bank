using System.Collections.Generic;
using System.Net.NetworkInformation;

class Login
{
    protected int customerID;
    protected int pin;
    protected int userEnteredPin;

    // Changed Constructor becuase didnt know how to make it work with the login form when i needed to use the Account class to set some of the data
    public void setCustomerID(int cID)
    {
        customerID = cID;
    }
    public void setPin(int pin)
    {
        this.pin = pin;
    }
    public bool VerifyPin(int userEnteredPin)
    {

        if (userEnteredPin == pin)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ReadCustomerID()
    {

    }

    public void DisplayMenu()
    {

    }
}

