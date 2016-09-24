using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Reserve : Account //short-term savings
    {
        //fields
        private string accountType;
        private int resBalance;

        //properties
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public int ResBalance
        {
            get { return this.resBalance; }
            set { this.resBalance = value; }
        }
        
        //constructors
        public Reserve()
        {
            this.accountType = "Reserve";
            this.resBalance = 40;
        }

        //methods
        public override void getBalance()
        {
            base.getBalance();
            Console.WriteLine("You currently have " + this.resBalance + " Galleons");
        }

        public override void Deposit()
        {
            base.Deposit();
            int amount = int.Parse(Console.ReadLine());
            this.resBalance = amount + this.resBalance;
            Console.WriteLine("+ " + amount);
        }

        public override void Withdraw()
        {
            base.Withdraw();
            int amount = int.Parse(Console.ReadLine());
            this.resBalance = this.resBalance - amount;
            Console.WriteLine("- " + amount);
        }
    }
}
