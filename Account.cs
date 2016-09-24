using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Account
    {
        //fields
        private string userName;
        private int vaultNum;

        //properties
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public int VaultNum
        {
            get { return this.vaultNum; }
            set { this.vaultNum = value; }
        }
        //constructors
        public Account()
        {
            this.userName = "Minerva McGonagall";
            this.vaultNum = 493;
        }
        //methods 
        public virtual void getBalance()
        {
            //writes balance of account
        }

        public virtual void Deposit()
        {
            //deposits Galleons
        }

        public virtual void Withdraw()
        {
            //withdraws Galleons
        }

        public void getInformation()
        {
            Console.WriteLine(userName+"\n"+ vaultNum);
        }
    }
}
