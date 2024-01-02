namespace Task1;

class Program
{
    static int Main()
    {
        MyMatrix mat1 = new MyMatrix(2, 3);
        mat1.Print();
        MyMatrix mat2 = new MyMatrix(3, 2);
        mat2.Print();
        MyMatrix mat3 = new MyMatrix(2, 3);
        mat3.Print();
        
        MyMatrix mat_multiplied = mat1 * mat2;
        mat_multiplied.Print();

        MyMatrix mat_multiplied_a = mat1 * 10;
        mat_multiplied_a.Print();

        MyMatrix mat_divided_a = mat2 / 10;
        mat_divided_a.Print();
        
        (mat1 + mat3).Print();
        (mat1 - mat3).Print();
        
        return 0;
    }
}