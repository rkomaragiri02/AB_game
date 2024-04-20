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
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@player_name", SqlDbType.NVarChar).Value = codemakerName;
            cmd.Parameters.Add("@secret_number", SqlDbType.VarChar).Value = code;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
