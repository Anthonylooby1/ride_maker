// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");

Vehicle Airplane = new Vehicle("B-17", "Chrome");
Vehicle Car = new Vehicle("Ford", 2, "Red", true, 100);
Vehicle Boat = new Vehicle("Sailboat", 3, "White", false, 20);

List<Vehicle> AllVehicles = new List<Vehicle>();
AllVehicles.Add(Airplane);
AllVehicles.Add(Car);
AllVehicles.Add(Boat);

foreach(Vehicle i in AllVehicles)
{
    i.ShowInfo();
}

Airplane.Travel(1000);
Airplane.ShowInfo();
Boat.Travel(200);
Boat.ShowInfo();



