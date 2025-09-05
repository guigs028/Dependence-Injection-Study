using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.Payments
{
    public class CreditCard : IPayment          //Implementação concreta da interface IPayment para pagamento via cartão de crédito
    {
        // Método para processar o pagamento via cartão de crédito
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    }
}
