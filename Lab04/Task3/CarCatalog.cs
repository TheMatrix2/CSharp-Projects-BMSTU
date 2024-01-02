namespace Task3;

using Task2;

public class CarCatalog
{
    private Car[] _arr;
    private byte _mode = 0;
    public CarCatalog(Car[] _arr) => this._arr = _arr;
    public byte Mode { set { this._mode = value; } }
    public int Length => _arr.Length;

    public IEnumerator<Car> GetEnumerator()
    {
        switch (_mode)
        {
            case 0:
                for (int i = 0; i < _arr.Length; ++i)
                {
                    yield return _arr[i];
                }

                break;
            case 1:
                for (int i = (_arr.Length - 1); i > -1; --i)
                {
                    yield return _arr[i];
                }

                break;
        }
    }

    public IEnumerable<Car> GetPersonnel(int param, byte mode)
    {
        switch (mode)
        {
            case 0:
                for (int i = 0; i < _arr.Length; ++i)
                {
                    if (_arr[i].ProductionYear == param)
                        yield return _arr[i];
                }

                break;
            case 1:
                for (int i = 0; i < _arr.Length; ++i)
                {
                    if ((_arr[i].MaxSpeed == param))
                        yield return _arr[i];
                }

                break;
        }
    }
}
