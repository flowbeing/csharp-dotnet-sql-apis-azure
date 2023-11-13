using System.Data;
using Microsoft.Data.SqlClient; // to create a database connection to Azure Data Studio
using Dapper; // to run queries on after an database connection has been setup with Azure Data Studio

namespace HelloWorld.Data
{
    public class DataContextDapper
    {
        // connection string configuration for Windows
        // string connectionStringWindows = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";
        // connection string configuration for Mac
        private string _connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=SQLConnect1;";

        // performs multiple queries on a database table at once and returns results as an IEnumerable
        public IEnumerable<T> LoadData<T>(string sql)
        {


            IDbConnection sqlConnection = new SqlConnection(_connectionString);
            return sqlConnection.Query<T>(sql);

        }

        // performs a single query on a database table and returns a dynamic value
        public T LoadDataSingle<T>(string sql)
        {

            IDbConnection sqlConnection = new SqlConnection(_connectionString);
            return sqlConnection.QuerySingle<T>(sql);

        }

        // detects whether a query affects at least one row in a table
        public bool ExecuteSql(string sql)
        {

            IDbConnection sqlConnection = new SqlConnection(_connectionString);
            int numOfRowsAffected = sqlConnection.Execute(sql);
            bool isAtLeastOneRowWasAffected = numOfRowsAffected > 0;
            return isAtLeastOneRowWasAffected;

        }

        // returns the number of rows affected by a query
        public int ExecuteWithRowCount(string sql)
        {

            IDbConnection sqlConnection = new SqlConnection(_connectionString);
            int numOfrowsAffected = sqlConnection.Execute(sql);
            return numOfrowsAffected;

        }

    }

}