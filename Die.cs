using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Die
    {

        public int value;


        //Constructeur
        public Die()
        {
            
            

        }

        
        //Lancer
        public int Lancer()
        {



            Random rand = new Random();

            
            value = rand.Next(1, 7);


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
