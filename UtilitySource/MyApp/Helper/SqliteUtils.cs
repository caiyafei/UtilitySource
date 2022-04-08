using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class SqliteUtils : IDataUtils
    {
        static SQLiteConnection con;
        static readonly string conStr = ConfigurationManager.ConnectionStrings["SqliteConStr"].ConnectionString;
        public TList<T> GetAll<T>() where T : BaseModel
        {
            if (con == null) con = new SQLiteConnection(conStr);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                InitDataSource(con);
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
            if (con == null) con = new SQLiteConnection(conStr);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                InitDataSource(con);
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
                    con.Update<T>(item);
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

        void InitDataSource(SQLiteConnection conn)
        {
            SQLiteCommand com = conn.CreateCommand();
            com.CommandText = "select name from sqlite_master where name='Security'";
            SQLiteDataReader reader = com.ExecuteReader();
            reader.Read();
            bool flag = reader.HasRows;
            reader.Close();
            if (!flag)
            {
                com.CommandText = @"create table Security(Id INTEGER PRIMARY KEY AUTOINCREMENT,AppType nvarchar(50) ,UserName nvarchar(50),
                    SecName nvarchar(50),UserPwd nvarchar(50),SecPwd nvarchar(50),Remark nvarchar(400))";
                com.ExecuteNonQuery();
            }
        }
    }
}
