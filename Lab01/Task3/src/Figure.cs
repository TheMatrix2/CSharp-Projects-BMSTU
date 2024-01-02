namespace Task3;

public class Figure
{
    private string _name = "Polygon";
    private Point[] _points { get; set; }

    public Figure(string name, params Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("Number of points must be between 3 and 5\n");
        }
        this._name = name;
        this._points = points;
    }

    public double LengthSide(Point A, Point B)
    {
        int dX = A.getX - B.getX;
        int dY = A.getY - B.getY;
        return Math.Sqrt(dX * dX + dY * dY);
    }

    public double PerimeterCalculator()
    {
        if (_points.Length != 0)
        {
            double p = 0;
            for (int i = 0; i < _points.Length - 1; i++)
            {
                p += LengthSide(_points[i], _points[i + 1]);
            }
            p += LengthSide(_points[_points.Length - 1], _points[0]);

            return p;
        }
        else { return 0; }

    }

    public string Name => _name;
}