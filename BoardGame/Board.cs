using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class Board 
    {
        // Board properties
        // int row, col; // rows and columns
        // array for cells
        // private char Symbol[] symbols;

        // Draws a game board of x * y dimensions
        public void DrawBoard()
        {
            string inputRows;
            string inputColumns;
            int rows, columns;

            do
            {
                Console.Write("Enter a value for x ");
                inputRows = Console.ReadLine();
                rows = Convert.ToInt32(inputRows);
            }
            while (rows % 4 != 0);

            do
            {
                Console.Write("Enter a value for y ");
                inputColumns = Console.ReadLine();
                columns = Convert.ToInt32(inputColumns);
            }
            while (columns % 4 != 0);
      
            int minHeight = 3; // x
            int minWidth = 2;  // y

            // Print characters
            for (int row = 0; row <= rows; row++)
            {
                for (int column = 0; column <= columns; column++)
                {
                    if (column % 2 == 0 && row % 2 == 0)
                    {
                        Console.Write(" ");
                    }

                    if (column % 2 != 0 && row % 2 == 0)
                    {
                        Console.Write("|");
                    }

                    if (row % 2 != 0 && column % 2 != 0)
                    {
                        Console.Write("+");
                    }

                    if (row % 2 != 0 && column % 2 == 0)
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
