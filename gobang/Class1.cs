using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gobang
{
    public class Control
    {
        public Control(Game game)
        {
            GameToControl = game;
        }//not finished
        public Game GameToControl { get; set; }
        public bool Winner()//这个地方效率血妈低，还能再优化，不用去搜索，直接下的时候改数组的值就好了，我前面写扯了，没办法写下去了，以后再写成强耦合我吃屎。
        {//祖传代码系列之16个if
            bool judge = true;
            if (GameToControl.CurrentStep % 2 == 0)//当前下的是黑棋
            {
                for (int i = 5; i < 5 + 15; i++)
                {
                    for (int j = 5; j < 5 + 15; j++)
                    {
                        if (GameToControl.Black.Matrix[i, j] == GameToControl.CurrentStep / 2)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                judge = judge & (GameToControl.Black.Matrix[i + k, j] >= 0);
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.Black.Matrix[i - k, j] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.Black.Matrix[i, j + k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.Black.Matrix[i, j - k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.Black.Matrix[i + k, j + k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.Black.Matrix[i - k, j - k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.Black.Matrix[i + k, j - k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.Black.Matrix[i - k, j + k] >= 0);
                                }
                            }
                            return judge;
                        }

                    }
                }
                return false;
            }
            else//当前下的是白棋
            {
                for (int i = 5; i < 5 + 15; i++)
                {
                    for (int j = 5; j < 5 + 15; j++)
                    {
                        if (GameToControl.White.Matrix[i, j] == GameToControl.CurrentStep / 2)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                judge = judge & (GameToControl.White.Matrix[i + k, j] >= 0);
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.White.Matrix[i - k, j] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.White.Matrix[i, j + k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.White.Matrix[i, j - k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.White.Matrix[i + k, j + k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.White.Matrix[i - k, j - k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.White.Matrix[i + k, j - k] >= 0);
                                }
                            }
                            if (judge)
                            {
                                return judge;
                            }
                            else
                            {
                                judge = true;
                                for (int k = 0; k < 5; k++)
                                {
                                    judge = judge & (GameToControl.White.Matrix[i - k, j + k] >= 0);
                                }
                            }
                            return judge;
                        }
                    }
                }
                return false;
            }
        }
        public void Recover()
        {
            if (GameToControl.CurrentStep > 0)
            {
                GameToControl.CurrentStep--;
                if (GameToControl.CurrentStep % 2 == 0)
                {
                    try
                    {
                        for (int i = 4; i < 15 + 5; i++)
                        {
                            for (int j = 4; j < 15 + 5; j++)
                            {
                                if (GameToControl.Black.Matrix[i, j] == GameToControl.CurrentStep / 2)
                                {
                                    GameToControl.Black.Matrix[i, j] = -1;
                                }
                            }
                        }
                        GameToControl.Black.ChessLocation[GameToControl.CurrentStep / 2] = new Point(0, 0);
                        GameToControl.Paint.Drawboard();
                        GameToControl.Black.step--;
                        GameToControl.Paint.Drawchess(GameToControl.Black);
                        GameToControl.Paint.Drawchess(GameToControl.White);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You don't have any chess to recall!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    try
                    {
                        for (int i = 4; i < 15 + 5; i++)
                        {
                            for (int j = 4; j < 15 + 5; j++)
                            {
                                if (GameToControl.White.Matrix[i, j] == GameToControl.CurrentStep / 2)
                                {
                                    GameToControl.White.Matrix[i, j] = -1;
                                }
                            }
                        }
                        GameToControl.White.ChessLocation[GameToControl.CurrentStep / 2] = new Point(0, 0);
                        GameToControl.Paint.Drawboard();
                        GameToControl.White.step--;
                        GameToControl.Paint.Drawchess(GameToControl.White);
                        GameToControl.Paint.Drawchess(GameToControl.Black);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You don't have any chess to recall!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }//not finished
        public void Save() { }
        public Attemptation Practice()
        {
            Attemptation InstanceToCreate = new Attemptation(GameToControl.Vertex, GameToControl.SizePerLine, GameToControl.CurrentForm);
            InstanceToCreate.Black = GameToControl.Black;
            InstanceToCreate.White = GameToControl.White;
            InstanceToCreate.Control = GameToControl.Control;
            InstanceToCreate.CurrentStep = GameToControl.CurrentStep;
            InstanceToCreate.InitialStep = GameToControl.CurrentStep;
            InstanceToCreate.Paint = GameToControl.Paint;
            GameToControl.Paint.Drawboard();
            GameToControl.Paint.Drawchess(GameToControl.Black);
            GameToControl.Paint.Drawchess(GameToControl.White);
            return InstanceToCreate;
        }//not finished
        public int Put(Point toput)
        {
            if (Check(toput))
            {
                if (GameToControl.CurrentStep % 2 == 0)
                {
                    GameToControl.Black.Chessput(toput);
                    GameToControl.Paint.Drawchess(GameToControl.Black);
                    if (Winner())
                    {
                        if (MessageBox.Show("The black win!Retry?", "We have a winner", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                else
                {
                    GameToControl.White.Chessput(toput);
                    GameToControl.Paint.Drawchess(GameToControl.White);
                    if (Winner())
                    {
                        if (MessageBox.Show("The white win! Retry?", "We have a winner!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                GameToControl.CurrentStep++;
                return 0;
            }
            else
            {
                return 0;
            }
        }//consider write this as methods in control. The method can recieve two paramentors of Chess(black or white) and a ChessLocation(place to put the chess), meaning put the white(black) chess on to the point.
        public bool Check(Point toput)
        {
            bool result = true;
            foreach (Point item in GameToControl.Black.ChessLocation)
            {
                if (Math.Abs(item.X - toput.X) <= 13 & Math.Abs(item.Y - toput.Y) <= 13)
                {
                    result = false;
                }
            }
            if (toput.X <= GameToControl.Board.XBoundary[0] || toput.X >= GameToControl.Board.XBoundary[15] || toput.Y <= GameToControl.Board.YBoundary[0] || toput.Y >= GameToControl.Board.YBoundary[15])
            {
                result = false;
            }
            foreach (Point item in GameToControl.White.ChessLocation)
            {
                if (Math.Abs(item.X - toput.X) <= 13 & Math.Abs(item.Y - toput.Y) <= 13)
                {
                    result = false;
                }
            }
            return result;
        }//finished in the class chess, but now i want to put this into the class control. With two paramentor 
        //chess balck and chess white and point p. And the method Put will use this method.
    }

    public class AI
    {
        public AI(Game game)
        {
            Ai = game.Black;
            Player = game.White;
            Judge = new int[9];
        }
        public int[] Judge { get; set; }
        public Chess Ai { get; set; }
        public Chess Player { get; set; }
        public int Count(int[] judge)
        {
            int i = 1;
            int j = 1;
            int result = 0;
            while (judge[4 + i] > 0)
            {
                result++;
                i++;
            }
            while (judge[4 - i] > 0)
            {
                result++;
                j++;
            }
            return result;
        }
        public enum Flag
        {
            win5,
            live4,
            nothreat,
            die4,
            die3,
            live3,
            live2,
            die2
        }
        public int MyMaxScore()
        {
            return 1;
        }

        public int HisMaxScore()
        {
            return 1;
        }
        public Flag SingleDirection(int[] judge)
        {
            switch (Count(judge))
            {
                default:
                    return Flag.nothreat;
                case 5:
                    return Flag.win5;
                case 4:
                    if (FindDie4(judge))
                    {
                        return Flag.die4;
                    }
                    if (FindLive4(judge))
                    {
                        return Flag.live4;
                    }
                    else
                    {
                        return Flag.nothreat;
                    }
                case 3:
                    return Find3(judge);
            }
        }
        public bool Find5(int[] judge)
        {
            if (Count(judge) >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FindLive4(int[] judge)
        {
            int i = 0;
            int j = 0;
            bool[] result = new bool[2] { false, false };
            if (Count(judge) == 4)
            {
                while (judge[4 - i] > 0)
                {
                    i++;
                }
                if (judge[4 - i] == 0)
                {
                    result[0] = true;
                }
                while (judge[4 + j] > 0)
                {
                    j++;
                }
                if (judge[4 + j] == 0)
                {
                    result[1] = true;
                }
            }
            return result[0] & result[1];
        }
        public bool FindDie4(int[] judge)
        {
            int i = 0;
            int j = 0;
            bool[] result = new bool[2] { false, false };
            while (judge[4 - i] > 0)
            {
                i++;
            }
            if (judge[4 - i] == 0)
            {
                result[0] = true;
            }
            while (judge[4 + j] > 0)
            {
                j++;
            }
            if (judge[4 + j] == 0)
            {
                result[1] = true;
            }
            return (result[0] | result[1]) & !(result[0] & result[1]);
        }

        public Flag Find3(int[] judge)
        {
            int i = 0;
            int j = 0;
            bool[] result = new bool[4] { false, false, false, false };
            while (judge[4 - i] > 0)
            {
                i++;
            }
            if (judge[4 - i - 1] == 0)
            {
                result[0] = true;
            }
            if (judge[4 - i] == 0)
            {
                result[1] = true;
            }
            while (judge[4 + j] > 0)
            {
                j++;
            }
            if (judge[4 + j] == 0)
            {
                result[2] = true;
            }
            if (judge[4 + j + 1] == 0)
            {
                result[3] = true;
            }

            if (result[1] & result[2])
            {
                if (!result[0] & !result[3])
                {
                    return Flag.die3;
                }
                else if ((!result[0] & result[3]) | (result[0]&!result[3]))
                {
                    return Flag.live3;
                }
                else
                {
                    return Flag.nothreat;
                }
            }
            else if (result[1] & !result[2])
            {
                if (result[0])
                {
                    return Flag.die3;
                }
                return Flag.nothreat;
            }
            else if (!result[1]&result[2])
            {
                if (result[3])
                {
                    return Flag.die3;
                }
                return Flag.nothreat;
            }
            else
                return Flag.nothreat;
        }
  /*      public Flag Find2(int[] judge)
        {
            int i = 0;
            int j = 0;
            bool[] result = new bool[6] { false, false, false, false ,false,false};
            if (judge[5]>0|judge[3]>0)
            {

            }
            else
            {
                if (judge[3]<0|judge[5]<0)
                {
                    return Flag.die2;
                }
                else
                {

                }
            }

        }*/
    }
    public class Paint
    {
        public Paint(Game game)
        {
            GameToPaint = game;
            g = GameToPaint.CurrentForm.CreateGraphics();
        }//not finished
        public Game GameToPaint { get; set; }
        public Graphics g { get; set; }
        public void Drawboard()
        {
            SolidBrush covering = new SolidBrush(Color.BurlyWood);
            g.FillRectangle(covering, GameToPaint.Board.XBoundary[0] - GameToPaint.SizePerLine, GameToPaint.Board.YBoundary[0] - GameToPaint.SizePerLine, GameToPaint.SizePerLine * 16, GameToPaint.SizePerLine * 16);
            Pen Lines = new Pen(Color.Black);
            foreach (int item in GameToPaint.Board.XBoundary)
            {
                g.DrawLine(Lines, item, GameToPaint.Board.YBoundary[0], item, GameToPaint.Board.YBoundary[15]);
            }
            foreach (int item in GameToPaint.Board.YBoundary)
            {
                g.DrawLine(Lines, GameToPaint.Board.XBoundary[0], item, GameToPaint.Board.XBoundary[15], item);
            }
        }//not finished
        public void Drawchess(Chess chess)
        {
            if (chess.ColorOfChess)
            {
                for (int i = 0; i < chess.step; i++)
                {
                    if (chess.ChessLocation[i] != new Point(0, 0))
                    {
                        g.FillEllipse(new SolidBrush(Color.Black), chess.ChessLocation[i].X - 10, chess.ChessLocation[i].Y - 10, 16, 16);
                    }
                }
            }
            else
            {
                for (int i = 0; i < chess.step; i++)
                {
                    if (chess.ChessLocation[i] != new Point(0, 0))
                    {
                        g.FillEllipse(new SolidBrush(Color.White), chess.ChessLocation[i].X - 10, chess.ChessLocation[i].Y - 10, 16, 16);
                    }
                }
            }
        }//notfinished
    }

    public class ChessBoard
    {
        public ChessBoard(Point vertex, int _sizePerLine)
        {
            SizePerLine = _sizePerLine;
            XBoundary = new int[16];
            YBoundary = new int[16];
            for (int i = 0; i < 16; i++)
            {
                XBoundary[i] = vertex.X + SizePerLine * i;
            }
            for (int i = 0; i < 16; i++)//here the lenth is 16 to satisfy the chessput methods
            {
                YBoundary[i] = vertex.Y + SizePerLine * i;
            }
        }//need the vertex on the top left of the board and size to initialize.
        public int SizePerLine { get; set; }// distance between line
        public int[] XBoundary { get; set; }// position of each vertical line
        public int[] YBoundary { get; set; }//position of each horizon line

    }

    public class Chess : ChessBoard
    {
        public Chess(Point vertex, int _sizePerLine, bool _colorOfChess)
            : base(vertex, _sizePerLine)
        {
            SizePerLine = _sizePerLine;
            XBoundary = new int[16];
            YBoundary = new int[16];
            for (int i = 0; i < 16; i++)
            {
                XBoundary[i] = vertex.X + SizePerLine * i;
            }
            for (int i = 0; i < 16; i++)//here the lenth is 16 to satisfy the chessput methods
            {
                YBoundary[i] = vertex.Y + SizePerLine * i;
            }
            ColorOfChess = _colorOfChess;
            step = 0;//this is used in the recovering game.
            Matrix = new int[30, 30];//size of matrix
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Matrix[i, j] = -1;
                }
            }//all content initialized to -1
            ChessLocation = new Point[181];//initialize the point array
        }//not finished
        public bool ColorOfChess { get; set; }//true for black,false for white.
        public int step = new int();//start at 0 to note down the step until now, used in the recovery.
        public Point[] ChessLocation { get; set; }//store the cordinate center of cross that has a chess on it.
        public int[,] Matrix { get; set; }//the content in this matrix show the order of the chess put, as well as the order of point.
        public int[,] DefenseWeight { get; set; }
        public int[,] OffenceWeight { get; set; }
        public void Chessput(Point toput)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (
                        (XBoundary[j] - SizePerLine / 2) < toput.X & toput.X <= (XBoundary[j + 1] - SizePerLine / 2)
                        &&
                        (YBoundary[i] - SizePerLine / 2) < toput.Y & toput.Y <= (YBoundary[i + 1] - SizePerLine / 2)
                        )
                    {
                        Matrix[i + 5, j + 5] = step;
                        ChessLocation[step] = new Point(XBoundary[j], YBoundary[i]);
                    }
                }
            }
            step++;
        }//fill the matrix and point array when put the chess in, do it after you do the checking. Have an imaginary boundary on the right and bottom

        public bool Check(Point toput)
        {
            bool result = true;
            foreach (Point item in ChessLocation)
            {
                if (item.X - toput.X <= SizePerLine / 2 & item.Y - toput.Y <= SizePerLine)
                {
                    result = false;
                }
            }
            return result;
        }//use the distance to judge, need to run twice to check both white and black.
    }

    public class Game
    {
        public Game(Point vertex, int _sizePerLine, Form form)
        {
            CurrentForm = form;
            Black = new Chess(vertex, _sizePerLine, true);
            White = new Chess(vertex, _sizePerLine, false);
            Board = new ChessBoard(vertex, _sizePerLine);
            Control = new Control(this);
            Paint = new Paint(this);
            Vertex = vertex;
            SizePerLine = _sizePerLine;
            this.Paint.Drawboard();
        }//one game shall have a black white chess and a chessboard, as well as two controller for logic and painting.
        public Form CurrentForm { get; set; }
        public Point Vertex { get; set; }
        public int SizePerLine { get; set; }
        public int CurrentStep { get; set; }
        public Chess Black { get; set; }
        public Chess White { get; set; }
        public ChessBoard Board { get; set; }
        public Control Control { get; set; }
        public Paint Paint { get; set; }
    }//examples for a game
    public class Attemptation : Game
    {
        public Attemptation(Point vertex, int sizePerLine, Form form) : base(vertex, sizePerLine, form)
        {

        }
        public int InitialStep { get; set; }
        public void Recover()
        {
            if (this.CurrentStep >= this.InitialStep)
            {
                base.Control.Recover();
            }
        }

    }// used in attemptation
}
