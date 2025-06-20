using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Document Management System");
        Console.WriteLine("--------------------------");

        // Create factories
        DocumentFactory wordFactory = new WordDocumentFactory();
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        DocumentFactory excelFactory = new ExcelDocumentFactory();

        // Create documents using factories
        IDocument wordDoc = wordFactory.CreateDocument();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        IDocument excelDoc = excelFactory.CreateDocument();

        // Use the documents
        Console.WriteLine("\nWorking with Word Document:");
        wordDoc.Open();
        wordDoc.Save();
        wordDoc.Close();

        Console.WriteLine("\nWorking with PDF Document:");
        pdfDoc.Open();
        pdfDoc.Save();
        pdfDoc.Close();

        Console.WriteLine("\nWorking with Excel Document:");
        excelDoc.Open();
        excelDoc.Save();
        excelDoc.Close();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
