using System;
using System.Collections.Generic;
using System.Text;


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
            for(int i = 0; i < 6; i++)
            {
                ChampsBle.Add(new Cards("Champs de blé", "blue", 1, new List<int> { 1 }, 0));
                Ferme.Add(new Cards("Ferme", "blue", 2, new List<int> { 1 }, 0));
                Boulangerie.Add(new Cards("Boulangerie", "green", 1, new List<int> { 2, 3 }, 1));
                Cafe.Add(new Cards("Café", "red", 2, new List<int> { 3 }, 4));
                Superette.Add(new Cards("Superette", "green", 2, new List<int> { 4 }, 2));
                Foret.Add(new Cards("Forêt", "blue", 2, new List<int> { 5 }, 0));
                Restaurant.Add(new Cards("Restaurant", "red", 4, new List<int> { 5 }, 5));
                Stade.Add(new Cards("Stade", "blue", 6, new List<int> { 6 }, 3));

            }
            
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
                }
            }
            
        }
    }

}
