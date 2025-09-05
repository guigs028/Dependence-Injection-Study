using ConsoleApp1.Interface;
using ConsoleApp1.Order;
using ConsoleApp1.Payments;
public class Program
{
    public static void Main(string[] args)
    {
        IPayment paymentPix = new Pix();                    //Criação das instâncias de pagamento
        IPayment paymentCC = new CreditCard();              //Criação das instâncias de pagamento
        IPayment paymentSlip = new BankSlip();              //Criação das instâncias de pagamento

        List<Order> order = new List<Order>                     
        {
            new Order("Laptop", 1500.00, paymentCC),        //Criação das instâncias de pedido      
            new Order("Book", 30.00, paymentPix),           //Criação das instâncias de pedido
            new Order("Desk Chair", 85.50, paymentSlip),    //Criação das instâncias de pedido
            new Order("Monitor", 300.00, paymentCC),        //Criação das instâncias de pedido
            new Order("Headphones", 75.00, paymentPix)      //Criação das instâncias de pedido
        };

        foreach (var ord in order)
        {
            ord.ProcessOrder();                             //Chamada do método para processar o pedido
        }
    }
}