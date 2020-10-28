using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Player
    {
        public int money;
        public List<Cards> hand;
        public string name;

        public Player()
        {

        }

        public Player(int money, Piles hand, string name)
        {
            this.money = money;
            this.hand = new List<Cards>();
            this.name = name;
        }

        public void CheckEffects()
        {
            //Appeler la méthode de checkEffects de la classe piles
        }

        public void BuyCard(Cards card)
        {
            //if (money >= card.price)
            //{
            //    money -= card.price;
            //    Ajouter carte à la main
            //}
        }

        public void ChooseCard(List<Cards> list)
        {

        }
    }
}
