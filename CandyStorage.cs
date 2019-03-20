using System;
using System.Collections.Generic;
using System.Linq;

namespace candy_market
{
    internal class CandyStorage
    {
        static List<Candy> _myCandy = new List<Candy>() {
            new Candy
            {
                CandyId = 1,
                Name = "Whatchamacallit",
                Manufacturer = "hershey's",
                Category = "chocolate",
                DateReceived = "02/03/19",
                Flavor = "chocolate"
            },
            new Candy
            {
                CandyId = 2,
                Name = "orion",
                Manufacturer = "Storck",
                Category = "chocolate",
                DateReceived = "02/03/19",
                Flavor = "carmel"
            }
        };

        internal IList<string> GetCandyTypes()
        {
            throw new NotImplementedException();
            
        }

        internal void AddCandy(Candy anyName)
        {
            _myCandy.Add(anyName);
            

        }

        // method that will find the max number in the list
        internal int ListMax ()
        {
            
                var fun = _myCandy.Count()+1
                ;
            
            return fun;

        }

        internal Candy SaveNewCandy(Candy newCandy)
        {
           _myCandy.Add(newCandy);
            return newCandy;
           
        }

        internal void PrintList()
        {
            foreach (var candy in _myCandy)
            {

                //Console.WriteLine(addCandy);
                
                Console.WriteLine($" {candy}");
                Console.ReadLine();
            }
        }

    }
}
