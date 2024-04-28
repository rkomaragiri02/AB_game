using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using CIS3433;
using Microsoft.VisualBasic;
using SQLData;

namespace AB_game
{
    public partial class Codemaker : Form
    {
        private string usercode;
        private string connString;
        private string playerName;
        private int tries;
        private int totalSeconds;
        private List<SessionDataPoint> sessionDataPoints = new List<SessionDataPoint>();
        public Codemaker(string playerName)
        {
            InitializeComponent();
            connString = DBInfo.dbConnString;
            this.playerName = playerName;
            this.tries = 0;
            this.totalSeconds = 0;
        }

        private bool isUnique(string code)
        {
            bool[] digitSeen = new bool[10];
            foreach (var item in code)
            {
                int digit = item - '0';
                if (digitSeen[digit])
                    return false;

                // Mark the digit as encountered
                digitSeen[digit] = true;
            }

            return true;
        }

        public bool isCodeSet()
        {
            if (usercode != null)
            {
                return true;
            }
            return false;
        }

        public string returnCode()
        {
            return this.usercode;
        }
        private void setCode()
        {
            if (int.TryParse(textBoxCodeIn.Text, out int ParsedVal))
            {
                if (textBoxCodeIn.Text.Length < 4)
                {
                    MessageBox.Show("The code must be 4 digits", "Error");
                }
                else if (!isUnique(textBoxCodeIn.Text))
                {
                    MessageBox.Show("All digits in the code must be unique", "Error");
                }
                else
                {
                    usercode = textBoxCodeIn.Text;
                    textBoxCodeIn.Text = "";
                    MessageBox.Show("Code successfuly set", "Success");
                    buttonGuess.Enabled = true;
                    timerGame.Enabled = true;
                    //DatabaseHelpers.insertCodemakerSession(connString, usercode, textBoxName.Text);
                    //Codebreaker codebreaker = new Codebreaker();
                    //codebreaker.Tag = usercode;
                    //codebreaker.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Enter only integer values", "Error");
            }
        }

        private void validateUserGuess()
        {
            int currentSessionID = DatabaseHelpers.getSessionID(DBInfo.dbConnString) + 1;
            string userGuess;
            if (!isValidGuess(textBoxUserGuess.Text))
            {
                MessageBox.Show("Your guess must be integers, try again");
                return;
            }
            if (textBoxUserGuess.Text.Length < 4)
            {
                MessageBox.Show("You must enter 4 digits, try again");
                return;
            }
            tries++;
            userGuess = textBoxUserGuess.Text;
            labelGuessesRemaining.Text = (tries).ToString();
            //if (tries == 10 && usercode != userGuess)
            //{
            //    timerGame.Enabled = false;
            //    MessageBox.Show("Thats it! Out of tries!");
            //    this.Close();
            //}
            Compare(currentSessionID);
            if (usercode == userGuess)
            {
                timerGame.Enabled = false;
                int score = CodebreakerHelper.calculateScore(tries, totalSeconds);
                MessageBox.Show($"Correct! Your score is {score}");
                // Do score + add to database here
                DatabaseHelpers.insertCodemakerSession(DBInfo.dbConnString, usercode, playerName, tries, score, totalSeconds);
                DatabaseHelpers.logSessionDataPoints(DBInfo.dbConnString, sessionDataPoints);
                this.Close();
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

        private void Compare(int sessionID)
        {

            //MessageBox.Show($"The user guess: {userGuess}");//DEBUG
            //MessageBox.Show($"The user code: {usercodeAsInt}");//DEBUG
            string userGuess = textBoxUserGuess.Text;
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
            textBoxHint.Text = $"{A}A{B}B";
            sessionDataPoints.Add(new SessionDataPoint(sessionID, userGuess, textBoxHint.Text));
            //DatabaseHelpers.logSessionDataPoint(DBInfo.dbConnString, sessionID, userGuess, $"{A}A{B}B");

        }

        private void btnSetCode_Click(object sender, EventArgs e)
        {
            setCode();
        }

        private void btnRandomise_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int[] digits = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int UniqueDigit = num.Next(0, 10);
                while (digits.Contains(UniqueDigit))
                {
                    UniqueDigit = num.Next(0, 10);
                }
                digits[i] = UniqueDigit;
            }
            textBoxCodeIn.Text = textBoxCodeIn.Text = string.Join("", digits);
            usercode = string.Join("", digits);
        }

        private void textBoxCodeIn_TextChanged(object sender, EventArgs e)
        {
            //TODO: Takes in code from user. Run validation logic for valid code here (Disable buttons maybe?)
        }

        private void setCodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Clone of setcode button logic
            setCode();
        }

        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int[] digits = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int UniqueDigit = num.Next(0, 10);
                while (digits.Contains(UniqueDigit))
                {
                    UniqueDigit = num.Next(0, 10);
                }
                digits[i] = UniqueDigit;
            }
            textBoxCodeIn.Text = textBoxCodeIn.Text = string.Join("", digits);
            usercode = string.Join("", digits);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clone of SetCode button logic
            setCode();
        }

        private void randomiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int[] digits = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int UniqueDigit = num.Next(0, 10);
                while (digits.Contains(UniqueDigit))
                {
                    UniqueDigit = num.Next(0, 10);
                }
                digits[i] = UniqueDigit;
            }
            textBoxCodeIn.Text = textBoxCodeIn.Text = string.Join("", digits);
            usercode = string.Join("", digits);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            validateUserGuess();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            labelTimeElapsed.Text = totalSeconds++.ToString();
        }
    }
}
