using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Client
    {
        //fields
        private string name= "Jovon Sales";
        private string address = "10313 Avon Ave";

        private bool isActive = true;
        

        public string Name
        {
            get{ return name; }
        }

        public string Address
        {
            get { return address; }
        }

        public bool IsActive
        {
            get { return isActive; }
        }



        public Client()
        {
            //default constructor
        }

        public void ClientInfo(string option)
        {
            if(option == "1")
            {
                Console.WriteLine(name + "\n" + address + "\n" + "Active Account: " + isActive);
            }
        }





    }
}
