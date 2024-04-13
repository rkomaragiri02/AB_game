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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnCodebreaker_Click(object sender, EventArgs e)
        {
            Form codebreakerForm = new Codebreaker();
            codebreakerForm.ShowDialog();
        }

        private void btnCodemaker_Click(object sender, EventArgs e)
        {
            Form codemakerForm = new Codemaker();
            codemakerForm.ShowDialog();
        }
    }
}
