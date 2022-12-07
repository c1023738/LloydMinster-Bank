class Transaction
{

    private string TypeOfTransaction;

    public Transaction(int currentBalance,int amount, string operation) // Sets Transaction Class
    {
        
    }

    public void setTypeOfTransaction(string selectedType)
    {
        TypeOfTransaction= selectedType;
    }

    public string getTypeOfTransaction()
    {
        return TypeOfTransaction;
    }

    public int Withdraw(int currentBalance, int amount) // Sends to SQL Code number to Withdraw Amount
    {
        int operation = currentBalance - amount;
        return operation ;
    }
    public void Transfer(int accountOne,int accountTwo, int amount) // Sends to SQL Code number to Deposit Amount
    {
        int accountOneAfter = accountOne - amount;
        int accountTwoAfter = accountTwo + amount;
       // return operation;
    }

}