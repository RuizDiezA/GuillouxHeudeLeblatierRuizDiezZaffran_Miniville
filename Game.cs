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

        public Game()
        {
            die = new Die(6);
        }

        public void Run()
        {
            while (player1.money < 20 || player2.money < 20)
            {
                //Tour du joueur 1
                
                //Affichage de la main.
                Console.WriteLine("Voici la main du joueur : ");
                foreach (Cards elem in player1.hand)
                {
                    Console.Write( "| " + elem + " |");
                }
                Console.Write('\n');

                //Lancer de dé et résolution des effets.
                die.Lancer();
                //player1.ApplyBlue()
                //player2.ApplyBlue();
                //player1.ApplyGreen();
                //player2.ApplyRed();

                //Acheter une nouvelle carte Et l'ajouter à sa main.
                player1.BuyCard(new Cards());

                //Tour du joueur 2
                
                //Affichage de la main
                Console.WriteLine("Voici la main de l'ordinateur : ");
                foreach (Cards elem in player2.hand)
                {
                    Console.Write("| " + elem + " |");
                }
                Console.Write('\n');


                die.Lancer();

                //player1.ApplyBlue()
                //player2.ApplyBlue();
                //player2.ApplyGreen();
                //player1.ApplyRed();
                player2.BuyCard(new Cards()/*Card*/);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
