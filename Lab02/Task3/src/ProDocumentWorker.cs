namespace Task3.src;
using Task3.src;

public class ProDocumentWorker : DocumentWorker
{
    
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован\n");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно" +
                          " в версии Expert\n");
    }
}