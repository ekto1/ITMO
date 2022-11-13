using System.Collections;

class BankAccount 
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
    private Queue tranQueue = new Queue();
    
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
        this.accNo = NextNumber();
        this.accBal = aBal;
        this.accType = aType;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) {
            accBal -= amount;
            BankTransaction tran = new BankTransaction(-amount);
            tranQueue.Enqueue(tran);
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        return accBal;
    }

    public Queue Transactions()
    {
        return tranQueue;
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
