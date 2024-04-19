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
    public partial class Codebreaker : Form
    {
        public Codebreaker()
        {
            InitializeComponent();
        }
        public static int userGuess;
        int tries = 0;

        private void btnGuess_Click(object sender, EventArgs e)

        {
            int usercodeAsInt = (int)this.Tag;

            if (int.TryParse(richTextBoxUserIn.Text, out int ParsedVal2))
            {
                if (ParsedVal2 >= 1000 && ParsedVal2 <= 9999)
                {
                    userGuess = ParsedVal2;
                    tries++;
                    if (tries == 7 && usercodeAsInt != userGuess)
                    {
                        MessageBox.Show("Thats it! Out of tries!");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("You must enter 4 digits, try again");
                    return;
                }
            }

            else
            {
                MessageBox.Show("Your guess must be integers, try again");
                return;
            }

            Compare();
        }

        private void Compare()
        {
            int usercodeAsInt = (int)this.Tag;
            //MessageBox.Show($"The user guess: {userGuess}");//DEBUG
            //MessageBox.Show($"The user code: {usercodeAsInt}");//DEBUG
            int A = 0;
            int B = 0;

            string userGuessAsString = userGuess.ToString();
            string[] UserGuessArray = userGuessAsString.Select(c => c.ToString()).ToArray();

            string usercodeAsString = usercodeAsInt.ToString();
            string[] UserCodeArray = usercodeAsString.Select(c => c.ToString()).ToArray();

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
