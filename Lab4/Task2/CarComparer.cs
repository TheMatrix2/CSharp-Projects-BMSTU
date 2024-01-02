using Task2;
namespace Task2;

public class CarComparer : IComparer<Car>
{
    private string _option;

    public CarComparer(string option)
    {
        this._option = option;
    }
    
    public int Compare(Car car1, Car car2)
    {
        if (_option == "name")
        {
            return string.Compare(car1.Name, car2.Name);
        }
        else if (_option == "year")
        {
            return car1.ProductionYear.CompareTo(car2.ProductionYear);
        }
        else if (_option == "maxspeed")
        {
            return car1.MaxSpeed.CompareTo(car2.MaxSpeed);
        }

        throw new ArgumentException("Invalid sort option");
    }
}