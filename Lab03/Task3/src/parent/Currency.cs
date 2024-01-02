namespace Task3.parent;

public class Currency
{
    private double _value;

    public double value
    {
        get { return _value; }

        set { _value = value; }
    }

    public Currency()
    {
        this._value = 0;
    }
    
    public Currency(double value)
    {
        this._value = value;
    }

    public virtual void print()
    {
        Console.WriteLine(_value);
    }
}