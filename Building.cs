using System;

namespace Planner
{
  public class Building
  {
    private string _designer;
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume
    {
      get
      {
        return Width * Depth * (3 * Stories);
      }
    }

    public string Address { get { return _address; } }
    public string Designer { get { return _designer; } }
    public DateTime DateConstructed { get { return _dateConstructed; } }
    public string Owner { get { return _owner; } }


    public Building(string address)
    {
      _address = address;
      _designer = "Joel Venable";
    }

    public void Construct()
    {
      _dateConstructed = DateTime.Now;
    }

    public void Purchase(string purchaser)
    {
      _owner = purchaser;
    }

    public void Describe()
    {
      System.Console.WriteLine();
      System.Console.WriteLine(Address);
      System.Console.WriteLine("-----------------");
      System.Console.WriteLine($"Designed by {Designer}");
      System.Console.WriteLine($"Constructed on {DateConstructed}");
      System.Console.WriteLine($"Owned by {Owner}");
      System.Console.WriteLine($"{Volume} cubic meters of space");
      System.Console.WriteLine();

    }
  }
}