using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using SynsPersistence;
using SynsEntity;

namespace SynsPersistence
{
    public class PrintProducts
    {

        //Author: Marc / Jesper

        public PrintProducts()
        {

        }

        public void PrintProductsFile(string fileName)
        {
            SqlProduct sqlP = new SqlProduct();
            List<Product> pList = new List<Product>(); 
            pList = sqlP.GetAllProducts("");


            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName))
            {

                writer.WriteLine("ProduktID\t"+ "Manufactor".PadRight(25) + "\t" + "ModelName".PadRight(30) + "\t" + "Price");

                foreach (Product item in pList)
                {
                    writer.WriteLine($"{item.productID}\t\t{item.manufactor.PadRight(25)}\t{item.modelName.PadRight(30)}\t{item.price:C}\t");
                }
            }

        }
    }
}
