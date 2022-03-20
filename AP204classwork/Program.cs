using System;

namespace AP204classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product();
            pr.Name = "";
            pr.Price = 2;
            pr.Count = 5;
            pr.Sell();
            pr.Sell();
            pr.Sell();
            pr.Sell();
            pr.Sell();
            pr.Sell();





            Console.WriteLine($"Gelirimiz : {pr.Totalcome} Mehsulun sayi {pr.Count} ");


        }
    }
}
