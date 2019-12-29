using System;
using Pedido_Simples.Entities;
using System.Globalization;

namespace Pedido_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("E-mail: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date: (DD/MM/YYYY:) ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enterder order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many itens to this order?");
            int orderedItems = int.Parse(Console.ReadLine());

            for(int i = 0; i < orderedItems; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + "item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);
        }
    }
}
