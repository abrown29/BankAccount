using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Checking spend = new Checking();
            Reserve shortTerm = new Reserve();
            Savings longTerm = new Savings();

            Console.WriteLine("Welcome to Gringotts Wizard Bank. Please select an option to continue:");
            Console.WriteLine("1. View Wizard Information \n2. View vault balance \n3. Deposit Galleons \n4. Withdraw Galleons \n5. Exit");
            int userChoice = int.Parse(Console.ReadLine());
            if(userChoice == 1)
            {
                spend.getInformation();
            }
            else if (userChoice == 2)
            {

            }
        }
    }
}
