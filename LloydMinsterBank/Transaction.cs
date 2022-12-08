using LloydMinsterBank;
using System.Collections.Generic;

class Transaction
{






    public string Withdraw(string accountOne, List<double> balances, double amount, double salary) // Sends to SQL Code number to Withdraw Amount
    {
        List<string> list = new List<string>();


        double currentBalance = balances[0];
        double calculation = currentBalance - amount;
        double calculatedOverdraft = amount - (currentBalance + (currentBalance / 10));


        if (accountOne == "CurrentAccount")
        {

            if (salary >= 30000)
            {
                if (calculation < 0)
                {
                    if (calculatedOverdraft >= 0)
                    {
                        return "Succesful Withdraw" + "," + calculatedOverdraft.ToString();

                    }
                    else
                    {
                        return "Invalid Withdraw" + "," + currentBalance.ToString();
                    }
                }
                else
                {
                    return "Succesful Withdraw" + "," + calculation.ToString();
                }
            }
            else
            {
                if (calculation < 0)
                {
                    return "Invalid Withdraw" + "," + currentBalance.ToString();
                }
                return "Succesful Withdraw" + "," + calculation.ToString();
            }
        }
        else if (accountOne == "SimpleAccount")
        {
            if (calculation > 0)
            {
                return "Invalid Withdraw" + "," + currentBalance.ToString();
            }
            else
            {
                return "Invalid Withdraw" + "," + currentBalance.ToString();
            }
        }
        return "Invalid Withdraw" + "," + currentBalance.ToString();
    }
    public string Transfer(string accountOne, string accountTwo, List<double> balances,double amount) // Sends to SQL Code number to Deposit Amount
    {

        if (accountOne == "CurrentAccount" && accountTwo == "SimpleAccount")
        {
            double IncreaseBalance = balances[1] + amount;
            double DecreaseBalance = balances[0] - amount;
            if (DecreaseBalance >= 0)
            {
                return "Succesful Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
            else
            {
                return "Invalid Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
        }
        else if (accountOne == "CurrentAccount" && accountTwo == "LongTermAccount")
        {
            double IncreaseBalance = balances[2] + amount;
            double DecreaseBalance = balances[0] - amount;
            if (DecreaseBalance >= 0)
            {
                return "Succesful Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
            else
            {
                return "Invalid Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
        }
        else if (accountOne == "SimpleAccount" && accountTwo == "CurrentAccount")
        {
            double IncreaseBalance = balances[0] + amount;
            double DecreaseBalance = balances[1] - amount;
            if (DecreaseBalance >= 0)
            {
                return "Succesful Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
            else
            {
                return "Invalid Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
        }
        else if (accountOne == "SimpleAccount" && accountTwo == "LongTermAccount")
        {
            double IncreaseBalance = balances[2] + amount;
            double DecreaseBalance = balances[1] - amount;
            if (DecreaseBalance >= 0)
            {
                return "Succesful Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
            else
            {
                return "Invalid Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
        }
        else if (accountOne == "LongTermAccount" && accountTwo == "CurrentAccount")
        {
            double IncreaseBalance = balances[0] + amount;
            double DecreaseBalance = balances[2] - amount;
            if (DecreaseBalance >= 0)
            {
                return "Succesful Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
            else
            {
                return "Invalid Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
        }
        else if (accountOne == "LongTermAccount" && accountTwo == "SimpleAccount")
        {
            double IncreaseBalance = balances[1] + amount;
            double DecreaseBalance = balances[2] - amount;
            if (DecreaseBalance >= 0)
            {
                return "Succesful Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
            else
            {
                return "Invalid Transfer" + "," + IncreaseBalance.ToString() + "," + DecreaseBalance.ToString();
            }
        }
        return "Invalid Transfer";
    }

}