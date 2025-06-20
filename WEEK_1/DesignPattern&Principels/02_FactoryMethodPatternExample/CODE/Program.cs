using System;

public interface IDocument
{
    void Open();
    void Save();
    void Close();
}

public class WordDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Word document...");
    public void Save() => Console.WriteLine("Saving Word document...");
    public void Close() => Console.WriteLine("Closing Word document...");
}

public class PdfDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening PDF document...");
    public void Save() => Console.WriteLine("Saving PDF document...");
    public void Close() => Console.WriteLine("Closing PDF document...");
}

public class ExcelDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Excel document...");
    public void Save() => Console.WriteLine("Saving Excel document...");
    public void Close() => Console.WriteLine("Closing Excel document...");
}
