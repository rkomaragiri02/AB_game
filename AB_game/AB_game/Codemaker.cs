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
        public Codemaker()
        {
            InitializeComponent();
        }

        private void btnSetCode_Click(object sender, EventArgs e)
        {
            //TODO: Sets code to break. Check that code is a valid integer
        }

        private void btnRandomise_Click(object sender, EventArgs e)
        {
            //TODO: Sets random code to break. Check that code is a valid integer

        }

        private void textBoxCodeIn_TextChanged(object sender, EventArgs e)
        {
            //TODO: Takes in code from user. Run validation logic for valid code here (Disable buttons maybe?)
        }
    }
}
