using System.Runtime.InteropServices;

namespace Task1;

public class ClassRoom
{
    private Pupil[] _pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length != 4)
        {
            throw new ArgumentException("Number of pupils in classroom must be 4");
        }
        else {this._pupils = pupils;}
    }

    public void print()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Pupil {i+1}:\n");
            _pupils[i].Study();
            _pupils[i].Read();
            _pupils[i].Write();
            _pupils[i].Relax();
        }
    }
}