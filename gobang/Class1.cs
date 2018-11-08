using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace gobang
{
    class Algorithm
    {
        public Algorithm()
        {

        }

        public bool legal(int[][] black,int[][] white)
        {
            return true;
        }

        public int winner()
        {
            return 1;
        }
    }

    class ChessBoard
    {
        public ChessBoard(Point vertex,double sizePerLine)
        {
            xBoundary = new double[20];
            for (int i = 0; i < 20; i++)
            {
                xBoundary[i] = vertex.X - sizePerLine / 2 + sizePerLine * i;
            }
            for (int i = 0; i < 20; i++)
            {
                yBoundary[i] = vertex.Y - sizePerLine / 2 + sizePerLine * i;
            }
        }
        public double[] xBoundary { get; set; }
        public double[] yBoundary { get; set; }
    }

    class Chess:ChessBoard
    {
        public Chess(Point vertex,double sizePerLine):base(vertex,sizePerLine)
        {
            step = 0;
            matrix = new int[19,19];
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    matrix[i, j] = -1;
                }
            }//all content initialized to -1
            point = new Point[181];
        }
        public int step = new int();
        public Point[] point
        {
            get
            {
                return this.point;
            }
            set
            {
                this.point = value;
            }
        }
        public int[,] matrix { get; set; }//the content in this matrix show the order of the chess put, as well as the order of point.
        public void Chessput(Point xy)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (xBoundary[j]<xy.X&xy.X<=yBoundary[j+1]&&yBoundary[i]<xy.Y&xy.Y<=yBoundary[i])
                    {
                        matrix[i, j] = step;
                        point[step] = xy;
                    }
                }
            }
            step += 1;
        }

    }

}
