using System;

namespace PartyThyme1
{
  class Program
  {
    static void Main(string[] args)
    {
      var user = new UserInterface();
      var gardenParty = true;
      Console.WriteLine("Welcome to Party Thyme!");
      while (gardenParty)
      {
        //Menu prompt
        Console.WriteLine("Do you want to (VIEW) current plants,(WATER) a plant, (PLANT) a new plant, (REMOVE) a  or (QUIT)?");
        var choice = Console.ReadLine().ToLower();
        //runs menu program and returns valid input
        choice = user.Menu(choice);

        //view selection method
        if (choice == "quit")
        {
          Console.WriteLine("See you later!");
          gardenParty = false;
        }
        else if (choice == "view")
        {
          Console.WriteLine("Do you want to view (ALL) plants, plant (LOCATIONS) or plants that need (WATER)");
          var viewMenu = Console.ReadLine().ToLower();
          user.ViewMenu(viewMenu);
        }
        else if (choice == "plant")
        {
          user.NewPlantInput();
        }

      }

    }
  }
}
