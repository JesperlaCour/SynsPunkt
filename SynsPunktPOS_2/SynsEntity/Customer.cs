using System;
using System.Data.SqlClient;
namespace SynsEntity
{
    public class Customer
    {
        //Author: Jesper
        public int customerID { get; protected set; }
        public string name { get; protected set; }
        public string adress { get; protected set; }
        public int zipCode { get; protected set; }
        public string city { get; protected set; }

        public Customer()
        {
        }
        public Customer(string name, string adress, int zipCode)
        {
            this.name = name;
            this.adress = adress;
            this.zipCode = zipCode;
        }

        public Customer(int customerID, string name, string adress, int zipCode, string city)
        {
            this.customerID = customerID;
            this.name = name;
            this.adress = adress;
            this.zipCode = zipCode;
            this.city = city;
        }
        public override string ToString()
        {
            return $"{customerID} {name} {adress} {zipCode} {city}";
        }
    }
}
