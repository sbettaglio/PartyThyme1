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
          //asks what view menu they want to see
          Console.WriteLine("Do you want to view (ALL) plants, plant (LOCATIONS), plants that have not been (WATER)ed today or plants that (NEED) water now");
          var viewMenu = Console.ReadLine().ToLower();
          //opens menu method
          user.ViewMenu(viewMenu);
        }
        else if (choice == "plant")
        {
          user.NewPlantInput();
        }
        else if (choice == "remove")
        {
          user.RemovePlantInput();
        }
        else if (choice == "water")
        {
          Console.WriteLine("What plant would you like to water?");
          user.WaterPlantInput();

        }

      }

    }
  }
}
