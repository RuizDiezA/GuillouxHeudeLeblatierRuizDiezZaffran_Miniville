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
        List<Cards> Fromagerie = new List<Cards>();
        List<Cards> FabriqueDeMeubles = new List<Cards>();
        List<Cards> Mine = new List<Cards>();
        List<Cards> CentreDaffaires = new List<Cards>();
        List<Cards> Verger = new List<Cards>();
        List<Cards> Marche = new List<Cards>();

        public List<List<Cards>> Shops = new List<List<Cards>>();

        public List<List<Cards>> LigneAchat()
        {
            for(int i = 0; i < 6; i++)
            {
                ChampsBle.Add(new Cards("Champs de blé", "blue", 1, new List<int> { 1 },"Recevez 1 pièce de la banque", 0));
                Ferme.Add(new Cards("Ferme", "blue", 2, new List<int> { 1 },"Recevez 1 pièce de la banque", 0));
                Boulangerie.Add(new Cards("Boulangerie", "green", 1, new List<int> { 2, 3 }, "Recevez 2 pièces de la banque", 1));
                Cafe.Add(new Cards("Café", "red", 2, new List<int> { 3 },"Recevez 1 pièce du joueur qui a lancé le dé" ,4));
                Superette.Add(new Cards("Superette", "green", 2, new List<int> { 4 },"Recevez 3 pièces de la banque", 2));
                Foret.Add(new Cards("Forêt", "blue", 2, new List<int> { 5 },"Recevez 1 pièce de la banque", 0));
                Restaurant.Add(new Cards("Restaurant", "red", 4, new List<int> { 5 }, "Recevez 2 pièces du joueur qui a lancé le dé", 5));
                Stade.Add(new Cards("Stade", "blue", 6, new List<int> { 6 },"Recevez 4 pièces de la banque", 3));
                Fromagerie.Add(new Cards("Fromagerie", "green", 5, new List<int> { 7 }, "Recevez 5 pièces de la banque", 6));
                FabriqueDeMeubles.Add(new Cards("Fabrique de meubles", "green", 6, new List<int> { 8 }, "Recevez 6 pièces de la banque", 7));
                Mine.Add(new Cards("Mine", "blue", 7, new List<int> { 9 }, "Recevez 7 pièces de la banque", 8));
                CentreDaffaires.Add(new Cards("Centre d'affaires", "red", 3, new List<int> { 9, 10 }, "Recevez 2 pièces du joueur qui qui a lancé les dés", 5));
                Verger.Add(new Cards("Verger", "blue", 3, new List<int> { 10 }, "Recevez 3 pièces de la banque", 2));
                Marche.Add(new Cards("Marché", "green", 3, new List<int> { 11, 12 }, "Recevez 4 pièces de la banque", 3));
            }
            
            Shops.Add(ChampsBle);
            Shops.Add(Ferme);
            Shops.Add(Boulangerie);
            Shops.Add(Cafe);
            Shops.Add(Superette);
            Shops.Add(Foret);
            Shops.Add(Restaurant);
            Shops.Add(Stade);
            Shops.Add(Fromagerie);
            Shops.Add(FabriqueDeMeubles);
            Shops.Add(Mine);
            Shops.Add(CentreDaffaires);
            Shops.Add(Verger);
            Shops.Add(Marche);

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
                }*/
            }
            
        }

        public void RemoveCard(Cards choice)
        {
            foreach(List<Cards> item in this.Shops)
            {
                if (item.Count > 0 && item[0].name == choice.name )
                {
                    item.RemoveAt(0);
                }
            }
        }
    }

}
