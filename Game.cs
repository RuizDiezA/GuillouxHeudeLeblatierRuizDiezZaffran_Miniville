using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Game
    {
        public Player player1 = new Player();
        public Player player2 = new Player();

        public Die die = new Die(6);
        public Shop shop = new Shop();
    }
}
