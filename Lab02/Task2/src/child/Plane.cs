using Task2.parent;

namespace Task2.child;

public class Plane : Vehicle
{
    private int Height { get; }
    private int NOPass { get; }

    public Plane(double[] coordinates, int height, int cost, int speed, int year, int nOPass) : base(coordinates, cost, speed,
        year)
    {
        this.Height = height;
        this.NOPass = nOPass;
    }

    public override void Print()
    {
        Console.WriteLine("         Type: Plane");
        base.Print();
        Console.WriteLine($"flight height: {Height}\nnumber of passengers: {NOPass}");
    }
}