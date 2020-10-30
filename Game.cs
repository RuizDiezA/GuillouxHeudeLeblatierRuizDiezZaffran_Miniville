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
        public Die die2;
        public Shop shop;
        public int choice;

        public Game()
        {
            die = new Die();
            die2 = new Die();
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
                Console.WriteLine("\n======= TOUR DU JOUEUR =========");
                //Lancer de(s) dé(s) et résolution des effets.

                Console.WriteLine("\n[Choisissez un nombre de des : (1 ou 2)]");
                //Choix du nombre
                while (!int.TryParse(Console.ReadLine(), out choice) | choice < 0 | choice > 2)
                {
                    Console.WriteLine("Veuillez entrer une valeur entre 1 et 2");
                }
                if (choice == 1)
                    die.Lancer();
                else
                {
                    choice = die.Lancer();
                    choice += die2.Lancer();
                    die.value = choice;
                }
                Console.WriteLine(die);

                player2.ApplyEffects("red", player2, player1, die.value);
                player1.ApplyEffects("green", player1, player2, die.value);
                //Affiche le montant de gold de chaque joueur apres application des effets
                Console.WriteLine("\n======================================================");
                Console.WriteLine("LE JOUEUR A MAINTENANT {0} GOLDS",player1.money);
                Console.WriteLine("L'ORDINATEUR A MAINTENANT {0} GOLDS", player2.money);
                Console.WriteLine("======================================================");
                //Acheter une nouvelle carte Et l'ajouter à sa main.
                player1.ChooseCard(shop);
                Thread.Sleep(1000);
                Console.Clear();
                DisplayHand();
                if (player1.money >= 20 || player2.money >= 20)
                    break;

                //Tour du joueur 2 (IA)
                Console.WriteLine("======= TOUR De L'ORDINATEUR =========");
                //L'IA choisi un nombre aleatoire de des.
                choice = player2.ChooseDiceNb();
                Console.WriteLine("\nL'Ordinateur a choisi {0} de(s)", choice);
                if (choice == 1)
                    die.Lancer();
                else
                {
                    choice = die.Lancer();
                    choice += die2.Lancer();
                    die.value = choice;
                }
                Console.WriteLine(die);
                player1.ApplyEffects("red", player1, player2, die.value);
                player2.ApplyEffects("green", player2, player1, die.value);
                //Affiche le montant de gold de chaque joueur apres application des effets
                Console.WriteLine("\n======================================================");
                Console.WriteLine("LE JOUEUR A MAINTENANT {0} GOLDS", player1.money);
                Console.WriteLine("L'ORDINATEUR A MAINTENANT {0} GOLDS", player2.money);
                Console.WriteLine("======================================================");
                player2.ChooseCard(shop);
                Thread.Sleep(1300);
                Console.WriteLine();
            }

            Console.WriteLine();
            if(player1.money > player2.money)
            {
                Console.WriteLine("FIN DU GAME : Vous avez gagné!");
            }
            else if(player1.money < player2.money)
            {
                Console.WriteLine("FIN DU GAME : Vous avez perdu!");
            }
            else
            {
                Console.WriteLine("FIN DU GAME : Match nul!");
            }

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
