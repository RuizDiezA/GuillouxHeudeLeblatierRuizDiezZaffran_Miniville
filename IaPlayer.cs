using System;
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
            Console.WriteLine(" VOICI LE SHOP");
            Console.WriteLine();
            for (int i = 0; i < displayList.Count; i++)
            {
                Console.WriteLine("=======================================================================");
                Console.WriteLine(i + " : " + displayList[i]);
            }
            Console.WriteLine();
            int choice = r.Next(0, displayList.Count);
            Console.WriteLine("L'Ordinateur choisit une carte : \n");
            Console.WriteLine("Je réfléchis ...");
            BuyCard(displayList[choice]);
            Console.WriteLine("L'Ordinateur a choisi :");

            Console.WriteLine(displayList[choice].name);
            Console.WriteLine("Appuyez sur Entrée pour continuer");
            Console.ReadLine();
            //foreach (List<Cards> c in shop.Shops)
            //{
            //    Console.WriteLine("Number card " + c.Count);
            //}
            shop.RemoveCard(displayList[choice]);
            return displayList[choice];
        }

    }
}
