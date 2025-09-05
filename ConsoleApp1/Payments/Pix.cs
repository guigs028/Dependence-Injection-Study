using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.Payments
{
    public class Pix: IPayment          //Implementação da interface IPayment para pagamento via Pix
    {
        // Método para processar o pagamento via Pix
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Pix payment of {amount:C}");
        }
    }
}
