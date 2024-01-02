using Task2.parent;
using Task2.child;

class Program
{
    public static void Main()
    {
        double[] CoordinatesForCar = new[] { 7426.0, 28434.0 };
        double[] CoordinatesForShip = new[] { 9284.0, 7247.8 };
        double[] CoordinatesForPlane = new[] { 74352.4, 83476.0 };
        
        Car car = new Car(CoordinatesForCar, 250, 50000, 2016);
        Ship ship = new Ship(CoordinatesForShip, 1000000, 85, 2010, "Los-Angeles", 250);
        Plane plane = new Plane(CoordinatesForPlane, 5000, 3500000, 850, 2020, 150);

        car.Print();
        ship.Print();
        plane.Print();
    }
}
