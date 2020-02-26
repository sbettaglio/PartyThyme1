using System;

namespace PartyThyme1
{
  public class UserInterface
  {
    public string Menu(string choice)
    {
      var tracker = new PlantTracker();
      while (choice != "view" && choice != "remove" && choice != "plant" && choice != "water" && choice != "quit")
      {
        Console.WriteLine("Invalid input. Please input (PLANT), (REMOVE), (VIEW), (WATER) or (QUIT)");
        choice = Console.ReadLine().ToLower();
      }
      return choice;
    }
    public void NewPlantInput()
    {
      var tracker = new PlantTracker();
      Console.WriteLine("What kind of plant?");
      var species = Console.ReadLine().ToLower();
      Console.WriteLine("Where did you plant it?");
      var locatedPlant = Console.ReadLine().ToLower();
      Console.WriteLine("When did you plant it?");
      var plantedDate = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("When was it last watered?");
      var lastWateredDate = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("How often should it be watered?");
      var waterNeeded = double.Parse(Console.ReadLine());
      Console.WriteLine("How much sunlight does it need per day?");
      var lightNeeded = double.Parse(Console.ReadLine());
      tracker.PlantNewPlant(species, locatedPlant, plantedDate, lastWateredDate, waterNeeded, lightNeeded);
    }
    public void ViewMenu(string viewMenu)
    {
      var tracker = new PlantTracker();
      while (viewMenu != "all" && viewMenu != "locations" && viewMenu != "water")
      {
        Console.WriteLine("Invalid input. Please input (ALL), (LOCATIONS) or (WATER)");
        viewMenu = Console.ReadLine().ToLower();
      }


      if (viewMenu == "all")
      {
        tracker.ViewAll();
      }

    }
  }
}