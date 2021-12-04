using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Class1
    {
        public static void CreateBoard()
        {
            char[] board = new char[10];

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
    }
}
