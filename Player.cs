using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Player
    {
        public int money;
        public Piles hand;
        public string name;

        public Player()
        {

        }

        public Player(int money, Piles hand, string name)
        {
            this.money = money;
            this.hand = hand;
            this.name = name;
        }

        public void CheckEffects()
        {
            //Appeler la méthode de checkEffects de la classe piles
        }

        public void BuyCard(int price)
        {
            if(money >= price)
            {
                money -= price;
                //Ajouter carte à la main
            }
        }
    }
}
