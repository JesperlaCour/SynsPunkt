using System;
using SynsPersistence;
using SynsEntity;
using System.Collections.Generic;

namespace SynsBLL
{
    public class OrderController
    {
        //Author: Jesper

        SqlOrder sqlO = new SqlOrder();

        public void CreateOrder(int customerID)
        {
            sqlO.CreateOrder(customerID);
        }

        public Order GetLastOrder()
        {
            return sqlO.GetLastOrder();
        }

        public List<Order> GetAllOrders(string name)
        {
            return sqlO.GetAllOrders(name);
        }

        public List<ProductLine> GetAllProductLines(int orderID)
        {
            return sqlO.GetAllProductLines(orderID);
        }

        public void CreateProductLine(int orderID,int productID,int quantity)
        {
            sqlO.CreateProductLine(orderID, productID, quantity);
        }

        public void DeleteProductLine(int productLineID)
        {
            sqlO.DeleteProductLine(productLineID);
        }
        public void DeleteOrder(int orderID)
        {
            sqlO.DeleteOrder(orderID);
        }

        public double TotalPrice(double discount,int orderID)
        {
            List<ProductLine> pList = sqlO.GetAllProductLines(orderID);
            double sum = 0;

            foreach (ProductLine item in pList)
            {
                sum += item.linePrice;
            }
            double rabat = (discount/ 100.0)*sum ;
            return sum - rabat;

        }

    }
}
