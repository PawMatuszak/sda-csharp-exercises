using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem chleb = new OrderItem("chleb", 5, 3.50m);
            Console.WriteLine(chleb);

            OrderItemWithPackage mleko = new OrderItemWithPackage("mleko", 5, 2.20m, "butelka", 1);
            Console.WriteLine(mleko);

            OrderItem[] orderItems = new OrderItem[2];

            orderItems[0] = chleb;
            orderItems[1] = mleko;

            Order order = new Order(orderItems);

            order.PrintSummary();

        }
    }
}