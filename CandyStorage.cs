using System;
using System.Collections.Generic;

namespace candy_market
{
    internal class CandyStorage
    {
        static List<Candy> _myCandy = new List<Candy>();

        internal IList<string> GetCandyTypes()
        {
            throw new NotImplementedException();
            
        }

        internal Candy SaveNewCandy(Candy newCandy)
        {
           _myCandy.Add(newCandy);
            return newCandy;
            //return("hello");
            //throw new NotImplementedException();
        }
    }
}
