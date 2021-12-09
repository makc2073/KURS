using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS
{
   public  class User
    {
        public static string uname;
        public static string uscore;
        public static void upd()
        {
           
            string connectionString = @"Data Source=10.10.1.24;Initial Catalog=MakcKURS;User ID=pro-41;Password=Pro_41student";
            string sqlExpression = "UPDATE Users SET Score = "+ uscore +" WHERE Name='"+ uname +"'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                
            }

        }
    }
}
