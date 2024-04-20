using Azure;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CIS3433
{
    public class DatabaseHelpers
    {
        public static void insertCodemakerSession(string connString, string code, string codemakerName)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("AddCodemakerSession", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@FIRST_NAME", SqlDbType.NVarChar).Value = firstName;
            //cmd.Parameters.AddWithValue("@LAST_NAME", SqlDbType.NVarChar).Value = lastName;
            //cmd.Parameters.AddWithValue("@AGE", SqlDbType.Int).Value = age;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
