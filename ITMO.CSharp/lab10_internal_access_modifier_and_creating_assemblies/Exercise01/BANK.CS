
using System.Collections;

public class Bank
{
    private Bank() { }
    public static long CreateAccount()
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }
    public static long CreateAccount(AccountType accType, decimal dec)
    {
        BankAccount newAcc = new BankAccount(accType, dec);
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }
    public static long CreateAccount(AccountType accType)
    {
        BankAccount newAcc = new BankAccount(accType);
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }
    public static long CreateAccount(decimal dec)
    {
        BankAccount newAcc = new BankAccount(dec);
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }
    public static bool CloseAccount(long accNo)
    {
        BankAccount closing = (BankAccount)accounts[accNo];
        if (closing != null)
        {
            accounts.Remove(accNo);
            closing.Dispose();
            return true;
        }
        else
        {
            return false;
        }
    }
    public static BankAccount GetAccount(long accNo)
    {
        return (BankAccount)accounts[accNo];
    }

    private static Hashtable accounts = new Hashtable();
}
