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
            using(Codemaker codemakerForm = new Codemaker())
            {
                codemakerForm.ShowDialog();
                code = codemakerForm.returnCode();
                btnCodebreaker.Enabled = codemakerForm.isCodeSet();
            }
        }

        private void btnCodebreaker_Click(object sender, EventArgs e)
        {
            Codebreaker codebreakerForm = new Codebreaker(code);
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
            Form codemakerForm = new Codemaker();
            codemakerForm.ShowDialog();
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
    }
}
