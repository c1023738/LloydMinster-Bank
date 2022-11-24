class Transaction
{

    public Transaction(int currentBalance,int amount, string operation) // Sets Transaction Class
    {
        
    }

    public int Withdraw(int currentBalance, int amount) // Sends to SQL Code number to Withdraw Amount
    {
        int operation = currentBalance - amount;
        return operation ;
    }
    public int Deposit(int currentBalance, int amount) // Sends to SQL Code number to Deposit Amount
    {
        int operation = currentBalance + amount;
        return operation;
    }

}