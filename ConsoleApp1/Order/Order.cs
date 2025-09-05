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
        // Atributos
        private int _id { get; set; }               // Identificador do pedido
        private static int _count = 1;              //Contador estático para gerar IDs únicos
        private string _description { get; set; }   // Descrição do pedido
        private double _amount { get; set; }        // Valor do pedido
        private readonly IPayment _payment;         // Método de pagamento associado ao pedido (interface)

        //IMPORTANTE: O Order depende da abstração IPayment, e não de uma implementação concreta (Pix/CreditCard/BankSlip)
        // Construtor - Injeção de dependência (ou seja, o pagamento é passado como parâmetro na criação do Order (Pix/CC/Boleto))
        public Order(string description, double amount, IPayment payment)
        {   
            _id = _count;
            _count++;
            _description = description;
            _amount = amount;
            _payment = payment;
        }

        // Métodos
        public void ProcessOrder()
        {
            DisplayOrderTitle();                //Exibe o título com o ID do pedido
            _payment.ProcessPayment(_amount);   //Processa o pagamento usando o método de pagamento injetado
            DisplayOrder();                     //Exibe os detalhes do pedido

        }

        // Metodo exibe os detalhes do pedido
        public void DisplayOrder()
        {
            Console.WriteLine($"Description: {_description}" +
                $" Amount: {_amount:C}" +
                $" Payment Method: {_payment.GetType().Name}\n");
            Thread.Sleep(2000); //Pausa de 2 segundos para melhor visualização no console

        }

        // Metodo exibe o título do pedido com o ID
        public void DisplayOrderTitle()
        {
            Console.WriteLine($"ORDER {_id} DETAILS: ");
        }
    }
}
