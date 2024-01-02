using Task1;

class Program
{
    public static int Main()
    {
        Console.Write("Input number of rows: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Input number of columns: ");
        int n = int.Parse(Console.ReadLine());
        MyMatrix mat = new MyMatrix(m, n, 0, 100);
        mat.Show();
        mat.ShowPartialy(0, 0, 2, 2);
        mat.Fill();
        mat.Show();
        Console.Write("Input new number of rows: ");
        int m1 = int.Parse(Console.ReadLine());
        Console.Write("Input new number of columns: ");
        int n1 = int.Parse(Console.ReadLine());
        mat.ChangeSize(m1, n1);
        mat.Show();
        
        return 0;
    }
}
