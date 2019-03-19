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
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;

			var db = new CandyStorage();

			return db;
		}

		internal static ConsoleKeyInfo MainMenu()
		{
			View mainMenu = new View()
					.AddMenuOption("Did you just get some new candy? Add it here.")
					.AddMenuOption("Do you want to eat some candy? Take it here.")
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
				case "1": AddNewCandy(db);
					break;
				case "2": EatCandy(db);
					break;
				default: return true;
			}
			return true;
		}

		internal static void AddNewCandy(CandyStorage db)
		{
            //var newCandy = new Candy
            //{
            //	Name = "Whatchamacallit"
            //};
            Console.WriteLine("Add your candy's name, manufacturer, category, DateReceived and flavor");
            var addCandys = new List<Candy>
            {

                new Candy
                {
                    
                    Name = Console.ReadLine(),
                    Manufacturer = Console.ReadLine(),
                    Category = Console.ReadLine(),
                    // some method to pull the date
                    DateReceived = Console.ReadLine(),
                    Flavor = Console.ReadLine()
                }
            };
            foreach (var addCandy in addCandys)
            {

                //Console.WriteLine(addCandy);
                var savedCandy = db.SaveNewCandy(addCandy);
                Console.WriteLine($"Now you own the candy {savedCandy.Name}");
            }
        }

		private static void EatCandy(CandyStorage db)
		{
			throw new NotImplementedException();
		}
	}
}
