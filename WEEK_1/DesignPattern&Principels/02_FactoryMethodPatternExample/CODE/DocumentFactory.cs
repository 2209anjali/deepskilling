// Abstract creator class
using System;

public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();

    // Optional: You can add common operations here
    public void SomeCommonOperation()
    {
        Console.WriteLine("Performing common operation...");
    }
}

// Concrete creator classes
public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new WordDocument();
}

public class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new PdfDocument();
}

public class ExcelDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new ExcelDocument();
}