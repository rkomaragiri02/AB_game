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
            if (!(usercode is null))
            {
                validateUserGuess();
            }
            else
            {
                MessageBox.Show("There is no code to break, please try again");
            }
        }

        private void validateUserGuess()
        {
            int currentSessionID;
            if (!isValidGuess(richTextBoxUserIn.Text))
            {
                MessageBox.Show("Your guess must be integers, try again");
                return;
            }
            if (richTextBoxUserIn.Text.Length < 4)
            {
                MessageBox.Show("You must enter 4 digits, try again");
                return;
            }
            tries++;
            userGuess = richTextBoxUserIn.Text;
            if (tries == 10 && usercode != userGuess)
            {
                MessageBox.Show("Thats it! Out of tries!");
                Application.Exit();
            }
            Compare();
            if (usercode == userGuess)
            {
                timerGame.Enabled = false;
                int score = CodebreakerHelper.calculateScore(tries, totalSeconds);
                MessageBox.Show("Correct!");
                string codebreakerName = Interaction.InputBox("Enter name");
                // Do score + add to database here
                
               // DatabaseHelpers.insertCodebreakerSession(DBInfo.dbConnString, usercode, codebreakerName, tries, score, totalSeconds);
            }
        }

        bool isValidGuess(string userGuess)
        {
            if (userGuess == "")
            {
                return false;
            }

            foreach (var item in userGuess)
                if (!char.IsDigit(item))
                    return false;
            return true;
        }

        private void Compare()
        {

            //MessageBox.Show($"The user guess: {userGuess}");//DEBUG
            //MessageBox.Show($"The user code: {usercodeAsInt}");//DEBUG
            int A = 0;
            int B = 0;

            string[] UserGuessArray = userGuess.Select(c => c.ToString()).ToArray();

            string[] UserCodeArray = usercode.Select(c => c.ToString()).ToArray();

            //MessageBox.Show($"UserGuessArray Length: {UserGuessArray.Length}, UserCodeArray Length: {UserCodeArray.Length}");

            for (int i = 0; i < 4; i++)
            {
                if (UserGuessArray[i] == UserCodeArray[i])
                {
                    A++;
                }
                else if (UserGuessArray.Contains(UserCodeArray[i]) && UserGuessArray[i] != UserCodeArray[i])
                {
                    B++;
                }
            }
            //MessageBox.Show($"{A}A{B}B");
            lbGuesses.Items.Add($"Guess - {userGuess}, Hint - {A}A{B}B");
            //DatabaseHelpers.logGuess(DBInfo.dbConnString, userGuess, $"{A}A{B}B");
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
            validateUserGuess();
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
