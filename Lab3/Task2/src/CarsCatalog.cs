namespace Task2;

public class CarsCatalog
{
    private List<Car> Cars = new List<Car>();

    public List<Car> cars
    {
        get { return Cars; }
    }
    
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < Cars.Count)
                return $"{Cars[index].name} - {Cars[index].engine}";
            
            return null;
        }
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        Cars.Remove(car);
    }
}