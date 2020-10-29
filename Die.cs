using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Die
    {

        public int value;
        public int nbCotes;


        //Constructeur
        public Die(int nbCotes)
        {
            this.nbCotes = nbCotes;
            

        }

        
        //Lancer
        public int Lancer()
        {



            Random rand = new Random();

            //Valeur entre 1 et le max de côté du dé
            value = rand.Next(1, nbCotes+1);


            return value;
        }


        //Message
        public override string ToString()
        {
            string toString = "";
            toString += "\n==========================================\n";
            toString += String.Format("Les dés sont jetés : {0}", value);
            toString += "\n==========================================\n";

            return toString;
        }


    }
}
