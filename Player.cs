using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.hand.Add(new Cards("Boulangerie", "green", 1, new List<int> { 2, 3 }, "Recevez 1 pièce"));
            this.hand.Add(new Cards("Champs de blé", "blue", 1, new List<int> { 1 }, "Recevez 1 pièce"));
            this.name = "Player";
        }

        //TEST CHANGEMENT
        public Player(int money, string name)
        {
            this.money = money;
            this.hand = new List<Cards>();
            this.hand.Add(new Cards("Boulangerie", "green", 1, new List<int> { 2, 3 }, "Recevez 1 pièce"));
            this.hand.Add(new Cards("Champs de blé", "blue", 1, new List<int> { 1 }, "Recevez 1 pièce"));
            this.name = name;
        }



        public void ApplyEffects(string color, Player player1, Player player2)
        {
            foreach(Cards card in hand)
            {
                if (card.color == color)
                {
                    card.ApplyEffect(player1, player2);
                    Console.WriteLine("Apply" + color);
                }
                else if(card.color == "blue")
                {
                    card.ApplyEffect(player1, player2);
                    Console.WriteLine("Apply blue");
                }
            }

        }

        public void BuyCard(Cards card)
        {
            if (money >= card.price)
            {
                money -= card.price;
                this.hand.Add(card);
            }
        }

        public Cards ChooseCard(List<List<Cards>> cardsList)
        {
            List<Cards> displayList = new List<Cards>();
            foreach(List<Cards> list in cardsList)
            {
                if (list.Count > 0)
                {
                    Console.WriteLine("FUUUUUUUUUCK");
                    displayList.Add(list[0]);
                }
            }

            Console.WriteLine("Veuillez choisir une carte :");

            for (int i = 0; i < displayList.Count; i++)
            {
                Console.WriteLine(i + " : " + displayList[i]);
            }

            int choice = Convert.ToInt32(Console.ReadLine());

            //TEEEEEEEST

            BuyCard(displayList[choice]);

            return displayList[choice];
        }
    }
}