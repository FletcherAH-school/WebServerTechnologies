using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace finalproject
{
    public class Users
    {

        public DataSet getAllUsers()
        {
            Database myDatabase = new Database();

            string query = "pahSelectAllUsers"; // maybe issues ?

            DataSet myDataSet = myDatabase.getData(query);
            return myDataSet; // when I get to the return statement, the function is complete


        }

        public void insertNewUser( string UName, string FName, string LName, string UKey, string UMail, int UTypeID)
        {
            Database myDatabase = new Database();
        

            string query = "pahInsertNewUser";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("username", UName);
            sqlParameters[1] = new SqlParameter("firstname", FName);
            sqlParameters[2] = new SqlParameter("lastname", LName);
            sqlParameters[3] = new SqlParameter("userkey", UKey);
            sqlParameters[4] = new SqlParameter("useremail", UMail);
            sqlParameters[5] = new SqlParameter("usertypeid", UTypeID);

            myDatabase.executeNonQueryWithParameters(sqlParameters, query);
            
        }

        public void updateUser( string UName, string FName, string LName, string UKey, string UMail, int UTypeID, int UserID)
        {
            Database myDatabase = new Database();

            string query = "pahUpdateUser";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("username", UName);
            sqlParameters[1] = new SqlParameter("firstname", FName);
            sqlParameters[2] = new SqlParameter("lastname", LName);
            sqlParameters[3] = new SqlParameter("userkey", UKey);
            sqlParameters[4] = new SqlParameter("useremail", UMail);
            sqlParameters[5] = new SqlParameter("usertypeid", UTypeID);
            sqlParameters[6] = new SqlParameter("userID", UserID);

            myDatabase.executeNonQueryWithParameters(sqlParameters, query);

        }

        public void deleteUser(int userID)
        {
            Database myDatabase = new Database();

            string query = "pahDeleteUser";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("userid", userID);

            myDatabase.executeNonQueryWithParameters(sqlParameters, query);

        }
    }
}