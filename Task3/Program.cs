using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for Phone or 2 for Laptop:");
        string userInput = Console.ReadLine();

        TechProductFactory factory;

        if (userInput == "1")
        {
            factory = new PhoneFactory();
        }
        else if (userInput == "2")
        {
            factory = new LaptopFactory();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting...");
            return;
        }

        Display display = factory.CreateDisplay();
        Processor processor = factory.CreateProcessor();
        Camera camera = factory.CreateCamera();

        Console.WriteLine("Product:");
        display.Show();
        processor.Process();
        camera.Capture();
    }
}