using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs1
{
    class Program
    {
        static string[] details;
        static int TotalBalance = 1000;
        static void Main(string[] args)
        {
            Register();
            Console.WriteLine("Your userid is:",details[4]);
            Credit();
            Debit();
        }
        static void Register(params string[] details)
        {
            Console.Write("Enter the name of user:");
            String name = Console.ReadLine();
            Console.Write("Enter Mobile no.:");
            String Mobileno = Console.ReadLine();
            Console.Write("Enter Gender: ");
            String Gender = Console.ReadLine();
            Console.Write("Enter Address:");
            String Address = Console.ReadLine();
            Console.Write("Your userid is:");
            string UserId = details[0].Substring(0,3) + details[1].Substring(0,3);
        }
        static void Credit()
        {
            Console.Write("Enter uniqueid:");
            string Key = Console.ReadLine();
            if (Key == details[4])
            {
                Console.Write("Enter the amount to be credited:");
                int Creditamount = Convert.ToInt32(Console.ReadLine());
                int Balance = Creditamount + TotalBalance;
                Console.WriteLine("Your total balance is:", Balance);
            }

        }
        static void Debit()
        {
            Console.Write("Enter uniqueid:");
            string Key = Console.ReadLine();
            if (Key == details[4])
            {
                Console.WriteLine("Enter the amount to be debitted:");
                int DebitAmount = Convert.ToInt32(Console.ReadLine());
                int NewBalance = TotalBalance - Balance;
                Console.WriteLine($"Your Balance is: {NewBalance}");
            }
        }
    }
}

