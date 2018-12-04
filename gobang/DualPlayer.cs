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
            Condition = true;
            AttemptationStatus = false;
            AttemptationIndexArray = new int[100];
        }
        public int SizePerLine { get; set; }
        public List<Game> Dual { get; set; }
        public int NumbersOfGame { get; set; }
        public Point Vertex { get; set; }
        public int[] Score { get; set; }
        public bool Condition { get; set; }//判断是否继续游戏的条件
        public bool AttemptationStatus { get; set; }
        public int[] AttemptationIndexArray { get; set; }

        private void DualPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (!AttemptationStatus)
            {
                if (Condition)
                {
                    int ocassion = Dual[NumbersOfGame].Control.Put(e.Location);//判断是否继续游戏
                    if (ocassion == 1)
                    {
                        NumbersOfGame++;
                        Dual.Add(new Game(Vertex, SizePerLine, this));

                    }
                    if (ocassion == -1)
                    {
                        Condition = false;
                        //MessageBox.Show({"The Score if "+Score[0].ToString()+" : "+Score[1].ToString(), FinalScore);
                    }
                }
            }
            if(AttemptationStatus)
            {
                if (Condition)
                {
                    int ocassion = Dual[2].Control.Put(e.Location);
                    if (ocassion == 1)
                    {
                        NumbersOfGame++;
                        Dual[NumbersOfGame].Paint.Drawboard();
                        Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].Black);
                        Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].White);
                        Dual.Add(Dual[AttemptationIndexArray[NumbersOfGame]].Control.Practice());
                    }
                    if (ocassion == -1)
                    {
                        Condition = false;
                    }
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
            if (!AttemptationStatus)
            {
                NumbersOfGame++;
                Dual.Add(new Game(Vertex, SizePerLine, this));
                Dual[NumbersOfGame].Paint.Drawboard();
                Condition = true;
            }
            else
            {
                Dual[0].Paint.Drawboard();
                Dual[0].Paint.Drawchess(Dual[0].Black);
                Dual[1].Paint.Drawboard();
                Dual[1].Paint.Drawchess(Dual[1].Black);
                ////Dual[AttemptationIndexArray[NumbersOfGame]].Paint.Drawboard();
                ////Dual[AttemptationIndexArray[NumbersOfGame]].Paint.Drawchess(Dual[AttemptationIndexArray[NumbersOfGame]].Black);
                //Dual.Add(Dual[AttemptationIndexArray[NumbersOfGame]].Control.Practice());
                //AttemptationIndexArray[NumbersOfGame+1] = AttemptationIndexArray[NumbersOfGame];
                //NumbersOfGame++;
                //Dual[AttemptationIndexArray[NumbersOfGame]].Paint.Drawchess(Dual[NumbersOfGame].Black);
                //Dual[AttemptationIndexArray[NumbersOfGame]].Paint.Drawchess(Dual[NumbersOfGame].White); 
            }
        }//restart

        private void Recover_Click(object sender, EventArgs e)
        {
            if (!AttemptationStatus)
            {
                Dual[NumbersOfGame].Control.Recover();
                Condition = true;
            }
            else
            {
                Dual[NumbersOfGame].Control.Recover();
                Condition = true;
            }
        }

        private void Attemptation_Click(object sender, EventArgs e)
        {
            if (!AttemptationStatus)
            {
                AttemptationStatus = true;
                Attemptation.Text = "END";
                Dual.Add(Dual[NumbersOfGame].Control.Practice());
                AttemptationIndexArray[NumbersOfGame + 1] = NumbersOfGame;
                NumbersOfGame++;
            }
            else
            {
                AttemptationStatus = false;
                Attemptation.Text = "Attempt";
                
            }
        }
    }

}
