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
            cmd.Parameters.Add("@player_name", SqlDbType.VarChar).Value = codemakerName;
            cmd.Parameters.Add("@secret_number", SqlDbType.VarChar).Value = code;
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

        public static void logGuess(string connString, string playerGuess, string recievedHint)
        {

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("LogGuess", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@player_guess", SqlDbType.VarChar).Value = playerGuess;
            cmd.Parameters.Add("@recieved_hint", SqlDbType.VarChar).Value = recievedHint;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
