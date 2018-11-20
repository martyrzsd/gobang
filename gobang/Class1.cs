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
        public int Winner(Game game)
        {
            return 1;
        }//not finished
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
                }
                else
                {
                    GameToControl.White.Chessput(toput);
                    GameToControl.Paint.Drawchess(GameToControl.White);
                }
                GameToControl.CurrentStep++;
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
                if (Math.Abs(item.X - toput.X) <= 13 &  Math.Abs(item.Y - toput.Y) <= 13)
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
                    if (chess.ChessLocation[i] != new Point(0,0))
                    {
                        g.FillEllipse(new SolidBrush(Color.Black), chess.ChessLocation[i].X - 10, chess.ChessLocation[i].Y - 10, 20, 20);
                    }
                }
            }
            else
            {
                for (int i = 0; i < chess.step; i++)
                {
                    if (chess.ChessLocation[i]!=new Point(0,0))
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
            Matrix = new int[19, 19];//size of matrix
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    Matrix[i, j] = -1;
                }
            }//all content initialized to -1
            ChessLocation = new Point[181];//initialize the point array
        }//not finished
        public bool ColorOfChess { get; set; }
        public int step = new int();//start at 0 to note down the step untill now, used in the recovery.
        public Point[] ChessLocation { get; set; }//store the cordinate center of cross that has a chess on it.
        public int[,] Matrix { get; set; }//the content in this matrix show the order of the chess put, as well as the order of point.
        public void Chessput(Point toput)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (
                        (XBoundary[j] - SizePerLine/2) < toput.X & toput.X <= (XBoundary[j + 1] - SizePerLine/2)
                        &&
                        (YBoundary[i] - SizePerLine/2) < toput.Y & toput.Y <= (YBoundary[i + 1] - SizePerLine/2)
                        )
                    {
                        Matrix[i, j] = step;
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
