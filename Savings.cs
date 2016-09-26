using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Savings : Account // long-term savings
    {
        //fields
        private string accountType; //type
        private int savBalance; //balance

        //properties
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public int SavBalance
        {
            get { return this.savBalance; }
            set { this.savBalance = value; }
        }

        //constructors
        public Savings()
        {
            this.accountType = "Savings";
            this.savBalance = 100; //starting balance
        }

        //methods
        public override void getBalance() //displays current balance
        {
            base.getBalance();
            Console.WriteLine("You currently have " + this.savBalance + " Galleons");
        }

        public override void Deposit() //adds amount, saves as new balance
        {
            base.Deposit();
            int amount = int.Parse(Console.ReadLine());
            this.savBalance = amount + this.savBalance;
        }

        public override void Withdraw() //removes amount, saves as new balance
        {
            base.Withdraw();
            int amount = int.Parse(Console.ReadLine());
            this.savBalance = this.savBalance - amount;
        }

        static void writeSavings() //my attempt at the stream writer in the class. It doesn't show the username or account number, even though it's inherited from the account class
        { 
        StreamWriter saveaccount = new StreamWriter("..\\..\\Savings.txt");
            using (saveaccount)
            {
                saveaccount.WriteLine("- " +)
            }
    }
}
