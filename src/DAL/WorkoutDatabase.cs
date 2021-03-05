using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class WorkoutDatabase
    {
        public static IDbConnection GetConnection()
        {
            return new SqlConnection("Server=mssql-db," + Environment.GetEnvironmentVariable("SQL_SERVER_PORT") + ";Database=Workouter;User Id=sa;Password=HelloW0rld;");
        }
    }
}
