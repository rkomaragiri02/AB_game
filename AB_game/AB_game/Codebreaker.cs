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
            if (BreakerHints.Text.Trim().Length != 4)
            {
                MessageBox.Show("A proper hint is needed");
            }

        }
        //blog conversion begins here, i kept it mostly the same except changing keywords and removing operations that arent in c#
        public static bool Break(char[] code, char[] guess, int A, int B)
        {
             int a = 0;
             int b = 0;
            Random random = new Random();;
            for (int i = 0; i < 4; i++) 
            {
                if (code[i] == guess[i])
                {
                    A++;
                }
                else
                {
                    for (int j =0; j < 4; j++)
                    {
                        if (i != j && code[j] == guess[i] && code[j] != guess[j])
                        {
                            B++;
                            break;
                        }
                    }
                }
            }
            return a == A && b == B;

        } 
        //different combinations are generated in this block
        public static void Generate(string[] args)
        {
            Random random = new Random();
            List<char[]> guessList = new List<char[]>(10000);

            for (int i = 0; i <= 9999; i++)
            {
                string intstring = i.ToString();
                while (intstring.Length != 4)
                {
                    intstring = "0" + intstring;
                }

                char a = intstring[0];
                char b = intstring[1];
                char c = intstring[2];
                char d = intstring[3];
                bool notUnique = a==b || a==c || a==d|| b==c || b==d;

                if (notUnique)
                {
                    continue;
                }

                char[]intarray = intstring.ToCharArray();
                guessList.Add(intarray);

            }
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
