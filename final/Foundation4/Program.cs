using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running running = new Running("2023-07-06", 30, 5.5);
        Swimming swimming = new Swimming("2023-07-06", 50, 10);
        Cycling cycling = new Cycling("2023-07-06", 25, 15);

        Console.WriteLine("\nRunning:");
        Console.WriteLine("Distance (km): " + running.CalculateDistance());
        Console.WriteLine("Speed: (mph)" + running.CalculateSpeed());
        Console.WriteLine("Pace: (min per mile)" + running.CalculatePace());

        Console.WriteLine("\nSwimming:");
        Console.WriteLine("Distance: (km)" + swimming.CalculateDistance());
        Console.WriteLine("Speed: (mph)" + swimming.CalculateSpeed());
        Console.WriteLine("Pace: (min per mile)" + swimming.CalculatePace());

        Console.WriteLine("\nCycling:");
        Console.WriteLine("Distance: (km)" + cycling.CalculateDistance());
        Console.WriteLine("Speed: (mph)" + cycling.CalculateSpeed());
        Console.WriteLine("Pace: (min per mile)" + cycling.CalculatePace());
    }
}
