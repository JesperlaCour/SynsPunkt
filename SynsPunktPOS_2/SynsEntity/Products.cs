using System;
using System.Data.SqlClient;
using System.Net;

namespace SynsEntity
{
    public class Product
    {
        //Author: Jesper
        public int productID { get; protected set; }
        public string manufactor { get; protected set; }
        public string modelName { get; protected set; }
        public double price { get; protected set; }
        public int categoryID { get; protected set; }
        public string catName { get; protected set; }

        public Product()
        {

        }
        public Product(string manufactor, string modelName, double price, int categoryID)
        {
            this.manufactor = manufactor;
            this.modelName = modelName;
            this.price = price;
            this.categoryID = categoryID;
        }

        public Product(int productID, string manufactor, string modelName, double price, int categoryID, string catName)
        {
            this.productID = productID;
            this.manufactor = manufactor;
            this.modelName = modelName;
            this.price = price;
            this.categoryID = categoryID;
            this.catName = catName;
        }

        public override string ToString()
        {
            return $"{productID} {manufactor} {modelName} {price:C} {categoryID} {catName}";
        }
    }
}
