using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Order
{
    public class Order
    {
        private int _id { get; set; }
        private static int _count = 1;
        private string _description { get; set; }
        private double _amount { get; set; }
        private readonly IPayment _payment;

        int count = 1;
        
        public Order(string description, double amount, IPayment payment)
        {   
            _id = _count;
            _count++;
            _description = description;
            _amount = amount;
            _payment = payment;
        }

        public void ProcessOrder()
        {
            DisplayOrderTitle();
            _payment.ProcessPayment(_amount);
            DisplayOrder();

        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order Details: Description: {_description}, Amount: {_amount:C}, Payment Method: {_payment.GetType().Name}");
            Console.WriteLine("###############################################\n");

        }

        public void DisplayOrderTitle()
        {
            Console.WriteLine($"ORDER {_id} DETAILS: ");
        }
    }
}
