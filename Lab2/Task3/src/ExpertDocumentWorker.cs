namespace Task3.src;
using Task3.src;

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате\n");
    }
}