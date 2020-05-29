using System;
using System.Data.SqlClient;

namespace SynsEntity
{
    public class Order
    {
        //Author: Jesper
        public int ordreID { get; private set; }
        public DateTime date { get; private set; }
        public int customerID { get; private set; }
        
        public string name { get; private set; }
        
        public double price { get; private set; }

        public Order()
        {

        }
        public Order(int customerID)
        {
            this.customerID = customerID;
        }

        public Order(int ordreID, int customerID, string name, DateTime date)
        {
            this.ordreID = ordreID;
            this.customerID = customerID;
            this.name = name;
            this.date = date;
        }
       
        public override string ToString()
        {
            return $"{ordreID} {customerID} {name} {date.ToShortDateString()}";
        }
    }
}
