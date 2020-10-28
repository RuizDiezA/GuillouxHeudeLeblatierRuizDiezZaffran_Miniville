using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Die
    {

        public int value;
        public int nbCotes;

<<<<<<< HEAD
        public Die()
        {
            Random rand = new Random();



        }


        public int Lancer()
        {



            return value;
        }



        public override string ToString()
        {
            string toString="";


            return toString;
=======

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
            string toString = base.ToString();

            toString += String.Format("Valeur: {0}", Lancer());


            return toString;
>>>>>>> main
        }


    }
}
