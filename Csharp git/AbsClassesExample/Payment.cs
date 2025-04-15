using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsClassesExample
{

    //Design a system using abstract classes and interfaces for a payment processing system(e.g., Payment, CreditCardPayment, UPIPayment, etc.)
    //Interface: IPaymentProcessor
    //Contains a method ProcessPayment()
    //Ensures all payment types implement the processor logic
    //Abstract Class: Payment
    //Contains shared properties like Amount, Currency, TransactionId
    //Declares abstract method ValidatePayment()
    //Concrete Classes:
    //CreditCardPayment
    //UPIPayment
    //Each payment type:
    //Implements IPaymentProcessor
    //Inherits from Payment
    interface IPaymentProcessor
    {
        void ProcessPayment();
    }

    public abstract class Payment
    {
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string TransactionId { get; set; }

        public Payment(double amount, string curr)
        {
            this.Amount = amount;
            this.Currency = curr;
            //this.TransactionId = tid;
        }

        public abstract bool ValidatePay();

    }

    public class CreditCardPayment : Payment, IPaymentProcessor
    {
        public string AccholderName { get; set; }
        public int CardNumber { get; set; }
        public DateOnly ExpiryDate { get; set; }

        public CreditCardPayment(double amount, string curr, string accname, int cardnum, DateOnly expdate) : base(amount, curr)
        {
            this.AccholderName = accname;
            this.CardNumber = cardnum;
            this.ExpiryDate = expdate;

        }
        public override bool ValidatePay()
        {
            return CardNumber == 16 && !String.IsNullOrEmpty(AccholderName);
        }

        public void ProcessPayment()
        {
            if (ValidatePay())
            {
                Console.WriteLine("Successfull");
            }
            else
            {
                {
                    Console.WriteLine("Not Sc");
                }
            }

        }
    }
}
