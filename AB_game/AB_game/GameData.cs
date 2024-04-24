using Microsoft.Data.SqlClient;
using SQLData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_game
{
    public partial class GameData : Form
    {
        public GameData()
        {
            InitializeComponent();
        }

        private void GameData_Load(object sender, EventArgs e)
        {
            displayGameData(DBInfo.dbConnString);
        }

        public void displayGameData(string connString)
        {
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT date_time, player_name, playing_mode, secret_number, total_tries, game_score, total_seconds FROM game_data;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewGameHistory.DataSource = dt;
            conn.Close();
        }
    }
}
