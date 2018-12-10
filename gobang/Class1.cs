using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
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
            if (GameToControl.CurrentStep >= 0)
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
                    catch (IndexOutOfRangeException)
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
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("You don't have any chess to recall!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("There's no chess left!");
            }
        }//not finished
        public void Save() { }
        public Attemptation Practice()
        {
            Attemptation InstanceToCreate = new Attemptation(GameToControl.Vertex, GameToControl.SizePerLine, GameToControl.CurrentForm, GameToControl.CurrentStep);
            for (int i = 0; i < InstanceToCreate.Black.ChessLocation.Length; i++)
            {
                InstanceToCreate.Black.ChessLocation[i] = GameToControl.Black.ChessLocation[i];
                InstanceToCreate.White.ChessLocation[i] = GameToControl.White.ChessLocation[i];
            }
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    InstanceToCreate.Black.Matrix[i, j] = GameToControl.Black.Matrix[i, j];
                    InstanceToCreate.White.Matrix[i, j] = GameToControl.White.Matrix[i, j];
                }
            }
            InstanceToCreate.Black.step = GameToControl.Black.step;
            InstanceToCreate.White.step = GameToControl.White.step;
            InstanceToCreate.CurrentStep = GameToControl.CurrentStep; InstanceToCreate.Paint.Drawboard();
            InstanceToCreate.Paint.Drawchess(InstanceToCreate.Black);
            InstanceToCreate.Paint.Drawchess(InstanceToCreate.White);
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
                //GameToControl.CurrentForm.Invalidate();
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
        public void MakeComments(string commentsToMake)
        {
            int i = 0;
            if (GameToControl.Comments[i] == "")
            {
                i++;
            }
            else
            {
                GameToControl.Comments[i] = commentsToMake;
                GameToControl.CommentsStep[i] = GameToControl.CurrentStep;
            }
        }
    }

    public class Counter
    {
        public Counter(int[] toCount)
        {
            Judge = toCount;
        }
        public int[] Judge { get; set; }
        public int Count(int[] judge)
        {
            int i = 1;
            int j = 1;
            int result = 0;
            while (judge[4 + i] >= 0)
            {
                result++;
                i++;
            }
            while (judge[4 - j] >= 0)
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
                else if ((!result[0] & result[3]) | (result[0] & !result[3]))
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
            else if (!result[1] & result[2])
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

        public Flag Find2(int[] judge)
        {
            int i = 0;
            int j = 0;
            int[] result = new int[6];


            if (
                (judge[3] < 0 &
                 (judge[6] < 0 |
                 judge[7] > 0 |
                 judge[8] < 0))
                 |
                 (judge[5]<0 &
                 (
                 judge[2]<0|judge[1]<0|judge[0]<0
                 )) 
                 |
                 (judge[2]<0&
                 (judge[6]<0|judge[7]<0))
                )
            {
                return Flag.die2;
            }
            else
            { return Flag.live2; }
        }
    }
    public class AI
    {

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
            //SolidBrush covering = new SolidBrush();
            //g.FillRectangle(covering, GameToPaint.Board.XBoundary[0] - GameToPaint.SizePerLine, GameToPaint.Board.YBoundary[0] - GameToPaint.SizePerLine, GameToPaint.SizePerLine * 16, GameToPaint.SizePerLine * 16);

            Pen Lines = new Pen(Color.Black);
            foreach (int item in GameToPaint.Board.XBoundary)
            {
                g.DrawLine(Lines, item, GameToPaint.Board.YBoundary[0], item, GameToPaint.Board.YBoundary[15]);
            }
            foreach (int item in GameToPaint.Board.YBoundary)
            {
                g.DrawLine(Lines, GameToPaint.Board.XBoundary[0], item, GameToPaint.Board.XBoundary[15], item);
            }
            //DrawEdgeIndex();
            DrawKeyPoint();
           // GameToPaint.CurrentForm.Invalidate();
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
            //GameToPaint.CurrentForm.Invalidate();
        }//notfinished
        public void Drawchess(Chess chess, int EndNumbers)
        {
            if (chess.ColorOfChess)
            {
                for (int i = 0; i < EndNumbers / 2; i++)
                {
                    if (chess.ChessLocation[i] != new Point(0, 0))
                    {
                        g.FillEllipse(new SolidBrush(Color.Black), chess.ChessLocation[i].X - 10, chess.ChessLocation[i].Y - 10, 16, 16);
                    }
                }
            }
            else
            {
                for (int i = 0; i < EndNumbers / 2; i++)
                {
                    if (chess.ChessLocation[i] != new Point(0, 0))
                    {
                        g.FillEllipse(new SolidBrush(Color.White), chess.ChessLocation[i].X - 10, chess.ChessLocation[i].Y - 10, 16, 16);
                    }
                }
            }//playback used
            //GameToPaint.CurrentForm.Invalidate();
        }

        public void DrawKeyPoint()
        {
            g.FillEllipse(new SolidBrush(Color.Black), GameToPaint.Board.XBoundary[3]-GameToPaint.SizePerLine/6, GameToPaint.Board.YBoundary[12] - GameToPaint.SizePerLine / 6, GameToPaint.SizePerLine / 3, GameToPaint.SizePerLine / 3);
            g.FillEllipse(new SolidBrush(Color.Black), GameToPaint.Board.XBoundary[3] - GameToPaint.SizePerLine / 6, GameToPaint.Board.YBoundary[3] - GameToPaint.SizePerLine / 6, GameToPaint.SizePerLine / 3, GameToPaint.SizePerLine / 3);
            g.FillEllipse(new SolidBrush(Color.Black), GameToPaint.Board.XBoundary[12] - GameToPaint.SizePerLine / 6, GameToPaint.Board.YBoundary[3] - GameToPaint.SizePerLine / 6, GameToPaint.SizePerLine / 3, GameToPaint.SizePerLine / 3);
            g.FillEllipse(new SolidBrush(Color.Black), GameToPaint.Board.XBoundary[12] - GameToPaint.SizePerLine / 6, GameToPaint.Board.YBoundary[12] - GameToPaint.SizePerLine / 6, GameToPaint.SizePerLine / 3, GameToPaint.SizePerLine / 3);
            g.FillEllipse(new SolidBrush(Color.Black), GameToPaint.Board.XBoundary[7] - GameToPaint.SizePerLine / 6, GameToPaint.Board.YBoundary[7] - GameToPaint.SizePerLine / 6, GameToPaint.SizePerLine / 3, GameToPaint.SizePerLine / 3);
        }

        public void DrawEdgeIndex()
        {
            for (int i = 0; i < 15; i++)
            {
               // g.DrawString((i + 1).ToString(), new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Gray), new Point(GameToPaint.Board.XBoundary[i], GameToPaint.Vertex.Y - GameToPaint.SizePerLine));
                //g.DrawString((i + 1).ToString(), new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Gray), new Point(GameToPaint.Vertex.X - GameToPaint.SizePerLine, GameToPaint.Board.YBoundary[i]));
            }
        }

        public void DrawNumber(int number, SolidBrush color, Point p)
        {
            g.DrawString(number.ToString(), new Font("Microsoft Sans Serif", 12), color, p);
        }
        public void DrawchessWithNumber(Game game)
        {
            if (game.InitialStep % 2 == 0)
            {
                int b = 1;
                int w = 2;
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if (game.Black.Matrix[i, j] >= game.InitialStep / 2)
                        {
                            DrawNumber(game.Black.Matrix[i, j] * 2 + b - game.InitialStep, new SolidBrush(Color.White), new Point(game.Black.ChessLocation[game.Black.Matrix[i, j]].X - game.Black.SizePerLine / 2, game.Black.ChessLocation[game.Black.Matrix[i, j]].Y - game.Black.SizePerLine / 2));

                        }
                        if (game.White.Matrix[i, j] >= game.InitialStep / 2)
                        {
                            DrawNumber(game.White.Matrix[i, j] * 2 + w - game.InitialStep, new SolidBrush(Color.Black), new Point(game.White.ChessLocation[game.White.Matrix[i, j]].X - game.White.SizePerLine / 2, game.White.ChessLocation[game.White.Matrix[i, j]].Y - game.White.SizePerLine / 2));
                        }
                    }
                }
            }
            else
            {
                int b = 1;
                int w = 2;
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if (game.Black.Matrix[i, j] > game.InitialStep / 2)
                        {
                            DrawNumber(game.Black.Matrix[i, j] * 2 - game.InitialStep + b, new SolidBrush(Color.White), new Point(game.Black.ChessLocation[game.Black.Matrix[i, j]].X - game.Black.SizePerLine / 2, game.Black.ChessLocation[game.Black.Matrix[i, j]].Y - game.Black.SizePerLine / 2));

                        }
                        if (game.White.Matrix[i, j] >= game.InitialStep / 2)
                        {
                            DrawNumber(game.White.Matrix[i, j] * 2 - game.InitialStep + w, new SolidBrush(Color.Black), new Point(game.White.ChessLocation[game.White.Matrix[i, j]].X - game.White.SizePerLine / 2, game.White.ChessLocation[game.White.Matrix[i, j]].Y - game.White.SizePerLine / 2));
                        }
                    }
                }
            }

        }
        public void DrawchessWithNumber(Game game, int endstep)
        {
            if (game.InitialStep % 2 == 0)
            {
                int b = 1;
                int w = 2;
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if (game.Black.Matrix[i, j] >= game.InitialStep / 2)
                        {
                            if (endstep >= game.Black.Matrix[i, j] * 2 + b - game.InitialStep)
                            {


                                DrawNumber(game.Black.Matrix[i, j] * 2 + b - game.InitialStep, new SolidBrush(Color.White), new Point(game.Black.ChessLocation[game.Black.Matrix[i, j]].X - game.Black.SizePerLine / 2, game.Black.ChessLocation[game.Black.Matrix[i, j]].Y - game.Black.SizePerLine / 2));
                            }
                        }
                        if (game.White.Matrix[i, j] >= game.InitialStep / 2)
                        {
                            if (endstep >= game.White.Matrix[i, j] * 2 + w - game.InitialStep)
                            {


                                DrawNumber(game.White.Matrix[i, j] * 2 + w - game.InitialStep, new SolidBrush(Color.Black), new Point(game.White.ChessLocation[game.White.Matrix[i, j]].X - game.White.SizePerLine / 2, game.White.ChessLocation[game.White.Matrix[i, j]].Y - game.White.SizePerLine / 2));
                            }
                        }
                    }
                }
            }
            else
            {
                int b = 1;
                int w = 2;
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if (game.Black.Matrix[i, j] > game.InitialStep / 2)
                        {
                            if (endstep >= game.Black.Matrix[i, j] * 2 - game.InitialStep + b)
                            {


                                DrawNumber(game.Black.Matrix[i, j] * 2 - game.InitialStep + b, new SolidBrush(Color.White), new Point(game.Black.ChessLocation[game.Black.Matrix[i, j]].X - game.Black.SizePerLine / 2, game.Black.ChessLocation[game.Black.Matrix[i, j]].Y - game.Black.SizePerLine / 2));
                            }
                        }
                        if (game.White.Matrix[i, j] >= game.InitialStep / 2)
                        {
                            if (endstep >= game.White.Matrix[i, j] * 2 - game.InitialStep + w)
                            {


                                DrawNumber(game.White.Matrix[i, j] * 2 - game.InitialStep + w, new SolidBrush(Color.Black), new Point(game.White.ChessLocation[game.White.Matrix[i, j]].X - game.White.SizePerLine / 2, game.White.ChessLocation[game.White.Matrix[i, j]].Y - game.White.SizePerLine / 2));
                            }
                        }
                    }
                }
            }
        }
    }

    public class PlayBack
    {
        public PlayBack(Game game)
        {
            GameToPlayBack = game;
            AutoPlayStatus = false;
        }
        public Game GameToPlayBack { get; set; }
        public int CurrentPlayBackStep { get; set; }
        public bool AutoPlayStatus { get; set; }
        public void NextStep()
        {
            GameToPlayBack.Paint.Drawboard();
            if (CurrentPlayBackStep % 2 == 0)
            {

                GameToPlayBack.Paint.Drawchess(GameToPlayBack.White, CurrentPlayBackStep + 1);
                GameToPlayBack.Paint.Drawchess(GameToPlayBack.Black, CurrentPlayBackStep);
            }
            else
            {

                GameToPlayBack.Paint.Drawchess(GameToPlayBack.Black, CurrentPlayBackStep + 1);
                GameToPlayBack.Paint.Drawchess(GameToPlayBack.White, CurrentPlayBackStep);
            }
            GameToPlayBack.Paint.DrawchessWithNumber(GameToPlayBack, CurrentPlayBackStep);
            CurrentPlayBackStep++;
        }
        public void NextStep(bool AutoPlayStatus, int Lag)
        {
            if (AutoPlayStatus)
            {
                NextStep();
                Thread.Sleep(100 * Lag);
                NextStep(AutoPlayStatus, Lag);
            }
        }
        public void PreviousStep()
        {
            CurrentPlayBackStep--;
            GameToPlayBack.Paint.Drawboard();
            GameToPlayBack.Paint.Drawchess(GameToPlayBack.Black, CurrentPlayBackStep);
            GameToPlayBack.Paint.Drawchess(GameToPlayBack.White, CurrentPlayBackStep);
        }
        public void AutoPlay(int Lag)
        {
            GameToPlayBack.Paint.Drawboard();
            AutoPlayStatus = true;
            while (CurrentPlayBackStep < GameToPlayBack.CurrentStep)
            {
                NextStep(AutoPlayStatus, Lag);
            }
        }
        public void Pause()
        {
            AutoPlayStatus = false;
        }
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
            PlayBack = new PlayBack(this);
            Vertex = vertex;
            SizePerLine = _sizePerLine;
            this.Paint.Drawboard();
            Comments = new string[180];
            CommentsStep = new int[180];
            //CurrentForm.Invalidate();
        }//one game shall have a black white chess and a chessboard, as well as two controller for logic and painting.
        public Form CurrentForm { get; set; }
        public PlayBack PlayBack { get; set; }
        public Point Vertex { get; set; }
        public int SizePerLine { get; set; }
        public int CurrentStep { get; set; }
        public int InitialStep { get; set; }
        public Chess Black { get; set; }
        public Chess White { get; set; }
        public ChessBoard Board { get; set; }
        public Control Control { get; set; }
        public Paint Paint { get; set; }
        public string[] Comments { get; set; }
        public int[] CommentsStep { get; set; }
        public virtual void Recover() { }
    }//examples for a game
    public class Attemptation : Game
    {
        public Attemptation(Point vertex, int sizePerLine, Form form, int Initial) : base(vertex, sizePerLine, form)
        {
            InitialStep = Initial;
        }
        public override void Recover()
        {
            if (CurrentStep > InitialStep)
            {
                Control.Recover();
            }
            else
            {
                MessageBox.Show("You cannot change the original game!");
            }
        }

    }// used in attemptation
}
