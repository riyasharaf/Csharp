using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allconceptspractice
{
//Bank Account
//Create a BankAccount class:
//Properties: AccountHolder, Balance
//Method: Deposit(double amount) and Withdraw(double amount)
//Use ref and out in methods to modify balance and return updated balance status
//Add method GetBalanceSummary()
    public class BankAccount  

    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accholder , double balance)
        {
            this.AccountHolder = accholder;
            this.Balance = balance;
        }

        public void Deposit(ref double amount , out double balance)
        {
            balance = Balance;
            if(amount > 0)
            {
                Balance = Balance + amount;
                balance = Balance;
                Console.WriteLine( $"Current Balance is {balance} and deposit was {amount}");
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public void Withdraw(ref double amount , out double bal)
        {
            bal = Balance;
            if(amount > 0 && amount < Balance)
            {
                Balance = Balance - amount;
                bal = Balance;
                Console.WriteLine($"Current Balance is {bal} and deposit was {amount}");
                
            }
            else
            {
                Console.WriteLine("Invalid Balance");
            }

        }

        public void getbalsummary()
        {
            
            Console.WriteLine($"Current Balance is {Balance}");
        }


    }
}
