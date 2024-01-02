global using NUnit.Framework;

namespace Task3;

[TestFixture]
public class FigureTests
{
    [Test]
    public void PerimeterCalculator_ShouldCalculatePerimeter_OfTriangle()
    {
        
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 1);
        Point p3 = new Point(2, 0);
        Figure triangle = new Figure("Triangle", p1, p2, p3);
        
        double perimeter = triangle.PerimeterCalculator();

        Assert.AreEqual(4.828427, perimeter, 0.000001);
    }

    [Test]
    public void PerimeterCalculator_ShouldCalculatePerimeter_OfRectangle()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 2);
        Point p3 = new Point(3, 2);
        Point p4 = new Point(3, 0);
        Figure rectangle = new Figure("Rectangle", p1, p2, p3, p4);
        
        double perimeter = rectangle.PerimeterCalculator();
        
        Assert.AreEqual(10, perimeter);
    }

    [Test]
    public void PerimeterCalculator_ShouldCalculatePerimeter_OfPentagon()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(2, 0);
        Point p3 = new Point(3, 1);
        Point p4 = new Point(2, 2);
        Point p5 = new Point(0, 2);
        Figure pentagon = new Figure("Pentagon", p1, p2, p3, p4, p5);
        
        double perimeter = pentagon.PerimeterCalculator();
        
        Assert.AreEqual(8.828427, perimeter, 0.000001);
    }
}
