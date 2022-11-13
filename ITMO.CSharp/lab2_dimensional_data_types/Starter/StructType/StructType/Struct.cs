using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    public enum AccountType
    {
        Cheking, Deposit
    }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    internal class Struct
    {
        public static void Main(string[] args)
        {
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Cheking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = 123;

            Console.WriteLine("***Account Summary***");
            Console.WriteLine("Account Number {0}", goldAccount.accNo);
            Console.WriteLine("Account Type {0}", goldAccount.accType);
            Console.WriteLine("Account Balance {0}", goldAccount.accBal);
        }
    }
}
