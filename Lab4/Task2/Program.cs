using Task2;

class Program
{
    public static int Main()
    {
        Car[] cars = new[]
        {
            new Car("BMW", 2015, 295),
            new Car("Mercedes", 2018, 290),
            new Car("Audi", 2020, 250)
        };
        Console.WriteLine("Sorting by name:");
        Array.Sort(cars, new CarComparer("name"));
        printCars(cars);

        Console.WriteLine("\nSorting by production year:");
        Array.Sort(cars, new CarComparer("year"));
        printCars(cars);

        Console.WriteLine("\nSorting by max speed:");
        Array.Sort(cars, new CarComparer("maxspeed"));
        printCars(cars);
        return 0;
    }

    public static void printCars(Car[] cars)
    {
        foreach (Car car in cars)
        {
            car.Print();
        }
    }
}