namespace Task3;

public class Point
{
    private int _x { get; }
    private int _y { get; }

    public Point()
    {
        this._x = 0;
        this._y = 0;
    }

    public Point(int x, int y)
    {
        this._x = x;
        this._y = y;
    }

    public int getX => _x;

    public int getY => _y;

    public void print()
    {
        Console.WriteLine($"x = {_x}; \n y = {_y};\n");
    }
}