namespace Task3.src;

public class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт\n");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro\n");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro\n");
    }
}