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
            this.hand.Add(new Cards("Boulangerie", "green", 1, new List<int> { 2, 3 }, "Recevez 2 pièces", 1));
            this.hand.Add(new Cards("Champs de blé", "blue", 1, new List<int> { 1 }, "Recevez 1 pièce", 0));
            this.name = "Joueur";
        }

        //TEST CHANGEMENT
        public Player(int money, string name)
        {
            this.money = money;
            this.hand = new List<Cards>();
            this.hand.Add(new Cards("Boulangerie", "green", 1, new List<int> { 2, 3 }, "Recevez 2 pièces", 1));
            this.hand.Add(new Cards("Champs de blé", "blue", 1, new List<int> { 1 }, "Recevez 1 pièce", 0));
            this.name = name;
        }



        public void ApplyEffects(string color, Player player1, Player player2, int value)
        {
            foreach(Cards card in hand)
            {
                if (card.numberToRoll.Contains(value))
                {
                    if (card.color == color)
                    {
                        card.ApplyEffect(player1, player2);
                    }
                    else if (card.color == "blue")
                    {
                        card.ApplyEffect(player1, player2);
                    }
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

        //public Cards ChooseCard(List<List<Cards>> cardsList)
        public virtual Cards ChooseCard(Shop shop)
        {
            List<List<Cards>> cardsList = shop.Shops;
            List<Cards> displayList = new List<Cards>();
            foreach(List<Cards> list in cardsList)
            {
                if (list.Count > 0)
                {
                    displayList.Add(list[0]);
                }
            }

            Console.WriteLine(" VOICI LE SHOP");
            Console.WriteLine();
            for (int i = 0; i < displayList.Count; i++)
            {
                Console.WriteLine("=======================================================================");
                Console.WriteLine(i + " : " + displayList[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            int choice;
            while(!int.TryParse(Console.ReadLine(), out choice) | choice <0 | choice> displayList.Count-1)
            {
                Console.WriteLine("Veuillez entrer une valeur entre 0 et {0}", displayList.Count-1);
            }

            BuyCard(displayList[choice]);
            Console.WriteLine("Le Joueur a acheté : ");
            Console.WriteLine((displayList[choice].name));
            Console.WriteLine("Appuyez sur Entrée pour continuer");
            Console.ReadLine();

            shop.RemoveCard(displayList[choice]);
            return displayList[choice];
        }
    }
}