namespace Task2;

public class Car : IEquatable<Car>
{
    private string Name;
    private string Engine;
    private int MaxSpeed;
    
    public string name
    {
        get { return this.Name; }
    }
    
    public string engine
    {
        get { return this.Engine; }
    }

    public Car(string name, string engine, int maxSpeed)
    {
        this.Name = name;
        this.Engine = engine;
        this.MaxSpeed = maxSpeed;
    }
    
    public override string ToString()
    {
        return Name;
    }

    
    public bool Equals(Car other)
    {
        if (other == null)
            return false;

        return this.Name == other.Name && this.Engine == other.Engine && this.MaxSpeed == other.MaxSpeed;
    }
    
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Car))
            return false;

        return Equals((Car)obj);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Engine.GetHashCode() ^ MaxSpeed.GetHashCode();
    }
}