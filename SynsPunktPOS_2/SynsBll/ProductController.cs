using System;
using System.Collections.Generic;
using SynsEntity;
using SynsPersistence;
using System.Data;

namespace SynsBLL
{
    public class ProductController
    {
        //Author: Jesper

        SqlProduct sqlProd = new SqlProduct();

        public void CreateProduct(string manufactor, string modelName, double price, int categoryID)
        {
            sqlProd.CreateProduct(new Product(manufactor, modelName, price, categoryID));
        }
        public void CreateEyewear(string manufactor, string modelName, double price, int categoryID, string sex, string shape, string color, int length)
        {
            sqlProd.CreateEyewear(new Eyewear(manufactor, modelName, price, categoryID, sex, shape, color, length));
        }
        public Product GetProduct(int productID)
        {
            return sqlProd.GetProduct(productID);
        }
        public List<Product> GetAllProducts(string modelName)
        {
            return new List<Product>(sqlProd.GetAllProducts(modelName));
        }
        public void UpdateProduct(int ProductID, string Manufactor, string ModelName, double price)
        {
            sqlProd.UpdateProduct(ProductID, Manufactor, ModelName, price);
        }
        public List<string> GetAllCategories()
        {
            return sqlProd.GetAllCategories();
        }
        public DataTable GridGetFrameSpec(int productID)
        {
            return sqlProd.GridGetFrameSpec(productID);
        }
        public void GridUpdateFrameSpec(DataTable dt)
        {
            sqlProd.GridUpdateFrameSpec(dt);
        }
        //Author: Marc / Andreas
        public DataTable GridGetProducts()
        {
            return sqlProd.GridGetProducts();
        }
        public void GridUpdateProducts(DataTable dt)
        {
            sqlProd.GridUpdateProducts(dt);
        }
        public DataTable GridGetCategories()
        {
            return sqlProd.GridGetCategories();
        }
        public void GridUpdateCategories(DataTable dt)
        {
            sqlProd.GridUpdateCategories(dt);
        }

    }
}
