using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a chart type:");
        Console.WriteLine("1. Line Chart");
        Console.WriteLine("2. Bar Chart");
        Console.WriteLine("3. Pie Chart");

        string choice = Console.ReadLine();

        GraphFactory factory = null;

        switch (choice)
        {
            case "1":
                factory = new LineChartFactory();
                break;
            case "2":
                factory = new BarChartFactory();
                break;
            case "3":
                factory = new PieChartFactory();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting.");
                return;
        }

        GraphVisualizer visualizer = new GraphVisualizer();
        visualizer.Visualize(factory);
    }
}
