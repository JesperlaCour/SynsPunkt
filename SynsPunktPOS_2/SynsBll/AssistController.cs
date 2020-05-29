using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynsEntity;
using SynsPersistence;

namespace SynsBll
{
    public class AssistController
    {
        //Author: Jesper
        

        public List<Eyewear> GetEyewear(string sex, string shape, string color, int length, double fromPrice, double toPrice)
        {
            SqlAssist sqlA = new SqlAssist();
            return sqlA.GetEyewear(sex, shape, color, length, fromPrice, toPrice);
        }

        public List<string> GetDistinctFromFrame(string column)
        {
            SqlAssist sqlA = new SqlAssist();
            return sqlA.GetDistinctFromFrame(column);
        }
    }

}
