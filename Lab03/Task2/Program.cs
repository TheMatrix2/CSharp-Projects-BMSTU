using Task2;

class Program
{
    static void Main()
    {
        Car car1 = new Car ("BMW", "V8", 250);
        Car car2 = new Car ("Audi", "V6", 220);
        Car car3 = new Car ("Mercedes", "V12", 300);

        CarsCatalog catalog = new CarsCatalog();
        catalog.AddCar(car1);
        catalog.AddCar(car2);
        catalog.AddCar(car3);

        Console.WriteLine("Cars in the catalog:");
        for (int i = 0; i < catalog.cars.Count; i++)
        {
            Console.WriteLine($"Car {i + 1}: {catalog[i]}");
        }

        catalog.RemoveCar(car2);

        Console.WriteLine("\nAfter removing a car from the catalog:");
        for (int i = 0; i < catalog.cars.Count; i++)
        {
            Console.WriteLine($"Car {i + 1}: {catalog[i]}");
        }
        
    }
}