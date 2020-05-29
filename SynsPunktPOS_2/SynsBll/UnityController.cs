using System;
using SynsPersistence;
using SynsEntity;
using System.Collections.Generic;

namespace SynsBLL
{
    public class UnityController
    {
        //Author: Marc / Jesper

        PrintProducts printProd = new PrintProducts();

        public void PrintProducts(string fileName)
        {
            printProd.PrintProductsFile(fileName);
        }

        public List<Order> ShowSalesStatistics(string fileName, DateTime fromDate, DateTime toDate)
        {
            return SaleStatisticsFile(fileName, fromDate, toDate);
        }

        private List<Order> SaleStatisticsFile(string fileName, DateTime fromDate, DateTime toDate)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName))
            {
                SqlOrder sqlO = new SqlOrder();
                writer.WriteLine("Salgsstatistik" + "\t\t" + "Fra dato: " + fromDate.ToString("MM/dd/yyyy") +
                    "\t" + "Til dato: " + "\t" + toDate.ToString("MM/dd/yyyy") + "\n");
                writer.WriteLine("Kundenr" + "\t" + "Navn".PadRight(20) + "\t\t" + "Dato".PadRight(10) + "\t\t" + "OrdreID");
                List<Order> OrderList = new List<Order>();
                OrderList = sqlO.GetAllOrders("");
                double sum = 0;
                foreach (Order item in OrderList)
                {
                    writer.WriteLine($"{item.customerID}\t\t{item.name.PadRight(20)}" +
                        $"\t\t{item.date.ToShortDateString().PadRight(10)}\t\t{item.ordreID}");
                    List<ProductLine> pList = new List<ProductLine>();
                    pList = sqlO.GetAllProductLines(item.ordreID);
                    if (pList.Count > 0)
                    {
                        writer.WriteLine("- - - - - - - - - - - -");
                        writer.WriteLine($"\t" + "Fabrikant\t\t\t" + "Model" + "" +
                            "\t\t\t\t" + "Enhedspris" + "\t" + "Antal" + "\t" + "Pris");
                        foreach (ProductLine item2 in pList)
                        {
                            writer.WriteLine($"\t{item2.manufactor.PadRight(25)}\t\t{item2.modelName.PadRight(30)}" +
                                $"\t{item2.unitPrice:C}\t{item2.quantity}\t{item2.linePrice:C}");
                            sum += item2.linePrice;
                        }
                    }
                    writer.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                }
                writer.WriteLine("\nPris i alt kr. " + sum);
                return OrderList;
            }
        }

    }

}
