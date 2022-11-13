
using System;

class CreateAccount
{
    static void Main() 
    {
        BankAccount berts = NewBankAccount();
        Write(berts);
        TestDeposit(berts);
        Write(berts);
        TestWithdraw(berts);
        Write(berts);
        
        BankAccount freds = NewBankAccount();
        Write(freds);
        TestDeposit(freds);
        Write(freds);
        TestWithdraw(freds);
        Write(freds);
    }
    
    static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();
        
        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());
        
        created.Populate(balance);
        
        return created;
    }
    
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
    }

    static void TestDeposit(BankAccount account)
    {
        Console.Write("¬ведите сумму депозита: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        account.Deposit(amount);
    }

    static void TestWithdraw(BankAccount account)
    {
        Console.Write("¬ведите сумму вывода: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (!account.Withdraw(amount)) Console.WriteLine("Insufficient funds");
    }
}
