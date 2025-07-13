using System;

public interface IImage
{
    void Display();
}

public class RealImage : IImage
{
    private string filename;

    public RealImage(string filename)
    {
        this.filename = filename;
        LoadFromServer(filename);
    }

    private void LoadFromServer(string filename)
    {
        Console.WriteLine("Loading image from remote server: " + filename);
    }

    public void Display()
    {
        Console.WriteLine("Displaying image: " + filename);
    }
}

public class ProxyImage : IImage
{
    private RealImage realImage;
    private string filename;

    public ProxyImage(string filename)
    {
        this.filename = filename;
    }

    public void Display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(filename); 
        }
        realImage.Display();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IImage image1 = new ProxyImage("nature_photo.jpg");
        IImage image2 = new ProxyImage("space_image.png");

        image1.Display();

        Console.WriteLine();

        image1.Display();

        Console.WriteLine();

        image2.Display();
    }
}
