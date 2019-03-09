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

        // Draws a game board of x * y dimensions
        public void DrawCell()
        {
            string inputRows;
            string inputColumns;
            int rows, columns;
            Console.Write("Enter a value for x");
            inputRows = Console.ReadLine();
            rows = Convert.ToInt32(inputRows);
            Console.Write("Enter a value for y");
            inputColumns = Console.ReadLine();
            columns = Convert.ToInt32(inputColumns);

            // Print characters
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; col++)
                {
                    if (row % 2 == 0 || row == 0)
                    {
                        Console.WriteLine(" " + "-" + " ");
                    }
                    else if (row % 2 != 0)
                    {
                        Console.WriteLine("|" + " " + "|");
                    }
                }
                
                // Console.WriteLine(" " + "-" + " ");
                // Console.WriteLine("|" + " " + "|");
                // Console.WriteLine(" " + "-" + " ");
            }
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
