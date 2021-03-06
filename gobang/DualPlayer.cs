﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
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
            SizePerLine = 30;//later may get this size changable
            Vertex = new Point(100, 180);
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
        public Game PlaybackGame { get; set; }
        public Point Vertex { get; set; }
        public int[] Score { get; set; }
        public bool PlayBackStatus { get; set; }
        public bool Condition { get; set; }//判断是否继续游戏的条件
        public bool AttemptationStatus { get; set; }
        public int[] AttemptationIndexArray { get; set; }
        [Serializable]
        public class Everything
        {
            public Everything(int q,List<Game> w,int e,Game r, Point t, int[] y,bool u, bool i,bool o,int[] p)
            {
                SizePerLine = q;
                Dual = w;
                NumbersOfGame = e;
                PlaybackGame = r;
                Vertex = t;
                Score = y;
                PlayBackStatus = u;
                Condition = i;
                AttemptationStatus = o;
                AttemptationIndexArray = p;
            }
            public int SizePerLine { get; set; }
            public List<Game> Dual { get; set; }
            public int NumbersOfGame { get; set; }
            public Game PlaybackGame { get; set; }
            public Point Vertex { get; set; }
            public int[] Score { get; set; }
            public bool PlayBackStatus { get; set; }
            public bool Condition { get; set; }//判断是否继续游戏的条件
            public bool AttemptationStatus { get; set; }
            public int[] AttemptationIndexArray { get; set; }
        }

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
                Condition = true;
                Dual.Add(new Game(Vertex, SizePerLine, this));
                Dual[NumbersOfGame].Paint.Drawboard();
                Invalidate();
            }
            else
            {
                Dual.Add(Dual[AttemptationIndexArray[NumbersOfGame]].Control.Practice());
                AttemptationIndexArray[NumbersOfGame + 1] = AttemptationIndexArray[NumbersOfGame];
                NumbersOfGame++;
                Dual[AttemptationIndexArray[NumbersOfGame]].Paint.Drawchess(Dual[NumbersOfGame].Black);
                Dual[AttemptationIndexArray[NumbersOfGame]].Paint.Drawchess(Dual[NumbersOfGame].White);
                Invalidate();
            }
        }//restart

        private void Recover_Click(object sender, EventArgs e)
        {
            if (!AttemptationStatus)
            {
                Dual[NumbersOfGame].Control.Recover();
                Condition = true;
                Invalidate();
            }
            else
            {
                Dual[NumbersOfGame].Recover();
                Condition = true;
                Invalidate();
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
                Invalidate();
            }
            else if(AttemptationStatus)
            {
                Recover.Visible = true;
                Recover.Enabled = true;
                AttemptationStatus = false;
                Attemptation.Text = "Attempt";
                Dual.Add(Dual[AttemptationIndexArray[NumbersOfGame]]);
                NumbersOfGame++;
                Invalidate();
                //Dual[NumbersOfGame].Paint.Drawboard();
                //Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].Black);
                //Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].White);
            }
        }

        private void Comment_Click(object sender, EventArgs e)
        {
            if (!PlayBackStatus)
            {
                Dual[NumbersOfGame].Control.MakeComments(CommentBox.Text);
                CommentBox.Text = "";
                if (!PlayBackStatus)
                {
                    MessageBox.Show("Already save your notes to step " + (Dual[NumbersOfGame].CurrentStep -1).ToString() + " !");
                }
                else
                {
                    MessageBox.Show("Already save your notes to step " + (PlaybackGame.PlayBack.CurrentPlayBackStep -1).ToString() + " !");
                }
            }
            if (PlayBackStatus)
            {
                PlaybackGame.Control.MakeComments(CommentBox.Text);
                CommentBox.Text = "";
                if (!PlayBackStatus)
                {
                    MessageBox.Show("Already save your notes to step " + (Dual[NumbersOfGame].CurrentStep - 1).ToString() + " !");
                }
                else
                {
                    MessageBox.Show("Already save your notes to step " + (PlaybackGame.PlayBack.CurrentPlayBackStep - 1).ToString() + " !");
                }
            }
        }

        private void playBackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void PlayBack(Game GameToPlayBack)
        {
            PlayBackStatus = true;
            PlaybackGame = GameToPlayBack;
            Dual.Add(GameToPlayBack.Control.Practice());
            Dual[NumbersOfGame].Paint.Drawboard();
            NumbersOfGame++;
            for (int i = 0; i < Dual.Count; i++)
            {
                if (Dual[i].Equals(GameToPlayBack))
                {
                    AttemptationIndexArray[NumbersOfGame] = i;
                }
            }
            //AttemptationIndexArray[NumbersOfGame]
            AttemptationStatus = true;
            Recover.Visible = false;
            Recover.Enabled = false;
            Attemptation.Visible = false;
            
            //ReStart.Visible = false;
            //ReStart.Enabled = false;
            Next.Visible = true;
            Next.Enabled = true;
            Previous.Visible = true;
            Previous.Enabled = true;
            CommentBox.Visible = true;
            Comment.Visible = true;
            Comment.Enabled = true;
            CommentBox.Enabled = true;
            CommentBox.Text = GameToPlayBack.Comments[GameToPlayBack.InitialStep];
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

        private void Previous_Click(object sender, EventArgs e)
        {
            PlaybackGame.PlayBack.PreviousStep();
            CommentBox.Text = PlaybackGame.Comments[PlaybackGame.PlayBack.CurrentPlayBackStep];
        }



        private void Next_Click(object sender, EventArgs e)
        {
            PlaybackGame.PlayBack.NextStep();
            //CommentBox.Text = PlaybackGame.Comments[];
            CommentBox.Text = PlaybackGame.Comments[PlaybackGame.PlayBack.CurrentPlayBackStep];

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "GOBang(*.data)|*.data";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                if (File.Exists(saveFileDialog1.FileName))
                {
                    if (MessageBox.Show("Cover?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                        Everything everything = new Everything(SizePerLine, Dual, NumbersOfGame, PlaybackGame, Vertex, Score, PlayBackStatus, Condition, AttemptationStatus, AttemptationIndexArray);
                        binaryFormatter.Serialize(fileStream, everything);
                        fileStream.Close();
                    }
                }
                
                else
                {
                    FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    Everything everything = new Everything(SizePerLine, Dual, NumbersOfGame, PlaybackGame, Vertex, Score, PlayBackStatus, Condition, AttemptationStatus, AttemptationIndexArray);
                    binaryFormatter.Serialize(fileStream, everything);
                    fileStream.Close();
                }
                
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "GOBang(*.data)|*.data";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                if (File.Exists(openFileDialog1.FileName))
                {
                    try
                    {
                        FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
                        Everything everything = (Everything)binaryFormatter.Deserialize(fileStream);

                        SizePerLine =everything.SizePerLine;
                        Dual = everything.Dual;
                        NumbersOfGame = everything.NumbersOfGame;
                        PlaybackGame = everything.PlaybackGame;
                        Vertex = everything.Vertex;
                        Score = everything.Score;
                        PlayBackStatus = everything.PlayBackStatus;
                        Condition = everything.Condition;
                        AttemptationStatus = everything.AttemptationStatus;
                        AttemptationIndexArray = everything.AttemptationIndexArray;
                        fileStream.Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not Correct Format!");
                    }
                }
                else
                {
                    MessageBox.Show("No such a file!");
                }
            }
        }

        private void DualPlayer_Load(object sender, EventArgs e)
        {

        }

        private void DualPlayer_Paint(object sender, PaintEventArgs e)
        {
            if (!AttemptationStatus)
            {
                Dual[0].Paint.Drawboard();
                Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].Black);
                Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].White);
            }
            else
            {
                Dual[NumbersOfGame].Paint.Drawboard();
                Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].Black);
                Dual[NumbersOfGame].Paint.Drawchess(Dual[NumbersOfGame].White);
                Dual[NumbersOfGame].Paint.DrawchessWithNumber(Dual[NumbersOfGame]);
            }
        }
    }

}

