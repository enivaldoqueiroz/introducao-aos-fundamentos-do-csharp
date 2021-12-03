using Aula115Enumeracao.Entities;
using Aula115Enumeracao.Entities.Enums;
using System;

namespace Aula115Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 100,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
