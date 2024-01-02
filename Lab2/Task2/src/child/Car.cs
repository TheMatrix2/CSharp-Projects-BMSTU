using Task2.parent;

namespace Task2.child;

public class Car : Vehicle
{
    public Car(double[] coordinates, int speed, int cost, int year) : base(coordinates, speed, cost, year) {}

    public override void Print()
    {
        Console.WriteLine("         Type: Car");
        base.Print();
    }
}