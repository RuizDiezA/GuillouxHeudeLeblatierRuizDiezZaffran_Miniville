using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Miniville
{
    class Game
    {
        public Player player1 = new Player();
        public IaPlayer player2 = new IaPlayer();

        public Die die;
        public Shop shop;

        public Game()
        {
            die = new Die(6);
            shop = new Shop();
            shop.LigneAchat();
        }

        public void Run()
        {
            
            while (player1.money < 20|| player2.money < 20)
            {
                Console.Clear();
                DisplayHand();
                //Tour du joueur 1

                //Lancer de dé et résolution des effets.
                die.Lancer();
                Console.WriteLine(die);
                player2.ApplyEffects("red", player1, player2);
                player1.ApplyEffects("green", player1, player2);

                //Acheter une nouvelle carte Et l'ajouter à sa main.
                player1.ChooseCard(shop);
                Thread.Sleep(1000);
                Console.Clear();
                DisplayHand();
                if (player1.money >= 20 || player2.money >= 20)
                    break;
                //Tour du joueur 2

                die.Lancer();
                Console.WriteLine(die);
                player2.ApplyEffects("red", player2, player1);
                player1.ApplyEffects("green", player2, player1);

                player2.ChooseCard(shop);
                Thread.Sleep(1300);
                Console.WriteLine();
            }

            Console.WriteLine();
            if (player1.money > player2.money)
            {
                Console.WriteLine("FIN DU GAME : Vous avez gagné");
            }
            else if(player1.money < player2.money)
            {
                Console.WriteLine("FIN DU GAME : Vous avez perdu");
            }
            else
            Console.WriteLine("FIN DU GAME : EGALITE");
        }

        public void DisplayHand()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("VOICI LA MAIN DU JOUEUR | GOLDS : " + player1.money);
            Console.WriteLine("======================================================");
            foreach (Cards card in player1.hand)
            {
                Console.WriteLine("");
                Console.WriteLine(card);
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("VOICI LA MAIN DE L'ORDINATEUR | GOLDS : " + player2.money);
            Console.WriteLine("======================================================");
            foreach (Cards card in player2.hand)
            {
                Console.WriteLine("");
                Console.WriteLine(card);
            }


        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
