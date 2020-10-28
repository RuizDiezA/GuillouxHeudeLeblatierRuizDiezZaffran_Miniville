using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Cards
    {
        public string name;
        public string color;
        public int price;
        public List<int> numberToRoll;
        public string description;

        public Cards()
        {

        }

        public Cards(string name, string color, int price, List<int> numberToRoll, string description)
        {
            this.name = name;
            this.color = color;
            this.price = price;
            this.numberToRoll = numberToRoll;
            this.description = description;
        }

        public void ApplyEffect()
        {

        }

        public override string ToString()
        {
            string toString = "";
            toString += "Nom : " + name + "\n";
            toString += "Color : " + color + "\n";
            toString += "Prix : " + price + "\n";
            toString += "S'active pour : ";
            toString += "Description : " + description;

            foreach (int num in numberToRoll)
            {
                toString += num + ", ";
            }
            toString += "\n";

            return base.ToString();
        }
    }
    

}
