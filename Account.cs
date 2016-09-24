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
           //writes account balance
        }

        public virtual void Deposit()
        {
            //deposits Galleons
            Console.WriteLine("How much would you like to deposit?");
        }

        public virtual void Withdraw()
        {
            //withdraws Galleons
            Console.WriteLine("How much would you like to withdraw?");
        }

        public void getInformation()
        {
            Console.WriteLine(userName+"\n"+ vaultNum);
        }
    }
}
