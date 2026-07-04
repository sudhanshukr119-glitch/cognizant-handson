using FactoryMethodPatternExample.Factories;

DocumentFactory[] factories = [new WordDocumentFactory(), new PdfDocumentFactory(), new ExcelDocumentFactory()];

foreach (var factory in factories)
{
    var doc = factory.CreateDocument();
    doc.Open();
}
