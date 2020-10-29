
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
                    break;
                case 1:
                    player1.money += 2;
                    break;
                case 2:
                    player1.money += 3;
                    break;
                case 3:
                    player1.money += 4;
                    break;
                case 4:
                    if (player1.money > 0)
                    {
                        player1.money -= 1;
                        player2.money++;
                    }
                    break;
                case 5:
                    if (player1.money > 0 && player1.money >= 2)
                    {
                        player1.money -= 2;
                        player2.money += 2;
                    }
                    else if (player1.money > 0)
                    {
                        player1.money -= 1;
                        player2.money++;
                    }
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            string toString = "";
            toString += "Nom : " + name + "\n";
            toString += "Color : " + color + "\n";
            toString += "Prix : " + price + "\n";
            toString += "S'active pour : ";
            toString += "Description : " + description;

            foreach (int num in numberToRoll)
            {
                toString += num + ", ";
            }
            toString += "\n";

            return base.ToString();
        }
    }
}
