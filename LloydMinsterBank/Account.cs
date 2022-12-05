class Account
{
    protected string firstName;
    protected string lastName;
    protected double overdraftLimit;
    protected double AccountBalance;
    protected int customerID;
    protected int pin;
    protected bool specialAccount;
    protected double salary;
    protected string type;


    public Account(int customerID, string firstName, string lastName, double AccountBalance, double overdraft, int pin)
    {
        this.customerID= customerID;
        this.firstName = firstName;
        this.lastName = lastName;
        this.AccountBalance = AccountBalance;
        overdraftLimit= overdraft;
        this.pin = pin;
   
    }

    
    

    public bool isSpecialAccount(int spA)
    {
        if (salary >= 30000)
        {
            specialAccount = true;
        }
        else
        {
            specialAccount = false;
        }
        return specialAccount;
        
    }
    public int getPin()
    {
        return pin;
    }

    public int getCustomerID()
    {
        return customerID;
    }
    
    public double getBalance()
    {
        return AccountBalance;
    }

    public double getOverdraftLimit()
    {

        return overdraftLimit;
    }
}
