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
        private string accountType;
        private int savBalance;

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
            this.savBalance = 100;
        }

        //methods
        public override void getBalance()
        {
            base.getBalance();
            Console.WriteLine("You currently have " + this.savBalance + " Galleons");
        }

        public override void Deposit()
        {
            base.Deposit();
            int amount = int.Parse(Console.ReadLine());
            this.savBalance = amount + this.savBalance;
        }

        public override void Withdraw()
        {
            base.Withdraw();
            int amount = int.Parse(Console.ReadLine());
            this.savBalance = this.savBalance - amount;
        }
    }
}
