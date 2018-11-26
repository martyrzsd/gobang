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
            SizePerLine = 25;//later may get this size changable
            Vertex = new Point(50, 50);
            Dual = new List<Game>() { new Game(Vertex, SizePerLine, this) };
            NumbersOfGame = 0;
            Score = new int[2] { 0, 0 };
            Condition = 1;
        }
        public int SizePerLine { get; set; }
        public List<Game> Dual { get; set; }
        public int NumbersOfGame { get; set; }
        public Point Vertex { get; set; }
        public int[] Score { get; set; }
        public int Condition { get; set; }

        private void DualPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (Condition != -1)
            {
                int ocassion = Dual[NumbersOfGame].Control.Put(e.Location);
                if (ocassion == 1)
                {
                    NumbersOfGame++;
                    Dual.Add(new Game(Vertex, SizePerLine, this));

                }
                if (ocassion == -1)
                {
                    Condition = -1;
                    //MessageBox.Show({"The Score if "+Score[0].ToString()+" : "+Score[1].ToString(), FinalScore);
                }
            }
        }

        private void dualToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new DualPlayer();
        }

        private void competitiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Compitetive();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumbersOfGame++;
            Dual.Add(new Game(Vertex, SizePerLine, this));
        }

        private void Recover_Click(object sender, EventArgs e)
        {
            //Dual[NumbersOfGame]
        }
    }

}
