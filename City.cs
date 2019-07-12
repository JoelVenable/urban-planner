using System;
using System.Collections.Generic;


namespace Planner
{
  class City
  {
    public string Name { get; private set; }
    public string Mayor { get; private set; }
    public int YearEstablished { get; private set; }

    private List<Building> _buildingList = new List<Building>();




    public City(string name, string mayor, int yearEstablished)
    {
      Name = name;
      Mayor = mayor;
      YearEstablished = yearEstablished;
    }

    public void AddBuilding(Building newBuilding) => _buildingList.Add(newBuilding);


    public void DescribeBuildings()
    {
      _buildingList.ForEach(building => building.Describe());
    }

    public void DescribeCity()
    {
      System.Console.WriteLine();
      System.Console.WriteLine("-----------------");

      System.Console.WriteLine(Name);
      System.Console.WriteLine("-----------------");
      System.Console.WriteLine($"Mayor: {Mayor}");
      System.Console.WriteLine($"Est.{YearEstablished}");
      DescribeBuildings();

    }
  }
}