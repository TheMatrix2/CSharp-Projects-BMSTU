using System.Xml.Serialization;
using AnimalClasses.abstract_classes;
using AnimalClasses.classes;
using AnimalClasses.enums;

namespace Task1_serialize;

public class Program
{
    public static void Main()
    {
        // create Animal example
        Animal cow = new Cow();
        cow.Country = "India";
        cow.HideFromOtherAnimals = false;
        cow.Name = "Burenkajhan";
        cow.GetClassificationAnimal = eClassificationAnimal.Herbivores;

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cow));

        // get stream and serialize object
        using (FileStream fs = new FileStream("/home/thematrix/CSharpProjects/Lab8/animal.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, cow);
            Console.WriteLine("Serialized");
        }
    }
}