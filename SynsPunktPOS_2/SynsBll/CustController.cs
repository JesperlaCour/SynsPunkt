using System;
using System.Collections.Generic;
using SynsEntity;
using SynsPersistence;
using System.Data;

namespace SynsBLL
{
    public class CustController
    {
        //Author: Jesper

        SqlCustomer sqlCust = new SqlCustomer();
        public CustController()
        {
        }
        public void OpretKunde(string name, string adress, int zipCode)
        {   
            Customer k = new Customer(name, adress, zipCode);
            sqlCust.CreateCustomer(k);
        }

        public Customer GetCustomer(int customerID)
        {
            return sqlCust.GetCustomer(customerID);
        }

        public List<Customer> GetAllCustomer(string name)
        {
            return sqlCust.GetAllCustomer(name);
        }

        public void DeleteCustomer(int customerID)
        {
            sqlCust.DeleteCustomer(customerID);
        }

        public void UpdateCustomer(int customerID, string name, string adress, int zipCode)
        {
            sqlCust.UpdateCustomer(customerID, name, adress, zipCode);
        }

        public DataTable GridGetCustomers()
        {
            return sqlCust.GridGetCustomers();
        }

        public void GridUpdateCustomers(DataTable dt)
        {
            sqlCust.GridUpdateCustomer(dt);
        }

        //Author: Marc / Andreas
        public DataTable GridGetCities()
        {
            return sqlCust.GridGetCities();
        }

        public void GridUpdateCity(DataTable dt)
        {
            sqlCust.GridUpdateCity(dt);
        }
    }
}