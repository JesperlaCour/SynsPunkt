using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SynsEntity;
namespace SynsPersistence
{
    public class SqlOrder
    {
        //Author: Jesper
        

        public void CreateOrder(int customerID)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"insert into Ordre(customerID) Values ({customerID})");
        }
        public Order GetLastOrder()
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.PrepareSql("SELECT * FROM Ordre O join Customer C ON O.customerID=C.customerID WHERE OrdreID=(SELECT max(OrdreID) FROM Ordre)");
            SqlDataReader sqld = sqlCon.ReadData();
            if (sqld.HasRows) {
                sqld.Read();
                return new Order(
                    Convert.ToInt32(sqld["ordreID"]),
                    Convert.ToInt32(sqld["customerID"]),
                    sqld["name"].ToString(),
                    Convert.ToDateTime(sqld["date"])
                    );
            }
            sqlCon.CloseConnection();
            return null;
        }

        public List<Order> GetAllOrders(string name)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            List<Order> oList = new List<Order>();
            sqlCon.PrepareSql($"Select * FROM Ordre O Join Customer C ON O.customerID=C.customerID WHERE C.name LIKE '%{name}%'");
            SqlDataReader sqld = sqlCon.ReadData();
            if (sqld.HasRows)
                while (sqld.Read())
                    oList.Add(new Order(Convert.ToInt32(sqld["ordreID"]),
                        Convert.ToInt32(sqld["customerID"]),
                        sqld["name"].ToString(),
                        Convert.ToDateTime(sqld["date"])
                        ));
            sqlCon.CloseConnection();
            return oList;
        }

        //ProductLines methods

        public void CreateProductLine(int orderID, int productID, int quantity)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"INSERT INTO ProductLine(ordreid,productID,quantity) Values ({orderID},{productID},{quantity})");
        }

        public List<ProductLine> GetAllProductLines(int orderID)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            List<ProductLine> pList = new List<ProductLine>();
            sqlCon.PrepareSql($"SELECT * FROM ProductLine PL JOIN Product P ON PL.productID=P.productID WHERE OrdreID = {orderID}");
            SqlDataReader sqld = sqlCon.ReadData();
            if (sqld.HasRows)
                while (sqld.Read())
                    pList.Add(new ProductLine(
                        Convert.ToInt32(sqld["productLineID"]),
                        Convert.ToInt32(sqld["ordreID"]),
                        Convert.ToInt32(sqld["productID"]),
                        Convert.ToInt32(sqld["quantity"]),
                        sqld["manufactor"].ToString(),
                        sqld["modelName"].ToString(),
                        Convert.ToDouble(sqld["price"])));
            sqlCon.CloseConnection();
            return pList;
        }

        //Delete methods

        public void DeleteOrder(int orderID)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"DELETE FROM ProductLine where ordreID = {orderID}");
            sqlCon.ExecuteSql($"DELETE FROM Ordre where ordreID = {orderID}");
        }

        public void DeleteProductLine (int productLineID)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"DELETE FROM ProductLine where productLineID = {productLineID}");
        }


    }
}
