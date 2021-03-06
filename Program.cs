﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Checking spend = new Checking();
            Reserve shortTerm = new Reserve();
            Savings longTerm = new Savings();

            int userChoice = 0;
            do
            {
                Console.WriteLine("Welcome to Gringotts Wizard Bank. Please select an option to continue:");
                Console.WriteLine("1. View Wizard Information \n2. View vault balance \n3. Deposit Galleons \n4. Withdraw Galleons \n5. Exit");
                userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1) //shows client information
                {
                    spend.getInformation();
                }
                else if (userChoice == 2) //choose an account balance to view
                {
                    Console.WriteLine("Please choose a balance to view:\n1.Checking\n2.Reserve\n3.Savings");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        spend.getBalance();
                    }
                    else if (option == 2)
                    {
                        shortTerm.getBalance();
                    }
                    else if (option == 3)
                    {
                        longTerm.getBalance();
                    }
                }
                else if (userChoice == 3) //deposit funds into a section of account
                {
                    Console.WriteLine("Please choose the section you wish to deposit funds into:\n1.Checking\n2.Reserve\n3.Savings");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        spend.Deposit();
                    }
                    else if (option == 2)
                    {
                        shortTerm.Deposit();
                    }
                    else if (option == 3)
                    {
                        longTerm.Deposit();
                    }
                }
                else if (userChoice == 4) //withdraw funds from a section of account
                {
                    Console.WriteLine("Please choose the section you wish to withdraw funds from: \n1. Checking\n2. Reserve\n3. Savings");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        spend.Withdraw();
                    }
                    else if (option == 2)
                    {
                        shortTerm.Withdraw();
                    }
                    else if (option == 3)
                    {
                        longTerm.Withdraw();
                    }
                }
                else if (userChoice == 5) //quits the program
                {
                    Environment.Exit(0);
                }
            }
            while (userChoice < 6 && userChoice > 0);

            StreamWriter saveAccount = new StreamWriter("..\\..\\..Savings.txt");
            using (saveAccount)
            {
                saveAccount.WriteLine(u) //trying to get the stream writer to work
                    //don't know if it's meant to go here or into each class
                    
            }
        }

    }
}
