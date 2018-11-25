using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                for (int i = 5; i < 5 + 19; i++)
                {
                    for (int j = 5; j < 5 + 19; j++)
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
                for (int i = 5; i < 5 + 19; i++)
                {
                    for (int j = 5; j < 5 + 19; j++)
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

        }//not finished
        public void Practice()
        {

        }//not finished
        public void Put(Point toput)
        {
            if (Check(toput))
            {
                if (GameToControl.CurrentStep % 2 == 0)
                {
                    GameToControl.Black.Chessput(toput);
                    GameToControl.Paint.Drawchess(GameToControl.Black);
                    if (Winner())
                    {
                        if (MessageBox.Show("The black win!Retry?","We have a winner",MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            
                        }
                    }
                }
                else
                {
                    GameToControl.White.Chessput(toput);
                    GameToControl.Paint.Drawchess(GameToControl.White);
                    if (Winner())
                    {
                        if (MessageBox.Show("The white win! Retry?","We have a winner!",MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            
                        }
                    }
                }
                GameToControl.CurrentStep++;
            }
            else
            {
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
            Pen Lines = new Pen(Color.Black);
            foreach (int item in GameToPaint.Board.XBoundary)
            {
                g.DrawLine(Lines, item, GameToPaint.Board.YBoundary[0], item, GameToPaint.Board.YBoundary[19]);
            }
            foreach (int item in GameToPaint.Board.YBoundary)
            {
                g.DrawLine(Lines, GameToPaint.Board.XBoundary[0], item, GameToPaint.Board.XBoundary[19], item);
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
                        g.FillEllipse(new SolidBrush(Color.Black), chess.ChessLocation[i].X - 10, chess.ChessLocation[i].Y - 10, 20, 20);
                    }
                }
            }
            else
            {
                for (int i = 0; i < chess.step; i++)
                {
                    if (chess.ChessLocation[i] != new Point(0, 0))
                    {
                        g.FillEllipse(new SolidBrush(Color.White), chess.ChessLocation[i].X - 10, chess.ChessLocation[i].Y - 10, 20, 20);
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
            XBoundary = new int[20];
            YBoundary = new int[20];
            for (int i = 0; i < 20; i++)
            {
                XBoundary[i] = vertex.X + SizePerLine * i;
            }
            for (int i = 0; i < 20; i++)//here the lenth is 20 to satisfy the chessput methods
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
            XBoundary = new int[20];
            YBoundary = new int[20];
            for (int i = 0; i < 20; i++)
            {
                XBoundary[i] = vertex.X + SizePerLine * i;
            }
            for (int i = 0; i < 20; i++)//here the lenth is 20 to satisfy the chessput methods
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
            Connection = new int[19, 19][];
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    Connection[i, j] = new int[] { i, 19, 0, 19, 0, 19, 0, 19 };
                    Connection[j, i][2] = Connection[i, j][0];
                }
            }//横向纵向链接数组初始化
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    Connection[i, j][4] = i - j;//对角线上都是0，对角线下都是正的，上面是负的.两个一组，联通组长度加连接性。
                    Connection[18 - i, 18 - j][6] = i - j;//反对角线的初始化，依旧保持反对角线上面是负的，下面是正的.
                }
            }
            ChessLocation = new Point[181];//initialize the point array
        }//not finished
        public bool ColorOfChess { get; set; }//true for black,false for white.
        public int step = new int();//start at 0 to note down the step until now, used in the recovery.
        public Point[] ChessLocation { get; set; }//store the cordinate center of cross that has a chess on it.
        public int[,] Matrix { get; set; }//the content in this matrix show the order of the chess put, as well as the order of point.
        public int[,][] Connection { get; set; }//{横,竖,左,右,}
        public void Disconnect(int i, int j)
        {

        }
        public void WeightChange(int i, int j)
        {

        }
        public int[,] DefenseWeight { get; set; }
        public int[,] OffenceWeight { get; set; }
        public void Chessput(Point toput)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
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
}
//    class Attemptation : Game
//    {
//        public Attemptation(Point vertex, int sizePerLine, Form form) : base(vertex, sizePerLine,form)
//        {
//            //CurrentForm = form;
//            //Black = new Chess(vertex, sizePerLine);
//            //White = new Chess(vertex, sizePerLine);
//            //Board = new Chess(vertex, sizePerLine);
//            //Control = new Control();
//        }
//    }// used in attemptation
//}
