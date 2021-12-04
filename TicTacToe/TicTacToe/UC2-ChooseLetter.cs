using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class UC2_ChooseLetter
    {
        public static char Input()
        {

            Console.WriteLine("choose your letter ");
            char input = Convert.ToChar(Console.ReadLine());
            char player = (input == 'X') ? 'X' : 'O';
            return player;

        }
    }
}
