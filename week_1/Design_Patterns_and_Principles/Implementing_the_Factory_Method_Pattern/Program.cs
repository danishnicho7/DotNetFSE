using System;

abstract class Document
{
    public abstract void Open();
}

class WordDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Word document...");
    }
}

class PdfDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening PDF document...");
    }
}

class ExcelDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Excel document...");
    }
}

abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

class WordFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new WordDocument();
    }
}

class PdfFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new PdfDocument();
    }
}

class ExcelFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new ExcelDocument();
    }
}


class Program
{
    static void Main()
    {
        DocumentFactory wordFactory = new WordFactory();
        Document word = wordFactory.CreateDocument();
        word.Open();

        DocumentFactory pdfFactory = new PdfFactory();
        Document pdf = pdfFactory.CreateDocument();
        pdf.Open();

        DocumentFactory excelFactory = new ExcelFactory();
        Document excel = excelFactory.CreateDocument();
        excel.Open();
    }
}
