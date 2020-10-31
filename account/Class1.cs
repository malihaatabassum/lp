using System;
using System.Collections.Generic;
using System.Text;

namespace  lp3
{
    class Account
    {

        string accName;
        string acId;
        int balance;

        public string Name
        {
            set { accName = value; }
            get { return accName; }
        }
        public string Id
        {
            set { acId = value; }
            get { return acId; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Holder Name : " + Name);

            Console.WriteLine("Account ID : " + Id);

            Console.WriteLine("Account initial balance : " + Balance);

        }

        public void Deposit(int amount)
        {

            balance = balance + amount  
            Console.WriteLine("Total amount " + balance + " TK");
        }




        public void Withdraw(int amount)
        {

            balance = balance - amount;
            Console.WriteLine("Now your total amount " + balance + " TK");


        }
    }
}