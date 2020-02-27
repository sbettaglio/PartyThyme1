using System;
using System.Linq;

namespace PartyThyme1
{
  public class PlantTracker
  {
    public void PlantNewPlant(string species, string locatedPlant, DateTime plantedDAte, DateTime lastWateredDate, double waterNeeded, double lightNeeded)
    {
      //interacts with
      var db = new PlantContext();
      var newPlant = new Plant
      {
        Species = species,
        LocatedPlant = locatedPlant,
        PlantedDate = plantedDAte,
        LastWateredDate = lastWateredDate,
        WaterNeeded = waterNeeded,
        LightNeeded = lightNeeded
      };
      db.Plants.Add(newPlant);
      db.SaveChanges();
      Console.WriteLine($"You have added {species} to the Plant Database one {DateTime.Now} ");
    }
    public void ViewAll()
    {
      var db = new PlantContext();
      var viewPlants = db.Plants.OrderBy(plant => plant.LocatedPlant);
      foreach (var p in viewPlants)
      {
        Console.WriteLine($"There is a {p.Species} with an id of {p.Id} in the {p.LocatedPlant}");
      }

    }
    public void RemovePlant(int plantId)
    {
      var db = new PlantContext();
      var validId = db.Plants.Any(plant => plant.Id == plantId);
      while (validId != true)
      {
        Console.WriteLine("That is not a valid Id number please try again");
        plantId = int.Parse(Console.ReadLine());
      }
      if (validId == true)
      {
        var idToRemove = db.Plants.FirstOrDefault(plant => plant.Id == plantId);
        Console.WriteLine($"Are you sure you wand to remove {idToRemove.Species} with an Id of {idToRemove.Id}? (Y)/(N)");
        var confirmRemoval = Console.ReadLine().ToLower();
        while (confirmRemoval != "y" && confirmRemoval != "n")
        {
          Console.WriteLine("Please take this seriously we're about to delete a plant. Input (Y) or (N) ");
          confirmRemoval = Console.ReadLine().ToLower();
        }
        if (confirmRemoval == "y")
        {
          Console.WriteLine($"{idToRemove.Id} has been removed.");
          db.Remove(idToRemove);
          db.SaveChanges();
        }
        else
        {
          Console.WriteLine("Nothing has been removed.");
        }

      }
    }
    public void WaterPlant(int plantId)
    {
      var db = new PlantContext();
      var validId = db.Plants.Any(plant => plant.Id == plantId);
      while (validId != true)
      {
        Console.WriteLine("That is not a valid Id number please try again");
        plantId = int.Parse(Console.ReadLine());
      }
      if (validId == true)
      {
        var idToWater = db.Plants.FirstOrDefault(plant => plant.Id == plantId);
        idToWater.LastWateredDate = DateTime.Now;
        db.SaveChanges();
        Console.WriteLine($"{idToWater.Species} with a Id of {idToWater.Id} was watered on {idToWater.LastWateredDate}");
      }
    }
    public void NotWatered()
    {
      var db = new PlantContext();
      var wateredToday = db.Plants.Where(plant => plant.LastWateredDate < DateTime.Today);
      foreach (var p in wateredToday)
      {
        Console.WriteLine($"{p.Species} has not been watered today, it was last watered on {p.LastWateredDate}");

      }
    }
    public void Locations(string plantLocated)
    {
      var db = new PlantContext();
      var validLocation = db.Plants.Any(plant => plant.LocatedPlant == plantLocated);
      while (validLocation == false)
      {
        Console.WriteLine("That location doesn't exist. Please input a valid location");
        plantLocated = Console.ReadLine().ToLower();
      }
      if (validLocation == true)
      {
        var locatedPlant = db.Plants.Where(plant => plant.LocatedPlant == plantLocated);
        foreach (var p in locatedPlant)
        {
          Console.WriteLine($"{p.Species} is located in {p.LocatedPlant}");
        }
      }
    }
  }
}