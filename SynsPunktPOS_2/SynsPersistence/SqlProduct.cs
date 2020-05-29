using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using SynsEntity;
using System.Data;
using System.Runtime.CompilerServices;
using System.Net;

namespace SynsPersistence
{
    public class SqlProduct
    {
        //Author: Jesper
        
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public void CreateProduct(Product p)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"insert into Product(Manufactor,ModelName,Price,CategoryID) Values ('{p.manufactor}','{p.modelName}',{p.price},{p.categoryID})");
        }

        public void CreateEyewear(Eyewear e)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"insert into Product(Manufactor,ModelName,Price,CategoryID) Values ('{e.manufactor}','{e.modelName}',{e.price},{e.categoryID})");
            sqlCon.PrepareSql("SELECT * FROM Product WHERE ProductID=(SELECT max(productId) FROM Product);");
            SqlDataReader sqld = sqlCon.ReadData();
            sqld.Read();
            sqlCon.ExecuteSql($"insert into Frame(Sex,Shape,Color,Length,productID) Values ('{e.sex}','{e.shape}','{e.color}',{e.length},{Convert.ToInt32(sqld["ProductID"])})");
        }

        public Product GetProduct(int productID)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            Sql_Connection SqlCon = new Sql_Connection();
            SqlCon.PrepareSql($"SELECT * from Product P JOIN Category C ON P.CategoryId=C.CategoryId where ProductID = {productID}");
            SqlDataReader sqld;
            sqld = SqlCon.ReadData();
            if (sqld.HasRows)
            {
                sqld.Read();
                return new Product(
                    Convert.ToInt32(sqld["ProductID"]),
                    sqld["manufactor"].ToString(),
                    sqld["modelName"].ToString(),
                    Convert.ToDouble(sqld["price"]),
                    Convert.ToInt32(sqld["CategoryID"]),
                    sqld["catName"].ToString());
            }
            sqlCon.CloseConnection();
            return null;
        }

        public List<Product> GetAllProducts(String modelName)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.PrepareSql($"SELECT * from Product P JOIN Category C ON P.CategoryId=C.CategoryId WHERE modelName LIKE '%{modelName}%'");
            List<Product> alleVarer = new List<Product>();
            SqlDataReader sqld;
            sqld = sqlCon.ReadData();
            if (sqld.HasRows)
                while (sqld.Read())
                    alleVarer.Add(new Product(
                    Convert.ToInt32(sqld["ProductID"]),
                    sqld["manufactor"].ToString(),
                    sqld["modelName"].ToString(),
                    Convert.ToDouble(sqld["price"]),
                    Convert.ToInt32(sqld["CategoryID"]),
                    sqld["catName"].ToString()));
            sqlCon.CloseConnection();
            return alleVarer;
        }

        public void UpdateProduct(int ProductID, string Manufactor, string ModelName, double price)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.ExecuteSql($"Update Product Set Manufactor = '{Manufactor}',ModelName = '{ModelName}',price = {price} WHERE ProductID = {ProductID}");
        }

        public List<string> GetAllCategories()
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.PrepareSql("Select * From category");
            List<string> AllCategories = new List<string>();
            SqlDataReader sqld = sqlCon.ReadData();
            if (sqld.HasRows)
                while (sqld.Read())
                {
                    AllCategories.Add($"{sqld[0]} {sqld[1]}");
                }
            sqlCon.CloseConnection();
            return AllCategories;
        }

        public DataTable GridGetFrameSpec(int productID)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sda = new SqlDataAdapter($"Select * from Frame WHERE productID = {productID}", sqlCon.Connection());
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void GridUpdateFrameSpec(DataTable dt)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        //Author: Marc / Andreas
        public DataTable GridGetProducts()
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sda = new SqlDataAdapter($"Select * from Product", sqlCon.Connection());
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void GridUpdateProducts(DataTable dt)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        public DataTable GridGetCategories()
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sda = new SqlDataAdapter($"Select * from category", sqlCon.Connection());
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void GridUpdateCategories(DataTable dt)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
