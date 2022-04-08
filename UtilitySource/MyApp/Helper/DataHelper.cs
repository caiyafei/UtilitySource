using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public static class DataHelper
    {
        static IDataUtils dataUtils=new SqliteUtils();
        public static TList<T> GetAll<T>() where T:BaseModel
        {
            return dataUtils.GetAll<T>();
        }
        
        public static void Update<T>(TList<T> list) where T: BaseModel
        {
            dataUtils.Update(list);
        }
    }
}
