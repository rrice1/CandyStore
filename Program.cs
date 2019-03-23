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
                    .AddMenuOption("Do you want to eat some candy? Eat it here, if you know the name.")
                    .AddMenuOption("Not sure about the candy name but know the flavor? Come here for a wild ride")
                    .AddMenuOption("List of candy you have eaten")
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
                    EatRandomCandy(db);
                    break;
                case "4":
                    EatenCandyList(db);
                    break;
                case "5":
                    TradeCandy(db);
                    break;
                default: return true;
            }
            return false; // changed this to false so app would start back at the menu
        }

        internal static void AddNewCandy(CandyStorage db)
        {
            Console.WriteLine("Add your candy's name, manufacturer, category, and flavor");
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

        private static void EatRandomCandy(CandyStorage db)
        {
            Console.WriteLine("Here is a list of flavors that are available:");
            db.PrintFlavorList();
            Console.WriteLine("Choose one flavor by typing it in and hitting enter to eat a random candy of that flavor!");
            db.FindRandomCandy();
        }





        private static void EatCandy(CandyStorage db)
        {
            Console.WriteLine("Here is a list to choose candy to eat :");
            db.PrintList();
            Console.WriteLine("Choose just ONE candy by typing it in and hitting enter to EAT!");
            db.FindCandy();
        }

        private static void EatenCandyList(CandyStorage db)
        {
            Console.WriteLine("Here is your list of eaten candy:");
            db.PrintEatenList();
            Console.ReadLine();
        }



        private static void TradeCandy(CandyStorage db)
        {
            throw new NotImplementedException();
        }
    }
}