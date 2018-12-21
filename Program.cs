using System;

namespace candy_market
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SetupNewApp();
            var userInput = MainMenu(db);
        }

        internal static CandyStorage SetupNewApp()
        {
            Console.Title = "Cross Confectioneries Incorporated";

            var db = new CandyStorage();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            return db;
        }

        internal static ConsoleKeyInfo MainMenu(CandyStorage db)
        {
            View mainMenu = new View()
                .AddMenuOption("Did you just get some new candy? Add it here.")
                .AddMenuOption("Do you want to eat some candy? Take it here.")
                .AddMenuText("Press 0 to exit.");
            Console.Write(mainMenu.GetFullMenu());
            var userOption = Console.ReadKey();
            return userOption;
        }

        internal static void AddNewCandy(CandyStorage db)
        {
            var candyTypes = db.GetCandyTypes();
            var newCandyMenu = new View()
                .AddMenuText("What type of candy did you get?")
                .AddMenuOptions(candyTypes);
            Console.Write(newCandyMenu.GetFullMenu());

            var selectedCandyType = Console.ReadKey();
            db.SaveNewCandy(selectedCandyType.Key);
        }
    }
}
