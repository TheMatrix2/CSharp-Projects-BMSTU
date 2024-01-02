namespace Task1;

public class Program
{
    static void Main()
    {
        Pupil p1 = new BadPupil();
        Pupil p2 = new GoodPupil();
        Pupil p3 = new ExcellentPupil();
        Pupil p4 = new GoodPupil();
        
        Pupil[] pupils = new [] {p1, p2, p3, p4};

        ClassRoom cr = new ClassRoom(pupils);

        cr.print();
    }
}