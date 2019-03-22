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
                Name = "orion",
                Manufacturer = "Storck",
                Category = "chocolate",
                DateReceived = "02/04/19",
                Flavor = "carmel"
            },
            new Candy
            {
                CandyId = 2,
                Name = "Whatchamacallit",
                Manufacturer = "hershey's",
                Category = "chocolate",
                DateReceived = "02/03/19",
                Flavor = "chocolate"
            }
        };

        // Nothing is being saved in this list when candy is eatten
        static List<Candy> eatThisDuplicate = new List<Candy>();

        internal void AddCandy(Candy anyName)
        {
            _myCandy.Add(anyName);
        }

        public void FindCandy()
        {
            var candyToEat = Console.ReadLine();
            var duplicateNames = new List<Candy>();
            
            var eatThisDuplicate = new List<Candy>();

            duplicateNames = (from Candy in _myCandy
                                  where (Candy.Name == candyToEat) 
                                  select Candy).ToList();

            var duplicateID = from Candy in _myCandy
                              where (Candy.Name == candyToEat)
                              select Candy.CandyId;

            var eattThisDuplicate = from Candy in duplicateNames
                                    //where Candy.CandyId == duplicateNames.Min(Candy.CandyId)
                                    select Candy.CandyId;

            var eatttThisDuplicate = eattThisDuplicate.Min();

            var eattttThisDuplicate = (from Candy in _myCandy
                                      where Candy.CandyId == eatttThisDuplicate
                                      select Candy).SingleOrDefault();

            _myCandy.Remove(eattttThisDuplicate);
            eatThisDuplicate.Add(eattttThisDuplicate);
            PrintEatenList();
            Console.ReadLine();
        }

        internal int ListMax ()
        {
            var fun = _myCandy.Count()+1
            ;
        return fun;
        }

        // used to iterate over list to send the list of current candies in list
        public void PrintList()
        {
            foreach (Candy candy in _myCandy)
            {
                var newName = candy.Name;
                Console.WriteLine(candy.Name + ", "); 
            };
        }

        public void PrintEatenList()
        {
            foreach (Candy candy in eatThisDuplicate)
            {
                var newName = candy.Name;
                Console.WriteLine(newName);
                Console.ReadLine();
                
            };
            
        }

    }
}
