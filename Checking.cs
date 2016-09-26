using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Checking : Account //I'm thinking of a checking account as a general 'I have this much to spend' account
    {
        //fields
        private string accountType;
        private int checkingBalance;
        
        //properties
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public int CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }

        //constructors
        public Checking ()
        {
            this.accountType = "Spend";
            this.checkingBalance = 25;
        }

        //methods
        public override void getBalance() //shows current checking balance
        {
            base.getBalance();
            Console.WriteLine("You currently have " + this.checkingBalance + " Galleons");
        }

        public override void Deposit() //adds amount to balance, then saves result as new balance
        {
            base.Deposit();
            int amount = int.Parse(Console.ReadLine());
            this.checkingBalance = amount + this.checkingBalance;
            
        }

        public override void Withdraw() //removes amount from previous balance, then saves result as new balance
        {
            base.Withdraw();
            int amount = int.Parse(Console.ReadLine());
            this.checkingBalance = this.checkingBalance - amount;
        }
    }
}
