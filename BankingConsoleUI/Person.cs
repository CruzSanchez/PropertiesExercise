using System;
using System.Collections.Generic;
using System.Text;

namespace BankingConsoleUI
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be less than 0");
                }
            }
        }

        private string _ssn;
        public string SSN
        {
            set
            {
                if (string.IsNullOrEmpty(_ssn) && value.Length == 9)
                {
                    _ssn = value;
                }
            }
        }

        private readonly string _checkingAccountNumber;

        public Person(string firstName, string ssn)
        {
            FirstName = firstName;
            SSN = ssn;
            _checkingAccountNumber = $"45{firstName.Length}{ssn.Substring(4, 4)}";
        }

        public void DepositToChecking(string name, string ssn, string accountNumber, int amount)
        {
            if (CheckUserIdentity(name, ssn, accountNumber))
            {
                Console.WriteLine($"Simulating a deposit of {amount}");
            }
        }

        private bool CheckUserIdentity(string name, string ssn, string accountNumber)
        {
            return name == FirstName && ssn == _ssn && accountNumber == _checkingAccountNumber;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"{FirstName} SSN: {_ssn} Checking Account Number: {_checkingAccountNumber}");
        }
    }
}
