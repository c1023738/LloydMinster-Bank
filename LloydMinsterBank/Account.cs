class Account
{
    protected string firstName;
    protected string lastName;
    protected double overdraftLimit;
    protected double balance;
    protected int customerID;
    protected int pin;
    protected bool specialAccount;
    protected double salary;


    public Account(int cID, string fn, string ln, double aB, double ol, int pin)
    {
        customerID= cID;
        firstName= fn;
        lastName= ln;
        balance = aB;
        overdraftLimit= ol;
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

    public int getCustomerID()
    {
        return customerID;
    }
    
    public double getBalance()
    {
        return balance;
    }

    public double getOverdraftLimit()
    {

        return overdraftLimit;
    }
}
