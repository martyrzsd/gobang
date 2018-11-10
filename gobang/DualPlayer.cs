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
            int sizePerLine = 25;//later may get this size changable
            Point vertex = new Point(50, 50);
            Game a = new Game(vertex, sizePerLine, this);
            a.Paint.Drawboard();
        }
        public int SizePerLine { get; set; }
        public Game Dual { get; set; }
        public Point Vertex { get; set; }
        public void DualPlayer_Click(object sender, EventArgs e)
        {
            Dual.Control.Put(MousePosition, Dual);
        }
    }
}
