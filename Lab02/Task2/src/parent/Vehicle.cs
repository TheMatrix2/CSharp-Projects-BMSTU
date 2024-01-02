namespace Task2.parent;

public class Vehicle
{
    private double[] Coordinates { get; }
    private int Cost { get; }
    private int Speed { get; }
    private int Year { get; }

    protected Vehicle(double[] coordinates, int cost, int speed, int year)
    {
        if (coordinates.Length != 2)
        {
            throw new ArgumentException("Argument coordinates must contain 2 numbers in list");
        }
        this.Coordinates = coordinates;
        this.Cost = cost;
        this.Speed = speed;
        this.Year = year;
    }

    public virtual void Print()
    {
        Console.WriteLine($"coordinates: {Coordinates[0]}, {Coordinates[1]}\ncost: {Cost}\nspeed: {Speed}\nyear of manufacture: {Year}");
    }
}