namespace FactoryMethodPatternExample.Documents;

public class WordDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Word document.");
}

public class PdfDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening PDF document.");
}

public class ExcelDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Excel document.");
}
