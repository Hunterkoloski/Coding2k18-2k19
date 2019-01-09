using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = true;
            
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;

            char[,] ticTacToe = new char[3, 3];
            Console.WriteLine("Welcome to Tic-Tac-Toe, two players are required to play this game.");
            Console.WriteLine("Player 1 please enter your name.");
            string name1 = Console.ReadLine();
            Console.WriteLine("Player 2 please enter your name.");
            string name2 = Console.ReadLine();

            drawBoard(ticTacToe);
            do
            {
                processTurn(ticTacToe, 'x');
                drawBoard(ticTacToe);
                processTurn(ticTacToe, 'x');




            } while (quit == false);

        }

        static void processTurn(char[,] board, char player) 
            {
            Console.WriteLine("Player 1 please enter your name.");
            string x1 = int.Parse(Console.ReadLine);
            Console.WriteLine("Player 2 please enter your name.");
            string x2 = Console.ReadLine();

            int x1 = 0;
            int x2 = 0;

            Console.WriteLine(name1 + " enter a cordinate to put the X");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine(name2 + " enter a cordinate to put the O");
            x2 = int.Parse(Console.ReadLine());

            //
            board[i, j] = 'X';

        }
        static void drawBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    Console.Write("|" + (board[i, j]) + "|");
                }
                Console.WriteLine();
            }
        }

    }

}

