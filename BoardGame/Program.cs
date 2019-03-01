using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create game board
            Board board = new Board();
            // Cell cell = new Cell();
            // Draw board cell
            board.DrawCell();

            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }
    }
}
