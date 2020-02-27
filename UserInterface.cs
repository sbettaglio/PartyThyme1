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
    //adds plants
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
      //displays all the plants by locations
      if (viewMenu == "all")
      {
        tracker.ViewAll();
      }
      else if (viewMenu == "water")
      {
        tracker.NotWatered();
      }
      else if (viewMenu == "locations")
      {
        Console.WriteLine("What location do you want to check?");
        var plantLocation = Console.ReadLine().ToLower();
        tracker.Locations(plantLocation);
      }

    }
    public void RemovePlantInput()
    {
      var tracker = new PlantTracker();
      tracker.ViewAll();
      Console.WriteLine("What plant do you want to remove? Please select by Id number");
      var plantId = int.Parse(Console.ReadLine());
      tracker.RemovePlant(plantId);
    }
    public void WaterPlantInput()
    {
      var tracker = new PlantTracker();
      tracker.ViewAll();
      Console.WriteLine("What plant do you want to water? Please select by Id number");
      var plantId = int.Parse(Console.ReadLine());
      tracker.WaterPlant(plantId);
    }
  }
}