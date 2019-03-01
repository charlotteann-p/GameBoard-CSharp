using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class Board : Cell
    {
        // Board properties
        int row, col; // rows and columns
        // array for cells
        // private char Symbol[] symbols;

        // Draws a single cell to the game board
        public void DrawCell()
        {
            // Print characters
            Console.WriteLine(" " + "-" + " ");
            Console.WriteLine("|" + " " + "|");
            Console.WriteLine(" " + "-" + " ");
            /*
            for (col = 0; col < 2; col++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine(" " + "-" + " ");
                }
                else if (row % 2 != 0)
                {
                    Console.WriteLine("|" + " " + "|");
                }              
            }
            */



            // Console.WriteLine("+" + "-" + "+");
            // Console.WriteLine("|" + " " + "|");
            // Console.WriteLine("+" + "-" + "+");

            // Console.WriteLine("|");

        }

        /*
        public void DrawBoard()
        {

        }
        */
    }
}
