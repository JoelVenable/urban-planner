using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building EliotTowers = new Building(
          "420 Avenue"
      )
      {
        Width = 60,
        Depth = 90,
        Stories = 3
      };

      EliotTowers.Construct();

      EliotTowers.Purchase("Shelly");

      Program.Describe(EliotTowers);

    }





    static void Describe(Building building)
    {
      System.Console.WriteLine();
      System.Console.WriteLine(building.Address);
      System.Console.WriteLine("-----------------");
      System.Console.WriteLine($"Designed by {building.Designer}");
      System.Console.WriteLine($"Constructed on {building.DateConstructed}");
      System.Console.WriteLine($"Owned by {building.Owner}");
      System.Console.WriteLine($"{building.Volume} cubic meters of space");
      System.Console.WriteLine();

    }
  }
}
