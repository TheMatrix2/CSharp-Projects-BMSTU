namespace Task1;

public class MyMatrix
{
    private int _rows;
    private int _columns;
    private double[,] _matrix;

    public MyMatrix(int m, int n)
    {
        this._rows = m;
        this._columns = n;
        this._matrix = new double[m, n];
        
        Random rdm = new Random();
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                this._matrix[i, j] = rdm.Next(0, 100);
            }
        }
    }
    
    public double this[int row, int column]
    {
        get { return _matrix[row, column]; }
        set { _matrix[row, column] = value; }
    }
    
    public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
    {
        if (matrix1._rows != matrix2._rows || matrix1._columns != matrix2._columns)
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        MyMatrix resultMatrix = new MyMatrix(matrix1._rows, matrix1._columns);

        for (int i = 0; i < matrix1._rows; i++)
        {
            for (int j = 0; j < matrix1._columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return resultMatrix;
    }
    
    public static MyMatrix operator -(MyMatrix matrix1, MyMatrix matrix2)
    {
        if (matrix1._rows != matrix2._rows || matrix1._columns != matrix2._columns)
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        MyMatrix resultMatrix = new MyMatrix(matrix1._rows, matrix1._columns);

        for (int i = 0; i < matrix1._rows; i++)
        {
            for (int j = 0; j < matrix1._columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return resultMatrix;
    }

    public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
    {
        if (matrix1._columns != matrix2._rows)
        {
            throw new ArgumentException("Number of rows in first matrix must equal to number of columns in second matrix.");
        }
        
        MyMatrix resultMatrix = new MyMatrix(matrix1._rows, matrix2._columns);

        for (int i = 0; i < matrix1._rows; i++)
        {
            for (int j = 0; j < matrix2._columns; j++)
            {
                double sum = 0;
                for (int l = 0; l < matrix1._columns; l++)
                {
                    sum += matrix1[i, l] * matrix2[l, j];
                }
                resultMatrix[i, j] = sum;
            }
            
        }

        return resultMatrix;
    }

    public static MyMatrix operator *(MyMatrix matrix, double a)
    {
        MyMatrix resultMatrix = new MyMatrix(matrix._rows, matrix._columns);
        
        for (int i = 0; i < matrix._rows; i++)
        {
            for (int j = 0; j < matrix._columns; j++)
            {
                resultMatrix[i, j] = a * matrix[i, j];
            }
            
        }

        return resultMatrix;
    }
    
    public static MyMatrix operator /(MyMatrix matrix, double a)
    {
        if (a == 0)
        {
            throw new DivideByZeroException("Cannot divide matrix by zero.");
        }
        
        MyMatrix resultMatrix = new MyMatrix(matrix._rows, matrix._columns);
        
        for (int i = 0; i < matrix._rows; i++)
        {
            for (int j = 0; j < matrix._columns; j++)
            {
                resultMatrix[i, j] = matrix[i, j] / a;
            }
            
        }

        return resultMatrix;
    }

    public void Print()
    {
        for (int i = 0; i < this._rows; i++)
        {
            for (int j = 0; j < this._columns; j++)
            {
                string number = _matrix[i, j].ToString();
                Console.Write(number.PadLeft(6) + " ");
            }
            Console.Write("\n");
        }
        Console.WriteLine();
    }
}
