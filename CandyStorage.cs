using System;
using System.Collections.Generic;
using System.Linq;

namespace candy_market
{
    internal class CandyStorage
    {
        public List<Candy> _myCandy = new List<Candy>() {
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
        public List<CandyOwners> candyOwners = new List<CandyOwners>()
        {
            new CandyOwners
            {
                CandyOwnerId = 12,
                Name = "Feven",
                CandyId = 1
            },
            new CandyOwners
            {   
                CandyOwnerId = 13,
                Name = "Robert",
                CandyId = 2
            },
            new CandyOwners
            {
                CandyOwnerId = 14,
                Name = "Wayne",
                CandyId = 3
            }
        };
        public void MatchCandyId() {
            List<Candy> candyOwnerCandys = new List<Candy>();
            var ownedCandys = (from candys in _myCandy
                               join owner in candyOwners on candys.CandyId equals owner.CandyId
                               select new { CandyOwner = owner.Name,owner.CandyOwnerId, Candy = candys.Name,candys.CandyId }).ToList();
            foreach (var ownedCandy in ownedCandys)
            {
                Console.WriteLine(ownedCandy);
            }
           // Console.WriteLine("If you want to return to the prompts press Enter");
            Console.ReadLine();
       }


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

        internal void AddOwner(CandyOwners ownerName)
        {
            candyOwners.Add(ownerName);
        }

        public void FindCandy()
        {
            var candyToEat = Console.ReadLine();
            var duplicateNames = new List<Candy>();
            
            var eatThisDuplicate = new List<Candy>();

            duplicateNames = (from Candy in _myCandy
                                  where (Candy.Name == candyToEat) 
                                  select Candy).ToList();

            var eattThisDuplicate = from Candy in duplicateNames
                                    select Candy.CandyId;

            var eatttThisDuplicate = eattThisDuplicate.Min();

            var eattttThisDuplicate = (from Candy in _myCandy
                                      where Candy.CandyId == eatttThisDuplicate
                                      select Candy).SingleOrDefault();

            eatenList.Add(eattttThisDuplicate);
            _myCandy.Remove(eattttThisDuplicate);
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

            var eattThisDuplicate = from Candy in duplicateFlavors
                                        //where Candy.CandyId == duplicateNames.Min(Candy.CandyId)
                                    select rand.Next(duplicateFlavors.Count());

            var indexOfCandyToEat = rand.Next(duplicateFlavors.Count());

            var theCandyToEat = duplicateFlavors[indexOfCandyToEat];


            eatenList.Add(theCandyToEat);
            _myCandy.Remove(theCandyToEat);

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
        public void PrintOwnersList()
        {
            foreach (CandyOwners owner in candyOwners)
            {
                var newOwner = owner.Name;
                Console.WriteLine(newOwner + ", ");
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
