using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    public class Users
    {

        public DataSet getAllUsers()
        {
            Database myDatabase = new Database();

            string query = "fletcherSelectAllUsers"; // one should feel itchy here..

            DataSet myDataSet = myDatabase.getData(query);
            return myDataSet; // when I get to the return statement, the function is complete


        }

        public void insertNewUser(string FName, string LName, string HKey)
        {
            Database myDatabase = new Database();
        

            string query = "fletcherInsertNewUser";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("firstname", FName);
            sqlParameters[1] = new SqlParameter("lastname", LName);
            sqlParameters[2] = new SqlParameter("hkey", HKey);

            myDatabase.executeNonQueryWithParameters(sqlParameters, query);
            
        }

        public void updateUser(string FName, string LName, string HKey, int userLoginID)
        {
            Database myDatabase = new Database();

            string query = "fletcherUpdateUser";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("firstname", FName);
            sqlParameters[1] = new SqlParameter("lastname", LName);
            sqlParameters[2] = new SqlParameter("hkey", HKey);
            sqlParameters[3] = new SqlParameter("userloginid", userLoginID);

            myDatabase.executeNonQueryWithParameters(sqlParameters, query);

        }

        public void deleteUser(string FName, string LName, string HKey, int userLoginID)
        {
            Database myDatabase = new Database();

            string query = "fletcherDeleteUser";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("firstname", FName);
            sqlParameters[1] = new SqlParameter("lastname", LName);
            sqlParameters[2] = new SqlParameter("hkey", HKey);
            sqlParameters[3] = new SqlParameter("userloginid", userLoginID);

            myDatabase.executeNonQueryWithParameters(sqlParameters, query);

        }
    }
}