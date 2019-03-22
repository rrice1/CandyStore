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
                DateReceived = "02/04/19",
                Flavor = "carmel"
            }
        };

        static List<Candy> EatList = new List<Candy>();


        public void FindCandy()
        {
            var candyToEat = Console.ReadLine();
            List<string> ateCandyList = new List<string>
            {
                candyToEat
            };



            //foreach (var ateCandy in ateCandyList)
            //{
            //    Console.WriteLine($"You just ate a {ateCandy}");
            //}

            foreach (var eatCandy in _myCandy)
            {

                if (candyToEat == eatCandy.Name)
                {
                    List<int> dupList = new List<int>();

                    var addToNewList = eatCandy.CandyId;
                    dupList.Add(addToNewList);
                    // add to list
                }
            }
            Console.ReadLine();
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

        

        // used to iterate over list to send the list of current candies in list
        internal void PrintList()
        {
            foreach (Candy candy in _myCandy)
            {
                var newName = candy.Name;
                Console.WriteLine(candy.Name + ", "); 
            };
        }

    }
}
