using System;

namespace account
{
    class account
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.Name = "Maliha";
            a1.Id = "129383";
            a1.Balance = "20,000"
                
            a1.ShowInfo();
            Console.WriteLine();
            a1.Deposit(10);
            Console.WriteLine();
            a1.Withdraw(-2);


        }
    }
}