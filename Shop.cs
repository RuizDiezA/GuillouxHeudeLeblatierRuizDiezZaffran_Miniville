using System;
using System.Collections.Generic;

namespace Miniville
{
    class Shop
    {

        List<Cards> ChampsBle = new List<Cards>();
        List<Cards> Ferme = new List<Cards>();
        List<Cards> Boulangerie = new List<Cards>();
        List<Cards> Cafe = new List<Cards>();
        List<Cards> Superette = new List<Cards>();
        List<Cards> Foret = new List<Cards>();
        List<Cards> Restaurant = new List<Cards>();
        List<Cards> Stade = new List<Cards>();

        List<List<Cards>> Shops = new List<List<Cards>>();

        public List<List<Cards>> LigneAchat()
        {
            Shops.Add(ChampsBle);
            Shops.Add(Ferme);
            Shops.Add(Boulangerie);
            Shops.Add(Cafe);
            Shops.Add(Superette);
            Shops.Add(Foret);
            Shops.Add(Restaurant);
            Shops.Add(Ferme);
            Shops.Add(Stade);

            return Shops;
        }

        public void AfficheShop()
        {
            System.Collections.IList list = Shops;
            for (int i = 0; i < list.Count; i++)
            {
                List<string> subList = (List<string>)list[i];
                Console.WriteLine(subList);
                /*foreach (string item in subList)
                {
                    Console.WriteLine(item);
                }*///prout
            }
        }
    }

    

    
}
