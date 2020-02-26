using System;

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
      var allPlants = db.Plants;
      foreach (var plant in allPlants)
      {
        Console.WriteLine($"{plant} ");
      }

    }
  }
}