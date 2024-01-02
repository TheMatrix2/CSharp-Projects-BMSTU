global using NUnit.Framework;

namespace Task2;

[TestFixture]
public class RectangleTests
{
    [Test]
    public void Rectangle_Constructor_WithNegativeSides_ThrowsArgumentException()
    {
        double sideA = -2;
        double sideB = 3;
        
        Assert.Throws<ArgumentException>(() => new Rectangle(sideA, sideB));
    }

    [Test]
    public void Rectangle_GetArea_ReturnsCorrectArea()
    {
        double sideA = 2;
        double sideB = 3;
        Rectangle rectangle = new Rectangle(sideA, sideB);

        double area = rectangle.getArea;

        Assert.AreEqual(6, area);
    }

    [Test]
    public void Rectangle_GetPerimeter_ReturnsCorrectPerimeter()
    {
        double sideA = 2;
        double sideB = 3;
        Rectangle rectangle = new Rectangle(sideA, sideB);
        
        double perimeter = rectangle.getPerimeter;
        
        Assert.AreEqual(10, perimeter);
    }
}