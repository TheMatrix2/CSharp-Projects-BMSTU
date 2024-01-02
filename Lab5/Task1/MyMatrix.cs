namespace Task1;

public class MyMatrix
{
    private int _rows;
    private int _columns;
    private double[,] _matrix;
    private double _minValue;
    private double _maxValue;

    public MyMatrix(int m, int n, double min_value, double max_value)
    {
        this._rows = m;
        this._columns = n;
        this._matrix = new double[m, n];
        this._minValue = min_value;
        this._maxValue = max_value;
        
        Random rdm = new Random();
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                this._matrix[i, j] = rdm.NextDouble() * (max_value - min_value) + min_value;
            }
        }
    }
    
    public double this[int row, int column]
    {
        get { return _matrix[row, column]; }
        set { _matrix[row, column] = value; }
    }

    public void Fill()
    {
        Random rdm = new Random();
        
        for (int i = 0; i < this._rows; i++)
        {
            for (int j = 0; j < this._columns; j++)
            {
                this._matrix[i, j] = rdm.NextDouble() * (_maxValue - _minValue) + _minValue;
            }
        }
    }

    public void ChangeSize(int new_rows, int new_columns)
    {
        double[,] resized = new double[new_rows, new_columns];

        Random rdm = new Random();
        
        for (int i = 0; i < new_rows; i++)
        {
            for (int j = 0; j < new_columns; j++)
            {
                if (i < this._rows && j < this._columns)
                {
                    resized[i, j] = this._matrix[i, j];
                }
                else
                {
                    resized[i, j] = rdm.NextDouble() * (_maxValue - _minValue) + _minValue;
                }
            }
        }

        this._matrix = resized;
        this._rows = new_rows;
        this._columns = new_columns;
    }

    // private static Array ResizeArray(Array arr, int[] newSizes)
    // {
    //     if (newSizes.Length != arr.Rank)
    //         throw new ArgumentException("arr must have the same number of dimensions " +
    //                                     "as there are elements in newSizes", "newSizes");
    //
    //     var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
    //     int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
    //     Array.ConstrainedCopy(arr, 0, temp, 0, length);
    //     return temp;
    // }

    public void ShowPartialy(int start_row, int start_column, int end_row, int end_column)
    {
        if (start_row < 0 || end_row < 0 || start_column < 0 || end_column < 0)
        {
            throw new ArgumentException("Arguments for ShowPartialy must be positive.");
        }
        for (int i = start_row; i <= end_row; i++)
        {
            for (int j = start_column; j <= end_column; j++)
            {
                double number = Math.Round(this._matrix[i, j], 2);
                Console.Write(number.ToString().PadLeft(5) + "  ");
            }
            Console.Write("\n");
        }
        Console.WriteLine();
    }

    public void Show()
    {
        this.ShowPartialy(0, 0, this._rows - 1, this._columns - 1);
    }
}
