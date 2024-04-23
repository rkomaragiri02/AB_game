using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS3433;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using SQLData;

namespace AB_game
{
    public partial class Codebreaker : Form
    {
        public static string userGuess;
        int tries;
        string usercode;
        int totalSeconds;
        public Codebreaker(string code)
        {
            InitializeComponent();
            this.tries = 0;
            this.usercode = code;
            totalSeconds = 0;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (BreakerHints.Text == "")
            {
                MessageBox.Show("A hint is needed");
            }
            else
            {
                GenGuess();
            }
        }

        private void GenGuess()
        {
           Random random = new Random();
           LabelGuess.Text = random.Next(1000, 9999).ToString();
        }


        private void CBContextStrip_Opening(object sender, CancelEventArgs e)
        {
            //Clone of the logic within the Guess button itself
        }

        private void CBMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Clone of the login within the Guess Button itself
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Codebreaker_Load(object sender, EventArgs e)
        {
            timerGame.Enabled = true;
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            totalSeconds++;
            labelTimeSeconds.Text = totalSeconds.ToString();
        }
    }
}
