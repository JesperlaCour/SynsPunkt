using System;
using System.Collections.Generic;
using System.Xml.Schema;
using SynsBll;
using SynsEntity;


namespace SynsBLL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer
            //CustController c = new CustController();

            //c.OpretKunde("Claus", "Torvet 2", 7100);
            //Console.WriteLine(c.GetCustomer(4));
            //foreach (var item in c.GetAllCustomer(""))
            //{
            //    Console.WriteLine(item);
            //}
            //c.UpdateCustomer(4, "Lars Poulsen", "Jyllandsgade 12", 7100);

            //c.DeleteCustomer(5);
            //Product
            //ProductController p = new ProductController();
            //p.CreateProduct("Klarsyn", "Perfection", 149, 1);
            //Console.WriteLine(p.GetProduct(18));
            //foreach (var item in p.GetAllProducts()) {C:\Users\enyah\Documents\GitHub\SynsPunktv2\SynsPunktPOS_2\SynsBll\Program.cs
            //    Console.WriteLine(item);
            //}
            //p.CreateEyewear("Hugo Boss", "EpicDisaster 3000", 6899, 2, "Male", "square", "Dark Brown", 122);
            //UnityController u = new UnityController();

            //u.PrintProducts(@"C:\Kode\Test.txt");

            //foreach (Order item in u.ShowSalesStatistics(@"C:\Kode\Test.txt", new DateTime(2000, 1, 1), DateTime.Now))
            //{
            //    Console.WriteLine(item);
            //    OrderController o = new OrderController();
            //    foreach (ProductLine item2 in o.GetAllProductLines(item.ordreID))
            //    {
            //        Console.WriteLine("\t" + item2);
            //    }

            //}
            //u.PrintProducts(@"C:\Kode\Test.txt");
            //Order
            OrderController o = new OrderController();
            double pris = o.TotalPrice(10, 17);
            Console.WriteLine(pris);

            //o.CreateOrder(2);
            //Console.WriteLine(o.GetLastOrder());
            //foreach (var item in o.GetAllOrders()) {
            //    Console.WriteLine(item);
            //}
            //foreach (var item in o.GetAllProductLines(5)) {
            //    Console.WriteLine(item);
            //}

            //AssistController a = new AssistController();
            //foreach (Eyewear item in a.GetEyewear("male","round","",120,0,10000))
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
    }
}
