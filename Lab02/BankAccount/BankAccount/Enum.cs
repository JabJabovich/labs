using System;

namespace BankAccount
{
    public enum AccountType { Checking, Deposit}
    class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccaunt;
            AccountType platinumAccount;
            goldAccaunt = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine("The Customer Account Type is {0}", goldAccaunt);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}
