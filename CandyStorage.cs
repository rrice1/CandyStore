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
                Name = "Orion",
                Manufacturer = "Storck",
                Category = "Chocolate",
                DateReceived = "02/04/19",
                Flavor = "Caramel"
            },
            new Candy
            {
                CandyId = 2,
                Name = "Whatchamacallit",
                Manufacturer = "Hershey's",
                Category = "Chocolate",
                DateReceived = "02/03/19",
                Flavor = "Chocolate"
            },
            new Candy
            {
                CandyId = 3,
                Name = "Snickers",
                Manufacturer = "Hershey's",
                Category = "Chocolate",
                DateReceived = "01/02/45",
                Flavor = "Chocolate"
            },
            new Candy
            {
                CandyId = 4,
                Name = "Skittles",
                Manufacturer = "Hershey's",
                Category = "Chocolate",
                DateReceived = "05/03/45",
                Flavor = "Fruit"
            },
            new Candy
            {
                CandyId = 5,
                Name = "Werthers",
                Manufacturer = "Storck",
                Category = "Hard",
                DateReceived = "05/019/75",
                Flavor = "Caramel"
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
        public void MatchCandyId()
        {
            List<Candy> candyOwnerCandys = new List<Candy>();
            var ownedCandys = (from candys in _myCandy
                               join owner in candyOwners on candys.CandyId equals owner.CandyId
                               select new { CandyOwner = owner.Name, owner.CandyOwnerId, Candy = candys.Name, candys.CandyId }).ToList();
            foreach (var ownedCandy in ownedCandys)
            {
                Console.WriteLine(ownedCandy);
            }
            // Console.WriteLine("If you want to return to the prompts press Enter");
            Console.ReadLine();
        }

        static List<Candy> eatenList = new List<Candy>();

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
        }

        internal int ListMax()
        {
            var fun = _myCandy.Count() + 1
            ;
            return fun;
        }

        internal Candy SaveNewCandy(Candy newCandy)
        {
            _myCandy.Add(newCandy);
            return newCandy;
        }

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
            var lengthOfList = eatenList.Count();
            if(lengthOfList == 0)
            {
                Console.WriteLine("WAIT IDIOT!!!  You have not eaten any candy");
            }
            else
            {
                foreach (Candy candy in eatenList)
                {



                    var newName = candy.Name;

                    Console.WriteLine(candy.Name + ", ");


                };
            }
            
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