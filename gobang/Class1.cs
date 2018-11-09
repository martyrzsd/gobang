﻿using System;
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

        }//not finished
        public int winner()
        {
            return 1;
        }//not finished
    }

    class ChessBoard
    {
        public ChessBoard(Point vertex,int sizePerLine)
        {
            SizePerLine = sizePerLine;
            xBoundary = new int[20];
            for (int i = 0; i < 20; i++)
            {
                xBoundary[i] = vertex.X + sizePerLine * i;
            }
            for (int i = 0; i < 20; i++)//here the lenth is 20 to satisfy the chessput methods
            {
                yBoundary[i] = vertex.Y + sizePerLine * i;
            }
        }//need the vertex on the top left of the board and size to initialize.
        public int SizePerLine { get; set; }// distance between line
        public int[] xBoundary { get; set; }// position of each vertical line
        public int[] yBoundary { get; set; }//position of each horizon line
    }

    class Chess:ChessBoard
    {
        public Chess(Point vertex,int sizePerLine):base(vertex,sizePerLine)
        {
            step = 0;//this is used in the recovering game.
            matrix = new int[19,19];//size of matrix
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    matrix[i, j] = -1;
                }
            }//all content initialized to -1
            point = new Point[181];//initialize the point array
        }
        public int step = new int();//start at 0 to note down the step untill now, used in the recovery.
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
        }//store the cordinate center of cross that has a chess on it.
        public int[,] matrix{ get; set; }//the content in this matrix show the order of the chess put, as well as the order of point.
        public void Chessput(Point xy)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (
                        (xBoundary[j]-SizePerLine)<xy.X&xy.X<=(xBoundary[j+1]-SizePerLine)
                        &&
                        (yBoundary[i]-SizePerLine)<xy.Y&xy.Y<=(yBoundary[i+1]-SizePerLine)
                        )
                    {
                        matrix[i, j] = step;
                        point[step] = new Point(xBoundary[j], yBoundary[i]);
                    }
                }
            }
            step += 1;
        }//fill the matrix and point array when put the chess in, do it after you do the checking. Have an imaginary boundary on the right and bottom
        public bool Check(Point toput)
        {
            bool result = true;
            foreach (Point item in point)
            {
                if (item.X-toput.X<=SizePerLine/2&item.Y-toput.Y<=SizePerLine)
                {
                    result = false;
                }
            }
            return result;
        }//use the distance to judge, need to run twice to check both white and black.

    }

}
