﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Miniville
{
    class IaPlayer : Player
    {
        public Random r = new Random();
        public IaPlayer()
        {
            this.name = "Ordinateur";
        }

        public override Cards ChooseCard(Shop shop)
        {
            List<List<Cards>> cardsList = shop.Shops;
            List<Cards> displayList = new List<Cards>();
            foreach (List<Cards> list in cardsList)
            {
                if (list.Count > 0)
                {
                    displayList.Add(list[0]);
                }
            }

            Console.WriteLine("L'Ordinateur choisir une carte : \n");

            Console.WriteLine(displayList.Count + " VOICI LE SHOP");
            Console.WriteLine();
            for (int i = 0; i < displayList.Count; i++)
            {
                Console.WriteLine("===============================");
                Console.WriteLine(i + " : " + displayList[i]);

                Console.WriteLine("LA LISTE FAIT : " + displayList.Count);
            }

            Console.WriteLine();
            Console.WriteLine("VOICI LA MAIN");
            Console.WriteLine("===============================");
            foreach (Cards card in hand)
            {
                Console.WriteLine("");
                Console.WriteLine(card);
            }

            Console.WriteLine();

            //RANDOM int choice = Convert.ToInt32(Console.ReadLine());
            int choice = r.Next(0, displayList.Count);
            Console.WriteLine("Je réfléchis ...");
            Thread.Sleep(1300);
            Console.WriteLine("AJOUTE ");

            Console.WriteLine("COUNT " + shop.Shops.Count);

            BuyCard(displayList[choice]);
            Console.WriteLine("BEFORE REMOVE");
            foreach (List<Cards> c in shop.Shops)
            {
                Console.WriteLine("Number card " + c.Count);
            }
            shop.RemoveCard(displayList[choice]);
            Console.WriteLine("AFTER REMOVE");
            Console.WriteLine("COUNT " + shop.Shops.Count);

            return displayList[choice];
        }

    }
}
