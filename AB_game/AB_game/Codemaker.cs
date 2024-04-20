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
        private string usercode;
        public Codemaker()
        {
            InitializeComponent();
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
        private void btnSetCode_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Code successfuly set", "Success");
                    this.Close();
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
            usercode = string.Join("", digits);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
