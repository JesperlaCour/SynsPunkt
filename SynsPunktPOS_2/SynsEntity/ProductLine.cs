using System;
namespace SynsEntity
{
    public class ProductLine
    {
        //Author: Jesper
        public int productLineID { get; private set; }
        public int orderID { get; private set; }
        public int productID { get; private set; }
        public int quantity { get; private set; }
        public string manufactor { get; private set; }
        public string modelName { get; private set; }
        public double unitPrice { get; private set; }
        public double linePrice { get; private set; }

        public ProductLine()
        {
        }

        public ProductLine(int orderID, int productID, int quantity)
        {
            this.orderID = orderID;
            this.productID = productID;
            this.quantity = quantity;
        }

        public ProductLine(int productLineID, int orderID, int productID, int quantity)
        {
            this.productLineID = productLineID;
            this.orderID = orderID;
            this.productID = productID;
            this.quantity = quantity;
        }

        public ProductLine(int productLineID, int orderID, int productID, int quantity, string manufactor, string modelName, double unitPrice)
        {
            this.productLineID = productLineID;
            this.orderID = orderID;
            this.productID = productID;
            this.quantity = quantity;
            this.manufactor = manufactor;
            this.modelName = modelName;
            this.unitPrice = unitPrice;
            linePrice = unitPrice * quantity;
        }

        public override string ToString()
        {
            return $"{productLineID} {orderID} {productID} {quantity} {manufactor} {modelName} {unitPrice} {linePrice}";
        }

    }
}
