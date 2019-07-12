# Practice: Urban Planner

### Setup

```sh
mkdir -p ~/workspace/csharp/exercises/planner && cd $_
dotnet new console -n Planner -o .
touch Building.cs
```

In this exercise, you are going to define your own **`Building`** type and create several instances of it to design your own virtual city. Create a class named **`Building`** in the `Building.cs` file and define the following fields, properties, and methods.

Also make sure that the class is defined in the same namespace as your program.

```cs
namespace Planner
{
    // Define class here
}
```

### Private Fields

- `_designer` of type `string`. It will hold your name.
- `_dateConstructed` of type `DateTime`. This will hold the exact time the building was created.
- `_address` of type string.
- `_owner` of type string. This will store the same of the person who owns the building.

### Public Properties

- `Stories` typed as an integer.
- `Width` typed as a double.
- `Depth` typed as a double.
- `Volume` should be read-only and should return _width * depth * (3 \* # of stories)_. Each story is 3 meters high.

### Constructor

Define a constructor method that accepts a single string argument - `address` - so that you can send as a parameter when you create each instance with `new Building("800 8th Street");`.

- The constructor's logic should set the `_address` field's value to the argument value

### Public Methods

- Define a `Construct()` method. The method's logic should set the `_dateConstructed` field's value to `DateTime.Now`.
- Define a `Purchase()` method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private `_owner` field.

Neither of these methods will return a value.

### Build Your City

1. Create several buildings in the `Main()` method of `Program.cs`.
   ```cs
   Building FiveOneTwoEigth = new Building("512 8th Avenue");
   ```
1. Give each building a width, height, and number of stories.
1. Construct each building.
1. Have business people in your city purchase each of your buildings.

After all of the buildings have been purchased, display the following information to the console for each building.

```sh
100 Main Street
---------------
Designed by Steve Brownlee
Constructed on 2/1/18 7:19:08 AM
Owned by Bob Ross
16128 cubic meters of space
```

## Part II

Now you need to create a type to represent your city. Here are the requirements for the class. You determine if/when to use fields, properties, a constructor, and methods.

1. Name of the city.
1. The mayor of the city.
1. Year the city was established.
1. A collection of all of the buildings in the city.
1. A method to add a building to the city.

Remember, each class should be in its own file. Create a `City.cs` file and define the **`City`** class in there. Make sure it's in the same namespace as your other classes.

Once the class is defined to your liking, refactor your code in `Main()` to create a new city instance and add your buildings to it. Once all buildings are in the city, refactor your code that outputs the building info to the console to be inside a `foreach` loop that iterate the city's building collection.

##### Example

```cs
City megalopolis = new City();

...

foreach (Building building in megalopolis.Buildings) {
    Console.WriteLine(...);
}
```
