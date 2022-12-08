using System.Collections.Generic;

class Account
{
    protected string firstName;
    protected string lastName;
    protected double overdraftLimit;
    protected double CurrentAccount;
    protected double SimpleAccount;
    protected double LongTermAccount;
    protected int customerID;
    protected int pin;
    protected bool specialAccount;
    protected double salary;
    protected string type;


    public Account(int customerID, string firstName, string lastName, double CurrentAccount, double SimpleAccount, double LongTermAccount, double salary, int pin)
    {
        this.customerID = customerID;
        this.firstName = firstName;
        this.lastName = lastName;
        this.CurrentAccount = CurrentAccount;
        this.SimpleAccount = SimpleAccount;
        this.LongTermAccount = LongTermAccount;
        this.salary = salary;
        this.pin = pin;

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
        return firstName + "," + lastName;
    }


    public List<double> getBalance()
    {
        List<double> balance = new List<double>();
        balance.Add(CurrentAccount);
        balance.Add(SimpleAccount);
        balance.Add(LongTermAccount);
        return balance;
    }

    public double getSalary()
    {

        return salary;
    }

    public void setCurrentAccount(double newBalance)
    {
        CurrentAccount = newBalance;
    }
    public void setSimpleAccount(double newBalance)
    {
        SimpleAccount = newBalance;
    }
    public void setLongTermAccount(double newBalance)
    {
        LongTermAccount = newBalance;
    }
}
