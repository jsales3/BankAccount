using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Savings:Account
    {
        //fields
       
        private double currentBalance = 0;
        private double minimumBalance = 20;

        public double MinimumBalance
        {
            get { return minimumBalance; }
        }

        public Savings()
        {
            //default constructor
        }

        public override void ViewBalance(string option)
        {
            if(option == "b")
            {
                Console.WriteLine(currentBalance);
            }
        }

        public override void Deposit(double amount)
        {
            currentBalance += amount;
            //return currentBalance;
        }

        public override void Withdraw(double amount)
        {
            currentBalance -= amount;

            if (currentBalance < minimumBalance)
            {
                Console.WriteLine("Sorry you have insufficent funds!");
            }
            else
            {
                currentBalance -= amount;
            }
            //return currentBalance;
        }


    }
}
