
class BankAccount 
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
    
    private static long nextNumber = 123;

    public BankAccount()
    {
        this.accNo = NextNumber();
        this.accBal = 0;
        this.accType = AccountType.Checking;
    }

    public BankAccount(AccountType aType)
    {
        this.accNo = NextNumber();
        this.accBal = 0;
        this.accType = aType;
    }

    public BankAccount(decimal aBal)
    {
        this.accNo = NextNumber();
        this.accBal = aBal;
        this.accType = AccountType.Checking;
    }

    public BankAccount(decimal aBal, AccountType aType)
    {
        this.accNo = Number();
        this.accBal = aBal;
        this.accType = aType;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) {
            accBal -= amount;
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextNumber++;
    }
}
