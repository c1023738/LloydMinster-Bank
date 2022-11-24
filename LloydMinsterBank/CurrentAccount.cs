class CurrentAccount : Account
{
    public CurrentAccount(string fn, string ln, double ol, int cID, int pin, bool spA) : base(fn, ln, ol, cID, pin, spA)
    { 
        firstName = fn;
        lastName = ln;
        overdraftLimit = ol;
        this.pin = pin;
        specialAccount = spA;

    }

    public void DoesBalanceExceedOverdraft()
    {

    }

}