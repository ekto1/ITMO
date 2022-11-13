using System;
using System.Collections.Generic;
using System.Text;

namespace MoreMethods
{
    internal class Test
    {
        public static void Main()
        {
            BankAccount account1 = new BankAccount();
            account1.Populate(100);
            Console.WriteLine("Счет: {0}, баланс: {1}, тип: {2}", account1.Number(), account1.Balance(), account1.GetType());
            BankAccount account2 = new BankAccount();
            account2.Populate(100);
            Console.WriteLine("Счет: {0}, баланс: {1}, тип: {2}", account2.Number(), account2.Balance(), account2.GetType());
            account1.TransferFrom(account2, 10);
            Console.WriteLine("Баланс счета {0} равен {1}, баланс счета {2} равен {3}", account1.Number(), account1.Balance(),
                account2.Number(), account2.Balance());
        }
    }
}
