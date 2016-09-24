using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //methods
    }
}
