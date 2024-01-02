using Task2;
using Task3;

public class Program
{
    public static void Main()
    {
        Car[] arr =
        {
            new Car("Citroen", 2013, 186),
            new Car("Honda", 2011, 190),
            new Car("Toyota", 2008, 185),
            new Car("Subaru", 2008, 195)
        };
        CarCatalog catalog = new(arr);
        catalog.Mode = 0;
        Console.WriteLine("Forward:");
        foreach (Car car in catalog)
        {
            car.Print();
        }
        Console.WriteLine();
        
        Console.WriteLine("Reverse:");
        catalog.Mode = 1;
        foreach (Car car in catalog)
        {
            car.Print();
        }
        Console.WriteLine();
        
        Console.WriteLine("Filtering by year(2013):");
        foreach (Car car in catalog.GetPersonnel(2013, 0))
        {
            car.Print();
        }
        Console.WriteLine();
        
        Console.WriteLine("Filtering by max speed(190):");
        foreach (Car car in catalog.GetPersonnel(190,1))
        {
            car.Print();
        }


    }
}