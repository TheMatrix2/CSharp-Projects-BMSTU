using Task3.src;

class Program
{
    static void Main()
    {
        Console.Write("Введите ключ активации или нажмите Enter: ");
        string? key = Console.ReadLine();

        DocumentWorker doc = KeyCheck(key);
        
        doc.OpenDocument();
        doc.EditDocument();
        doc.SaveDocument();
    }

    static DocumentWorker KeyCheck(string input)
    {
        switch (input)
        {
            case "pro8888":
                return new ProDocumentWorker();
            case "exp9999":
                return new ExpertDocumentWorker();
        }

        return new DocumentWorker();
    }
}

