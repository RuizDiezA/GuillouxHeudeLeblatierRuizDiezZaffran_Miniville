
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Cards
    {
        public string name;
        public string color;
        public int price;
        public List<int> numberToRoll;
        public string description;
        public int effect;

        public Cards()
        {

        }

        public Cards(string name, string color, int price, List<int> numberToRoll, string description, int effect)
        {
            this.name = name;
            this.color = color;
            this.price = price;
            this.numberToRoll = numberToRoll;
            this.description = description;
            this.effect = effect;
        }

        public void ApplyEffect(Player player1, Player player2)
        {
            switch (effect)
            {
                case 0 :
                    player1.money++;
                    Console.WriteLine("La carte " + this.name + " est activée, " + player1.name + " gagne une pièce");
                    break;
                case 1:
                    player1.money += 2;
                    Console.WriteLine("La carte " + this.name + " est activée, " + player1.name + " gagne deux pièces");
                    break;
                case 2:
                    player1.money += 3;
                    Console.WriteLine("La carte " + this.name + " est activée, " + player1.name + " gagne trois pièces");
                    break;
                case 3:
                    player1.money += 4;
                    Console.WriteLine("La carte " + this.name + " est activée, " + player1.name + " gagne quatre pièces");
                    break;
                case 4:
                    if (player1.money > 0)
                    {
                        player1.money -= 1;
                        player2.money++;
                        Console.WriteLine("La carte " + this.name + " est activée, " + player1.name + " donne 1 pièce à " + player2.name);
                    }
                    break;
                case 5:
                    if (player1.money > 0 && player1.money >= 2)
                    {
                        player1.money -= 2;
                        player2.money += 2;
                        Console.WriteLine("La carte " + this.name + " est activée, " + player1.name + " donne 2 pièce à " + player2.name);
                    }
                    else if (player1.money > 0)
                    {
                        player1.money -= 1;
                        player2.money++;
                        Console.WriteLine("La carte " + this.name + " est activée, " + player1.name + " est fauché, il ne donne qu'1 pièce à " + player2.name);
                    }
                    else
                        Console.WriteLine("La carte " + this.name + " est activée, " + player1.name + " est fauché, il ne peut rien donner à " + player2.name);
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            string toString = "";
            toString += "Nom : " + name;
            toString += " Couleur : " + color;
            toString += " Prix : " + price;
            toString += " S'active si le dé = ";
            foreach (int num in numberToRoll)
            {
                toString += num + ", ";
            }
            toString += "\n";
            toString += "Description : " + description;
            return toString;
        }
    }
}
