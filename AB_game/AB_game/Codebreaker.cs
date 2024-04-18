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

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //TODO: Runs logic for checking code with input in richTextBoxUserIn
        }

        private void CBContextStrip_Opening(object sender, CancelEventArgs e)
        {
            //Clone of the login within the buttons themselves
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
