using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Checkings:Account
    {
        //fields
        private double deposit;
        private double withdraw;
        private double currentBalance = 0;

        public double Deposits
        {
            get { return deposit; }
            set { deposit = value; }
        }



        public Checkings()
        {
            //default constructor
        }

       

        public override void ViewBalance(string option)
        {
            if(option == "a")
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
            //return currentBalance;
        }
    }
}
