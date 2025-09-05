using ConsoleApp1.Interface;
using ConsoleApp1.Order;
using ConsoleApp1.Payments;

public class Program
{
    public static void Main(string[] args)
    {
        IPayment paymentPix = new Pix();
        IPayment paymentCC = new CreditCard();
        IPayment paymentSlip = new BankSlip();

        List<Order> order = new List<Order>
        {
            new Order("Laptop", 1500.00, paymentCC),
            new Order("Book", 30.00, paymentPix),
            new Order("Desk Chair", 85.50, paymentSlip)
        };

        foreach (var ord in order)
        {
            ord.ProcessOrder();
        }
    }
}
