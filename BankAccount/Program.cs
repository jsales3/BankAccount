using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client();

            Checkings myCheckings = new Checkings();

            Savings mySavings = new Savings();

            List<string> userOption = new List<string>();

            
            string userInput;
            double amount;

            userOption.Add("1. View Client Information");
            userOption.Add("2. View Account Balance");
            userOption.Add("3. Deposit Funds");
            userOption.Add("4. Withdraw Funds");
            userOption.Add("5. Exit");

            

            do { 
            

            foreach(string option in userOption)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine("Enter a number that corressponds to an option: ");
            userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        myClient.ClientInfo(userInput);
                        break;

                    case "2":
                        Console.WriteLine("A. Checkings Account Balance\n");
                        Console.WriteLine("B. Savings Account Balance");
                        userInput = Console.ReadLine().ToLower();
                        if (userInput == "a")
                        {
                            myCheckings.ViewBalance(userInput);
                        }
                        else if (userInput == "b")
                        {
                            mySavings.ViewBalance(userInput);
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid letter that corresponds to an option!");
                        }
                        break;

                    case "3":
                        Console.WriteLine("A. To Checkings Account\n");
                        Console.WriteLine("B. To Savings Account");
                        userInput = Console.ReadLine().ToLower();
                        if (userInput == "a")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            myCheckings.Deposits = double.Parse(Console.ReadLine());
                            myCheckings.Deposit(myCheckings.Deposits);
                        }
                        else if (userInput == "b")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            amount = double.Parse(Console.ReadLine());
                            mySavings.Deposit(amount);
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid letter that corresponds to an option!");
                        }
                        break;

                    case "4":
                        Console.WriteLine("A. From Checkings Account?\n");
                        Console.WriteLine("B. From Savings Account?");
                        userInput = Console.ReadLine().ToLower();
                        if (userInput == "a")
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            amount = double.Parse(Console.ReadLine());
                            myCheckings.Withdraw(amount);
                        }
                        else if (userInput == "b")
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            amount = double.Parse(Console.ReadLine());
                            mySavings.Withdraw(amount);
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid letter that corresponds to an option!");
                        }
                        break;
                }
                
            }
            while (userInput != "5");
        }

    }
}
