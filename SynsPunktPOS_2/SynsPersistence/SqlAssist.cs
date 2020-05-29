using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynsEntity;
using System.Data.SqlClient;

namespace SynsPersistence
{
    public class SqlAssist
    {
        //Author: Jesper
        
        public List<Eyewear> GetEyewear(string sex, string shape, string color, int length,double fromPrice,double toPrice)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.PrepareSql($"select * from frame f join product p on f.ProductId = p.ProductId " +
                $"where sex like '%{sex}%' " +
                $"and shape like '%{shape}%' " +
                $"and color like '%{color}%' " +
                $"and length between {length-10} and {length+10} " +
                $"and price between {fromPrice} and {toPrice}");
            List <Eyewear> EyewearList = new List<Eyewear>();
            SqlDataReader sqld = sqlCon.ReadData();
            if (sqld.HasRows)
                while (sqld.Read())
                    EyewearList.Add(new Eyewear(
                    sqld["sex"].ToString(),
                    sqld["shape"].ToString(),
                    sqld["color"].ToString(),
                    Convert.ToInt32(sqld["length"]),
                    sqld["manufactor"].ToString(),
                    sqld["modelName"].ToString(),
                    Convert.ToDouble(sqld["price"])
                    ));
            sqlCon.CloseConnection();
            return EyewearList;
            
        }

        public List<string> GetDistinctFromFrame(string column)
        {
            Sql_Connection sqlCon = new Sql_Connection();
            sqlCon.PrepareSql($"SELECT DISTINCT {column} FROM frame");
            List<string> list = new List<string>();
            SqlDataReader sqld = sqlCon.ReadData();
            if (sqld.HasRows)
                while (sqld.Read())
                {
                    list.Add(sqld[0].ToString());
                }
            sqlCon.CloseConnection();
            return list;

        }

    }
}
