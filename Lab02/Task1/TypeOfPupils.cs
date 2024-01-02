namespace Task1;

public class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Pupil is studying excellently");
    }

    public override void Read()
    {
        Console.WriteLine("Pupil is reading excellently");
    }

    public override void Write()
    {
        Console.WriteLine("Pupil is writing excellently");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Pupil is studying good");
    }

    public override void Read()
    {
        Console.WriteLine("Pupil is reading good");
    }

    public override void Write()
    {
        Console.WriteLine("Pupil is writing good");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Pupil is studying badly");
    }

    public override void Read()
    {
        Console.WriteLine("Pupil is reading badly");
    }

    public override void Write()
    {
        Console.WriteLine("Pupil is writing badly");
    }
}