using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Payments
{
    public class BankSlip : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing bank slip payment of {amount:C}");
        }
    }
}
