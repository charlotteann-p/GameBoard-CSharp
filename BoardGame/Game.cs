using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class Game : Board
    {
        // Properties of the game
        public string player1;
        public string player2;

        // var cellState = new List<string>();

        public string[] cellState = { "Red", "Black", null };
        // string cells = new List<string>();
        public string[] cells;

        bool gameOver;

        public DateTime GameTime { get; set; }

    }
}
