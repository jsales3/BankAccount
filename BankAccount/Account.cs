using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {
        //fields
        private int accountNumber= 00005678;
        private double checkings = 0;
        private double savings = 0;
        private double currentBalance = 0;
        private double deposit;
        private double withdraw;

        public double Deposits
        {
            get { return deposit; }
            set { deposit = value; }
        }


        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public double Checkings
        {
            get { return checkings; }
        }

        public double Savings
        {
            get { return savings; }
        }

        public double CurrentBalance
        {
            get { return currentBalance; }
            
        }


        public abstract void ViewBalance(string option);

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);


    }

   
}
