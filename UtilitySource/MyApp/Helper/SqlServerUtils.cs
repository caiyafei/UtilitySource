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
    public class SqlServerUtils : IDataUtils
    {
        static SqlConnection con;
        static readonly string conStr = ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString;
        public TList<T> GetAll<T>() where T : BaseModel
        {
            if (con == null) con = new SqlConnection(conStr);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                return con.GetAll<T>().ToTList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public void Update<T>(TList<T> list) where T : BaseModel
        {
            if (con == null) con = new SqlConnection(conStr);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                foreach (T item in list.NewItems)
                {
                    con.Insert(item);
                }
                foreach (T item in list.DelItems)
                {
                    con.Delete(item);
                }
                foreach (T item in list)
                {
                    con.Update(item);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
