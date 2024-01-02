using AnimalClasses.abstract_classes;
using AnimalClasses.enums;

namespace AnimalClasses.classes;

[Comment("Class for lion")]
public class Lion : Animal
{
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Meat;
    }

    public override void SayHello()
    {
        Console.WriteLine("RAAAR");
    }
}