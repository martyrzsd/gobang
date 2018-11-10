using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gobang
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void dualPlayer_Click(object sender, EventArgs e)
        {
            new DualPlayer();
            this.Hide();
        }

        private void competitve_Click(object sender, EventArgs e)
        {
            new Compitetive();
            this.Hide();
        }

        private void singlePlayer_Click(object sender, EventArgs e)
        {
            new SinglePlayer();
            this.Hide();
        }
    }
    
}
