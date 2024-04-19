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
                if (textBoxCodeIn.Text.Length < 4)
                {
                    MessageBox.Show("The code must be 4 digits");
                }
                else
                {
                    usercode = ParsedVal;
                    Codebreaker codebreaker = new Codebreaker();
                    codebreaker.Tag = usercode;
                    codebreaker.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Enter only integer values");
            }            
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
            usercode = Convert.ToInt32(string.Join("", digits));
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
            usercode = Convert.ToInt32(string.Join("", digits));
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
            usercode = Convert.ToInt32(string.Join("", digits));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
