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
    public partial class DualPlayer : Form
    {
        public DualPlayer()
        {
            InitializeComponent();
            Height = 1000;
            Width = 800;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DualPlayer_Load(object sender, EventArgs e)
        {
            int sizePerLine = 25;//later may get this size changable
            Point vertex = new Point();
            Game a = new Game(vertex, sizePerLine);
        }
    }
}
