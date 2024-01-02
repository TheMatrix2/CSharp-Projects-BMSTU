namespace Task1;

public struct Vector
{
    private int X;
    private int Y;
    private int Z;

    public Vector(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static int operator *(Vector v1, Vector v2)
    {
        return (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z);
    }

    public static Vector operator *(Vector v, int a)
    {
        return new Vector(v.X * a, v.Y * a, v.Z * a);
    }

    public double Length()
    {
        return Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z);
    }

    public static bool operator <(Vector v1, Vector v2)
    {
        return v1.Length() < v2.Length();
    }
    
    public static bool operator >(Vector v1, Vector v2)
    {
        return v1.Length() > v2.Length();
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return (v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z);
    }
    
    public static bool operator !=(Vector v1, Vector v2)
    {
        return (v1.X != v2.X && v1.Y != v2.Y && v1.Z != v2.Z);
    }

    public void Print()
    {
        Console.WriteLine("{" + this.X + ", " + this.Y + ", " + this.Z + "}\n");
    }
}