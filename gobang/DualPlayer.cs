using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        public bool PlayBackStatus { get; set; }
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
            if (AttemptationStatus)
            {
                if (Condition)
                {
                    int ocassion = Dual[NumbersOfGame].Control.Put(e.Location);
                    Dual[NumbersOfGame].Paint.DrawchessWithNumber(Dual[NumbersOfGame]);
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
                Dual.Add(Dual[AttemptationIndexArray[NumbersOfGame]].Control.Practice());
                AttemptationIndexArray[NumbersOfGame + 1] = AttemptationIndexArray[NumbersOfGame];
                NumbersOfGame++;
                Dual[AttemptationIndexArray[NumbersOfGame]].Paint.Drawchess(Dual[NumbersOfGame].Black);
                Dual[AttemptationIndexArray[NumbersOfGame]].Paint.Drawchess(Dual[NumbersOfGame].White);
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
                Dual[NumbersOfGame].Recover();
                Condition = true;
            }
        }

        private void Attemptation_Click(object sender, EventArgs e)
        {
            if (!AttemptationStatus)
            {
                AttemptationStatus = true;
                Attemptation.Text = "END";
                CommentBox.Visible = true;
                CommentBox.Enabled = true;
                Comment.Enabled = true;
                Comment.Visible = true;
                Dual.Add(Dual[NumbersOfGame].Control.Practice());
                AttemptationIndexArray[NumbersOfGame + 1] = NumbersOfGame;
                NumbersOfGame++;
            }
            else if(AttemptationStatus)
            {
                Recover.Visible = true;
                Recover.Enabled = true;
                AttemptationStatus = false;
                Attemptation.Text = "Attempt";
                Dual.Add(Dual[AttemptationIndexArray[NumbersOfGame]]);
                NumbersOfGame++;
                Dual[NumbersOfGame].Paint.Drawboard();
                Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].Black);
                Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].White);
            }
        }

        private void Comment_Click(object sender, EventArgs e)
        {
            Dual[NumbersOfGame].Control.MakeComments(CommentBox.Text);
        }

        private void playBackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void PlayBack(Game GameToPlayBack)
        {
            PlayBackStatus = true;
            Dual.Add(GameToPlayBack.Control.Practice());
            NumbersOfGame++;
            //AttemptationIndexArray[NumbersOfGame]
            AttemptationStatus = true;
            Recover.Visible = false;
            Recover.Enabled = false;
            ReStart.Visible = false;
            ReStart.Enabled = false;
            Next.Visible = true;
            Next.Enabled = true;
            Previous.Visible = true;
            Previous.Enabled = true;
            AutoPlay.Visible = true;
            AutoPlay.Enabled = true;
        }

        private void playBackToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            playBackToolStripMenuItem.DropDownItems.Clear();
            int i = 1;
            int result = 2;
            bool flag = true;
            playBackToolStripMenuItem.DropDownItems.Add("Game1");
            ToolStripMenuItem GameToPlayback;
            while (i < Dual.Count)
            {
                if (AttemptationIndexArray[i] == 0)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (Dual[j].Equals(Dual[i]))
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        GameToPlayback = new ToolStripMenuItem();
                        GameToPlayback.Tag = (result-1).ToString();
                        GameToPlayback.Text= "Game" + result.ToString();
                        playBackToolStripMenuItem.DropDownItems.Add(GameToPlayback);
                        result++;
                        GameToPlayback.Click += new EventHandler(GameToPlayback_Click);
                    }
                }
                i++;
            }
        }

        private void GameToPlayback_Click(object sender, EventArgs e)
        {
            PlayBack(Dual[Convert.ToInt32(((ToolStripMenuItem)sender).Tag)]);
        }   


    }

}
