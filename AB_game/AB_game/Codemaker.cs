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
    public partial class Codemaker : Form
    {
        public int usercode;
        public Codemaker()
        {
            InitializeComponent();
        }

        private void btnSetCode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCodeIn.Text, out int ParsedVal))
            {
                usercode = ParsedVal;
            }
            else
            {
                MessageBox.Show("Enter an integer value");
            }
            
        }
       
        private void btnRandomise_Click(object sender, EventArgs e)
        {
            //TODO: Sets random code to break. Check that code is a valid integer

        }

        private void textBoxCodeIn_TextChanged(object sender, EventArgs e)
        {
            //TODO: Takes in code from user. Run validation logic for valid code here (Disable buttons maybe?)
        }

        private void setCodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Clone of setcode button logic
        }

        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clone of Randomize Button logic
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clone of SetCode button logic
        }

        private void randomiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clone of Randomise button logic
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
