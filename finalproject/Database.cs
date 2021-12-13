using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace finalproject
{
    public class Database
    {
        private string getConnectionString()
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            return connection;
        }

        private SqlConnection openDatabase()
        {
            string connection = getConnectionString();
            // variable for database connection
            SqlConnection myConnection;

            myConnection = new SqlConnection(connection);
            // open a connection to the database
            myConnection.Open();
            return myConnection;

        }

        

        private void closeDatabase(SqlConnection myConnection)
        {
            myConnection.Close();
        }

        public DataSet getData(string query)
        {
            SqlConnection myConnection = openDatabase();
            DataSet myDataSet = new DataSet();
            SqlCommand myCommand = new SqlCommand(query);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);

            closeDatabase(myConnection);

            return myDataSet; // when I get to the return statement, the function is complete
        }

        public DataSet getDataWithParameters(SqlParameter[] myParameters, string query)
        {
            SqlConnection myConnection = openDatabase();
            DataSet myDataSet = new DataSet();
            SqlCommand myCommand = new SqlCommand(query);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            // add the parameters
            myCommand.Parameters.AddRange(myParameters);
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);

            closeDatabase(myConnection);

            return myDataSet; // when I get to the return statement, the function is complete
        }

        public void executeNonQueryWithParameters(SqlParameter[] myParameters, string query)
        {
            // open a database connection
            SqlConnection myConnection = openDatabase();

            // set the query
            SqlCommand myCommand = new SqlCommand(query);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            
            // add the parameters
            myCommand.Parameters.AddRange(myParameters);

            // execute the nonquery
            myCommand.ExecuteNonQuery();
            closeDatabase(myConnection);
        }

    }

   

}