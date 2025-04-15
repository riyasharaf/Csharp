using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q4: Create a class BankAccount with properties like AccountNumber, Name, and Balance. Add methods for:
//Deposit(int amount)
//Withdraw(int amount)
//DisplayBalance()

namespace OopsPractice
{
    internal class BankAccount
    {

        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public  BankAccount(int accountnumber , string name , int balance)
        {
            AccountNumber= accountnumber;
            Name= name;
            Balance= balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited :rs{amount}  Total Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            
            }
        }


        public void Withdraw(double amount)
        {
            if(amount > 0 && amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Withdrawn Amount rs{amount} Total Balance{Balance}");
            }
            else
            {
                Console.WriteLine("Invalid Transaction");
            }
        }

        public void displaybal()
        {
            Console.WriteLine($" Current Balance is {Balance}");
        }
    }
}
