
using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        BankAccount acc1, acc2, acc3, acc4;
        acc1 = new BankAccount();
        acc2 = new BankAccount(AccountType.Deposit);
        acc3 = new BankAccount(100);
        acc4 = new BankAccount(500, AccountType.Deposit);

        acc1.Deposit(99);
        acc1.Withdraw(50);
        acc2.Deposit(700);
        acc2.Withdraw(361);
        acc3.Deposit(1000);
        acc3.Withdraw(1000);
        acc4.Deposit(10);
        acc4.Withdraw(9);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);
    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        foreach (BankTransaction bankTransaction in acc.Transactions())
        {
            Console.WriteLine("Транзакция выполнена {0}, сумма: {1}", 
                bankTransaction.When(), bankTransaction.Amount());
        }
        Console.WriteLine("-------------");
    }
}
