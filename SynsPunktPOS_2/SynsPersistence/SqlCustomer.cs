using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using SynsEntity;
using System.Data;


namespace SynsPersistence
{
    public class SqlCustomer
    {
        //Author: Jesper
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        

        public void CreateCustomer(Customer k)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"insert into Customer(name, adress, zipcode) Values ('{k.name}','{k.adress}',{k.zipCode})");
        }

        public Customer GetCustomer(int CustomerID)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.PrepareSql($"select * from Customer C join zipcode Z ON C.zipcode=Z.zipcode where CustomerID = {CustomerID}");
            SqlDataReader sqld;
            sqld = sqlCon.ReadData();
            if (sqld.HasRows)
                while (sqld.Read())
                    return new Customer(
                        Convert.ToInt32(sqld["customerID"]),
                        sqld["name"].ToString(),
                        sqld["adress"].ToString(),
                        Convert.ToInt32(sqld["zipCode"]),
                        sqld["city"].ToString());
            sqlCon.CloseConnection();
            return null;
        }

        public List<Customer> GetAllCustomer(string name)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.PrepareSql($"Select * FROM Customer C join zipcode z ON c.zipcode=z.zipcode WHERE name LIKE '%{name}%'");
            List<Customer> alleKunder = new List<Customer>();
            SqlDataReader sqld;
            sqld = sqlCon.ReadData();
            if (sqld.HasRows) {
                while (sqld.Read()) {
                    alleKunder.Add(new Customer(
                        Convert.ToInt32(sqld["customerID"]),
                        sqld["name"].ToString(),
                        sqld["adress"].ToString(),
                        Convert.ToInt32(sqld["zipCode"]),
                        sqld["city"].ToString()));
                }
            }
            sqlCon.CloseConnection();
            return alleKunder;
            
        }

        public void UpdateCustomer(int customerID,string name, string adress,int zipCode)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"Update Customer Set name = '{name}',adress = '{adress}',zipCode = {zipCode} WHERE CustomerID = {customerID}");
        }

        public string DeleteCustomer(int CustomerID)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"DELETE Customer WHERE CustomerID = {CustomerID}");
            string confirm = ($"Kundenummer {CustomerID} er slettet!");
            return confirm;
        }
        //Author: Marc / Andreas
        public DataTable GridGetCustomers()
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sda = new SqlDataAdapter($"Select CustomerId, Name, Adress, ZipCode from Customer", sqlCon.Connection());
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void GridUpdateCustomer(DataTable dt)
        {
                scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
        }

        
        public DataTable GridGetCities()
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sda = new SqlDataAdapter($"Select * from zipCode", sqlCon.Connection());
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void GridUpdateCity(DataTable dt)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
