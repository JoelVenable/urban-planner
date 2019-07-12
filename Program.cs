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

      EliotTowers.Describe();

    }





  }
}
