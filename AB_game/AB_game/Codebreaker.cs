using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
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
        string guess = null;
        static Random rand = new Random();
        List<string> guessList;
        int numGuesses;
        public Codebreaker(string code)
        {
            InitializeComponent();
            this.guessList = CodebreakerHelper.GenerateGuessList();
            labelPossibleGuesses.Text = 0.ToString();
            numGuesses = 1;
        }

        private void GenerateGuess()
        {
            string firstGuess = guessList[rand.Next(guessList.Count)];

            if (numGuesses > 1)
            {
                if (BreakerHints.Text.Trim().Length != 4)
                {
                    MessageBox.Show("A proper hint is needed");
                    return;
                }
                //string hint = Interaction.InputBox("");
                string hint = BreakerHints.Text;
                int A;
                int B;

                A = hint[0] - '0';
                B = hint[2] - '0';

                if (A == 4) return;

                List<string> guessList_ = new List<string>(guessList.Count);

                foreach (var item in guessList)
                {
                    if (CodebreakerHelper.codeMatch(item, guess, A, B))
                        guessList_.Add(item);
                }
                guessList = guessList_;
            }

            string nextGuess = null;
            if (numGuesses == 1)
                nextGuess = firstGuess;
            else nextGuess = guessList[rand.Next(guessList.Count)];

            //MessageBox.Show($"Guess: {numGuesses} - {nextGuess}. Possible Guesses: {guessList.Count}");
            LabelGuess.Text = nextGuess.ToString();
            labelPossibleGuesses.Text = guessList.Count.ToString();

            if (guessList.Count == 1)
                return;

            guess = nextGuess;
            numGuesses++;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            GenerateGuess();
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
            GenerateGuess();
        }

        private void Codebreaker_Load(object sender, EventArgs e)
        {
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            //totalSeconds++;
            //labelTimeSeconds.Text = totalSeconds.ToString();
        }

        private void guessToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GenerateGuess();
        }
    }
}
