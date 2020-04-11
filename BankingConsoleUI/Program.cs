using System;

namespace BankingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gemmie ur name");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your social? No Hyphens digits only");
            string userSSN = Console.ReadLine();

            Person p = new Person(userName, userSSN);
            p.DisplayUserInfo();
        }
    }
}
