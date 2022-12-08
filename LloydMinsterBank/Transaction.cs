using LloydMinsterBank;

class Transaction
{






    public string Withdraw(string accountOne, double currentBalance, double amount, double salary) // Sends to SQL Code number to Withdraw Amount
    {
        MainForm mm = new MainForm();
        double calculation = currentBalance - amount;
        double calculatedOverdraft = currentBalance + (currentBalance / 10);
        if (accountOne == "CurrentAccount")
        {
            if (salary >= 30000)
            {
                if (calculation < 0)
                {
                    if (calculation >= calculatedOverdraft)
                    {
                        return "Successful Withdraw";
                        mm.setBalance(calculation, accountOne);
                    }
                    else
                    {
                        return "Invalid Withdraw";
                    }
                }
                else
                {
                    return "Successful Withdraw";
                    mm.setBalance(calculation, accountOne);
                }
            }
            else
            {
                if (calculation < 0)
                {
                    return "Invalid Withdraw";
                }
                return "Successful Withdraw";
                mm.setBalance(calculation, accountOne);
            }
        }
        else if (accountOne == "SimpleAccount")
        {
            if (calculation > 0)
            {
                return "Successful Withdraw";
                mm.setBalance(calculation, accountOne);
            }
            else
            {
                return "Invalid Withdraw";
            }
        }
        return "Invalid Withdraw";
    }
    public void Transfer(int accountOne, int accountTwo, int amount) // Sends to SQL Code number to Deposit Amount
    {
        int accountOneAfter = accountOne - amount;
        int accountTwoAfter = accountTwo + amount;
        // return operation;
    }

}