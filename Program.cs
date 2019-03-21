using System;
using System.Collections.Generic;

namespace candy_market
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SetupNewApp();

            var exit = false;
            while (!exit)
            {
                var userInput = MainMenu();
                exit = TakeActions(db, userInput);
            }
        }

        internal static CandyStorage SetupNewApp()
        {
            Console.Title = "Cross Confectioneries Incorporated";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            var db = new CandyStorage();

            return db;
        }

        internal static ConsoleKeyInfo MainMenu()
        {
            View mainMenu = new View()
                    .AddMenuOption("Did you just get some new candy? Add it here.")
                    .AddMenuOption("Do you want to eat some candy? Take it here.")
                   .AddMenuOption("Do you want to trade a candy? Trade it here.")
                   .AddMenuText("Press Esc to exit.");
            Console.Write(mainMenu.GetFullMenu());
            var userOption = Console.ReadKey();
            return userOption;
        }

        private static bool TakeActions(CandyStorage db, ConsoleKeyInfo userInput)
        {
            Console.Write(Environment.NewLine);

            if (userInput.Key == ConsoleKey.Escape)
                return true;

            var selection = userInput.KeyChar.ToString();
            switch (selection)
            {
                case "1":
                    AddNewCandy(db);
                    break;
                case "2":
                    EatCandy(db);
                    break;
                case "3":
                    TradeCandy(db);
                    break;
                default: return true;
            }
            return false; // changed this to false so app would start back at the menu
        }

        internal static void AddNewCandy(CandyStorage db)
        {
            Console.WriteLine("Add your candy's name, manufacturer, category, DateReceived and flavor");
            DateTime localDate = DateTime.Now;
            var candyGood = new Candy
            {
                CandyId = db.ListMax(),
                Name = Console.ReadLine(),
                Manufacturer = Console.ReadLine(),
                Category = Console.ReadLine(),
                DateReceived = localDate.ToString(),
                Flavor = Console.ReadLine()
            };

            db.AddCandy(candyGood);
        }

        // Used to call the list of current candy in list
        //      private static void EatCandy(CandyStorage db)
        //{
        //          Console.WriteLine("Here is a list to choose candy to eat :");
        //          db.PrintList();
        //          Console.WriteLine("Choose just ONE candy by typing it in and hitting enter to EAT!");
        //          Candy candyToEat = Console.ReadLine();

        //          // function to add this candy to a list
        //          // funciton to remove it from the main list?
        //          db.EatCandy(candyToEat);
        //          Console.WriteLine($"You just ate a {candyToEat}");
        //          Console.ReadLine();

        //}







        private static void EatCandy(CandyStorage db)
        {
            Console.WriteLine("Here is a list to choose candy to eat :");
            db.PrintList();
            Console.WriteLine("Choose just ONE candy by typing it in and hitting enter to EAT!");
            db.FindCandy();
            //var candyToEat = Console.ReadLine();



            //List<string> ateCandyList = new List<string>();
            //ateCandyList.Add(candyToEat);

            //foreach (var ateCandy in ateCandyList)
            //{
            //    Console.WriteLine($"You just ate a {ateCandy}");
            //}
            //Console.ReadLine();
        }



        private static void TradeCandy(CandyStorage db)
        {
            throw new NotImplementedException();
        }
    }
}