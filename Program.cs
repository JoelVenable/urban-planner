using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      City Nashville = new City("Nashville", "David Briley", 1779);

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


      Building Interstate = new Building(
          "500 Interstate Blvd"
      )
      {
        Width = 30,
        Depth = 50,
        Stories = 5
      };

      Interstate.Construct();
      Interstate.Purchase("John Wark");

      Building Batman = new Building(
          "333 Commerce St"
      )
      {
        Width = 120,
        Depth = 60,
        Stories = 33
      };

      Batman.Construct();
      Batman.Purchase("Pitney Bowes");

      Nashville.AddBuilding(EliotTowers);
      Nashville.AddBuilding(Interstate);
      Nashville.AddBuilding(Batman);

      Nashville.DescribeCity();



    }





  }
}
