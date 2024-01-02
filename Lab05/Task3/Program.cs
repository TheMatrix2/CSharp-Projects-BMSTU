
using Task3;

class Program
{
    public static void Main()
    {
        MyDictionary<int, int> dic = new MyDictionary<int, int>();
        dic.Add(1, 5);
        dic.Add(2, 9);
        dic.Print();
        dic.Add(2, 4);

        foreach (var d in dic)
        {
            d.Print();
        }
    }
}