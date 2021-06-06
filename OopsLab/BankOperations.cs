using System;
using System.Collections.Generic;
using System.Text;

namespace OopsLab
{
    public class Account
    {
        public Account(String Name)
        {
            Name = Name;
        }
        public string AccountHolderName { get; set; }
        public string AccountId { get; set; }
        public double Balance { get; set; }
        public bool CreateAccount(string name, double initialBalance)
        {
            Name = name;
            Balance = initialBalance;
            return true;
            
        }

    }
    public class Savings : Account
    {
        public 
    }
}
