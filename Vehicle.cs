class Vehicle
{
    public string Name;
    public int Passengers;
    public string Color;
    public bool HasEngine;
    public int Speed;
    private int Miles = 0;

    public Vehicle(string name, int passengers, string color, bool hasengine, int speed)
    {
        Name = name;
        Passengers = passengers;
        Color = color;
        HasEngine = hasengine;
        Speed = speed;
    }

    public Vehicle(string name, string color)
    {
        Name = name;
        Passengers = 10;
        Color = color;
        HasEngine = true;
        Speed = 150;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}, {Passengers}, {Color}, {HasEngine}, {Miles}, {Speed}");
    }

    public void Travel(int amount)
    {
        Miles =+ amount;
        Console.WriteLine($"Went {amount} for a total of {Miles} miles");
    }
}

