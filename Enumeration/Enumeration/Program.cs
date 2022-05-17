using System;
using Enumeration.Entites;
using Enumeration.Entites.Enums;
namespace Enumeration {
    class Program {
        static void Main(string[] args) {

            order order = new order {
                ID = 1080,
                Moment = DateTime.Now,
                Status = Orderstatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = Orderstatus.PendingPayment.ToString();

            Orderstatus os = Enum.Parse<Orderstatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
