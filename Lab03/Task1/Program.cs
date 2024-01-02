using Task1;

class Program
{
    public static void Main()
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(3, 4, 5);
        Vector v3 = v1;
        
        Console.WriteLine("v1");
        v1.Print();
        Console.WriteLine("v1_length = " + v1.Length());
        Console.WriteLine("v2");
        v2.Print();
        Console.WriteLine("v2_length = " + v2.Length());

        Vector summ = v1 + v2;
        Console.WriteLine("v1 + v2 = ");
        summ.Print();
        
        Console.WriteLine($" v1 * 10 = ");
        (v1 * 10).Print();
        
        Console.WriteLine("v1 * v2 = " + v1 * v2);

    }
}