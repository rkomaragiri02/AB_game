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

namespace AB_game
{
    public partial class Codebreaker : Form
    {
        public Codebreaker()
        {
            InitializeComponent();
        }
        public static string userGuess;
        int tries = 0;

        private void btnGuess_Click(object sender, EventArgs e)

        {
            string usercode = (string) this.Tag;

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
            userGuess = richTextBoxUserIn.Text;
            if (tries == 7 && usercode != userGuess)
            {
                MessageBox.Show("Thats it! Out of tries!");
                Application.Exit();
            }
            Compare();
            tries++;
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
            string usercode = (string) this.Tag;
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
            MessageBox.Show($"{A}A{B}B");
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
    }
}
