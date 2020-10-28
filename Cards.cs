using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    public class Cards
    {
        string color;
        int prix;
        List<int> CardsValue = new List<int>();
        
        public Cards()
        {
            CardsValue.Add(1);
            CardsValue.Add(2);
            CardsValue.Add(4);
            CardsValue.Add(6);
        }
        
        void CheckAndApplyEffect(int prix, string color)
        {

        }
    }
}
