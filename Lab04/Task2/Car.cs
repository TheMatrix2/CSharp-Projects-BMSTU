namespace Task2;

public class Car
{
    public string Name { get; set; }
    public int ProductionYear { get; set; }
    public int MaxSpeed { get; set; }

    public Car()
    {
        this.Name = "";
    }

    public Car(string name, int year, int max_speed)
    {
        this.Name = name;
        this.ProductionYear = year;
        this.MaxSpeed = max_speed;
    }

    public void Print()
    {
        Console.WriteLine($"{Name}, {ProductionYear}, {MaxSpeed}");
    }
}