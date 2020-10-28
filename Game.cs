using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Game
    {
        public Player player1 = new Player();
        public Player player2 = new Player();

        public Die die;
        public Shop shop = new Shop();
        
        public Game ()
        {
            die = new Die(6);
        }

        public void Run()
        {
            while (player1.money < 20 || player2.money < 20)
            {
                //Tour du joueur 1
                Console.WriteLine("Voici la main du joueur : ");
                //foreach (Cards elem in player1.hand)
                //{
                //    Console.Write(player1.hand);
                //}
                Console.Write(player1.hand);
                die.Lancer();
                player2.CheckEffects(/*die*/);
                player1.CheckEffects(/*die*/);
                player1.BuyCard(6/*Card*/);
                //Tour du joueur 2
                die.Lancer();
                player1.CheckEffects(/*die*/);
                player2.CheckEffects(/*die*/);
                player2.BuyCard(6/*Card*/);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
