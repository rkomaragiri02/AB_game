using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_game
{
    public partial class Welcome : Form
    {
        public string code;
        public Welcome()
        {
            InitializeComponent();
        }

        private void runCodeMaker()
        {
            using (Codemaker codemakerForm = new Codemaker(textBoxPlayerName.Text))
            {
                codemakerForm.ShowDialog();
                code = codemakerForm.returnCode();
                btnCodebreaker.Enabled = codemakerForm.isCodeSet();
            }
        }

        private void btnCodebreaker_Click(object sender, EventArgs e)
        {
            Codebreaker codebreakerForm = new Codebreaker(textBoxPlayerName.Text);
            codebreakerForm.ShowDialog();
        }

        private void btnCodemaker_Click(object sender, EventArgs e)
        {
            runCodeMaker();
        }



        private void codemakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runCodeMaker();
        }

        private void codebreakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codebreaker codebreakerForm = new Codebreaker(code);
            codebreakerForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void codemakerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            runCodeMaker();
        }

        private void codebreakerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Codebreaker codebreakerForm = new Codebreaker(code);
            codebreakerForm.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //added some input validation here
        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPlayerName.Text.Trim() == "")
            {
                btnCodebreaker.Enabled = false;
                btnCodemaker.Enabled = false;
            }
            else
            {
                btnCodemaker.Enabled = textBoxPlayerName.Text.Length > 0;
                btnCodebreaker.Enabled = textBoxPlayerName.Text.Length > 0;
                codebreakerToolStripMenuItem.Enabled = textBoxPlayerName.Text.Length > 0;
                codemakerToolStripMenuItem.Enabled = textBoxPlayerName.Text.Length > 0;
                codebreakerToolStripMenuItem1.Enabled = textBoxPlayerName.Text.Length > 0;
                codemakerToolStripMenuItem1.Enabled = textBoxPlayerName.Text.Length > 0;
            }

        }

        private void buttonGameData_Click(object sender, EventArgs e)
        {
            GameData gameData = new GameData();
            gameData.ShowDialog();
        }
    }
}
