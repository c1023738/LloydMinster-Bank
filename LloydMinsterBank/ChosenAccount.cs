using System.Collections.Generic;

class ChosenAccount
{
    private string firstName;
    private string lastName;
    private double overdraftLimit;
    private double CurrentAccount;
    private double SimpleAccount;
    private double LongTermAccount;
    private int customerID;
    private int pin;
    private bool specialAccount;
    private double salary;

    public void setChosenAccount(int customerID, string fullName,List<double> balances,double overdraftLimit)
    {
        var name = fullName.Split(',');
        firstName = name[0];
        lastName = name[1];
        CurrentAccount= balances[0];
        SimpleAccount = balances[1];
        LongTermAccount = balances[2];
        this.overdraftLimit= overdraftLimit;
        this.customerID = customerID;
    }

    public int getPin()
    {
        return pin;
    }

    public int getCustomerID()
    {
        return customerID;
    }


    public string getFullName()
    {
        return firstName + " " + lastName;
    }


    public double GetCurrentAccount()
    {
        return CurrentAccount;
    }
    public double GetSimpleAccount()
    {
        return SimpleAccount;
    }
    public double GetLongTermAccount()
    {
        return LongTermAccount;
    }

    public double getOverdraftLimit()
    {

        return overdraftLimit;
    }
}