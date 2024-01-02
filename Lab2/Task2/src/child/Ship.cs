using Task2.parent;

namespace Task2.child;

public class Ship : Vehicle
{
    private string Reg { get; }
    private int NOPass { get; }

    public Ship(double[] coordinates, int cost, int speed, int year, string registry, int nOPass) : base(coordinates, cost,
        speed, year)
    {
        this.Reg = registry;
        this.NOPass = nOPass;
    }

    public override void Print()
    {
        Console.WriteLine("         Type: Ship");
        base.Print();
        Console.WriteLine($"port of registry: {Reg}\nnumber of passengers: {NOPass}");
    }
}