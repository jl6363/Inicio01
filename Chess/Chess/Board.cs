using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace Chess
{
    public class Board
    {
        public static int X { get; set; } =8;
        public static int Y { get; set; } =8;


        Cell[,] board = new Cell[X, Y];    // create cell's array but no the cells itself

        public Board() // The match begin
        {
            // Create each cell with its color
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    // the [0, 0] cell is white
                    if ((i + j) == 1 || (i + j) % 2 == 1)
                        board[i, j] = new Cell(Color.Black);
                    else
                        board[i, j] = new Cell(Color.White);
                }
            }
            // Create the White Pawns
            for (int i = 0; i < X; i++)
                board[i, 1].P = new Pawn(Color.White);
            // Create the Black Pawns
            for (int i = 0; i < X; i++)
                board[i, 6].P = new Pawn(Color.Black);

            // Create the White Bishops
            board[2, 0].P = new Bishop(Color.White);
            board[5, 0].P = new Bishop(Color.White);
            // Create teh black Bishops
            board[2, 7].P = new Bishop(Color.Black);
            board[5, 7].P = new Bishop(Color.Black);

            // Create the White Knight
            board[1, 0].P = new Knight(Color.White);
            board[6, 0].P = new Knight(Color.White);
            // Create the black Knight
            board[1, 7].P = new Knight(Color.Black);
            board[6, 7].P = new Knight(Color.Black);

            // Create the White Rook
            board[0, 0].P = new Rook(Color.White);
            board[7, 0].P = new Rook(Color.White);
            // Create the White Rook
            board[0, 7].P = new Rook(Color.Black);
            board[7, 7].P = new Rook(Color.Black);

            // Create the White Queen and the King 
            board[4, 0].P = new Queen(Color.White);
            board[3, 0].P = new King(Color.White);
            // Create the Black Queen and the King POSITION REVERSE
            board[3, 7].P = new Queen(Color.Black);
            board[4, 7].P = new King(Color.Black);

            // Check the position
            for (int i=0; i<X; i++)
            {
                if (board[i, 0] == null)
                    continue;
                Console.WriteLine();
                for (int j=0; j<Y; j++)
                {
                    Console.Write(board[i, j].P);
                    Console.Write("\t");
                }
            }
        }
    }
    public class Cell
    {
        public Color C { get; set; } // cell color

        public Piece P { get; set; }

        public Cell ( Color color)
        {
            C = color; P = null;
        }
        public Cell ( Color color, Piece piece)
        {
            C = color; P = piece;
        }
    }

    public class Piece
    {
        public String Name { get; set; }
        public Color C { get; set; }

        public Piece (Color color, String name)
        {
            C = color;
            Name = name;
        }
    }
    public class Pawn : Piece
    {
        //public static String Name = "Pawn";
        public Pawn (Color color) : base(color, "Pawn") { }
    }

    public class Bishop : Piece
    {
        //public static String Name = "Bishop";

        public Bishop(Color color) : base(color, "Bishop") { }
    }

    public class Knight : Piece
    {
        //public static String Name = "Knight";

        public Knight (Color color) : base (color, "Knight") { }
    }

    public class Rook : Piece
    {
        //public static String Name = "Rook";

        public Rook (Color color) : base(color, "Rook") { }
    }

    public class Queen : Piece
    {
        //public static String Name = "Queen";

        public Queen (Color color) : base(color, "Queen") { }
    }

    public class King : Piece
    {
        //public static String Name = "King";

        public King (Color color) : base(color, "King") { }
    }
}
