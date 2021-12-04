using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Class1
    {
        public static char[] CreateBoard()
        {
            char[] board = new char[10];

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public static char Input()
        {

            Console.WriteLine("choose your letter ");
            char input = Convert.ToChar(Console.ReadLine());
            char player = (input == 'X') ? 'X' : 'O';
            return player;

        }
    }
}
