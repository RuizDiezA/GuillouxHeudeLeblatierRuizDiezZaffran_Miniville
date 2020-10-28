using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Miniville
{
    class Cards
    {
        public string color;
        public string name;
        public string description;
        public int price;
        public List<int> numberToRoll;
        public List<string> Cartes;


        public Cards(string name, string color, int price, List<int> numberToRoll, List<string> Cartes, string description)
        {
            this.name = name;
            this.color = color;
            this.price = price;
            this.description = description;

            numberToRoll.Add(1);
            numberToRoll.Add(2);
            numberToRoll.Add(3);
            numberToRoll.Add(4);
            numberToRoll.Add(5);
            numberToRoll.Add(6);

            Cartes.Add("Champs de blé");
            Cartes.Add("Ferme");
            Cartes.Add("Boulangerie");
            Cartes.Add("Café");
            Cartes.Add("Superette");
            Cartes.Add("Forêt");
            Cartes.Add("Restaurant");
            Cartes.Add("Stade");
        }

        public void CheckAndApplyEffect()
        {

        }
