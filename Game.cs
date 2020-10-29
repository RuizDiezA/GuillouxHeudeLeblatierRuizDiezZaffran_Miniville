﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Game
    {
        public Player player1 = new Player();
        public Player player2 = new Player();

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
                //player2.ApplyRed("red");
                //player1.ApplyGreen("green");
                player2.ApplyEffects("red", player1, player2);
                player1.ApplyEffects("green", player1, player2);



                //Acheter une nouvelle carte Et l'ajouter à sa main.
                player1.ChooseCard(shop);

                //Tour du joueur 2
                
                //Affichage de la main
                Console.WriteLine("\n\nVoici la main de l'ordinateur : ");
                foreach (Cards elem in player2.hand)
                {
                    Console.Write("| " + elem + " |");
                }
                Console.Write('\n');


                die.Lancer();
                //player1.ApplyRed(red);
                //player2.ApplyGreen(green);
                player2.ApplyEffects("red", player2, player1);
                player1.ApplyEffects("green", player2, player1);

                player2.ChooseCard(shop);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
