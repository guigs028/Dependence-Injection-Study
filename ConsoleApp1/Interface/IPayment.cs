using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.Interface
{
    //Interface com o método para processar o pagamento
    public interface IPayment
    {
        void ProcessPayment (double amount);
    }
}
