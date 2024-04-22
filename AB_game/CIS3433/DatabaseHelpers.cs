using Azure;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CIS3433
{
    public class DatabaseHelpers
    {
        public static void insertCodemakerSession(string connString, string code, string codemakerName, int totalTries, int gameScore, int totalSeconds)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("AddCodemakerSession", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@player_name", SqlDbType.VarChar).Value = codemakerName;
            cmd.Parameters.Add("@secret_number", SqlDbType.VarChar).Value = code; 
            cmd.Parameters.Add("@total_tries", SqlDbType.Int).Value = totalTries;
            cmd.Parameters.Add("@game_score", SqlDbType.Int).Value = gameScore;
            cmd.Parameters.Add("@total_seconds", SqlDbType.Int).Value = totalSeconds;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void insertCodebreakerSession(string connString, string code, string codebreakerName, int totalTries, int gameScore, int totalSeconds)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("AddCodebreakerSession", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@player_name", SqlDbType.VarChar).Value = codebreakerName;
            cmd.Parameters.Add("@secret_number", SqlDbType.VarChar).Value = code;
            cmd.Parameters.Add("@total_tries", SqlDbType.Int).Value = totalTries;
            cmd.Parameters.Add("@game_score", SqlDbType.Int).Value = gameScore;
            cmd.Parameters.Add("@total_seconds", SqlDbType.Int).Value = totalSeconds;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void logSessionDataPoint(string connString, int sessionId, string guess, string hint)
        {

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("LogSessionData", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@session_id", SqlDbType.Int).Value = sessionId;
            cmd.Parameters.Add("@guess", SqlDbType.VarChar).Value = guess;
            cmd.Parameters.Add("@hint", SqlDbType.VarChar).Value = hint;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void logSessionDataPoints(string connString, List<SessionDataPoint> datapoints)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            foreach (var item in datapoints)
            {
                SqlCommand cmd = new SqlCommand("LogSessionData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@session_id", SqlDbType.Int).Value = item.sessionId;
                cmd.Parameters.Add("@guess", SqlDbType.VarChar).Value = item.guess;
                cmd.Parameters.Add("@hint", SqlDbType.VarChar).Value = item.hint;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static int getSessionID(string connString)
        {
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT COUNT(session_id) from game_data;";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                int sessionID = 0;
                while (reader.Read())
                {
                    sessionID = reader.GetInt32(0);
                }
                reader.Close();
                conn.Close();
                return sessionID;
            }
            else
            {
                reader.Close();
                conn.Close();
                return 0;
            }
        }
    }
}
