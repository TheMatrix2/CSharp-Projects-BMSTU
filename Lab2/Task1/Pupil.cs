namespace Task1;

public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil is studying\n");
    }

    public virtual void Read()
    {
        Console.WriteLine($"Pupil is reading\n");
    }

    public virtual void Write()
    {
        Console.WriteLine($"Pupil is writing\n");
    }

    public void Relax()
    {
        Console.WriteLine($"Pupil is relaxing\n");
    }
}