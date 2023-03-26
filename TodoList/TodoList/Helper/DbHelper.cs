using System;
using System.Data.SqlClient;

namespace TodoList.Helpers
{
    public class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TodoList;");
        }
    }
}