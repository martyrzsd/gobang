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
            this.Show();
            InitializeComponent();
            Height = 1000;
            Width = 800;
            SizePerLine = 25;//later may get this size changable
            Vertex = new Point(50, 50);
            Dual = new Game(Vertex, SizePerLine, this);
            Dual.Paint.Drawboard();
        }
        public int SizePerLine { get; set; }
        public Game Dual { get; set; }
        public Point Vertex { get; set; }
        public void DualPlayer_Click(object sender, EventArgs e)
        {
            Dual.Control.Put(MousePosition);
        }

        private void DualPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            Dual.Control.Put(e.Location);
        }
    }
}
