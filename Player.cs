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
            this.money = 2;
            this.hand = new List<Cards>();
            hand.Add(new Cards("Boulangerie", "green", 1, new List<int> { 2, 3 }, "Recevez 1 pièce"));
            hand.Add(new Cards("Champs de blé", "blue", 1, new List<int> { 1 }, "Recevez 1 pièce"));
            this.name = "Player";
        }

        //TEST CHANGEMENT
        public Player(int money, Piles hand, string name)
        {
            this.money = money;
            this.hand = new List<Cards>();
            hand.Add(new Cards("Boulangerie", "green", 1, new List<int> { 2, 3 }, "Recevez 1 pièce"));
            hand.Add(new Cards("Champs de blé", "blue", 1, new List<int> { 1 }, "Recevez 1 pièce"));
            this.name = name;
        }



        public void CheckEffects()
        {
            //Appeler la méthode de checkEffects de la classe piles
        }

        public void BuyCard(Cards card)
        {
            if (money >= card.price)
            {
                money -= card.price;
                hand.Add(card);
            }
        }

        public Cards ChooseCard(List<List<Cards>> cardsList)
        {
            List<Cards> DisplayList = new List<Cards>();
            foreach(List<Cards> list in cardsList)
            {
                if (list.Count >= 0)
                {
                    finalList.Add(list<Cards>[0]);
                }
            }

            Console.WriteLine("Veuillez choisir une carte :");

            for (int i = 0; i < finalList.Count(); i++)
            {
                Console.WriteLine(i + " : " + finalList[i]);
            }

            int choice = Console.ReadLine();

            BuyCard(finalList[choice]);

            return finalList[choice];
        }
    }
}
