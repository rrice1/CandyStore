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

        static List<Candy> eatenList = new List<Candy>();

        internal IList<string> GetCandyTypes()
        {
            throw new NotImplementedException();
            
        }

        internal void AddCandy(Candy anyName)
        {
            _myCandy.Add(anyName);
            

        }

        public void EatenList()
        {
            var showEatenList = new List<Candy>();
        }

        public void FindCandy()
        {
            var candyToEat = Console.ReadLine();
            var duplicateNames = new List<Candy>();
            
            var eatThisDuplicate = new List<Candy>();
            //var eattttThisDuplicate = new List<Candy>();




            duplicateNames = (from Candy in _myCandy
                                  where (Candy.Name == candyToEat) 
                                  select Candy).ToList();

            //var duplicateID = from Candy in _myCandy
            //                  where (Candy.Name == candyToEat)
            //                  select Candy.CandyId;

            //eatThisDuplicate = (from Candy in duplicateNames
            //                    where Candy.CandyId == duplicateNames.Min(Candy.CandyId)
            //                    select Candy).ToList();

            var eattThisDuplicate = from Candy in duplicateNames
                                    //where Candy.CandyId == duplicateNames.Min(Candy.CandyId)
                                    select Candy.CandyId;

            var eatttThisDuplicate = eattThisDuplicate.Min();

            var eattttThisDuplicate = (from Candy in _myCandy
                                      where Candy.CandyId == eatttThisDuplicate
                                      select Candy).SingleOrDefault();


            //var fevVar = 

            //var getIndex = (from Candy in _myCandy
            //                where Candy.CandyId == eatttThisDuplicate
            //                select Candy[]).ToList();
            eatenList.Add(eattttThisDuplicate);
            _myCandy.Remove(eattttThisDuplicate);


            //foreach (var ateCandy in ateCandyList)
            //{
            //    Console.WriteLine($"You just ate a {ateCandy}");
            //}

            //    foreach (var eatCandy in _myCandy)
            //    {

            //        if (candyToEat == eatCandy.Name)
            //        {
            //            List<string> dupList = new List<string>();

            //            var addToNewList = eatCandy.CandyId;
            //            dupList.Add(addToNewList);
            //            // add to list
            //        }
            //    }
            //    Console.ReadLine();
            //}

            // method that will find the max number in the list
        }

        public void FindRandomCandy()
        {
            var typedFlavor = Console.ReadLine();
            var duplicateFlavors = new List<Candy>();

            var eatThisDuplicate = new List<Candy>();
            //var eattttThisDuplicate = new List<Candy>();
            Random rand = new Random();
            var myRands = new List<int> { };



            duplicateFlavors = (from Candy in _myCandy
                              where (Candy.Flavor == typedFlavor)
                              select Candy).ToList();

            //var duplicateID = from Candy in _myCandy
            //                  where (Candy.Name == candyToEat)
            //                  select Candy.CandyId;

            //eatThisDuplicate = (from Candy in duplicateNames
            //                    where Candy.CandyId == duplicateNames.Min(Candy.CandyId)
            //                    select Candy).ToList();

            var eattThisDuplicate = from Candy in duplicateFlavors
                                        //where Candy.CandyId == duplicateNames.Min(Candy.CandyId)
                                    select rand.Next(Candy.CandyId);

            //var randomId = rand.Next(eattThisDuplicate.Min(), eattThisDuplicate.Max());

            var eattttThisDuplicate = (from Candy in duplicateFlavors
                                       where Candy.CandyId == eattThisDuplicate
                                       select Candy).SingleOrDefault();

            _myCandy.Remove(eattttThisDuplicate);

            // method that will find the max number in the list
        }
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
            foreach (Candy candy in eatenList)
            {
                var newName = candy.Name;
                Console.WriteLine(candy.Name + ", ");
            };


        }

        public void PrintFlavorList()
        {
            foreach (Candy candy in _myCandy)
            {
                var newName = candy.Flavor;
                Console.WriteLine(candy.Flavor + ", ");
            };


        }

    }
}
