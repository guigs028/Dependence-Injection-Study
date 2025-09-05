using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.Payments
{
    public class BankSlip : IPayment        // Implementação da interface IPayment para pagamento via boleto bancário
    {
        // Método para processar o pagamento via boleto bancário    
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing bank slip payment of {amount:C}");
        }
    }
}
